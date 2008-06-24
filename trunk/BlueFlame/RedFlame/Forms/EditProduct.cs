using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedFlame.Forms
{
    public partial class EditProduct : Form
    {
        private string _product;
        public string Product
        {
            get { return _product; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
        }

        public EditProduct()
        {
            InitializeComponent();
            _description = "";
            _product     = "";
        }

        public EditProduct(string product, string description)
        {
            InitializeComponent();
            _product     = product;
            _description = description;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            PopulateForm();
        }

        private void PopulateForm()
        {
            tB_description.Text = _description;
            tB_product.Text     = _product;
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_product.Text))
            {
                MessageBox.Show("Please specify a productname!", "Productname Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _product = tB_product.Text;
                _description = tB_description.Text;
               this.DialogResult = DialogResult.OK; 
            }
        }
    }
}