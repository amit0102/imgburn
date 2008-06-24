using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using BlueFlame.Classes;
using BlueFlame.Classes.MySql;
using BlueFlame.Classes.UserControls;
using BlueFlame.Classes.DatabaseObjects;
using RedFlame.Properties;

namespace RedFlame.Forms
{
    public partial class MainForm : Form
    {
        private Settings _settings;

        private static MySqlWrapper _mysql;
        public static MySqlWrapper MySql
        {
            get { return _mysql; }
            set { _mysql = value; }
        }

        private ListViewColumnStatus _productColumnStatus;
        private ListViewColumnStatus _licenseUserColumnStatus;
        private ListViewColumnStatus _licenseProductColumnStatus;
        private ListViewColumnStatus _licenseDetailsUserColumnStatus;
        private ListViewColumnStatus _licenseDetailsProductColumnStatus;

        private ListView lV_searchResult;
        private SearchCriterion _searchCriterion;
        private List<SearchItem> _searchKeywords;

        private Configuration _config;

        private bool _showAll;

        #region Form Events
        public MainForm()
        {
            InitializeComponent();   
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitForm();
            LoadConfig();
            PopulateForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settings.tS_searchPosition = tS_search.Location;
            _settings.tS_licensePosition = tS_license.Location;
            _settings.ShowAllChecked = tSB_showAll.Checked;
            _settings.Save();
        }
        #endregion

        #region Display Logic
        /// <summary>
        /// Populates the list view item for the currently selected page
        /// </summary>
        private void tC_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateForm();
        }

        private void PopulateForm()
        {
            if (tC_main.SelectedTab == tC_main.TabPages["tP_licenseUser"])
            {
                tS_license.Visible = true;
                _searchCriterion = SearchCriterion.UserWithLicense;
                PopulateUserLicenseListView();
            }
            else if (tC_main.SelectedTab == tC_main.TabPages["tP_licenseProduct"])
            {
                tS_license.Visible = true;
                _searchCriterion = SearchCriterion.ProductWithLicense;
                PopulateProductLicenseListView();
            }
            else
            {
                tS_license.Visible = false;
                _searchCriterion = SearchCriterion.Product;
                PopulateProductListView();
            }
        }

        private void PopulateUserLicenseListView()
        {
            string sqlQuery = "";
            if (_showAll) sqlQuery = Resources.SqlStrings.GetAllUsers;
            else sqlQuery = Resources.SqlStrings.GetFilteredUsers;
            using (MySqlDataReader reader = MySql.Query(sqlQuery))
            {
                if (reader.HasRows)
                {
                    lV_licenseUser.Items.Clear();
                    while (reader.Read())
                    {
                        // user domain displayname
                        ListViewItem item = new ListViewItem(reader["user"].ToString());
                        item.SubItems.Add(reader["domain"].ToString());
                        item.SubItems.Add(reader["displayname"].ToString());
                        item.ImageKey = "user";
                        item.Tag = new User(reader["user"].ToString(),
                            reader["domain"].ToString(),
                            reader["displayname"].ToString());
                        lV_licenseUser.Items.Add(item);
                    }
                }
                tSSL_count.Text = lV_licenseUser.Items.Count + " Users";
                tSSL_count2.Text = "";
            }
        }

        private void lV_licenseUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lV_licenseUser.SelectedItems.Count > 0)
            {
                if (lV_licenseUser.SelectedItems[0].Tag is User)
                {
                    lV_licenseDetailUser.Items.Clear();
                    User user = (lV_licenseUser.SelectedItems[0].Tag as User);
                    using (MySqlDataReader reader = MySql.Query(
                        Resources.SqlStrings.GetProductsByUser,
                        new MySqlDataParameter("user", user.UserId),
                        new MySqlDataParameter("domain", user.Domain)))
                    {
                        if (reader.HasRows)
                        {
                            
                            while (reader.Read())
                            {
                                // name id file lang key date
                                ListViewItem item = new ListViewItem(reader["productname"].ToString());
                                item.SubItems.Add(reader["productid"].ToString());
                                item.SubItems.Add(reader["file"].ToString());
                                item.SubItems.Add(reader["lang"].ToString());
                                item.SubItems.Add(reader["licensekey"].ToString());
                                item.SubItems.Add(reader["time"].ToString());

                                item.Tag = new BlueFlame.Classes.DatabaseObjects.License(reader["licensekey"].ToString(),
                                    false, false, null,
                                    null,
                                    new Product("","",
                                    reader["file"].ToString(),
                                    reader["productid"].ToString()));

                                item.ImageKey = "productlicense";
                                lV_licenseDetailUser.Items.Add(item);
                            }
                            tSSL_count2.Text = lV_licenseDetailUser.Items.Count + " Licenses";
                        }
                    }
                }
            }
        }

        private void PopulateProductLicenseListView()
        {
            string sqlQuery = "";
            if (_showAll)
                sqlQuery = Resources.SqlStrings.GetAllProducts;
            else sqlQuery = Resources.SqlStrings.GetFilteredProducts;

            using (MySqlDataReader reader = MySql.Query(sqlQuery))
            {
                if (reader.HasRows)
                {
                    lV_licenseProduct.Items.Clear();
                    while (reader.Read())
                    {
                        // ProductName id file lang
                        ListViewItem item = new ListViewItem(reader["productname"].ToString());
                        item.SubItems.Add(reader["productid"].ToString());
                        item.SubItems.Add(reader["file"].ToString());
                        item.SubItems.Add(reader["lang"].ToString());
                        
                        item.Tag = new Disc(
                            reader["file"].ToString(),
                            reader["productid"].ToString(),
                            MediaType.CompactDisc);

                        item.ImageKey = "product";


                        lV_licenseProduct.Items.Add(item);
                    }
                    tSSL_count.Text = lV_licenseProduct.Items.Count + " Products";
                }
            }
        }

        private bool PopulateProductListView()
        {
            if (_mysql == null) return false;
            tS_license.Visible = false;
            using (MySqlDataReader reader = _mysql.Query(Resources.SqlStrings.GetAllProducts))
            {
                if (reader.HasRows)
                {
                    lV_products.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["productname"].ToString());

                        string path = reader["path"].ToString();
                        string file = reader["file"].ToString();
                        string ext = reader["ext"].ToString();

                        string filename = path + @"\" + file + "." + ext;

                        

                        item.SubItems.Add(filename);
                        item.SubItems.Add(reader["lang"].ToString());
                        item.SubItems.Add(reader["date"].ToString());
                        item.SubItems.Add(reader["productdescription"].ToString());

                        bool isDvd = (bool)reader["dvdmedia"];
                        MediaType type = ((isDvd) ? MediaType.DigitalVersatileDisc : MediaType.CompactDisc);
                        Disc imageWrapper = new Disc(reader["file"].ToString(), reader["productid"].ToString(), filename, type);
                        item.Tag = imageWrapper;

                        if (type == MediaType.CompactDisc)
                            item.ImageKey = "default";
                        else item.ImageKey = "dvd";

                        lV_products.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("The products could not be retrieved. Please verify your database connection.");
                }
                tSSL_count.Text = lV_products.Items.Count + " Items found";
                tSSL_count2.Text = "";
            }
            return true;
        }

        #endregion

 

        #region Prerequesites

        private void InitForm()
        {
            _searchKeywords = new List<SearchItem>();
            _settings = new Settings();

            // Hide the license menu
            tS_license.Visible = false;

            // Restore last view
            tS_license.Location =
            tS_search.Location = _settings.tS_searchPosition;

            _showAll = _settings.ShowAllChecked;
            tSB_showAll.Checked = _showAll;

            _productColumnStatus = new ListViewColumnStatus();
            _licenseDetailsProductColumnStatus = new ListViewColumnStatus();
            _licenseDetailsUserColumnStatus = new ListViewColumnStatus();
            _licenseProductColumnStatus = new ListViewColumnStatus();
            _licenseUserColumnStatus = new ListViewColumnStatus();
        }

        /// <summary>
        /// Retrieves Configuration data and establishes a database connection
        /// </summary>
        private void LoadConfig()
        {
            _config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            if (!_config.ConnectionStrings.SectionInformation.IsProtected)
                _config.ConnectionStrings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");

            string conStr = _config.ConnectionStrings.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                _mysql = new MySqlWrapper(conStr);
                DatabaseContainer.MySql = _mysql;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                VerifyPreferences();
            }
        }

        /// <summary>
        /// If the database connection could not be established this method offers the user to 
        /// verify the configuration data
        /// </summary>
        private void VerifyPreferences()
        {
            if (MessageBox.Show(
                "The database connection could not be established. Please verify that the connection string is set up corretly. Would you like to edit the preferences now?",
                "Database connection errror",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EditPreferences preferencesDialog = new EditPreferences();
                if (preferencesDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadConfig();
                }
                else Application.Exit();
            }
            else Application.Exit();
        }
        #endregion
        
        #region AddDisc
        private void tSB_new_Click(object sender, EventArgs e)
        {
            NewDisc();
        }

        private void tSMI_new_Click(object sender, EventArgs e)
        {
            NewDisc();
        }

        private void addDiscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDisc();
        }

        private void NewDisc()
        {
            EditDisc editDialog = new EditDisc();
            editDialog.ShowDialog();
        }
        #endregion

        #region EditDisc
        private void tSB_edit_Click(object sender, EventArgs e)
        {
            EditDisc();
        }

        private void cTSMI_edit_Click(object sender, EventArgs e)
        {
            EditDisc();
        }

        private void tSMI_edit_Click(object sender, EventArgs e)
        {
            EditDisc();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            EditDisc();
        }

        private void EditDisc()
        {
            if (lV_products.SelectedItems.Count > 0)
            { 
                if(lV_products.SelectedItems[0].Tag is Disc)
                {
                    EditDisc editDiscDialog = new EditDisc(lV_products.SelectedItems[0].Tag as Disc);
                    editDiscDialog.ShowDialog();
                }
            }
            
        }
        #endregion

        #region RemoveDisc

        private void tSB_delete_Click(object sender, EventArgs e)
        {
            RemoveDisc();
        }

        private void tSMI_delete_Click(object sender, EventArgs e)
        {
            RemoveDisc();
        }

        private void cTSMI_delete_Click(object sender, EventArgs e)
        {
            RemoveDisc();
        }

        private void RemoveDisc()
        {
            if (lV_products.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Do you really want to remove this image and all of its products?",
                        "o rly?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lV_products.SelectedItems)
                    {
                        if (item.Tag is Disc)
                        {
                            Disc disc = item.Tag as Disc;
                            disc.Remove();
                        }
                    }
                }
            }
            PopulateProductListView();
        }

        #endregion

        #region Misc
        private void tSB_showAll_CheckedChanged(object sender, EventArgs e)
        {
            _showAll = tSB_showAll.Checked;
            PopulateForm();
        }

        private void tSMI_preferences_Click(object sender, EventArgs e)
        {
            EditPreferences preferencesDialog = new EditPreferences();
            preferencesDialog.ShowDialog();
            LoadConfig();
        }

        private void tSMI_startReadImageProgram_Click(object sender, EventArgs e)
        {
            string burnApplication = _config.AppSettings.Settings["BurnApplication"].Value;
            if (!string.IsNullOrEmpty(burnApplication) &&
                File.Exists(burnApplication))
            {
                Process.Start(burnApplication);
            }
            else
            {
                if (MessageBox.Show(
                    "There is no image reading application specified or the specified application could not be found. Would you like to edit the preferences now?",
                    "No application specified",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EditPreferences preferences = new EditPreferences();
                    preferences.ShowDialog();
                }
            }
        }
        #endregion

        private void lV_licenseProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lV_licenseProduct.SelectedItems.Count > 0)
            {
                if (lV_licenseProduct.SelectedItems[0].Tag is Disc)
                {
                    Cursor = Cursors.WaitCursor;
                    lV_licenseDetailProduct.Items.Clear();
                    Disc product = (lV_licenseProduct.SelectedItems[0].Tag as Disc);
                    using (MySqlDataReader reader = MySql.Query(
                        Resources.SqlStrings.GetLicensesByProduct,
                        new MySqlDataParameter("file", product.FileId),
                        new MySqlDataParameter("productid", product.ProductId)))
                    {
                        if (reader.HasRows)
                        {
                            int used = 0;
                            while (reader.Read())
                            {
                                // name id file lang key date
                                User user = null;
                                if(!string.IsNullOrEmpty(reader["user"].ToString()))
                                {
                                    user = new User(reader["user"].ToString(),
                                        reader["domain"].ToString(),"");
                                }

                                bool multi = (bool)reader["multi"];
                                bool distributed = (bool)reader["distributed"];
                                ListViewItem item = new ListViewItem(reader["user"].ToString());
                                item.SubItems.Add(reader["domain"].ToString());
                                item.SubItems.Add(reader["licensekey"].ToString().ToUpper());
                                item.SubItems.Add(reader["time"].ToString());
                                item.SubItems.Add(reader["multi"].ToString());
                                item.SubItems.Add(reader["distributed"].ToString());
                                item.Tag = new BlueFlame.Classes.DatabaseObjects.License(reader["licensekey"].ToString(),
                                    multi, 
                                    distributed,
                                    reader["time"].ToString(),
                                    user,
                                    new Product("","",product.FileId, product.ProductId));
                                    

                                if (user != null)
                                {
                                    item.ImageKey = "userlicense";
                                    used++;
                                }
                                else
                                {
                                    item.ImageKey = "productlicense";
                                }
                                lV_licenseDetailProduct.Items.Add(item);
                            }
                            int all = lV_licenseDetailProduct.Items.Count;
                            tSSL_count2.Text = all + " Licenses, " + used + " Used, " + (all - used) + " Unused";
                        }
                    }
                    Cursor = Cursors.Default;
                }
            }
        }

        private void tSMI_copyKey_Click(object sender, EventArgs e)
        {
            SelectControls(_searchCriterion);
            if (lV_searchResult.SelectedItems.Count > 0)
            {
                if (lV_searchResult.SelectedItems[0].Tag is BlueFlame.Classes.DatabaseObjects.License)
                {
                    string key = (lV_searchResult.SelectedItems[0].Tag as BlueFlame.Classes.DatabaseObjects.License).Key;
                    Clipboard.SetText(key);
                }
            }
        }
        
        #region Reorder Rows
        private void lV_products_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ReorderRows(sender, e, _licenseProductColumnStatus);
        }

        private void lV_licenseProduct_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ReorderRows(sender, e, _licenseProductColumnStatus);
        }

        private void lV_licenseDetailProduct_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ReorderRows(sender, e, _licenseDetailsProductColumnStatus);
        }

        private void lV_licenseUser_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ReorderRows(sender, e, _licenseUserColumnStatus);
        }

        private void lV_licenseDetailUser_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ReorderRows(sender, e, _licenseDetailsUserColumnStatus);
        }

        private void ReorderRows(object sender, ColumnClickEventArgs e, ListViewColumnStatus columnStatus)
        {
            if (!(sender is ListView)) return;
            (sender as ListView).ListViewItemSorter = 
                new ListViewItemSorter(e.Column, columnStatus.Reorder(e.Column));
        }
        #endregion

        #region Check License
        private void tSMI_checkLicense_Click(object sender, EventArgs e)
        {
            CheckLicense checkLicenseDialog = new CheckLicense();
            checkLicenseDialog.ShowDialog();
        }

        private void checkLicensekeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckLicense();
        }        

        private void lV_licenseDetailUser_DoubleClick(object sender, EventArgs e)
        {
            CheckLicense();
        }

        private void CheckLicense()
        {
            SelectControls(_searchCriterion);
            if (lV_searchResult.SelectedItems.Count > 0)
            {
                if (lV_searchResult.SelectedItems[0].Tag is BlueFlame.Classes.DatabaseObjects.License)
                {
                    string key = (lV_searchResult.SelectedItems[0].Tag as BlueFlame.Classes.DatabaseObjects.License).Key;
                    CheckLicense checkDialog = new CheckLicense(key);
                    checkDialog.ShowDialog();
                }
            }
        }

        private void lV_licenseDetailProduct_DoubleClick(object sender, EventArgs e)
        {
            CheckLicense();
        }
        #endregion

        #region Search
        /// <summary>
        /// Populates the main form filters the images in the database using the string specified in the search field.
        /// </summary>
        private void PerformSearch()
        {
            if (string.IsNullOrEmpty(tSICB_search.Text)) return;
            string keyword = tSICB_search.Text.ToLowerInvariant();
            SearchItem item = new SearchItem(keyword, _searchCriterion);
            if (!_searchKeywords.Contains(item))
            {
                _searchKeywords.Add(item);
                ImageComboBoxItem displayItem = new ImageComboBoxItem(keyword);
                string imageKey = "";
                switch (_searchCriterion)
                {
                    case SearchCriterion.Product: imageKey = "product"; break;
                    case SearchCriterion.ProductWithLicense: imageKey = "productwithlicense"; break;
                    case SearchCriterion.UserWithLicense: imageKey = "userwithlicense"; break;
                    case SearchCriterion.LicenseByProduct: imageKey = "licensebyuser"; break;
                    case SearchCriterion.LicenseByUser: imageKey = "licensebyproduct"; break;
                    default: imageKey = "product"; break;
                }
                displayItem.ImageKey = imageKey;
                tSICB_search.Items.Add(displayItem);
            }

            SelectControls(item.SearchCriterion);

            switch (_searchCriterion)
            {
                case SearchCriterion.Product:
                    SearchProduct();
                    break;
                case SearchCriterion.UserWithLicense:
                    SearchUserWithLicense();
                    break;
                case SearchCriterion.ProductWithLicense:
                    SearchProductWithLicense();
                    break;

                case SearchCriterion.LicenseByUser:
                    SearchLicenseByUser();
                    break;

                case SearchCriterion.LicenseByProduct:
                    SearchLicenseByProduct();
                    break;

                default:
                    SearchProduct();
                    break;
            }
        }

        private void SearchLicenseByProduct()
        {
            lV_searchResult.Items.Clear();

            using (MySqlDataReader reader = MySql.Query(Resources.SqlStrings.SearchLicenseByProduct,
                new MySqlDataParameter("keyword", "%" + tSICB_search.Text + "%")))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = null;
                        if (!string.IsNullOrEmpty(reader["user"].ToString()))
                        {
                            user = new User(reader["user"].ToString(),
                                reader["domain"].ToString(), "");
                        }

                        ListViewItem item = new ListViewItem(reader["user"].ToString());
                        item.SubItems.Add(reader["user"].ToString());
                        item.SubItems.Add(reader["licensekey"].ToString());
                        item.SubItems.Add(reader["insertdate"].ToString());
                        item.SubItems.Add(reader["multi"].ToString());
                        item.SubItems.Add(reader["distributed"].ToString());
                        if (user != null) item.ImageKey = "userlicense";
                        else item.ImageKey = "productlicense";

                        item.Tag = new BlueFlame.Classes.DatabaseObjects.License(reader["licensekey"].ToString(),
                            (int.Parse(reader["multi"].ToString()) == 1),
                            (int.Parse(reader["distributed"].ToString()) == 1),
                            reader["insertdate"].ToString(),
                            user,
                            null);

                        lV_searchResult.Items.Add(item);
                    }
                }
                tSSL_count.Text = lV_searchResult.Items.Count + " Items found";
            }
        }

        private void SearchLicenseByUser()
        {
            lV_searchResult.Items.Clear();
            using (MySqlDataReader reader = MySql.Query(Resources.SqlStrings.SearchLicenseByUser,
                new MySqlDataParameter("keyword", "%" + tSICB_search.Text + "%")))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Product product = new Product(
                            reader["productname"].ToString(),
                            "",
                            reader["file"].ToString(),
                            reader["productid"].ToString());

                        BlueFlame.Classes.DatabaseObjects.License license = new BlueFlame.Classes.DatabaseObjects.License(reader["licensekey"].ToString(),
                              (bool)reader["multi"],
                                (bool)reader["distributed"],
                            reader["insertdate"].ToString(),
                            null,
                            product);

                        ListViewItem item = new ListViewItem(product.Name);
                        item.SubItems.Add(product.ProductId);
                        item.SubItems.Add(product.FileId);
                        item.SubItems.Add(reader["lang"].ToString());
                        item.SubItems.Add(license.Key);
                        item.SubItems.Add(reader["insertdate"].ToString());
                        item.ImageKey = "productlicense";
                        item.Tag = license;
                        lV_searchResult.Items.Add(item);
                    }
                }
                tSSL_count.Text = lV_searchResult.Items.Count + " Items found";
            }
        }

        private void SelectControls(SearchCriterion searchCriterion)
        {
            System.Diagnostics.Debug.WriteLine("Switching: " + searchCriterion.ToString());
            switch (searchCriterion)
            {
                case SearchCriterion.Product:
                    tC_main.SelectedTab = tC_main.TabPages["tP_products"];
                    lV_searchResult = lV_products;
                    break;

                case SearchCriterion.ProductWithLicense:
                    tC_main.SelectedTab = tC_main.TabPages["tP_licenseProduct"];
                    lV_searchResult = lV_licenseProduct;
                    break;

                case SearchCriterion.LicenseByProduct:
                    tC_main.SelectedTab = tC_main.TabPages["tP_licenseProduct"];
                    lV_searchResult = lV_licenseDetailProduct;
                    break;

                case SearchCriterion.UserWithLicense:
                    tC_main.SelectedTab = tC_main.TabPages["tP_licenseUser"];
                    lV_searchResult = lV_licenseUser;
                    break;

                case SearchCriterion.LicenseByUser:
                    tC_main.SelectedTab = tC_main.TabPages["tP_licenseUser"];
                    lV_searchResult = lV_licenseDetailUser;
                    break;

                default:
                    tC_main.SelectedTab = tC_main.TabPages["tP_products"];
                    lV_searchResult = lV_products;
                    break;
            }
        }

        private void SearchProduct()
        {
            lV_searchResult.Items.Clear();

            // execute a reader wil the SQL string for this method's name
            using (MySqlDataReader reader = _mysql.Query(Resources.SqlStrings.SearchProduct,
                                                     new MySqlDataParameter("keyword", "%" + tSICB_search.Text + "%")))
            {

                // iterate the result set and fill the listview according to its layout
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["productname"].ToString());
                    item.SubItems.Add(reader["filename"].ToString());
                    item.SubItems.Add(reader["lang"].ToString());
                    item.SubItems.Add(reader["date"].ToString());


                    bool isDvd = (bool)reader["dvdmedia"];
                    MediaType type = ((isDvd) ? MediaType.DigitalVersatileDisc : MediaType.CompactDisc);
                    
                    Disc imageWrapper = new Disc(reader["file"].ToString(), reader["productid"].ToString(), reader["filename"].ToString(), type);

                    if(type== MediaType.CompactDisc)
                        item.ImageKey = "default";
                    else item.ImageKey = "dvd";

                    item.Tag = imageWrapper;
                    lV_searchResult.Items.Add(item);
                }
                tSSL_count.Text = lV_searchResult.Items.Count + " Items found";
            }
        }

        private void SearchProductWithLicense()
        {
            lV_searchResult.Items.Clear();

            // execute a reader wil the SQL string for this method's name
            using (MySqlDataReader reader = _mysql.Query(Resources.SqlStrings.SearchProduct,
                                                     new MySqlDataParameter("keyword", "%" + tSICB_search.Text + "%")))
            {

                // iterate the result set and fill the listview according to its layout
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["productname"].ToString());
                    item.SubItems.Add(reader["productid"].ToString());
                    item.SubItems.Add(reader["file"].ToString());
                    item.SubItems.Add(reader["lang"].ToString());
                    item.ImageKey = "product";


                    bool isDvd = (bool)reader["dvdmedia"];
                    MediaType type = ((isDvd) ? MediaType.DigitalVersatileDisc : MediaType.CompactDisc);
                    Disc imageWrapper = new Disc(reader["file"].ToString(), reader["productid"].ToString(), type);

                    item.Tag = imageWrapper;
                    lV_searchResult.Items.Add(item);
                }
                tSSL_count.Text = lV_searchResult.Items.Count + " Items found";
            }
        }

        private void SearchUserWithLicense()
        {
            lV_licenseUser.Items.Clear();
            using (MySqlDataReader reader =
                    _mysql.Query(Resources.SqlStrings.SearchUser,
                    new MySqlDataParameter("keyword", "%" + tSICB_search.Text + "%")))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["user"].ToString());
                        item.SubItems.Add(reader["domain"].ToString());
                        item.SubItems.Add(reader["displayname"].ToString());
                        item.ImageKey = "user";
                        item.Tag = new User(reader["user"].ToString(),
                            reader["domain"].ToString(),
                            reader["displayname"].ToString());
                        lV_licenseUser.Items.Add(item);
                    }
                }
                tSSL_count.Text = lV_licenseUser.Items.Count + " User Items found";
            }
        }

        private void lV_licenseDetailProduct_Enter(object sender, EventArgs e)
        {
            _searchCriterion = SearchCriterion.LicenseByProduct;
        }

        private void lV_licenseDetailUser_Enter(object sender, EventArgs e)
        {
            _searchCriterion = SearchCriterion.LicenseByUser;
        }

        private void lV_licenseProduct_Enter(object sender, EventArgs e)
        {
            _searchCriterion = SearchCriterion.ProductWithLicense;
        }

        private void lV_licenseUser_Enter(object sender, EventArgs e)
        {
            _searchCriterion = SearchCriterion.UserWithLicense;
        }

        private void tSB_search_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void tSB_clearSearch_Click(object sender, EventArgs e)
        {
            _searchKeywords.Clear();
            tSICB_search.Items.Clear();
            tSICB_search.Text = "";
            PopulateProductListView();
        }

        private void tSSB_search_ButtonClick(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void tSCB_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) PerformSearch();
        }

        private void tSCB_search_DropDown(object sender, EventArgs e)
        {
            object o = sender as ToolStripImageComboBox;
        }

        private void tSCB_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tSICB_search.SelectedItem is SearchItem)
                SelectControls((tSICB_search.SelectedItem as SearchItem).SearchCriterion);
            PerformSearch();
        }
        #endregion

        private void tSMI_editLicenseForProduct_Click(object sender, EventArgs e)
        {
            if (lV_products.SelectedItems.Count > 0)
            {
                if (lV_products.SelectedItems[0].Tag is Disc)
                {
                    EditLicense licenseDialog = new EditLicense(lV_products.SelectedItems[0].Tag as Disc);
                    licenseDialog.ShowDialog();
                }
            }
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lV_licenseProduct.SelectedItems.Count > 0)
            {
                if (lV_licenseProduct.SelectedItems[0].Tag is Disc)
                {
                    EditDisc editDisc = new EditDisc(lV_licenseProduct.SelectedItems[0].Tag as Disc);
                    editDisc.ShowDialog();
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lV_licenseProduct.SelectedItems.Count > 0)
            {
                if (lV_licenseProduct.SelectedItems[0].Tag is Disc)
                {
                    EditLicense editLicense = new EditLicense(lV_licenseProduct.SelectedItems[0].Tag as Disc);
                    editLicense.ShowDialog();
                }
            }
        }

        private void removeLicenseFromLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetLicense();
        }

        private void ResetLicense()
        {
            if (tC_main.SelectedTab == tC_main.TabPages["tP_licenseProduct"])
            {
                lV_searchResult = lV_licenseDetailProduct;
                if (lV_searchResult.SelectedItems[0].Tag is BlueFlame.Classes.DatabaseObjects.License)
                {
                    BlueFlame.Classes.DatabaseObjects.License license = lV_searchResult.SelectedItems[0].Tag as BlueFlame.Classes.DatabaseObjects.License;

                    MainForm.MySql.Statement(
                        Resources.SqlStrings.RemoveUserLicense,
                        new MySqlDataParameter("user", license.User.UserId),
                        new MySqlDataParameter("file", license.Product.FileId),
                        new MySqlDataParameter("productid", license.Product.ProductId));

                    license.Distributed = false;
                    license.Save();
                }
            }
            else
            {
                lV_searchResult = lV_licenseDetailUser;

                if (lV_licenseUser.SelectedItems.Count > 0)
                {
                    User user = lV_licenseUser.SelectedItems[0].Tag as User;
                    if (lV_searchResult.SelectedItems[0].Tag is BlueFlame.Classes.DatabaseObjects.License)
                    {
                        BlueFlame.Classes.DatabaseObjects.License license = lV_searchResult.SelectedItems[0].Tag as BlueFlame.Classes.DatabaseObjects.License;

                        MainForm.MySql.Statement(
                            Resources.SqlStrings.RemoveUserLicense,
                            new MySqlDataParameter("user", user.UserId),
                            new MySqlDataParameter("file", license.Product.FileId),
                            new MySqlDataParameter("productid", license.Product.ProductId));

                        license.Distributed = false;
                        license.Save();
                    }
                }
            }
            PopulateForm();
        }

        private void auditDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuditData auditDataDialog = new AuditData();
            auditDataDialog.Show();
        }
    } // endclass
} // endns
