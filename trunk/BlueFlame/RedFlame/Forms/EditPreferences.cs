using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.IO;

namespace RedFlame.Forms
{
    public partial class EditPreferences : Form
    {
        private const string ConnectionStringIdentifier = "ConnectionString";
        private Configuration _config;

        public EditPreferences()
        {
            InitializeComponent();
        }

        private void EditPreferences_Load(object sender, EventArgs e)
        {
            try
            {
                _config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                if (!_config.ConnectionStrings.SectionInformation.IsProtected)
                    _config.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                string constr = _config.ConnectionStrings.ConnectionStrings[ConnectionStringIdentifier].ToString();
                tB_connectionString.Text = constr;

                tB_externalProgram.Text = _config.AppSettings.Settings["BurnApplication"].Value;
            }
            catch(ConfigurationException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                MessageBox.Show(
                    "An error occured while trying to read the configuation file. Message:\n\n" + ex.Message,
                    "Configuration Error",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            _config.ConnectionStrings.ConnectionStrings[ConnectionStringIdentifier].ConnectionString =
                tB_connectionString.Text;
            _config.AppSettings.Settings["BurnApplication"].Value = tB_externalProgram.Text;

            if (!_config.ConnectionStrings.SectionInformation.IsProtected)
                _config.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            _config.Save();
            
            this.DialogResult = DialogResult.OK;
        }

        private void b_editConStr_Click(object sender, EventArgs e)
        {
            EditConnectionString cstrForm = new EditConnectionString(tB_connectionString.Text);
            if (cstrForm.ShowDialog() == DialogResult.OK)
            { 
                tB_connectionString.Text = cstrForm.ConnectionString.ToString();
            }
        }

        private void b_browseProg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tB_externalProgram.Text = openFileDialog1.FileName;
                this.DialogResult = DialogResult.None;
            }
        }

        private void b_export_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = File.Create(saveFileDialog1.FileName))
                {
                    using (XmlWriter writer = XmlWriter.Create(stream))
                    {
                        XmlDocument doc = new XmlDocument();
                        XmlElement config = doc.CreateElement("configuration");
                        doc.AppendChild(config);

                        XmlElement connectionStrings = doc.CreateElement("connectionStrings");
                        XmlElement add = doc.CreateElement("add");
                        add.SetAttribute("name", "ConnectionString");
                        add.SetAttribute("connectionString", tB_connectionString.Text);

                        config.AppendChild(connectionStrings);
                        connectionStrings.AppendChild(add);

                        doc.WriteContentTo(writer);
                    }
                }
            }
        }
    }
}

//<?xml version="1.0" encoding="utf-8" ?>
//<configuration>
//    <configSections>
//    </configSections>
//    <connectionStrings>
//      <add name="ConnectionString" connectionString="Database=visualstudio;Password=visualstudio;User ID=visualstudio;Server=localhost;Port=3306;" providerName="MySql.Data.MySqlClient" />
//    </connectionStrings>
//</configuration>