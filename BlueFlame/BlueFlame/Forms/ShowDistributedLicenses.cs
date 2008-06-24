using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BlueFlame.Classes.MySql;
using MySql.Data.MySqlClient;
using System.IO;

namespace BlueFlame.Forms
{
    public partial class ShowDistributedLicenses : Form
    {
        public ShowDistributedLicenses()
        {
            InitializeComponent();
        }

        private void ShowDistributedLicenses_Load(object sender, EventArgs e)
        {

            Text = "User: " + MainForm.DisplayName + " Account: " + MainForm.Domain + "/" + MainForm.AccountName;

            listView1.Items.Clear();
            using (MySqlDataReader reader = MainForm.MySql.Query(Resources.SqlStrings.GetAllLicensesForUser,
                new MySqlDataParameter("user", MainForm.AccountName)))
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["productname"].ToString());
                    item.SubItems.Add(reader["licensekey"].ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void lL_excel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = File.Create(saveFileDialog1.FileName))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine("Produkt;Lizenzschluessel");
                        foreach (ListViewItem item in listView1.Items)
                        {
                            writer.WriteLine(item.SubItems[0].Text + ";" + item.SubItems[1].Text);
                        }
                    }
                }
            }
        }

        private void tSMI_copy_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string text = "";
                foreach (ListViewItem item in listView1.Items)
                {
                    text += item.SubItems[0].Text + ":" + item.SubItems[1].Text + Environment.NewLine;
                }
                Clipboard.SetText(text);
            }
        } 
    } // class
} // ns