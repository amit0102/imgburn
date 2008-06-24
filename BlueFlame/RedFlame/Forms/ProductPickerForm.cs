using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BlueFlame.Classes.DatabaseObjects;
using MySql.Data.MySqlClient;
using BlueFlame.Classes.MySql;

namespace RedFlame.Forms
{
    public partial class ProductPickerForm : Form
    {
        private Product _product;

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }
	

        public ProductPickerForm()
        {
            InitializeComponent();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            SelectProduct();
        }

        private void SelectProduct()
        {
            if (lV_produtcs.SelectedItems.Count > 0)
            {
                if (lV_produtcs.SelectedItems[0].Tag is Product)
                {
                    _product = (lV_produtcs.SelectedItems[0].Tag as Product);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void ProductPickerForm_Load(object sender, EventArgs e)
        {
            PopulateForm();                
        }

        private void PopulateForm()
        {
            using (MySqlDataReader reader = MainForm.MySql.Query(
                Resources.SqlStrings.GetFilteredProducts))
            {
                lV_produtcs.Items.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["productname"].ToString());
                        item.SubItems.Add(reader["productid"].ToString());
                        item.SubItems.Add(reader["file"].ToString());
                        Product product = new Product(reader["productname"].ToString(),
                            "",
                            reader["file"].ToString(),
                            reader["productid"].ToString());
                        item.Tag = product;
                        item.ImageKey = "product";
                        lV_produtcs.Items.Add(item);
                    }
                }
            }
        }


        private void b_search_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tB_keyword.Text))
            {
                PopulateForm();
                return;
            }
            using(MySqlDataReader reader = MainForm.MySql.Query(
                Resources.SqlStrings.SearchProductsWithLicenses,
                new MySqlDataParameter("keyword","%" + tB_keyword.Text + "%")))
            {
                lV_produtcs.Items.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["productname"].ToString());
                        item.SubItems.Add(reader["productid"].ToString());
                        item.SubItems.Add(reader["file"].ToString());
                        Product product = new Product(reader["productname"].ToString(),
                            "",
                            reader["file"].ToString(),
                            reader["productid"].ToString());
                        item.Tag = product;
                        item.ImageKey = "product";
                        lV_produtcs.Items.Add(item);
                    }
                }
            }
        }

        private void tB_keyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelectProduct();
        }

        private void lV_produtcs_DoubleClick(object sender, EventArgs e)
        {
            SelectProduct();
        }
    }
}