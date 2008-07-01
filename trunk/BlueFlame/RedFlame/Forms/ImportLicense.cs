using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.XPath;
using System.IO;

namespace RedFlame.Forms
{
    public partial class ImportLicense : Form
    {
        private List<string> _keys;
        public List<string> Keys
        {
            get { return _keys; }
        }

        public bool IsMulti
        {
            get { return cB_multi.Checked; }
        
        }

        public ImportLicense()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Stream str = File.OpenRead(tb_path.Text))
            {
                XPathDocument document = new XPathDocument(str);
                XPathNavigator navigator = document.CreateNavigator();
                XPathNodeIterator iterator = navigator.Select("YourKey/Product_Key/Key");

                while (iterator.MoveNext())
                {
                    if (!_keys.Contains(iterator.Current.Value))
                        _keys.Add(iterator.Current.Value);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ImportLicense_Load(object sender, EventArgs e)
        {
            _keys = new List<string>();
        }
    }
}