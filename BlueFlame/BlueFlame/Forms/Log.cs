using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BlueFlame.Forms
{
    public partial class Log : Form
    {
        List<string> _log;

        public Log(List<string> log)
        {
            InitializeComponent();
            _log = log;
        }

        private void Log_Load(object sender, EventArgs e)
        {
            if (_log == null) return;
            listBox1.Items.Clear();
            foreach(string str in _log) listBox1.Items.Add(str);
        }
    }
}