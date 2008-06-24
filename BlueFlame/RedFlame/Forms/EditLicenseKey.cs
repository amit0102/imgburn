using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedFlame.Forms
{
    public partial class EditLicenseKey : Form
    {
        private bool _distributed;
        public bool IsDistributed
        {
            get { return _distributed; }
        }

        private bool _multi;
        public bool IsMulti
        {
            get { return _multi; }
        }

        private string _key;
        public string LicenseKey
        {
            get { return _key; }
        }

        public EditLicenseKey()
        {
            InitializeComponent();

            _key = "";
            _multi = false;
            _distributed = false;
        }

        public EditLicenseKey(string key, bool distributed, bool multi)
        {
            InitializeComponent();

            _key = key;
            _multi = multi;
            _distributed = distributed;
        }

        private void EditLicense_Load(object sender, EventArgs e)
        {
            cB_distributed.Checked = _distributed;
            cB_multiple.Checked = _multi;
            tB_key.Text = _key;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_key.Text))
            {
                MessageBox.Show("Please specify a license key!", "Key missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _key = tB_key.Text;
                _distributed = cB_distributed.Checked;
                _multi = cB_multiple.Checked;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}