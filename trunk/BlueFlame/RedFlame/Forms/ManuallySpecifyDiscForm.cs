using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RedFlame.Forms
{
    public partial class ManuallySpecifyDiscForm : Form
    {
        private string _filename;
        public string Filename
        {
            get { return _filename; }
        }
	
        public ManuallySpecifyDiscForm()
        {
            InitializeComponent();
            _filename = "";
            PopulateForm();
        }

        public ManuallySpecifyDiscForm(string filename)
        {
            InitializeComponent();
            _filename = filename;
            PopulateForm();
        }

        private void PopulateForm()
        {
            if (!string.IsNullOrEmpty(_filename))
            {
                FileInfo info = new FileInfo(_filename);

                cB_extension.Text = info.Extension;
                tB_filename.Text = info.Name.Remove(((info.Name.Length) - info.Extension.Length), info.Extension.Length);
                tB_path.Text     = info.FullName.Replace(info.Name,"");
            }
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            string ext = cB_extension.Text;
            string path = tB_path.Text;
            string filename = tB_filename.Text;

            if (!cB_extension.Text.StartsWith("."))
                ext = "." + cB_extension.Text;

            if (!tB_path.Text.EndsWith("\\"))
                path = tB_path.Text + "\\";

            if (!tB_filename.Text.Contains("."))
                filename = tB_filename.Text + ext;

            _filename = path + filename;
            System.Diagnostics.Debug.WriteLine("Concatenated Filename: " + _filename);

            if (File.Exists(_filename))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (MessageBox.Show(
                    "The specified file\n\n"+_filename+"\n\ncould not be found. Do you want to use it anyway?",
                    "File not found",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    this.DialogResult = DialogResult.OK;
            }
        }
    }
}