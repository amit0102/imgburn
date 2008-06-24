using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueFlame.Forms
{
    public partial class RTFViewer : Form
    {
        public RTFViewer()
        {
            InitializeComponent();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RTFViewer_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("license.rtf");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}