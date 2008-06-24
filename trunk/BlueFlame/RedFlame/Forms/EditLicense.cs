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
    public partial class EditLicense : Form
    {
        private Disc _disc;
        private Product _product;
        private Product _licenseProvider;
	
        public EditLicense(Disc disc)
        {
            _disc = disc;
            _product = null;
            _licenseProvider = null;
            InitializeComponent();
        }

        private void EditLicense_Load(object sender, EventArgs e)
        {
            l_licenseFromFilename.Text = "";
            l_licenseFromProduct.Text = "";
            l_licenseFromProductId.Text = "";

            PopulateForm();
        }

        private Product GetProductInfo(string fileid, string productid)
        {
            Product product = null;
            using (MySqlDataReader reader = MainForm.MySql.Query(
                Resources.SqlStrings.GetSingleProduct,
                new MySqlDataParameter("file", fileid),
                new MySqlDataParameter("productid", productid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                     product = new Product(reader["productname"].ToString(),
                        reader["productdescription"].ToString(),
                        fileid,
                        productid);
                    if(reader["licensefromfile"] != null 
                        && reader["licensefromproductid"] != null)
                    {
                        if(!string.IsNullOrEmpty(reader["licensefromfile"].ToString())
                           && !string.IsNullOrEmpty(reader["licensefromproductid"].ToString()))
                        {
                            product.LicenseFromFile = reader["licensefromfile"].ToString();
                            product.LicenseFromProductId = reader["licensefromproductid"].ToString();
                        }
                    }
                }
            }
            return product;
        }

        private void GetLicenseKeys(Product product)
        {
            lV_licenses.Items.Clear();
            using (MySqlDataReader reader = MainForm.MySql.Query(
                Resources.SqlStrings.GetLicensesByProduct,
                new MySqlDataParameter("file", product.FileId),
                new MySqlDataParameter("productid", product.ProductId)))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = null;

                        ListViewItem item = new ListViewItem(reader["licensekey"].ToString());
                        item.SubItems.Add(reader["multi"].ToString());
                        item.SubItems.Add(reader["distributed"].ToString());
                        item.SubItems.Add(reader["time"].ToString());

                        if (reader["user"] != null
                            && reader["domain"] != null)
                            if (!string.IsNullOrEmpty(reader["user"].ToString())
                                && !string.IsNullOrEmpty(reader["domain"].ToString()))
                                user = new User(reader["user"].ToString(), reader["domain"].ToString(), "");

                        BlueFlame.Classes.DatabaseObjects.License license =
                            new BlueFlame.Classes.DatabaseObjects.License(reader["licensekey"].ToString(),
                            (bool)reader["multi"],
                            (bool)reader["distributed"],
                            reader["time"].ToString(), user, _product);
                        item.Tag = license;

                        if (user == null) item.ImageKey = "productlicense";
                        else item.ImageKey = "userlicense";

                        lV_licenses.Items.Add(item);
                    }
                    tSSL_count.Text = lV_licenses.Items.Count + " Licenses found";
                }
            }
        }

        private void PopulateForm()
        {
            l_filename.Text = _disc.FullName;
            _product = GetProductInfo(_disc.FileId, _disc.ProductId);

            l_product.Text = _product.Name;
            l_productid.Text = _product.ProductId;
            l_filename.Text = _product.FileId;
            
            _licenseProvider = null;
            if (_product.LicenseFromFile != null
                 && _product.LicenseFromProductId != null)
            {
                _licenseProvider = GetProductInfo(_product.LicenseFromFile, _product.LicenseFromProductId);
            }

            if (_licenseProvider != null)
            {
                rB_fromProduct.Checked = true;
                l_licenseFromProduct.Text = _licenseProvider.Name;
                l_licenseFromProductId.Text = _licenseProvider.ProductId;
                l_licenseFromFilename.Text = _licenseProvider.FileId;

                GetLicenseKeys(_licenseProvider);
            }
            else
            {
                rB_license.Checked = true;
                GetLicenseKeys(_product);
            }
        }

        private void tSB_add_Click(object sender, EventArgs e)
        {
            EditLicenseKey newKey = new EditLicenseKey();
            if (newKey.ShowDialog() == DialogResult.OK)
            {
                BlueFlame.Classes.DatabaseObjects.License license = 
                    new BlueFlame.Classes.DatabaseObjects.License(
                        newKey.LicenseKey,
                        newKey.IsMulti,
                        newKey.IsDistributed,
                        "",
                        null,
                        _product);
                license.Create();
                _licenseProvider = null;
            }
            GetLicenseKeys(_product);
        }

        private void tSB_editLicense_Click(object sender, EventArgs e)
        {
            if(lV_licenses.SelectedItems.Count > 0)
            {
                BlueFlame.Classes.DatabaseObjects.License license
                    = (BlueFlame.Classes.DatabaseObjects.License)lV_licenses.SelectedItems[0].Tag;

                EditLicenseKey editKey = new EditLicenseKey(license.Key, license.Distributed, license.Multi);
                if (editKey.ShowDialog() == DialogResult.OK)
                {
                    license.Multi = editKey.IsMulti;
                    license.Distributed = editKey.IsDistributed;
                    license.Save();
                }
            }
            GetLicenseKeys(_product);
        }

        private void tSB_removeLicense_Click(object sender, EventArgs e)
        {
            if (lV_licenses.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Would you really like to remove all the selected licenses?",
                    "o rly?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lV_licenses.SelectedItems)
                    {
                        if (item.Tag is BlueFlame.Classes.DatabaseObjects.License)
                        {
                            (item.Tag as BlueFlame.Classes.DatabaseObjects.License).Remove();
                        }
                    }
                }
                GetLicenseKeys(_product);
            }
        }

        private void rB_license_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_license.Checked == true)
            {
                gB_licenses.Enabled = true;
                GetLicenseKeys(_product);
                rB_fromProduct.Checked = false;
                gB_fromFile.Enabled = false;
            }
            else
            {
                rB_fromProduct.Checked = true;
                gB_fromFile.Enabled = true;

                if(_licenseProvider != null )
                    GetLicenseKeys(_licenseProvider);
            }
        }

        private void rB_fromProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_fromProduct.Checked == true)
            {
                gB_fromFile.Enabled = true;

                gB_licenses.Enabled = false;
                rB_license.Checked = false;
            }
            else
            {
                gB_licenses.Enabled = true;
                rB_license.Checked = true;
            }
        }

        private void b_choose_Click(object sender, EventArgs e)
        {
            ProductPickerForm picker = new ProductPickerForm();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                _licenseProvider = picker.Product;
                l_licenseFromFilename.Text = _licenseProvider.FileId;
                l_licenseFromProduct.Text = _licenseProvider.Name;
                l_licenseFromProductId.Text = _licenseProvider.ProductId;
                GetLicenseKeys(_licenseProvider);
            }
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (
                rB_fromProduct.Checked == true
                && _licenseProvider != null)
            {
                _product.LicenseFromFile = _licenseProvider.FileId;
                _product.LicenseFromProductId = _licenseProvider.ProductId;
                _product.Save();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                _product.LicenseFromFile = null;
                _product.LicenseFromProductId = null;
                _product.Save();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_licenseProvider != null)
            {
                EditLicense licenseEditor = new EditLicense(new Disc(_licenseProvider.FileId,
                    _licenseProvider.ProductId,
                    BlueFlame.Classes.MediaType.CompactDisc));
                licenseEditor.ShowDialog();
            }
            
        }
    }
}