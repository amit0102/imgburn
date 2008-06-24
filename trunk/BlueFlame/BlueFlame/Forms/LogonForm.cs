using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

using BlueFlame.Classes;
using BlueFlame.Classes.UserControls;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;
using BlueFlame.Classes.DatabaseObjects;
using BlueFlame.Classes.MySql;

namespace BlueFlame.Forms
{
    public partial class LogonForm : Form
    {
        // used to count the logon attempts
        private int _logonAttempts;

        #region Static properties that hold the gathered data
        private string _displayName;
        /// <summary>
        /// Returns the Username eg. 'John Doe'
        /// </summary>
        public string DisplayName
        {
            get { return _displayName; }
        }

        private string _accountName;
        /// <summary>
        /// Returns the account Name eg. 'm0012345'
        /// </summary>
        public string AccountName
        {
            get { return _accountName; }
        }

        private string _domain;
        /// <summary>
        /// Returns the users domain, eg. 'DCS', 'SOE', etc.
        /// </summary>
        public string Domain
        {
            get { return _domain; }
        }
        #endregion

        public LogonForm()
        {

            InitializeComponent();

            _displayName = "";
            _accountName = "";
            _domain = "";
            _logonAttempts = 0;
        }

        private void SetUpLanguagePicker()
        {
            ImageComboBoxItem german = new ImageComboBoxItem("Deutsch", "german");
            german.Tag = new CultureInfo("de-DE");
            ImageComboBoxItem english = new ImageComboBoxItem("English", "english");
            english.Tag = new CultureInfo("en");
            iCB_language.Items.Add(german);
            iCB_language.Items.Add(english);
            iCB_language.SelectedIndex = 0;
        }

        private void LogonForm_Load(object sender, EventArgs e)
        {
            SetUpLanguagePicker();

            // The main resource stores the allowed domains in a scalar string eg. 'DCS;SOE;'
            string domainString = Resources.BlueFlameResource.Domains;

            // divide the strings
            string[] domains = domainString.Split(';');

            // fill the domain combobox with the divided strings
            foreach(string domain in domains)
            {
                cB_domains.Items.Add(domain);
            }
            
            // select the first string in the list
            if (cB_domains.Items.Count > 0) cB_domains.SelectedIndex = 0;
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            // set cursor to waid. the domain query might take a little time
            Cursor = Cursors.WaitCursor;

            // get the servers uri from the ressource file 
            string server = Resources.BlueFlameResource.DomainServer;

            // get the user domain from the selected combobox entry 
            string domainName = (string)cB_domains.SelectedItem;

            if (string.IsNullOrEmpty(tB_name.Text))
            {
                NotifyUserLog(LogMessage.UserLogonErrorEmptyName);

                if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                MessageBox.Show("Please enter a username", "Who wants to know?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                MessageBox.Show("Bitte geben Sie einen Benutzernamen ein", "Wer will das wissen?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cursor = Cursors.Default;
                return;
            }
            if (string.IsNullOrEmpty(tB_password.Text))
            {
                if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                MessageBox.Show("Please enter a password", "Authorized personell only!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                MessageBox.Show("Bitte geben Sie ein Passwort an", "Hier darf nicht jeder rein!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cursor = Cursors.Default;
                return;
            }

            // typed in textbox
            string username = tB_name.Text;

            // typed in textbox
            string password = tB_password.Text;

            // Authenticate the user within the active directory. 
            // If the authentification succeeds the static properties in the class are filled
            if (ActiveDirectoryAuthentification.IsAuthentificated(server, domainName, username, password))
            {
                NotifyUserLog(LogMessage.UserLogonSuccess);                                
                _accountName = ActiveDirectoryAuthentification.AccountName;
                _displayName = ActiveDirectoryAuthentification.DisplayName;
                _domain = domainName;
                
                // Set back the Cursor
                Cursor = Cursors.Default;

                // Successfully quit the dialog
                this.DialogResult = DialogResult.OK;   
            }
            else
            {
                NotifyUserLog(LogMessage.UserLogonError);
                Cursor = Cursors.Default;
                // display error message
                if(Thread.CurrentThread.CurrentUICulture.Name == "en")
                    MessageBox.Show("Your log on attempt failed.\n"
                                    + "Please check your username and password.\n\n"
                                    + "Are these correct but still not working "
                                    + "please contact your administrator.",
                                    "Access denied",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                else
                MessageBox.Show("Sie konnten nicht angemeldet werden.\n"
                                + "Bitte überprüfen Sie Ihren Benutzernamen und Passwort.\n\n"
                                + "Sind diese korrekt und es funktioniert trotzdem nicht " 
                                + "wenden Sie sich bitte an Ihren Administrator.", 
                                "Du komms hier ned rein...", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                // reset password
                tB_password.Text = "";
                _logonAttempts++;
            }
            // Kill the app if logon failed more than 3x
            if (_logonAttempts == 3)
            {
                NotifyUserLog(LogMessage.UserLogonAbort);

                // reset the cursor
                Cursor = Cursors.Default;

                // Unsuccessfully quit the dialog
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            NotifyUserLog(LogMessage.UserLogonAbort);
            this.DialogResult = DialogResult.Cancel;
        }

        private void b_set_Click(object sender, EventArgs e)
        {
            ImageComboBoxItem item = iCB_language.SelectedItem as ImageComboBoxItem;
            CultureInfo info = (CultureInfo)item.Tag;
            if (Thread.CurrentThread.CurrentUICulture != info)
                Thread.CurrentThread.CurrentUICulture = info;
            this.Controls.Clear();
            this.InitializeComponent();
            LogonForm_Load(sender, e);
        }

        private void NotifyUserLog(LogMessage message)
        {
            MainForm.MySql.Statement(Resources.SqlStrings.NotifyUserLog,
             new MySqlDataParameter("user", tB_name.Text),
             new MySqlDataParameter("message", (int)message),
             new MySqlDataParameter("domain", cB_domains.Text));
        }

    }
}