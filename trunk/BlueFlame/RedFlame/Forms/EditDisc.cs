using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BlueFlame.Classes;
using System.IO;
using MySql.Data.MySqlClient;
using BlueFlame.Classes.MySql;
using System.Diagnostics;
using BlueFlame.Classes.DatabaseObjects;

namespace RedFlame.Forms
{
    public partial class EditDisc : Form
    {
        private class ProductWrapper : IEquatable<ProductWrapper>, IComparable<ProductWrapper>
        {
            private int _index;
            public int Index
            {
                get { return _index; }
                set { _index = value; }
            }
	
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

            public ProductWrapper(int index, string product, string description)
            {
                _index = index;
                _product = product;
                _description = description;
            }

            #region IEquatable<ProductWrapper> Member

            public bool Equals(ProductWrapper other)
            {
                return (_product == other.Product &&
                        _description == other.Description);
            }

            #endregion

            #region IComparable<ProductWrapper> Member

            public int CompareTo(ProductWrapper other)
            {
                if (_index > other.Index) return 1;
                else if (_index == other.Index) return 0;
                else return -1;
            }
            #endregion
        }

        private List<ProductWrapper> _products;

        private Disc _image;

        private string _filename;
        public string FileName
        {
            get { return _filename; }
        }

        public EditDisc()
        {
            _products = new List<ProductWrapper>();
            _image = null;
            _filename = "";
            
            InitializeComponent();
        }

        public EditDisc(Disc image)
        {
            _products = new List<ProductWrapper>();
            _image = image;
            _filename = "";
            InitializeComponent();
        }

        private void EditDisc_Load(object sender, EventArgs e)
        {
            if (_image != null)
            {
                using (MySqlDataReader reader = MainForm.MySql.Query
                    (Resources.SqlStrings.GetSingleFile,
                    new MySqlDataParameter("fileId", _image.FileId)))
                {
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("The specified file could not be found within the database.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        reader.Read();

                        _filename = reader["filename"].ToString();
                        tB_filename.Text = reader["filename"].ToString();
                        dTP_date.Value = DateTime.Parse(reader["date"].ToString());
                        cB_dvd.Checked = (bool)reader["dvdmedia"];

                        if (cB_language.Items.Contains(reader["lang"].ToString()))
                        {
                            cB_language.SelectedItem = reader["lang"].ToString();
                        }
                    }
                }

                using (MySqlDataReader reader = MainForm.MySql.Query(Resources.SqlStrings.GetProductsByFile,
                    new MySqlDataParameter("fileId", _image.FileId), 
                    new MySqlDataParameter("productId", _image.ProductId)))
                {
                    if (reader.HasRows)
                    { 
                        while(reader.Read())
                        {
                            _products.Add(
                                new ProductWrapper(int.Parse(reader["productid"].ToString()),
                                    reader["productname"].ToString(),
                                    reader["productdescription"].ToString()));
                        }
                    }
                }
            }

            PopulateForm();
        }      

        #region EventHandler
        #region AddProduct
        private void tSMI_add_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void tSB_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void AddProduct()
        {
            EditProduct editProductDialog = new EditProduct();
            if (editProductDialog.ShowDialog() == DialogResult.OK)
            {
                int index = _products.Count;
                _products.Add(new ProductWrapper(
                        _products.Count,
                        editProductDialog.Product, 
                        editProductDialog.Description));
                PopulateForm();
            }
        }
        #endregion
        #region EditProduct
        private void tSMI_edit_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void tSB_editProduct_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void lV_products_DoubleClick(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void EditProduct()
        {
            if (lV_products.SelectedItems.Count > 0)
            {
                if (lV_products.SelectedItems[0].Tag is ProductWrapper)
                { 
                    ProductWrapper product = (lV_products.SelectedItems[0].Tag as ProductWrapper);
                    EditProduct editProductDialog = new EditProduct(product.Product, product.Description);
                    if (editProductDialog.ShowDialog() == DialogResult.OK)
                    {
                        _products.Remove(product);

                        ProductWrapper newProduct = new ProductWrapper(
                            _products.Count, 
                            editProductDialog.Product,
                            editProductDialog.Description);
                        _products.Add(newProduct);
                        PopulateForm();
                    }
                }
            }
        }


        #endregion
        #region DeleteProduct
        private void tSMI_delete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void tSB_deleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void DeleteProduct()
        {
            if (lV_products.SelectedItems.Count > 0)
            {
                if (lV_products.SelectedItems[0].Tag is ProductWrapper)
                {
                    if (MessageBox.Show("Do you really want to delete the selected product?",
                        "o rly?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _products.Remove(lV_products.SelectedItems[0].Tag as ProductWrapper);
                        PopulateForm();
                    }
                }
            }
        }
        #endregion  
        #region Increase Index
        private void tSB_increaseIndex_Click(object sender, EventArgs e)
        {
            IncreaseIndex();
        }

        private void tSMI_increaseIndex_Click(object sender, EventArgs e)
        {
            IncreaseIndex();
        }

        private void IncreaseIndex()
        {
            if (lV_products.SelectedItems.Count > 0)
            {
                if (lV_products.SelectedItems[0].Tag is ProductWrapper)
                {
                    // get current position in the list
                    int currentIndex = _products.IndexOf(lV_products.SelectedItems[0].Tag as ProductWrapper);
                    
                    // if the item is on first position dont change anything
                    if (currentIndex != 0)
                    {
                        try
                        {
                            // item prior to the currently selected
                            if (_products[(currentIndex - 1)] != null)
                            {
                                int tempIndex = _products[(currentIndex - 1)].Index;
                                _products[(currentIndex - 1)].Index = _products[currentIndex].Index;
                                _products[currentIndex].Index = tempIndex;
                            }
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Debug.WriteLine(ex.ToString());
                            System.Diagnostics.Debug.WriteLine("False index access.");
                        }
                    }
                }
            }
            PopulateForm();
        }
        #endregion
        #region Decrease Index
        private void tSMI_decreaseIndex_Click(object sender, EventArgs e)
        {
            DecreaseIndex();
        }

        private void tSB_decreaseIndex_Click(object sender, EventArgs e)
        {
            DecreaseIndex();
        }

        private void DecreaseIndex()
        {
            if (lV_products.SelectedItems.Count > 0)
            {
                if (lV_products.SelectedItems[0].Tag is ProductWrapper)
                {
                    // get current position in the list
                    int currentIndex = _products.IndexOf(lV_products.SelectedItems[0].Tag as ProductWrapper);

                    // if the item is on last position dont change anything
                    if (currentIndex != (_products.Count - 1))
                    {
                        try
                        {
                            // item prior to the currently selected
                            if (_products[(currentIndex + 1)] != null)
                            {
                                int tempIndex = _products[(currentIndex + 1)].Index;
                                _products[(currentIndex + 1)].Index = _products[currentIndex].Index;
                                _products[currentIndex].Index = tempIndex;
                            }
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Debug.WriteLine(ex.ToString());
                            System.Diagnostics.Debug.WriteLine("False index access.");
                        }
                    }
                }
   
            }
            PopulateForm();
        }
        #endregion

        private void b_select_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                _filename = openFileDialog1.FileName;

            System.Diagnostics.Debug.WriteLine(_filename);
            PopulateForm();
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            ManuallySpecifyDiscForm manualDiscForm;
            if (!string.IsNullOrEmpty(tB_filename.Text))
                manualDiscForm = new ManuallySpecifyDiscForm(tB_filename.Text);
            else
                manualDiscForm = new ManuallySpecifyDiscForm();

            if (manualDiscForm.ShowDialog() == DialogResult.OK)
            {
                _filename = manualDiscForm.Filename;
            }
            PopulateForm();
        }

        #endregion

        /// <summary>
        /// Populates the data on the form
        /// </summary>
        private void PopulateForm()
        {
            ListViewItem selectedItem = null;
            if (lV_products.SelectedItems.Count > 0)
                selectedItem = lV_products.SelectedItems[0];

            l_fileStatus.Text = "No file selected.";
            pB_fileStatus.Image = iL_fileStatus.Images["unknown"];

            if (!string.IsNullOrEmpty(_filename))
            {
                tB_filename.Text = _filename;
                if (File.Exists(tB_filename.Text))
                {
                    pB_fileStatus.Image = iL_fileStatus.Images["exists"];
                    l_fileStatus.Text = "This is a valid file.";
                }
                else
                {
                    pB_fileStatus.Image = iL_fileStatus.Images["unknown"];
                    l_fileStatus.Text = "The specified file could not be found.";
                }
            }

            cB_language.SelectedIndex = 0;


            lV_products.Items.Clear();
            _products.Sort();
            SetIndices();
            foreach (ProductWrapper product in _products)
            {
                ListViewItem item = new ListViewItem(product.Index.ToString());
                item.SubItems.Add(product.Product);
                item.SubItems.Add(product.Description);
                item.Tag = product;
                lV_products.Items.Add(item);
            }
            tSSL_status.Text = _products.Count + " Products total";


            if (selectedItem != null)
            {
                selectedItem.EnsureVisible();
                selectedItem.Selected = true;
                lV_products.Focus();
                //lV_products.Select();
            }
        }

        private void SetIndices()
        {
            _products.Sort();
            for (int i = 0; i < _products.Count; i++)
            {
                _products[i].Index = (i + 1);
            }
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (_image == null)
            {               
                if(!CreateImage())
                {
                    MessageBox.Show("An error occured while trying to create a new image in the database.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // helper object 
                Disc disc = new Disc(_image.FileId, null, MediaType.CompactDisc);
                disc.Remove();
                CreateImage();
            }   
        }

        private bool CreateImage()
        {
            if (string.IsNullOrEmpty(tB_filename.Text)) return true;

            BlueFlame.Classes.DatabaseObjects.Image image = new BlueFlame.Classes.DatabaseObjects.Image();
            image.IsDvd = cB_dvd.Checked;
            image.Language = cB_language.Text;
            FileInfo info = null;
            try
            {
                 info = new FileInfo(_filename);
            }
            catch(Exception ex)
            {
                MessageBox.Show("The specified path has a bad format. ");
                return false;
            }
            if (info.Extension.StartsWith(".")) image.Extension = info.Extension.Remove(0, 1);

            image.FileName = info.Name.Remove(((info.Name.Length) - info.Extension.Length), info.Extension.Length);
            image.Path = info.FullName.Replace(info.Name, "");
            image.Date = dTP_date.Value.Year + "-" + dTP_date.Value.Month;
            if (image.Create())
            {
                if (lV_products.Items.Count == 0)
                {
                    Product product = new Product();
                    product.FileId = image.FileName;
                    product.ProductId = "1";
                    product.Name = image.FileName;
                    product.Description = "";
                    product.Create();
                }
                else
                {
                    foreach (ListViewItem item in lV_products.Items)
                    {
                        if (item.Tag is ProductWrapper)
                        {
                            ProductWrapper productInfo = (item.Tag as ProductWrapper);
                            Product product = new Product();
                            product.FileId = image.FileName;
                            product.ProductId = productInfo.Index.ToString();
                            product.Description = productInfo.Description;
                            product.Name = productInfo.Product;
                            product.Create();
                        }
                    }
                }
                this.DialogResult = DialogResult.OK;
                return true;
            }
            else return false;
        }
    } // endclass
} // endns