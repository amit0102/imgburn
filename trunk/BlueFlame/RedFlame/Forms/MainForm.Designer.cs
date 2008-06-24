namespace RedFlame.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL_count2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tC_main = new System.Windows.Forms.TabControl();
            this.tP_products = new System.Windows.Forms.TabPage();
            this.lV_products = new System.Windows.Forms.ListView();
            this.cH_product = new System.Windows.Forms.ColumnHeader();
            this.cH_file = new System.Windows.Forms.ColumnHeader();
            this.cH_languages = new System.Windows.Forms.ColumnHeader();
            this.c_date = new System.Windows.Forms.ColumnHeader();
            this.ch_desc = new System.Windows.Forms.ColumnHeader();
            this.cMS_products = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cTSMI_new = new System.Windows.Forms.ToolStripMenuItem();
            this.cTSMI_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cTSMI_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMI_editLicenseForProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.iL_icons = new System.Windows.Forms.ImageList(this.components);
            this.tP_licenseProduct = new System.Windows.Forms.TabPage();
            this.sC_productLicenses = new System.Windows.Forms.SplitContainer();
            this.lV_licenseProduct = new System.Windows.Forms.ListView();
            this.cH_productName = new System.Windows.Forms.ColumnHeader();
            this.cH_productId = new System.Windows.Forms.ColumnHeader();
            this.cH_fileName = new System.Windows.Forms.ColumnHeader();
            this.cH_lang = new System.Windows.Forms.ColumnHeader();
            this.cMS_licenseProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lV_licenseDetailProduct = new System.Windows.Forms.ListView();
            this.cH_user_name = new System.Windows.Forms.ColumnHeader();
            this.cH_user_domain = new System.Windows.Forms.ColumnHeader();
            this.cH_user_key = new System.Windows.Forms.ColumnHeader();
            this.cH_time = new System.Windows.Forms.ColumnHeader();
            this.cH_user_multi = new System.Windows.Forms.ColumnHeader();
            this.cH_user_distributed = new System.Windows.Forms.ColumnHeader();
            this.cMS_license = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMI_copyKey = new System.Windows.Forms.ToolStripMenuItem();
            this.checkLicensekeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.removeLicenseFromLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tP_licenseUser = new System.Windows.Forms.TabPage();
            this.sC_userLicenses = new System.Windows.Forms.SplitContainer();
            this.lV_licenseUser = new System.Windows.Forms.ListView();
            this.cH_user = new System.Windows.Forms.ColumnHeader();
            this.cH_domain = new System.Windows.Forms.ColumnHeader();
            this.cH_displayname = new System.Windows.Forms.ColumnHeader();
            this.lV_licenseDetailUser = new System.Windows.Forms.ListView();
            this.cH_detailProduct = new System.Windows.Forms.ColumnHeader();
            this.cH_detailId = new System.Windows.Forms.ColumnHeader();
            this.cH_detailFile = new System.Windows.Forms.ColumnHeader();
            this.cH_detailLang = new System.Windows.Forms.ColumnHeader();
            this.cH_detailKey = new System.Windows.Forms.ColumnHeader();
            this.cH_detailDate = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMI_editLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMI_startReadImageProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMI_checkLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMI_preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.tS_products = new System.Windows.Forms.ToolStrip();
            this.tSB_new = new System.Windows.Forms.ToolStripButton();
            this.tSB_edit = new System.Windows.Forms.ToolStripButton();
            this.tSB_delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB_editLicense = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tS_search = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tSICB_search = new BlueFlame.Classes.UserControls.ToolStripImageComboBox();
            this.iL_search = new System.Windows.Forms.ImageList(this.components);
            this.tSB_search = new System.Windows.Forms.ToolStripButton();
            this.tSB_clearSearch = new System.Windows.Forms.ToolStripButton();
            this.tS_license = new System.Windows.Forms.ToolStrip();
            this.tSL_show = new System.Windows.Forms.ToolStripLabel();
            this.tSB_showAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tC_main.SuspendLayout();
            this.tP_products.SuspendLayout();
            this.cMS_products.SuspendLayout();
            this.tP_licenseProduct.SuspendLayout();
            this.sC_productLicenses.Panel1.SuspendLayout();
            this.sC_productLicenses.Panel2.SuspendLayout();
            this.sC_productLicenses.SuspendLayout();
            this.cMS_licenseProduct.SuspendLayout();
            this.cMS_license.SuspendLayout();
            this.tP_licenseUser.SuspendLayout();
            this.sC_userLicenses.Panel1.SuspendLayout();
            this.sC_userLicenses.Panel2.SuspendLayout();
            this.sC_userLicenses.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tS_products.SuspendLayout();
            this.tS_search.SuspendLayout();
            this.tS_license.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tC_main);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(838, 422);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(838, 518);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tS_products);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tS_license);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tS_search);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_count,
            this.tSSL_count2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // tSSL_count
            // 
            this.tSSL_count.Name = "tSSL_count";
            this.tSSL_count.Size = new System.Drawing.Size(61, 17);
            this.tSSL_count.Text = "tSSL_count";
            // 
            // tSSL_count2
            // 
            this.tSSL_count2.Name = "tSSL_count2";
            this.tSSL_count2.Size = new System.Drawing.Size(67, 17);
            this.tSSL_count2.Text = "tSSL_count2";
            // 
            // tC_main
            // 
            this.tC_main.Controls.Add(this.tP_products);
            this.tC_main.Controls.Add(this.tP_licenseProduct);
            this.tC_main.Controls.Add(this.tP_licenseUser);
            this.tC_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tC_main.ImageList = this.iL_icons;
            this.tC_main.Location = new System.Drawing.Point(0, 0);
            this.tC_main.Name = "tC_main";
            this.tC_main.SelectedIndex = 0;
            this.tC_main.Size = new System.Drawing.Size(838, 422);
            this.tC_main.TabIndex = 0;
            this.tC_main.SelectedIndexChanged += new System.EventHandler(this.tC_main_SelectedIndexChanged);
            // 
            // tP_products
            // 
            this.tP_products.Controls.Add(this.lV_products);
            this.tP_products.Location = new System.Drawing.Point(4, 23);
            this.tP_products.Name = "tP_products";
            this.tP_products.Padding = new System.Windows.Forms.Padding(3);
            this.tP_products.Size = new System.Drawing.Size(830, 395);
            this.tP_products.TabIndex = 0;
            this.tP_products.Text = "Products";
            this.tP_products.UseVisualStyleBackColor = true;
            // 
            // lV_products
            // 
            this.lV_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_product,
            this.cH_file,
            this.cH_languages,
            this.c_date,
            this.ch_desc});
            this.lV_products.ContextMenuStrip = this.cMS_products;
            this.lV_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_products.FullRowSelect = true;
            this.lV_products.GridLines = true;
            this.lV_products.Location = new System.Drawing.Point(3, 3);
            this.lV_products.Name = "lV_products";
            this.lV_products.Size = new System.Drawing.Size(824, 389);
            this.lV_products.SmallImageList = this.iL_icons;
            this.lV_products.TabIndex = 0;
            this.lV_products.UseCompatibleStateImageBehavior = false;
            this.lV_products.View = System.Windows.Forms.View.Details;
            this.lV_products.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.lV_products.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lV_products_ColumnClick);
            // 
            // cH_product
            // 
            this.cH_product.Text = "Product";
            this.cH_product.Width = 300;
            // 
            // cH_file
            // 
            this.cH_file.Text = "File";
            this.cH_file.Width = 300;
            // 
            // cH_languages
            // 
            this.cH_languages.Text = "Language";
            this.cH_languages.Width = 150;
            // 
            // c_date
            // 
            this.c_date.Text = "Date";
            this.c_date.Width = 100;
            // 
            // ch_desc
            // 
            this.ch_desc.Text = "Description";
            this.ch_desc.Width = 250;
            // 
            // cMS_products
            // 
            this.cMS_products.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cTSMI_new,
            this.cTSMI_edit,
            this.cTSMI_delete,
            this.toolStripSeparator10,
            this.tSMI_editLicenseForProduct});
            this.cMS_products.Name = "cMS_products";
            this.cMS_products.Size = new System.Drawing.Size(150, 98);
            // 
            // cTSMI_new
            // 
            this.cTSMI_new.Image = global::RedFlame.Properties.Resources.addDisc;
            this.cTSMI_new.Name = "cTSMI_new";
            this.cTSMI_new.Size = new System.Drawing.Size(149, 22);
            this.cTSMI_new.Text = "New Image";
            this.cTSMI_new.Click += new System.EventHandler(this.addDiscToolStripMenuItem_Click);
            // 
            // cTSMI_edit
            // 
            this.cTSMI_edit.Image = global::RedFlame.Properties.Resources.editDisc;
            this.cTSMI_edit.Name = "cTSMI_edit";
            this.cTSMI_edit.Size = new System.Drawing.Size(149, 22);
            this.cTSMI_edit.Text = "Edit Image";
            this.cTSMI_edit.Click += new System.EventHandler(this.cTSMI_edit_Click);
            // 
            // cTSMI_delete
            // 
            this.cTSMI_delete.Image = global::RedFlame.Properties.Resources.removeDisc;
            this.cTSMI_delete.Name = "cTSMI_delete";
            this.cTSMI_delete.Size = new System.Drawing.Size(149, 22);
            this.cTSMI_delete.Text = "Delete Image";
            this.cTSMI_delete.Click += new System.EventHandler(this.cTSMI_delete_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(146, 6);
            // 
            // tSMI_editLicenseForProduct
            // 
            this.tSMI_editLicenseForProduct.Image = global::RedFlame.Properties.Resources.editLicense;
            this.tSMI_editLicenseForProduct.Name = "tSMI_editLicenseForProduct";
            this.tSMI_editLicenseForProduct.Size = new System.Drawing.Size(149, 22);
            this.tSMI_editLicenseForProduct.Text = "Edit Licenses";
            this.tSMI_editLicenseForProduct.Click += new System.EventHandler(this.tSMI_editLicenseForProduct_Click);
            // 
            // iL_icons
            // 
            this.iL_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_icons.ImageStream")));
            this.iL_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_icons.Images.SetKeyName(0, "default");
            this.iL_icons.Images.SetKeyName(1, "user");
            this.iL_icons.Images.SetKeyName(2, "userlicense");
            this.iL_icons.Images.SetKeyName(3, "license");
            this.iL_icons.Images.SetKeyName(4, "product");
            this.iL_icons.Images.SetKeyName(5, "productlicense");
            this.iL_icons.Images.SetKeyName(6, "checklicense.ico");
            this.iL_icons.Images.SetKeyName(7, "dvd");
            this.iL_icons.Images.SetKeyName(8, "licensefromfile");
            // 
            // tP_licenseProduct
            // 
            this.tP_licenseProduct.Controls.Add(this.sC_productLicenses);
            this.tP_licenseProduct.Location = new System.Drawing.Point(4, 23);
            this.tP_licenseProduct.Name = "tP_licenseProduct";
            this.tP_licenseProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tP_licenseProduct.Size = new System.Drawing.Size(830, 395);
            this.tP_licenseProduct.TabIndex = 1;
            this.tP_licenseProduct.Text = "Licenses (Product)";
            this.tP_licenseProduct.UseVisualStyleBackColor = true;
            // 
            // sC_productLicenses
            // 
            this.sC_productLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sC_productLicenses.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sC_productLicenses.IsSplitterFixed = true;
            this.sC_productLicenses.Location = new System.Drawing.Point(3, 3);
            this.sC_productLicenses.Name = "sC_productLicenses";
            // 
            // sC_productLicenses.Panel1
            // 
            this.sC_productLicenses.Panel1.Controls.Add(this.lV_licenseProduct);
            // 
            // sC_productLicenses.Panel2
            // 
            this.sC_productLicenses.Panel2.Controls.Add(this.lV_licenseDetailProduct);
            this.sC_productLicenses.Panel2.Controls.Add(this.listView1);
            this.sC_productLicenses.Size = new System.Drawing.Size(824, 389);
            this.sC_productLicenses.SplitterDistance = 300;
            this.sC_productLicenses.TabIndex = 2;
            // 
            // lV_licenseProduct
            // 
            this.lV_licenseProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_productName,
            this.cH_productId,
            this.cH_fileName,
            this.cH_lang});
            this.lV_licenseProduct.ContextMenuStrip = this.cMS_licenseProduct;
            this.lV_licenseProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_licenseProduct.FullRowSelect = true;
            this.lV_licenseProduct.GridLines = true;
            this.lV_licenseProduct.HideSelection = false;
            this.lV_licenseProduct.Location = new System.Drawing.Point(0, 0);
            this.lV_licenseProduct.Name = "lV_licenseProduct";
            this.lV_licenseProduct.Size = new System.Drawing.Size(300, 389);
            this.lV_licenseProduct.SmallImageList = this.iL_icons;
            this.lV_licenseProduct.TabIndex = 1;
            this.lV_licenseProduct.UseCompatibleStateImageBehavior = false;
            this.lV_licenseProduct.View = System.Windows.Forms.View.Details;
            this.lV_licenseProduct.SelectedIndexChanged += new System.EventHandler(this.lV_licenseProduct_SelectedIndexChanged);
            this.lV_licenseProduct.Enter += new System.EventHandler(this.lV_licenseProduct_Enter);
            this.lV_licenseProduct.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lV_licenseProduct_ColumnClick);
            // 
            // cH_productName
            // 
            this.cH_productName.Text = "Product";
            this.cH_productName.Width = 140;
            // 
            // cH_productId
            // 
            this.cH_productId.Text = "Id";
            this.cH_productId.Width = 30;
            // 
            // cH_fileName
            // 
            this.cH_fileName.Text = "File";
            this.cH_fileName.Width = 70;
            // 
            // cH_lang
            // 
            this.cH_lang.Text = "Language";
            // 
            // cMS_licenseProduct
            // 
            this.cMS_licenseProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.editProductToolStripMenuItem});
            this.cMS_licenseProduct.Name = "cMS_licenses";
            this.cMS_licenseProduct.Size = new System.Drawing.Size(144, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::RedFlame.Properties.Resources.editLicense;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem2.Text = "Edit License";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Image = global::RedFlame.Properties.Resources.editProduct;
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // lV_licenseDetailProduct
            // 
            this.lV_licenseDetailProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_user_name,
            this.cH_user_domain,
            this.cH_user_key,
            this.cH_time,
            this.cH_user_multi,
            this.cH_user_distributed});
            this.lV_licenseDetailProduct.ContextMenuStrip = this.cMS_license;
            this.lV_licenseDetailProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_licenseDetailProduct.FullRowSelect = true;
            this.lV_licenseDetailProduct.GridLines = true;
            this.lV_licenseDetailProduct.Location = new System.Drawing.Point(0, 0);
            this.lV_licenseDetailProduct.Name = "lV_licenseDetailProduct";
            this.lV_licenseDetailProduct.Size = new System.Drawing.Size(520, 389);
            this.lV_licenseDetailProduct.SmallImageList = this.iL_icons;
            this.lV_licenseDetailProduct.TabIndex = 2;
            this.lV_licenseDetailProduct.UseCompatibleStateImageBehavior = false;
            this.lV_licenseDetailProduct.View = System.Windows.Forms.View.Details;
            this.lV_licenseDetailProduct.DoubleClick += new System.EventHandler(this.lV_licenseDetailProduct_DoubleClick);
            this.lV_licenseDetailProduct.Enter += new System.EventHandler(this.lV_licenseDetailProduct_Enter);
            this.lV_licenseDetailProduct.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lV_licenseDetailProduct_ColumnClick);
            // 
            // cH_user_name
            // 
            this.cH_user_name.Text = "User";
            this.cH_user_name.Width = 150;
            // 
            // cH_user_domain
            // 
            this.cH_user_domain.Text = "Domain";
            // 
            // cH_user_key
            // 
            this.cH_user_key.Text = "License Key";
            this.cH_user_key.Width = 200;
            // 
            // cH_time
            // 
            this.cH_time.Text = "Time";
            this.cH_time.Width = 150;
            // 
            // cH_user_multi
            // 
            this.cH_user_multi.Text = "Multi";
            // 
            // cH_user_distributed
            // 
            this.cH_user_distributed.Text = "Distributed";
            this.cH_user_distributed.Width = 70;
            // 
            // cMS_license
            // 
            this.cMS_license.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI_copyKey,
            this.checkLicensekeyToolStripMenuItem,
            this.toolStripSeparator3,
            this.removeLicenseFromLogToolStripMenuItem});
            this.cMS_license.Name = "cMS_licenses";
            this.cMS_license.Size = new System.Drawing.Size(170, 76);
            // 
            // tSMI_copyKey
            // 
            this.tSMI_copyKey.Image = global::RedFlame.Properties.Resources.copykey;
            this.tSMI_copyKey.Name = "tSMI_copyKey";
            this.tSMI_copyKey.Size = new System.Drawing.Size(169, 22);
            this.tSMI_copyKey.Text = "Copy Licensekey";
            this.tSMI_copyKey.Click += new System.EventHandler(this.tSMI_copyKey_Click);
            // 
            // checkLicensekeyToolStripMenuItem
            // 
            this.checkLicensekeyToolStripMenuItem.Image = global::RedFlame.Properties.Resources.checklicense;
            this.checkLicensekeyToolStripMenuItem.Name = "checkLicensekeyToolStripMenuItem";
            this.checkLicensekeyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.checkLicensekeyToolStripMenuItem.Text = "Check Licensekey";
            this.checkLicensekeyToolStripMenuItem.Click += new System.EventHandler(this.checkLicensekeyToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // removeLicenseFromLogToolStripMenuItem
            // 
            this.removeLicenseFromLogToolStripMenuItem.Image = global::RedFlame.Properties.Resources.removeLicense;
            this.removeLicenseFromLogToolStripMenuItem.Name = "removeLicenseFromLogToolStripMenuItem";
            this.removeLicenseFromLogToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.removeLicenseFromLogToolStripMenuItem.Text = "Reset License";
            this.removeLicenseFromLogToolStripMenuItem.Click += new System.EventHandler(this.removeLicenseFromLogToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 119);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tP_licenseUser
            // 
            this.tP_licenseUser.Controls.Add(this.sC_userLicenses);
            this.tP_licenseUser.Location = new System.Drawing.Point(4, 23);
            this.tP_licenseUser.Name = "tP_licenseUser";
            this.tP_licenseUser.Padding = new System.Windows.Forms.Padding(3);
            this.tP_licenseUser.Size = new System.Drawing.Size(830, 395);
            this.tP_licenseUser.TabIndex = 2;
            this.tP_licenseUser.Text = "Licenses (User)";
            this.tP_licenseUser.UseVisualStyleBackColor = true;
            // 
            // sC_userLicenses
            // 
            this.sC_userLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sC_userLicenses.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sC_userLicenses.IsSplitterFixed = true;
            this.sC_userLicenses.Location = new System.Drawing.Point(3, 3);
            this.sC_userLicenses.Name = "sC_userLicenses";
            // 
            // sC_userLicenses.Panel1
            // 
            this.sC_userLicenses.Panel1.Controls.Add(this.lV_licenseUser);
            // 
            // sC_userLicenses.Panel2
            // 
            this.sC_userLicenses.Panel2.Controls.Add(this.lV_licenseDetailUser);
            this.sC_userLicenses.Panel2.Controls.Add(this.listView2);
            this.sC_userLicenses.Size = new System.Drawing.Size(824, 389);
            this.sC_userLicenses.SplitterDistance = 300;
            this.sC_userLicenses.TabIndex = 1;
            // 
            // lV_licenseUser
            // 
            this.lV_licenseUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_user,
            this.cH_domain,
            this.cH_displayname});
            this.lV_licenseUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_licenseUser.FullRowSelect = true;
            this.lV_licenseUser.GridLines = true;
            this.lV_licenseUser.HideSelection = false;
            this.lV_licenseUser.Location = new System.Drawing.Point(0, 0);
            this.lV_licenseUser.Name = "lV_licenseUser";
            this.lV_licenseUser.Size = new System.Drawing.Size(300, 389);
            this.lV_licenseUser.SmallImageList = this.iL_icons;
            this.lV_licenseUser.TabIndex = 0;
            this.lV_licenseUser.UseCompatibleStateImageBehavior = false;
            this.lV_licenseUser.View = System.Windows.Forms.View.Details;
            this.lV_licenseUser.SelectedIndexChanged += new System.EventHandler(this.lV_licenseUser_SelectedIndexChanged);
            this.lV_licenseUser.Enter += new System.EventHandler(this.lV_licenseUser_Enter);
            this.lV_licenseUser.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lV_licenseUser_ColumnClick);
            // 
            // cH_user
            // 
            this.cH_user.Text = "UserId";
            this.cH_user.Width = 100;
            // 
            // cH_domain
            // 
            this.cH_domain.Text = "Domain";
            this.cH_domain.Width = 50;
            // 
            // cH_displayname
            // 
            this.cH_displayname.Text = "Displayname";
            this.cH_displayname.Width = 150;
            // 
            // lV_licenseDetailUser
            // 
            this.lV_licenseDetailUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_detailProduct,
            this.cH_detailId,
            this.cH_detailFile,
            this.cH_detailLang,
            this.cH_detailKey,
            this.cH_detailDate});
            this.lV_licenseDetailUser.ContextMenuStrip = this.cMS_license;
            this.lV_licenseDetailUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_licenseDetailUser.FullRowSelect = true;
            this.lV_licenseDetailUser.GridLines = true;
            this.lV_licenseDetailUser.Location = new System.Drawing.Point(0, 0);
            this.lV_licenseDetailUser.Name = "lV_licenseDetailUser";
            this.lV_licenseDetailUser.Size = new System.Drawing.Size(520, 389);
            this.lV_licenseDetailUser.SmallImageList = this.iL_icons;
            this.lV_licenseDetailUser.TabIndex = 0;
            this.lV_licenseDetailUser.UseCompatibleStateImageBehavior = false;
            this.lV_licenseDetailUser.View = System.Windows.Forms.View.Details;
            this.lV_licenseDetailUser.DoubleClick += new System.EventHandler(this.lV_licenseDetailUser_DoubleClick);
            this.lV_licenseDetailUser.Enter += new System.EventHandler(this.lV_licenseDetailUser_Enter);
            this.lV_licenseDetailUser.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lV_licenseDetailUser_ColumnClick);
            // 
            // cH_detailProduct
            // 
            this.cH_detailProduct.Text = "Product";
            this.cH_detailProduct.Width = 180;
            // 
            // cH_detailId
            // 
            this.cH_detailId.Text = "Id";
            this.cH_detailId.Width = 40;
            // 
            // cH_detailFile
            // 
            this.cH_detailFile.Text = "File";
            this.cH_detailFile.Width = 180;
            // 
            // cH_detailLang
            // 
            this.cH_detailLang.Text = "Language";
            this.cH_detailLang.Width = 100;
            // 
            // cH_detailKey
            // 
            this.cH_detailKey.Text = "License Key";
            this.cH_detailKey.Width = 220;
            // 
            // cH_detailDate
            // 
            this.cH_detailDate.Text = "Date";
            this.cH_detailDate.Width = 120;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(520, 389);
            this.listView2.SmallImageList = this.iL_icons;
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.extrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.dateiToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI_new,
            this.tSMI_edit,
            this.tSMI_delete,
            this.toolStripSeparator9,
            this.tSMI_editLicense,
            this.toolStripSeparator6,
            this.tSMI_startReadImageProgram,
            this.toolStripSeparator2,
            this.checkFilesToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.bearbeitenToolStripMenuItem.Text = "Edit";
            // 
            // tSMI_new
            // 
            this.tSMI_new.Image = global::RedFlame.Properties.Resources.addDisc;
            this.tSMI_new.Name = "tSMI_new";
            this.tSMI_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tSMI_new.Size = new System.Drawing.Size(181, 22);
            this.tSMI_new.Text = "New Image";
            this.tSMI_new.Click += new System.EventHandler(this.tSMI_new_Click);
            // 
            // tSMI_edit
            // 
            this.tSMI_edit.Image = global::RedFlame.Properties.Resources.editDisc;
            this.tSMI_edit.Name = "tSMI_edit";
            this.tSMI_edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tSMI_edit.Size = new System.Drawing.Size(181, 22);
            this.tSMI_edit.Text = "Edit Image";
            this.tSMI_edit.Click += new System.EventHandler(this.tSMI_edit_Click);
            // 
            // tSMI_delete
            // 
            this.tSMI_delete.Image = global::RedFlame.Properties.Resources.removeDisc;
            this.tSMI_delete.Name = "tSMI_delete";
            this.tSMI_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tSMI_delete.Size = new System.Drawing.Size(181, 22);
            this.tSMI_delete.Text = "Delete Image";
            this.tSMI_delete.Click += new System.EventHandler(this.tSMI_delete_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(178, 6);
            // 
            // tSMI_editLicense
            // 
            this.tSMI_editLicense.Image = global::RedFlame.Properties.Resources.editLicense;
            this.tSMI_editLicense.Name = "tSMI_editLicense";
            this.tSMI_editLicense.Size = new System.Drawing.Size(181, 22);
            this.tSMI_editLicense.Text = "Edit License";
            this.tSMI_editLicense.Click += new System.EventHandler(this.tSMI_editLicenseForProduct_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(178, 6);
            // 
            // tSMI_startReadImageProgram
            // 
            this.tSMI_startReadImageProgram.Name = "tSMI_startReadImageProgram";
            this.tSMI_startReadImageProgram.Size = new System.Drawing.Size(181, 22);
            this.tSMI_startReadImageProgram.Text = "Read Image";
            this.tSMI_startReadImageProgram.Click += new System.EventHandler(this.tSMI_startReadImageProgram_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // checkFilesToolStripMenuItem
            // 
            this.checkFilesToolStripMenuItem.Name = "checkFilesToolStripMenuItem";
            this.checkFilesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.checkFilesToolStripMenuItem.Text = "Check Files";
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.tSMI_checkLicense,
            this.toolStripSeparator5,
            this.tSMI_preferences});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // auditDataToolStripMenuItem
            // 
            this.auditDataToolStripMenuItem.Name = "auditDataToolStripMenuItem";
            this.auditDataToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.auditDataToolStripMenuItem.Text = "Audit Data Log";
            this.auditDataToolStripMenuItem.Click += new System.EventHandler(this.auditDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // tSMI_checkLicense
            // 
            this.tSMI_checkLicense.Image = global::RedFlame.Properties.Resources.license;
            this.tSMI_checkLicense.Name = "tSMI_checkLicense";
            this.tSMI_checkLicense.Size = new System.Drawing.Size(173, 22);
            this.tSMI_checkLicense.Text = "Check License Key";
            this.tSMI_checkLicense.Click += new System.EventHandler(this.tSMI_checkLicense_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(170, 6);
            // 
            // tSMI_preferences
            // 
            this.tSMI_preferences.Image = global::RedFlame.Properties.Resources.gear;
            this.tSMI_preferences.Name = "tSMI_preferences";
            this.tSMI_preferences.Size = new System.Drawing.Size(173, 22);
            this.tSMI_preferences.Text = "Preferences";
            this.tSMI_preferences.Click += new System.EventHandler(this.tSMI_preferences_Click);
            // 
            // tS_products
            // 
            this.tS_products.Dock = System.Windows.Forms.DockStyle.None;
            this.tS_products.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_new,
            this.tSB_edit,
            this.tSB_delete,
            this.toolStripSeparator4,
            this.tSB_editLicense,
            this.toolStripSeparator11});
            this.tS_products.Location = new System.Drawing.Point(3, 24);
            this.tS_products.Name = "tS_products";
            this.tS_products.Size = new System.Drawing.Size(116, 25);
            this.tS_products.TabIndex = 1;
            // 
            // tSB_new
            // 
            this.tSB_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_new.Image = global::RedFlame.Properties.Resources.addDisc;
            this.tSB_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_new.Name = "tSB_new";
            this.tSB_new.Size = new System.Drawing.Size(23, 22);
            this.tSB_new.Text = "New";
            this.tSB_new.Click += new System.EventHandler(this.tSB_new_Click);
            // 
            // tSB_edit
            // 
            this.tSB_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_edit.Image = global::RedFlame.Properties.Resources.editDisc;
            this.tSB_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_edit.Name = "tSB_edit";
            this.tSB_edit.Size = new System.Drawing.Size(23, 22);
            this.tSB_edit.Text = "Edit";
            this.tSB_edit.Click += new System.EventHandler(this.tSB_edit_Click);
            // 
            // tSB_delete
            // 
            this.tSB_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_delete.Image = global::RedFlame.Properties.Resources.removeDisc;
            this.tSB_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_delete.Name = "tSB_delete";
            this.tSB_delete.Size = new System.Drawing.Size(23, 22);
            this.tSB_delete.Text = "Delete";
            this.tSB_delete.Click += new System.EventHandler(this.tSB_delete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tSB_editLicense
            // 
            this.tSB_editLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_editLicense.Image = global::RedFlame.Properties.Resources.editLicense;
            this.tSB_editLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_editLicense.Name = "tSB_editLicense";
            this.tSB_editLicense.Size = new System.Drawing.Size(23, 22);
            this.tSB_editLicense.Text = "Edit License";
            this.tSB_editLicense.Click += new System.EventHandler(this.tSMI_editLicenseForProduct_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // tS_search
            // 
            this.tS_search.Dock = System.Windows.Forms.DockStyle.None;
            this.tS_search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tSICB_search,
            this.tSB_search,
            this.tSB_clearSearch});
            this.tS_search.Location = new System.Drawing.Point(3, 49);
            this.tS_search.Name = "tS_search";
            this.tS_search.Size = new System.Drawing.Size(234, 25);
            this.tS_search.TabIndex = 4;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel2.Text = "Keyword:";
            // 
            // tSICB_search
            // 
            this.tSICB_search.ImageList = this.iL_search;
            this.tSICB_search.Name = "tSICB_search";
            this.tSICB_search.Size = new System.Drawing.Size(121, 25);
            this.tSICB_search.SelectedIndexChanged += new System.EventHandler(this.tSCB_search_SelectedIndexChanged);
            this.tSICB_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tSCB_search_KeyDown);
            this.tSICB_search.DropDown += new System.EventHandler(this.tSCB_search_DropDown);
            // 
            // iL_search
            // 
            this.iL_search.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_search.ImageStream")));
            this.iL_search.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_search.Images.SetKeyName(0, "product");
            this.iL_search.Images.SetKeyName(1, "productwithlicense");
            this.iL_search.Images.SetKeyName(2, "userwithlicense");
            this.iL_search.Images.SetKeyName(3, "licensebyproduct");
            this.iL_search.Images.SetKeyName(4, "licensebyuser");
            // 
            // tSB_search
            // 
            this.tSB_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_search.Image = global::RedFlame.Properties.Resources.searchProduct;
            this.tSB_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_search.Name = "tSB_search";
            this.tSB_search.RightToLeftAutoMirrorImage = true;
            this.tSB_search.Size = new System.Drawing.Size(23, 22);
            this.tSB_search.Text = "Search";
            this.tSB_search.Click += new System.EventHandler(this.tSB_search_Click);
            // 
            // tSB_clearSearch
            // 
            this.tSB_clearSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_clearSearch.Image = global::RedFlame.Properties.Resources.resetSearch;
            this.tSB_clearSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_clearSearch.Name = "tSB_clearSearch";
            this.tSB_clearSearch.Size = new System.Drawing.Size(23, 22);
            this.tSB_clearSearch.Text = "Clear Search";
            this.tSB_clearSearch.Click += new System.EventHandler(this.tSB_clearSearch_Click);
            // 
            // tS_license
            // 
            this.tS_license.Dock = System.Windows.Forms.DockStyle.None;
            this.tS_license.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSL_show,
            this.tSB_showAll});
            this.tS_license.Location = new System.Drawing.Point(119, 24);
            this.tS_license.Name = "tS_license";
            this.tS_license.Size = new System.Drawing.Size(87, 25);
            this.tS_license.TabIndex = 3;
            // 
            // tSL_show
            // 
            this.tSL_show.Name = "tSL_show";
            this.tSL_show.Size = new System.Drawing.Size(37, 22);
            this.tSL_show.Text = "Show:";
            // 
            // tSB_showAll
            // 
            this.tSB_showAll.Checked = true;
            this.tSB_showAll.CheckOnClick = true;
            this.tSB_showAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tSB_showAll.Image = global::RedFlame.Properties.Resources.license;
            this.tSB_showAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_showAll.Name = "tSB_showAll";
            this.tSB_showAll.Size = new System.Drawing.Size(38, 22);
            this.tSB_showAll.Text = "All";
            this.tSB_showAll.ToolTipText = "Show All";
            this.tSB_showAll.CheckedChanged += new System.EventHandler(this.tSB_showAll_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 518);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tC_main.ResumeLayout(false);
            this.tP_products.ResumeLayout(false);
            this.cMS_products.ResumeLayout(false);
            this.tP_licenseProduct.ResumeLayout(false);
            this.sC_productLicenses.Panel1.ResumeLayout(false);
            this.sC_productLicenses.Panel2.ResumeLayout(false);
            this.sC_productLicenses.ResumeLayout(false);
            this.cMS_licenseProduct.ResumeLayout(false);
            this.cMS_license.ResumeLayout(false);
            this.tP_licenseUser.ResumeLayout(false);
            this.sC_userLicenses.Panel1.ResumeLayout(false);
            this.sC_userLicenses.Panel2.ResumeLayout(false);
            this.sC_userLicenses.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tS_products.ResumeLayout(false);
            this.tS_products.PerformLayout();
            this.tS_search.ResumeLayout(false);
            this.tS_search.PerformLayout();
            this.tS_license.ResumeLayout(false);
            this.tS_license.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tS_products;
        private System.Windows.Forms.ToolStripButton tSB_new;
        private System.Windows.Forms.TabControl tC_main;
        private System.Windows.Forms.TabPage tP_products;
        private System.Windows.Forms.TabPage tP_licenseProduct;
        private System.Windows.Forms.ListView lV_products;
        private System.Windows.Forms.ColumnHeader cH_product;
        private System.Windows.Forms.ColumnHeader cH_file;
        private System.Windows.Forms.ColumnHeader cH_languages;
        private System.Windows.Forms.ColumnHeader c_date;
        private System.Windows.Forms.ColumnHeader ch_desc;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSMI_new;
        private System.Windows.Forms.ToolStripMenuItem tSMI_startReadImageProgram;
        private System.Windows.Forms.ToolStripMenuItem checkFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tSMI_checkLicense;
        private System.Windows.Forms.ToolStripMenuItem tSMI_edit;
        private System.Windows.Forms.ToolStripMenuItem tSMI_delete;
        private System.Windows.Forms.ImageList iL_icons;
        private System.Windows.Forms.ToolStripButton tSB_edit;
        private System.Windows.Forms.ToolStripButton tSB_delete;
        private System.Windows.Forms.ContextMenuStrip cMS_products;
        private System.Windows.Forms.ToolStripMenuItem cTSMI_new;
        private System.Windows.Forms.ToolStripMenuItem cTSMI_edit;
        private System.Windows.Forms.ToolStripMenuItem cTSMI_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_count;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tSMI_preferences;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tSB_editLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tSMI_editLicense;
        private System.Windows.Forms.ContextMenuStrip cMS_license;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem tSMI_editLicenseForProduct;
        private System.Windows.Forms.ToolStrip tS_license;
        private System.Windows.Forms.ToolStripLabel tSL_show;
        private System.Windows.Forms.ToolStripButton tSB_showAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStrip tS_search;
        private BlueFlame.Classes.UserControls.ToolStripImageComboBox tSICB_search;
        private System.Windows.Forms.ToolStripButton tSB_search;
        private System.Windows.Forms.ToolStripButton tSB_clearSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TabPage tP_licenseUser;
        private System.Windows.Forms.SplitContainer sC_productLicenses;
        private System.Windows.Forms.ListView lV_licenseProduct;
        private System.Windows.Forms.ColumnHeader cH_productName;
        private System.Windows.Forms.ColumnHeader cH_productId;
        private System.Windows.Forms.ColumnHeader cH_fileName;
        private System.Windows.Forms.ColumnHeader cH_lang;
        private System.Windows.Forms.ListView lV_licenseDetailProduct;
        private System.Windows.Forms.ColumnHeader cH_user_name;
        private System.Windows.Forms.ColumnHeader cH_user_domain;
        private System.Windows.Forms.ColumnHeader cH_user_key;
        private System.Windows.Forms.ColumnHeader cH_user_multi;
        private System.Windows.Forms.ColumnHeader cH_user_distributed;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.SplitContainer sC_userLicenses;
        private System.Windows.Forms.ListView lV_licenseUser;
        private System.Windows.Forms.ColumnHeader cH_user;
        private System.Windows.Forms.ColumnHeader cH_domain;
        private System.Windows.Forms.ColumnHeader cH_displayname;
        private System.Windows.Forms.ListView lV_licenseDetailUser;
        private System.Windows.Forms.ColumnHeader cH_detailProduct;
        private System.Windows.Forms.ColumnHeader cH_detailId;
        private System.Windows.Forms.ColumnHeader cH_detailFile;
        private System.Windows.Forms.ColumnHeader cH_detailLang;
        private System.Windows.Forms.ColumnHeader cH_detailKey;
        private System.Windows.Forms.ColumnHeader cH_detailDate;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_count2;
        private System.Windows.Forms.ColumnHeader cH_time;
        private System.Windows.Forms.ImageList iL_search;
        private System.Windows.Forms.ContextMenuStrip cMS_licenseProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tSMI_copyKey;
        private System.Windows.Forms.ToolStripMenuItem checkLicensekeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem removeLicenseFromLogToolStripMenuItem;
    }
}