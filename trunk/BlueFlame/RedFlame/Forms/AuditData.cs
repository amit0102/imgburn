using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BlueFlame.Classes.UserControls;
using MySql.Data.MySqlClient;
using BlueFlame.Classes;

namespace RedFlame.Forms
{
    public partial class AuditData : Form
    {
        private ListViewColumnStatus _currentSortOrder;

        public AuditData()
        {
            InitializeComponent();
        }

        private void AuditData_Load(object sender, EventArgs e)
        {
            _currentSortOrder = new ListViewColumnStatus();
            GetUserLog();
        }


        private void GetLicenseLog()
        {
            lV_audit.Clear();

            ColumnHeader time = new ColumnHeader();
            time.Text = "Time";
            time.Width = 150;

            ColumnHeader displayname = new ColumnHeader();
            displayname.Text = "Displayname";
            displayname.Width = 150;

            ColumnHeader name = new ColumnHeader();
            name.Text = "Name";
            name.Width = 100;

            ColumnHeader domain = new ColumnHeader();
            domain.Text = "domain";
            domain.Width = 50;

            ColumnHeader message = new ColumnHeader();
            message.Text = "Message";
            message.Width = 200;

            ColumnHeader file = new ColumnHeader();
            file.Text = "File";
            file.Width = 200;

            ColumnHeader productid = new ColumnHeader();
            productid.Text = "ID";
            productid.Width = 30;

            ColumnHeader licensekey = new ColumnHeader();
            licensekey.Text = "Key";
            licensekey.Width = 200;

            //l.time, u.displayname, u.user, u.domain, m.text, l.file, l.productid,  l.licensekey, 
            lV_audit.Columns.AddRange(new ColumnHeader[] { time, displayname, name, domain, message, file, productid, licensekey });

            using (MySqlDataReader reader = MainForm.MySql.Query(
                Resources.SqlStrings.GetAllLicenseLogs))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["time"].ToString());
                        item.SubItems.Add(reader["displayname"].ToString());
                        item.SubItems.Add(reader["user"].ToString());
                        item.SubItems.Add(reader["domain"].ToString());
                        item.SubItems.Add(reader["text"].ToString());
                        item.SubItems.Add(reader["file"].ToString());
                        item.SubItems.Add(reader["productid"].ToString());
                        item.SubItems.Add(reader["licensekey"].ToString());
                        lV_audit.Items.Add(item);
                    }
                }
            }
        }

        private void GetMediaLog()
        {
            lV_audit.Clear();

            ColumnHeader time = new ColumnHeader();
            time.Text = "Time";
            time.Width = 150;

            ColumnHeader displayname = new ColumnHeader();
            displayname.Text = "Displayname";
            displayname.Width = 150;

            ColumnHeader name = new ColumnHeader();
            name.Text = "Name";
            name.Width = 100;

            ColumnHeader domain = new ColumnHeader();
            domain.Text = "domain";
            domain.Width = 50;

            ColumnHeader message = new ColumnHeader();
            message.Text = "Message";
            message.Width = 200;

            ColumnHeader file = new ColumnHeader();
            file.Text = "File";
            file.Width = 200;

            ColumnHeader returncode = new ColumnHeader();
            returncode.Text = "RC";
            returncode.Width = 30;

            // u.displayname, u.user, u.domain, l.file,l.time, m.text, l.rc
            lV_audit.Columns.AddRange(new ColumnHeader[] { time, displayname, name, domain, message, file, returncode });

            using (MySqlDataReader reader = MainForm.MySql.Query(
                Resources.SqlStrings.GetAllImageLogs))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["time"].ToString());
                        item.SubItems.Add(reader["displayname"].ToString());
                        item.SubItems.Add(reader["user"].ToString());
                        item.SubItems.Add(reader["domain"].ToString());
                        item.SubItems.Add(reader["text"].ToString());
                        item.SubItems.Add(reader["file"].ToString());
                        item.SubItems.Add(reader["rc"].ToString());
                        lV_audit.Items.Add(item);
                    }
                }
            }
        }

        private void GetUserLog()
        {
            lV_audit.Clear();

            ColumnHeader time = new ColumnHeader();
            time.Text = "Time";
            time.Width = 150;

            ColumnHeader displayname = new ColumnHeader();
            displayname.Text = "Displayname";
            displayname.Width = 150;

            ColumnHeader name = new ColumnHeader();
            name.Text = "Name";
            name.Width = 100;

            ColumnHeader domain  = new ColumnHeader();
            domain.Text = "domain";
            domain.Width = 50;

            ColumnHeader message = new ColumnHeader();
            message.Text = "Message";
            message.Width = 200;

            // u.displayname, u.user, u.domain, l.file,l.time, m.text, l.rc
            lV_audit.Columns.AddRange(new ColumnHeader[] { time,displayname,name,domain,message});

            using(MySqlDataReader reader = MainForm.MySql.Query(
                Resources.SqlStrings.GetAllUserLogs))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["time"].ToString());
                        item.SubItems.Add(reader["displayname"].ToString());
                        item.SubItems.Add(reader["user"].ToString());
                        item.SubItems.Add(reader["domain"].ToString());
                        item.SubItems.Add(reader["text"].ToString());
                        lV_audit.Items.Add(item);
                    }
                }
            }
        }

        private void tSB_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tSB_user_Click(object sender, EventArgs e)
        {
            tSB_clear.Enabled = true;
            tSB_media.Checked = false;
            tSB_license.Checked = false;
            tSB_user.Checked = true;
            GetUserLog();
        }

        private void tSB_license_Click(object sender, EventArgs e)
        {
            tSB_clear.Enabled = false;
            tSB_media.Checked = false;
            tSB_license.Checked = true;
            tSB_user.Checked = false;
            GetLicenseLog();
        }

        private void tSB_media_Click(object sender, EventArgs e)
        {
            tSB_clear.Enabled = true; ;
            tSB_media.Checked = true;
            tSB_license.Checked = false;
            tSB_user.Checked = false;
            GetMediaLog();
        }

        private void tSB_clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear all the data from the current log?", "o rly?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tSB_media.Checked) ClearMediaLog();
                else if (tSB_user.Checked) ClearUserLog();
            }
        }

        private void ClearUserLog()
        {
            MainForm.MySql.Statement(Resources.SqlStrings.RemoveAllUserLogs);
            GetUserLog();
        }

        private void ClearMediaLog()
        {
            MainForm.MySql.Statement(Resources.SqlStrings.RemoveAllImageLogs);
            GetMediaLog();
        }

        private void lV_audit_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lV_audit.ListViewItemSorter = new ListViewItemSorter(e.Column, _currentSortOrder.Reorder(e.Column));
        }      
    }
}