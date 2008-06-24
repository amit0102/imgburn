using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;

using NEROLib;

using MySql.Data;
using MySql.Data.MySqlClient;

using BlueFlame.Classes.MySql;
using System.Security;
using System.IO;
using BlueFlame.Classes;
using BlueFlame.Classes.DatabaseObjects;
using System.Threading;

namespace BlueFlame.Forms
{
    public partial class Burn : Form
    {
        private enum LicenseType 
        { 
            /// <summary>
            /// The type of the license has not yet been determined. This happens if an error occured
            /// </summary>
            NotSet = -1,

            /// <summary>
            /// The selected product doesnt need a license
            /// </summary>
            None = 0,

            /// <summary>
            /// The license was distributed and must be set as distributed
            /// </summary>
            NewSingle = 1,

            /// <summary>
            /// The license was distributed and no further action is available
            /// </summary>
            NewMulti = 2,

            /// <summary>
            /// The license was distributed in an earlier session
            /// </summary>
            Redistribution = 3,

            /// <summary>
            /// All licenses have been distributed and there are no more available
            /// </summary>
            NotAvailable = 4
        }

        private string _licensekey;
        private string _message;
        private int _speed;
        private double _size;

        private Disc _disc;

        // The currently selected drive
        private static NeroDrive _drive;
        /// <summary>
        /// Returns the currently selected drive. 
        /// </summary>
        public static NeroDrive Drive
        {
            get { return _drive; }
        }

        // ctor
        public Burn(Disc disc)
        {
            _disc = disc;
            // init needed data
            _speed = 0;
            _size = 0;
            
            InitializeComponent();
        }

        private void Burn_Load(object sender, EventArgs e)
        {
            // Check if there are burners available
            if(MainForm.Drives.Count == 0)
            {
                if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                    MessageBox.Show("There are no compatible devices present. Please contact your administrator", "No device present", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                else
                MessageBox.Show("Leider sind keine geeigneten Laufwerke vorhanden. Wenden Sie sich an ihren Administrator", "Kein Brenner vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // show available burners
            cB_burner.Items.Clear();
            for (int i = 0; i < MainForm.Drives.Count; i++)
                cB_burner.Items.Add(MainForm.Drives.Item(i).DeviceName);

            GetFileInfo();
            LicenseType licenseType = GetLicense(_disc.FileId, _disc.ProductId);
            EvaluateLicenseType(licenseType);

            // Select first burner in list
            if (cB_burner.Items.Count > 0) cB_burner.SelectedIndex = 0;

            // Populate form will be called on SelectedIndex changed
        }

        private NERO_MEDIA_TYPE ConvertMediaTypeToNERO_MEDIA_TYPE(MediaType discType)
        {
            switch (discType)
            {
                case MediaType.CompactDisc:
                    return NERO_MEDIA_TYPE.NERO_MEDIA_CD;

                case MediaType.DigitalVersatileDisc:
                    return NERO_MEDIA_TYPE.NERO_MEDIA_DVD_ANY;

                default:
                    return NERO_MEDIA_TYPE.NERO_MEDIA_CD;
            }
        }

        private void PopulateForm()
        {
            l_product.Text = _disc.ProductName;
            l_info.Text = _message;
            tB_licence.Text = _licensekey;
            
            switch (_disc.MediaType)
            {
                case MediaType.CompactDisc:
                    l_requireddisc.Text = "CD";
                    break;
                case MediaType.DigitalVersatileDisc:
                    l_requireddisc.Text = "DVD";
                    break;
                default:
                    if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                        MessageBox.Show("An error occured. Please contact your administrator", "Ein Fehler trat auf");
                    else MessageBox.Show("Ein Fehler trat auf, bitte wenden Sie sich an den Administrator", "Ein Fehler trat auf");
                    DialogResult = DialogResult.Cancel;
                    break;
            }


            // use the selected burner as the currently used drive
            _drive = (NeroDrive)MainForm.Drives.Item(cB_burner.SelectedIndex);

            NERO_MEDIA_TYPE type = ConvertMediaTypeToNERO_MEDIA_TYPE(_disc.MediaType);

            // update the info of the disc
            _drive.UpdateDeviceInfo(type);
            
            // show the speeds in the combo box
            cB_speeds.Items.Clear();
            
            NeroSpeeds _speeds = _drive.get_AvailableSpeeds(NERO_ACCESSTYPE.NERO_ACCESSTYPE_WRITE, type);

            for (int i = 0; i < _speeds.Count; i++)
            {
                float speed = _speeds.Item(i) /(float) _speeds.BaseSpeedKBs;
                cB_speeds.Items.Add(((speed) + "x (" + _speeds.Item(i) + " KB/s)"));
            }

            if (cB_speeds.Items.Count > 0)
                cB_speeds.SelectedIndex = cB_speeds.Items.Count - 1;
        }

        private void cB_burner_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateForm();            
        }

        private void b_burn_Click(object sender, EventArgs e)
        {
            BurnProgress progressDialog = new BurnProgress(_disc, _speed);
            progressDialog.ShowDialog();
        }

        private void cB_speeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_speeds.SelectedItem != null)
            {
                int? i = _drive.WriteSpeeds.Item(cB_speeds.SelectedIndex);
                if (i != null) _speed = (int)i;
            }
            if (_size > 0) UpdateEstimatedBurnTime();
        }

        private void UpdateEstimatedBurnTime()
        {
            //1024; // size in kb
            double kbPerSecond = _speed * 150; //* 60; // speed by 150 kb per second by 60 seconds = kilobit per minute
            double sizeKb = _size / 1024;
            double timeSec = (sizeKb / kbPerSecond + 1);
            double time = Math.Round((timeSec / 60), 2);
            time += 2; // lead in + lead out
            l_estimated.Text = time.ToString() + " Minuten";
        }

        /// <summary>
        /// Fetches the filepath and the name of the selecetd product using 
        /// the static file and product ids and displays the productname on the form.
        /// </summary>
        private void GetFileInfo()
        {
            try
            {
                FileInfo info = new FileInfo(_disc.FullName);
                _size = info.Length;
            }
            catch(Exception ex)
            {
                if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                    MessageBox.Show("An error occured while trying to open the file. Please contact your administrator.\n\n",
                    "Error opening file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                MessageBox.Show("Beim Öffnen der Datei trat ein Fehler auf. Bitte wenden Sie sich an Ihren Administrator.\n\n",
                    "Fehler beim Öffnen der Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Retrieves the data of the license and populates the properties that are needed to display a status and the licensekey
        /// </summary>
        /// <param name="fileId">The Database Id from the database, eg. '2344'</param>
        /// <param name="productId">The Product Id from the database, eg. 2</param>
        /// <returns>A result of the type LicenseType that specifies how the logging must react.</returns>
        private LicenseType GetLicense(string fileId, string productId)
        {
            LicenseType returnLicenseType = LicenseType.NotSet;

            // In case the product license is specified by a different file that the 
            // source image of the file itself the file and product ids have to be updated.
            // Used Sql String: GetLicence
            using (MySqlDataReader reader = MainForm.MySql.Query(Resources.SqlStrings.GetLicenseSourceFile,
                                    new MySqlDataParameter("fileId", fileId),
                                    new MySqlDataParameter("productId", productId)))
            {
                if (reader.HasRows)
                {
                    reader.Read();

                    string parentFile = reader["licensefromfile"].ToString();
                    string parentProductId = reader["licensefromproductid"].ToString();

                    if(!string.IsNullOrEmpty(parentFile))
                    {
                        fileId = parentFile;
                        productId = parentProductId;
                    }
                }
            } // endusing
            
            // Avoid distributing more than one license by checking the log first
            using(MySqlDataReader reader =  MainForm.MySql.Query(Resources.SqlStrings.GetLicenseFromLog,
                new MySqlDataParameter("file", fileId),
                new MySqlDataParameter("productid", productId),
                new MySqlDataParameter("user", MainForm.AccountName),
                new MySqlDataParameter("domain", MainForm.Domain)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    _licensekey = reader["licensekey"].ToString();
                    if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                        _message = "The license for this product has already been distributed.";
                    else
                    _message = "Die Lizenz für dieses Produkt wurde bereits erteilt.";
                    return LicenseType.Redistribution;
                }
            } // endusing

            // Try finding the licenses for the selected product
            using (MySqlDataReader reader = MainForm.MySql.Query(Resources.SqlStrings.GetLicense,
                new MySqlDataParameter("file", fileId),
                new MySqlDataParameter("productId", productId)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    _licensekey = reader["licensekey"].ToString();
                    if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                        _message = "The license for this product is new";
                    else
                        _message = "Die Lizenz für dieses Produkt wurde neu erteilt.";
                    
                    if((bool)reader["multi"]) return LicenseType.NewMulti;
                    else return LicenseType.NewSingle;
                }
            }  // endusing

            // if there's none available that has not been distributed
            // try to find out if the product even needs one
            using (MySqlDataReader reader = MainForm.MySql.Query(Resources.SqlStrings.GetLicenseDistributed,
                new MySqlDataParameter("file", fileId),
                new MySqlDataParameter("productid", productId)))
            {
                // there are licenses, but they are not available
                if (reader.HasRows)
                {
                    _licensekey = "";
                    if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                        _message = "All the licenses for this product have been distributed. Please ask your administrator for a licensekey.";
                    else
                    _message = "Die Lizenzen für dieses Produkt sind verbraucht. Bitte wenden Sie sich an den Administrator";
                    return LicenseType.NotAvailable;
                }
                // there are no licenses at all, so none is needed
                else
                {
                    _licensekey = "";
                    if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                        _message = "This product doesn't require a licensekey.";
                    else
                        _message = "Für dieses Produkt wird kein Lizenzschlüssel benötigt.";
                    return LicenseType.None;
                }
            } // endusing
        }

        /// <summary>
        /// Evaluates the a result of LicenseType to determine what further actions
        /// have to be taken after a license has been found (such as logging or distributing it)
        /// </summary>
        /// <param name="type">The type of the result</param>
        private void EvaluateLicenseType(LicenseType type)
        {
            switch (type)
            {
                case LicenseType.None:
                    NotifyLicenseLog(3002);        
                    break;
                case LicenseType.NewSingle:

                    MainForm.MySql.Statement(Resources.SqlStrings.SetLicenseDistributed,
                        new MySqlDataParameter("file", _disc.FileId),
                        new MySqlDataParameter("productid", _disc.ProductId),
                        new MySqlDataParameter("licensekey", _licensekey));

                    NotifyLicenseLog(3000);    
                    break;

                case LicenseType.NewMulti:
                    NotifyLicenseLog(3000);
                    break;

                case LicenseType.Redistribution:
                    NotifyLicenseLog(3001);
                    break;

                case LicenseType.NotAvailable:
                    NotifyLicenseLog(3002);
                    break;

                default:
                    NotifyLicenseLog(3002);
                    break;
            }
        }

        /// <summary>
        /// Logs the licenses of a user into the database
        /// </summary>
        /// <param name="messageId">The id of a message from the database that containes a certain statement</param>
        private void NotifyLicenseLog(int messageId)
        {
            // Insert the licenskey into the log
            string sqlString = "INSERT INTO licenselog (user,file,productid,licensekey,time,message,domain)" +
                               "VALUES (?user,?file,?productid,?licensekey,?time,?message,?domain)";

            string key = (string.IsNullOrEmpty(_licensekey)) ? "- Keine -" : _licensekey; 
            
            MainForm.MySql.Statement(sqlString, 
                new MySqlDataParameter("user",      MainForm.AccountName),
                new MySqlDataParameter("file",      _disc.FileId),
                new MySqlDataParameter("productid", _disc.ProductId),
                new MySqlDataParameter("licensekey",key),
                new MySqlDataParameter("time",      DateTime.Now.ToString("yyyyMMddHHmmss")),
                new MySqlDataParameter("message",   messageId),
                new MySqlDataParameter("domain",    MainForm.Domain));
        }
    } // end class
} // end namespace 