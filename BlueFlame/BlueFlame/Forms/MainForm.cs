using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Text;
using System.Security;
using System.Windows.Forms;

using System.Configuration;
using System.Diagnostics;

using MySql.Data.MySqlClient;
using MySql.Data.Types;

using NEROLib;

using BlueFlame.Resources;
using BlueFlame.Classes;
using BlueFlame.Classes.MySql;
using BlueFlame.Forms;
using BlueFlame.Classes.DatabaseObjects;
using System.Threading;
using System.Collections.Specialized;


namespace BlueFlame
{
    public partial class MainForm : Form
    {
        #region Static Properties to be used among all instances of the application

        ComponentResourceManager _compResMan;

        private static List<string> _deniedGroups;
        public static List<string> DeniedGroups
        {
            get { return _deniedGroups; }
        }
        
        // The Nero Base object
        private static NeroClass _nero;
        public static NeroClass Nero
        {
            get { return _nero; }
        }

        // Drives to burn with, captured by nero
        private static NeroDrives _drives;
        public static NeroDrives Drives
        {
            get { return _drives; }
        }

        // The mysql wrapper object, used to easily access the database
        private static MySqlWrapper _mysql;
        public static MySqlWrapper MySql
        {
            get { return _mysql; }
        }

        // App.config settings
        private static Configuration _config;
        private static Configuration Configuration
        {
            get { return _config; }
        }

        // The central container for all sql queries
        private static ResourceManager _sqlStrings;
        public static ResourceManager SqlStrings
        {
            get { return _sqlStrings;  }
        }

        // Default configuration container
        private static ResourceManager _resource;
        public static ResourceManager Resource
        {
            get { return _resource; }
        }

        #region Authentification Data, used for LDAP Access
        private static string _displayName = "";
        /// <summary>
        /// The users name to display, eg. John Doe
        /// </summary>
        public static string DisplayName
        {
            get { return _displayName; }
        }

        private static string _domain = "";
        /// <summary>
        /// The current users authentification Domain in the Active directory, eg. DCS, SOE etc
        /// </summary>
        public static string Domain
        {
            get { return _domain; }
        }

        private static string _accountName = "";
        /// <summary>
        /// The user identification name (sAMAccountName) within the domain
        /// </summary>
        public static string AccountName
        {
            get { return _accountName; }
        }
        #endregion
        #endregion

        // A private Event Log
        private List<string> _log;
        private bool isLoggedIn;
        private ListViewColumnStatus _columnStatus;

        // Ctor
        public MainForm()
        {
            InitializeComponent();
            _columnStatus = new ListViewColumnStatus();
            isLoggedIn = false;

            _compResMan = new ComponentResourceManager(this.GetType());

            // Instantiation of all Resources
            _nero = new NeroClass();
            _nero.OnFileSelImage +=new _INeroEvents_OnFileSelImageEventHandler(_nero_OnFileSelImage);
            
            // Get all available drives
            _drives = _nero.GetDrives(NERO_MEDIA_TYPE.NERO_MEDIA_CD);

            // instantiate logging list
            _log = new List<string>();

            // Used resources
            _resource = new ResourceManager(typeof(BlueFlameResource));
            _sqlStrings = new ResourceManager(typeof(SqlStrings));
        }

        private void LoadConfig()
        {
            try
            {
                // open app.config to gaher database connection string
                _config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

                // protect string section if not already protected 
                if (!_config.ConnectionStrings.SectionInformation.IsProtected)
                {
                    // Protect section so it's not saved in plain text
                    _config.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    _config.Save();
                }

                if(!_config.AppSettings.SectionInformation.IsProtected)
                {
                    _config.AppSettings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    _config.Save();
                }
                // extract database connection string from app.config
                string connectionString = _config.ConnectionStrings.ConnectionStrings["ConnectionString"].ConnectionString;

                //_deniedGroups = (StringCollection)_config.AppSettings.Settings["DeniedGroups"];


                foreach (string str in _config.AppSettings.Settings["DeniedGroups"].Value.Split(new char[] { ';' }))
                    _deniedGroups.Add(str);
                    
                // instantiate database wrapper (with connection)
                _mysql = new MySqlWrapper(connectionString);
                Log("Database connection established.");
            }
            catch (MySqlException msex)
            {
                // Display error Message
                if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                MessageBox.Show("A database connection error occured. Please contact your administrator.",
                                "Database connection error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                else
                MessageBox.Show("Bei der Verbindung mit der Datenbank trat ein Fehler auf. Bitte kontaktieren Sie den Administrator.",
                                "Fehler bei der Datenbank Verbindung",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);


                Debug.WriteLine(msex.ToString());

                // kill the app by all means necessary
                this.Close();
            }
            catch (ConfigurationErrorsException ex)
            {
                Debug.WriteLine(ex.ToString());
                // Display error Message
                if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                    MessageBox.Show("A configuration exception occured. Please contact your administrator.",
                                    "Configuration error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                else
                    MessageBox.Show("Beim Laden der Konfigurationsdatei trat ein Fehler auf. Bitte kontaktieren Sie den Administrator.",
                                    "Fehler beim Laden der Konfiguration",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);

                // kill the app by all means necessary
                this.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                    MessageBox.Show("An error occured while loading the form. Please contact your administrator.",
                                    "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                else
                    MessageBox.Show("Beim Laden der Anwendung trat ein Fehler auf. Bitte kontaktieren Sie den Administrator.",
                                    "Fehler beim Laden der Anwendung",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);

                // kill the app by all means necessary
                this.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadConfig();

            // Instantiate logon form
            LogonForm logonForm = new LogonForm();

            this.WindowState = FormWindowState.Minimized;
            #if DEBUG
            isLoggedIn = true;
            #else 
            isLoggedIn = false;
            #endif
          

            // Logon routine
            while(isLoggedIn == false)
            {
                // If the form was disposed (due to mistakes in code)
                // the app will be killed in last instance
                if (logonForm.IsDisposed) 
                {   
                    break;
                }
                switch(logonForm.ShowDialog())
                {
                    // This is not supposed to happen and will kill the app
                    case DialogResult.Cancel:
                        isLoggedIn = false;
                        Application.Exit();
                        return ;

                    // This is not supposed to happen and will kill the app
                    case DialogResult.None:
                        isLoggedIn = false;
                        Application.Exit();
                        return ;

                    // The Dialog Result returns DialogResult.OK 
                    // if the authentification succeeded.
                    case DialogResult.OK:
                        isLoggedIn = true;
                        // gather all the data to provide them to other forms
                        _accountName =  logonForm.AccountName;
                        _displayName =  logonForm.DisplayName;
                        _domain =       logonForm.Domain;
                        break;

                    // This is not supposed to happen and will kill the app
                    default:
                        NotifyUserLog(LogMessage.UserLogonError);
                        isLoggedIn = false;
                        return ;
                }
            }
            // Kill the app in last instance, if an error occured and the while block was exited
            if (isLoggedIn == false) Application.Exit();
            
            // Reset the form to apply the culture
            this.Controls.Clear();
            InitializeComponent();

            // Display the Main Form in full size
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;

            PopulateList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggedIn == true)
            {
                NotifyUserLog(LogMessage.UserLoggedOff);
                isLoggedIn = false;
            }
        }

        private void PopulateList()
        {
            // remove all items from the listview
            listView1.Items.Clear();
            if (_mysql == null) return;
            // execute a reader wil the SQL string for this method's name
            using (MySqlDataReader reader = _mysql.Query(Resources.SqlStrings.GetAllProducts))
            {
                if (reader.HasRows)
                {
                    // iterate the result set and fill the listview according to its layout
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["productname"].ToString());
                        item.SubItems.Add(reader["productdescription"].ToString());
                        item.SubItems.Add(reader["date"].ToString());
                        item.SubItems.Add(reader["lang"].ToString());
                        
                        bool isDvd = (bool)reader["dvdmedia"];
                        MediaType type = ((isDvd) ? MediaType.DigitalVersatileDisc : MediaType.CompactDisc);
                        
                        Disc imageWrapper = new Disc(reader["file"].ToString(), reader["productid"].ToString(), reader["fullname"].ToString(), type);
                        imageWrapper.ProductName = reader["productname"].ToString();
                        item.Tag = imageWrapper;

                        if (type == MediaType.DigitalVersatileDisc) item.ImageKey = "dvd";
                        else item.ImageKey = "cd";                      

                        listView1.Items.Add(item);
                    }
                    SwitchBackgroundColor();
                }
            }
        }

        private void PerformSearch()
        {
            // redundancy check to add to the search history
            if (!tSCB_search.Items.Contains(tSCB_search.Text))
                tSCB_search.Items.Add(tSCB_search.Text);

            // clear all items in the listview
            listView1.Items.Clear();

            // execute a reader wil the SQL string for this method's name
            MySqlDataReader reader = _mysql.Query(Resources.SqlStrings.Search,
                                                    new MySqlDataParameter("productName", "%" + tSCB_search.Text + "%"),
                                                    new MySqlDataParameter("description", "%" + tSCB_search.Text + "%"));

            // iterate the result set and fill the listview according to its layout
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["productname"].ToString());
                item.SubItems.Add(reader["productdescription"].ToString());
                item.SubItems.Add(reader["date"].ToString());
                item.SubItems.Add(reader["lang"].ToString());
                
                MediaType type = (((bool)reader["dvdmedia"]) ? MediaType.DigitalVersatileDisc : MediaType.CompactDisc);
                Disc imageWrapper = new Disc(reader["file"].ToString(), reader["productid"].ToString(), reader["fullname"].ToString(), type);
                imageWrapper.ProductName = reader["productname"].ToString();
                item.Tag = imageWrapper;

                if (type == MediaType.DigitalVersatileDisc) item.ImageKey = "dvd";
                else item.ImageKey = "cd";   

                listView1.Items.Add(item);
            }
            reader.Close();

            SwitchBackgroundColor();
        }
   
        #region Helper Methods
        private void SwitchBackgroundColor()
        {
            for (int index = 0; index < listView1.Items.Count; index++)
                listView1.Items[index].BackColor = (((index % 2) == 1) ? Color.FromArgb(0xEDEDFF) : Color.White);
            //d0ecff
        }

        private void NotifyUserLog(LogMessage message)
        {
            MySql.Statement(Resources.SqlStrings.NotifyUserLog,
             new MySqlDataParameter("user", _accountName),
             new MySqlDataParameter("message", (int)message),
             new MySqlDataParameter("domain", _domain));
        }

        private void Log(string str) 
        { 
            _log.Add(DateTime.Now.ToString() + ": " + str);
        }
        #endregion

        #region User Interaction Event handlers
        #region Toolstrip Menu Item Event Handlers
        private void tSMI_quit_Click(object sender, EventArgs e) { Application.Exit(); }
        private void tSMI_burn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Disc wrapper = (Disc)listView1.SelectedItems[0].Tag;
                Burn burnForm = new Burn(wrapper);
                burnForm.ShowDialog();
            }
        }
        private void tSMI_showalllicences_Click(object sender, EventArgs e)
        {
            ShowDistributedLicenses licensDialog = new ShowDistributedLicenses();
            licensDialog.ShowDialog();
        }
        private void tSMI_showlog_Click(object sender, EventArgs e)
        {
            BlueFlame.Forms.Log log = new BlueFlame.Forms.Log(_log);
            log.Show();
        }
        #endregion

        #region Toolstrip Button Event Handlers
        private void tSB_search_Click(object sender, EventArgs e) { PerformSearch(); }
        private void tSB_reset_Click(object sender, EventArgs e)
        {
            tSCB_search.Text = " Suchen ";
            tSCB_search.Items.Clear();
            PopulateList();
        }
        #endregion

        #region Toolstrip Search Field Event Handlers
        private void tSCB_search_SelectedIndexChanged(object sender, EventArgs e) 
        {
            PerformSearch();
        }
        private void tSCB_search_Click(object sender, EventArgs e) 
        { 
            if (tSCB_search.Text == " Suchen ") tSCB_search.Text = ""; 
        }
        private void tSCB_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PerformSearch();
        }
        #endregion

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.ListViewItemSorter = new ListViewItemSorter(e.Column, _columnStatus.Reorder(e.Column));
        }
        #endregion

        void _nero_OnFileSelImage(ref string Filename)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Filename = saveFileDialog1.FileName;
            }
            else
            {
                Filename = "";
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}