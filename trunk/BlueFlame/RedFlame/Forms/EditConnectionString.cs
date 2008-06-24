using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BlueFlame.Classes.MySql;

namespace RedFlame.Forms
{
    public partial class EditConnectionString : Form
    {
        private MySqlConnectionString _conStr;
        public MySqlConnectionString ConnectionString
        {
            get { return _conStr; }
        }

        public EditConnectionString()
        {
            InitializeComponent();
            _conStr = null;
        }

        public EditConnectionString(string constr)
        {
            InitializeComponent();
            _conStr = new MySqlConnectionString(constr);
        }

        private void EditConnectionString_Load(object sender, EventArgs e)
        {
            l_status.Text = "";
            l_message.Text = "";
            if (_conStr != null)
            {
                tB_server.Text =    _conStr.Server;
                tB_port.Text =      _conStr.Port;
                tB_dataBase.Text =  _conStr.Database;
                tB_userId.Text =    _conStr.User;
                tB_password.Text =  _conStr.Password;
            }
        }

        private void b_test_Click(object sender, EventArgs e)
        {
            TestConnection();
        }

        private void TestConnection()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                MySqlWrapper mySqlConnection = new MySqlWrapper(CreateConnectionString().ToString());

                pB_connectionStatus.Image = iL_connection.Images["connected"];
                l_status.Text = "The connection was successfully established.";
                l_message.Text = "";
            }
            catch(Exception ex)
            {
                pB_connectionStatus.Image = iL_connection.Images["disconnected"];
                l_status.Text = "The connection could not be established.";
                l_message.Text = ex.Message;
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            Cursor = Cursors.Default;
        }

        private MySqlConnectionString CreateConnectionString()
        {
            return new MySqlConnectionString(
                            tB_userId.Text,
                            tB_password.Text,
                            tB_server.Text,
                            int.Parse(tB_port.Text),
                            tB_dataBase.Text);
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            _conStr = CreateConnectionString();
            this.DialogResult = DialogResult.OK;
        }
        


    }
}