using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BlueFlame.Classes;
using BlueFlame.Classes.MySql;
using BlueFlame.Classes.DatabaseObjects;

namespace RedFlame.Forms
{
    public partial class CheckLicense : Form
    {
        private ListViewColumnStatus _productStatus;
        private ListViewColumnStatus _userStatus;

        public CheckLicense(string licensekey)
        {
            _productStatus = new ListViewColumnStatus();
            _userStatus = new ListViewColumnStatus();
            InitializeComponent();
            tB_key.Text = licensekey;
        }

        public CheckLicense()
        {
            _productStatus = new ListViewColumnStatus();
            _userStatus = new ListViewColumnStatus();
            InitializeComponent();
        }

        private void b_check_Click(object sender, EventArgs e)
        {
            GetProducts();
            
        }

        private void GetProducts()
        {
            if (string.IsNullOrEmpty(tB_key.Text)) return;

            lV_products.Items.Clear();
            using (MySqlDataReader reader = MainForm.MySql.Query(Resources.SqlStrings.GetProductsByLicense,
                new MySqlDataParameter("key", tB_key.Text)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["productname"].ToString());
                        item.SubItems.Add(reader["productid"].ToString());
                        item.SubItems.Add(reader["file"].ToString());
                        item.ImageKey = "product";
                        item.Tag = new Disc(
                            reader["file"].ToString(),
                            reader["productid"].ToString(),
                            MediaType.CompactDisc);

                        lV_products.Items.Add(item);
                    }
                }
            }
        }

        private void lV_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductDetails();
        }

        private void GetProductDetails()
        {
            if (lV_products.SelectedItems.Count > 0)
            {
                if (lV_products.SelectedItems[0].Tag is Disc)
                {
                    Disc product = (lV_products.SelectedItems[0].Tag as Disc);
                    #region LicenseInfo
                    using (MySqlDataReader reader =
                        MainForm.MySql.Query(
                            Resources.SqlStrings.GetLicenseInfo,
                            new MySqlDataParameter("key", tB_key.Text),
                            new MySqlDataParameter("file", product.FileId),
                            new MySqlDataParameter("productId", product.ProductId)))
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                l_insertDate.Text = reader["insertdate"].ToString();
                                cB_distributed.Checked =(bool)reader["distributed"];
                                cB_multi.Checked = (bool)reader["multi"];

                
                            }
                        }
                    } // endusing
                    #endregion

                    #region Last Date
                    using (MySqlDataReader reader = 
                        MainForm.MySql.Query(
                            Resources.SqlStrings.GetLastDistributionDate,
                            new MySqlDataParameter("key", tB_key.Text),
                            new MySqlDataParameter("id", product.ProductId),
                            new MySqlDataParameter("file",product.FileId)))
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                //2006-09-13 15:22:36
                                
                                l_lastDistribution.Text  = DateTime.Parse(reader["lastdate"].ToString()).ToString();
                                l_count.Text = reader["count"].ToString();
                            }
                        }
                    } // endusing
                    #endregion

                    #region User Data
                    lV_user.Items.Clear();
                    using (MySqlDataReader reader = MainForm.MySql.Query(
                            Resources.SqlStrings.GetUserByLicense,
                            new MySqlDataParameter("key", tB_key.Text),
                            new MySqlDataParameter("productId",product.ProductId),
                            new MySqlDataParameter("fileId", product.FileId))
                        )
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            { 
                                // user displayname domain time
                                ListViewItem item = new ListViewItem(reader["user"].ToString());
                                item.SubItems.Add(reader["displayname"].ToString());
                                item.SubItems.Add(reader["domain"].ToString());
                                item.SubItems.Add(DateTime.Parse(reader["time"].ToString()).ToString());
                                item.ImageKey = "user";
                                lV_user.Items.Add(item);
                            }
                        }
                    }  // endusing
                    #endregion
                }// end if
            }
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lV_products_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lV_products.ListViewItemSorter = new ListViewItemSorter(e.Column, _productStatus.SortOrder);
        }

        private void lV_user_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lV_user.ListViewItemSorter = new ListViewItemSorter(e.Column, _userStatus.SortOrder);
        }

        private void CheckLicense_Load(object sender, EventArgs e)
        {
            l_count.Text = "";
            l_insertDate.Text = "";
            l_lastDistribution.Text = "";
            if (!string.IsNullOrEmpty(tB_key.Text))
            {
                GetProducts();
            }
        }// endmethod
    } // end cls
} // end ns