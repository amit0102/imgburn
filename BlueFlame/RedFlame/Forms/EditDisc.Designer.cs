namespace RedFlame.Forms
{
    partial class EditDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDisc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.b_select = new System.Windows.Forms.Button();
            this.tB_filename = new System.Windows.Forms.TextBox();
            this.b_edit = new System.Windows.Forms.Button();
            this.pB_fileStatus = new System.Windows.Forms.PictureBox();
            this.l_fileStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTP_date = new System.Windows.Forms.DateTimePicker();
            this.cB_language = new System.Windows.Forms.ComboBox();
            this.cB_dvd = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.lV_products = new System.Windows.Forms.ListView();
            this.cH_order = new System.Windows.Forms.ColumnHeader();
            this.cH_product = new System.Windows.Forms.ColumnHeader();
            this.cH_desc = new System.Windows.Forms.ColumnHeader();
            this.cMS_products = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMI_add = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMI_increaseIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_decreaseIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_addProduct = new System.Windows.Forms.ToolStripButton();
            this.tSB_editProduct = new System.Windows.Forms.ToolStripButton();
            this.tSB_deleteProduct = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB_increaseIndex = new System.Windows.Forms.ToolStripButton();
            this.tSB_decreaseIndex = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_ok = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iL_fileStatus = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_fileStatus)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cMS_products.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.b_select, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tB_filename, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.b_edit, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.pB_fileStatus, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.l_fileStatus, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(534, 75);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // b_select
            // 
            this.b_select.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_select.Location = new System.Drawing.Point(437, 7);
            this.b_select.Name = "b_select";
            this.b_select.Size = new System.Drawing.Size(75, 23);
            this.b_select.TabIndex = 1;
            this.b_select.Text = "Select";
            this.b_select.UseVisualStyleBackColor = true;
            this.b_select.Click += new System.EventHandler(this.b_select_Click);
            // 
            // tB_filename
            // 
            this.tB_filename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_filename.Location = new System.Drawing.Point(103, 8);
            this.tB_filename.Name = "tB_filename";
            this.tB_filename.Size = new System.Drawing.Size(328, 20);
            this.tB_filename.TabIndex = 0;
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(437, 40);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(75, 23);
            this.b_edit.TabIndex = 2;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // pB_fileStatus
            // 
            this.pB_fileStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pB_fileStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pB_fileStatus.Location = new System.Drawing.Point(77, 46);
            this.pB_fileStatus.Name = "pB_fileStatus";
            this.pB_fileStatus.Size = new System.Drawing.Size(20, 20);
            this.pB_fileStatus.TabIndex = 4;
            this.pB_fileStatus.TabStop = false;
            // 
            // l_fileStatus
            // 
            this.l_fileStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_fileStatus.AutoSize = true;
            this.l_fileStatus.Location = new System.Drawing.Point(103, 49);
            this.l_fileStatus.Name = "l_fileStatus";
            this.l_fileStatus.Size = new System.Drawing.Size(58, 13);
            this.l_fileStatus.TabIndex = 3;
            this.l_fileStatus.Text = "l_fileStatus";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.68504F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.95275F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 547);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dTP_date, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cB_language, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cB_dvd, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 117);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Language:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date:";
            // 
            // dTP_date
            // 
            this.dTP_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dTP_date.CustomFormat = "MMMM yyyy";
            this.dTP_date.Location = new System.Drawing.Point(103, 47);
            this.dTP_date.Name = "dTP_date";
            this.dTP_date.Size = new System.Drawing.Size(200, 20);
            this.dTP_date.TabIndex = 1;
            // 
            // cB_language
            // 
            this.cB_language.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cB_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_language.FormattingEnabled = true;
            this.cB_language.Items.AddRange(new object[] {
            "Deutsch",
            "Englisch",
            "Deutsch / Englisch",
            "Multi Language"});
            this.cB_language.Location = new System.Drawing.Point(103, 8);
            this.cB_language.Name = "cB_language";
            this.cB_language.Size = new System.Drawing.Size(200, 21);
            this.cB_language.TabIndex = 0;
            // 
            // cB_dvd
            // 
            this.cB_dvd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cB_dvd.AutoSize = true;
            this.cB_dvd.Location = new System.Drawing.Point(103, 88);
            this.cB_dvd.Name = "cB_dvd";
            this.cB_dvd.Size = new System.Drawing.Size(226, 17);
            this.cB_dvd.TabIndex = 2;
            this.cB_dvd.Text = "The media is a Digital Versatile Disc (DVD)";
            this.cB_dvd.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.toolStripContainer1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 245);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 2);
            this.groupBox3.Size = new System.Drawing.Size(540, 260);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Products";
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lV_products);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(534, 194);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(534, 241);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            // 
            // tSSL_status
            // 
            this.tSSL_status.Name = "tSSL_status";
            this.tSSL_status.Size = new System.Drawing.Size(65, 17);
            this.tSSL_status.Text = "tSSL_status";
            // 
            // lV_products
            // 
            this.lV_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_order,
            this.cH_product,
            this.cH_desc});
            this.lV_products.ContextMenuStrip = this.cMS_products;
            this.lV_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_products.FullRowSelect = true;
            this.lV_products.GridLines = true;
            this.lV_products.Location = new System.Drawing.Point(0, 0);
            this.lV_products.MultiSelect = false;
            this.lV_products.Name = "lV_products";
            this.lV_products.Size = new System.Drawing.Size(534, 194);
            this.lV_products.TabIndex = 0;
            this.lV_products.UseCompatibleStateImageBehavior = false;
            this.lV_products.View = System.Windows.Forms.View.Details;
            this.lV_products.DoubleClick += new System.EventHandler(this.lV_products_DoubleClick);
            // 
            // cH_order
            // 
            this.cH_order.Text = "Id";
            this.cH_order.Width = 40;
            // 
            // cH_product
            // 
            this.cH_product.Text = "Product";
            this.cH_product.Width = 200;
            // 
            // cH_desc
            // 
            this.cH_desc.Text = "Description";
            this.cH_desc.Width = 200;
            // 
            // cMS_products
            // 
            this.cMS_products.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI_add,
            this.tSMI_edit,
            this.tSMI_delete,
            this.toolStripSeparator2,
            this.tSMI_increaseIndex,
            this.tSMI_decreaseIndex});
            this.cMS_products.Name = "cMS_products";
            this.cMS_products.Size = new System.Drawing.Size(220, 120);
            // 
            // tSMI_add
            // 
            this.tSMI_add.Image = global::RedFlame.Properties.Resources.addProduct;
            this.tSMI_add.Name = "tSMI_add";
            this.tSMI_add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tSMI_add.Size = new System.Drawing.Size(219, 22);
            this.tSMI_add.Text = "Add Product";
            this.tSMI_add.Click += new System.EventHandler(this.tSMI_add_Click);
            // 
            // tSMI_edit
            // 
            this.tSMI_edit.Image = global::RedFlame.Properties.Resources.editProduct;
            this.tSMI_edit.Name = "tSMI_edit";
            this.tSMI_edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tSMI_edit.Size = new System.Drawing.Size(219, 22);
            this.tSMI_edit.Text = "Edit Product";
            this.tSMI_edit.Click += new System.EventHandler(this.tSMI_edit_Click);
            // 
            // tSMI_delete
            // 
            this.tSMI_delete.Image = global::RedFlame.Properties.Resources.removeProduct;
            this.tSMI_delete.Name = "tSMI_delete";
            this.tSMI_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tSMI_delete.Size = new System.Drawing.Size(219, 22);
            this.tSMI_delete.Text = "Delete Product";
            this.tSMI_delete.Click += new System.EventHandler(this.tSMI_delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // tSMI_increaseIndex
            // 
            this.tSMI_increaseIndex.Image = global::RedFlame.Properties.Resources.arrowUp;
            this.tSMI_increaseIndex.Name = "tSMI_increaseIndex";
            this.tSMI_increaseIndex.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.tSMI_increaseIndex.Size = new System.Drawing.Size(219, 22);
            this.tSMI_increaseIndex.Text = "Increase Index";
            this.tSMI_increaseIndex.Click += new System.EventHandler(this.tSMI_increaseIndex_Click);
            // 
            // tSMI_decreaseIndex
            // 
            this.tSMI_decreaseIndex.Image = global::RedFlame.Properties.Resources.arrowDown;
            this.tSMI_decreaseIndex.Name = "tSMI_decreaseIndex";
            this.tSMI_decreaseIndex.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.tSMI_decreaseIndex.Size = new System.Drawing.Size(219, 22);
            this.tSMI_decreaseIndex.Text = "Decrease Index";
            this.tSMI_decreaseIndex.Click += new System.EventHandler(this.tSMI_decreaseIndex_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_addProduct,
            this.tSB_editProduct,
            this.tSB_deleteProduct,
            this.toolStripSeparator1,
            this.tSB_increaseIndex,
            this.tSB_decreaseIndex});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(133, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tSB_addProduct
            // 
            this.tSB_addProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_addProduct.Image = global::RedFlame.Properties.Resources.addProduct;
            this.tSB_addProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_addProduct.Name = "tSB_addProduct";
            this.tSB_addProduct.Size = new System.Drawing.Size(23, 22);
            this.tSB_addProduct.Text = "Add Product";
            this.tSB_addProduct.Click += new System.EventHandler(this.tSB_addProduct_Click);
            // 
            // tSB_editProduct
            // 
            this.tSB_editProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_editProduct.Image = global::RedFlame.Properties.Resources.editProduct;
            this.tSB_editProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_editProduct.Name = "tSB_editProduct";
            this.tSB_editProduct.Size = new System.Drawing.Size(23, 22);
            this.tSB_editProduct.Text = "Edit Product";
            this.tSB_editProduct.Click += new System.EventHandler(this.tSB_editProduct_Click);
            // 
            // tSB_deleteProduct
            // 
            this.tSB_deleteProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_deleteProduct.Image = global::RedFlame.Properties.Resources.removeProduct;
            this.tSB_deleteProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_deleteProduct.Name = "tSB_deleteProduct";
            this.tSB_deleteProduct.Size = new System.Drawing.Size(23, 22);
            this.tSB_deleteProduct.Text = "Delete Product";
            this.tSB_deleteProduct.Click += new System.EventHandler(this.tSB_deleteProduct_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSB_increaseIndex
            // 
            this.tSB_increaseIndex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_increaseIndex.Image = global::RedFlame.Properties.Resources.arrowUp;
            this.tSB_increaseIndex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_increaseIndex.Name = "tSB_increaseIndex";
            this.tSB_increaseIndex.Size = new System.Drawing.Size(23, 22);
            this.tSB_increaseIndex.Text = "Increase Index";
            this.tSB_increaseIndex.Click += new System.EventHandler(this.tSB_increaseIndex_Click);
            // 
            // tSB_decreaseIndex
            // 
            this.tSB_decreaseIndex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_decreaseIndex.Image = global::RedFlame.Properties.Resources.arrowDown;
            this.tSB_decreaseIndex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_decreaseIndex.Name = "tSB_decreaseIndex";
            this.tSB_decreaseIndex.Size = new System.Drawing.Size(23, 22);
            this.tSB_decreaseIndex.Text = "Decrease Index";
            this.tSB_decreaseIndex.Click += new System.EventHandler(this.tSB_decreaseIndex_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_cancel);
            this.panel1.Controls.Add(this.b_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(276, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 33);
            this.panel1.TabIndex = 3;
            // 
            // b_cancel
            // 
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(102, 7);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 1;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(183, 7);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 0;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Image";
            this.openFileDialog1.Filter = "Image Dateien (*.img;*.iso;*.nrg)|*.img;*.iso;*.nrg|Alle Dateien (*.*)|*.*";
            // 
            // iL_fileStatus
            // 
            this.iL_fileStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_fileStatus.ImageStream")));
            this.iL_fileStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_fileStatus.Images.SetKeyName(0, "unknown");
            this.iL_fileStatus.Images.SetKeyName(1, "exists");
            // 
            // EditDisc
            // 
            this.AcceptButton = this.b_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(546, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDisc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Disc";
            this.Load += new System.EventHandler(this.EditDisc_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_fileStatus)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cMS_products.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tB_filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_select;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTP_date;
        private System.Windows.Forms.ComboBox cB_language;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_addProduct;
        private System.Windows.Forms.ToolStripButton tSB_editProduct;
        private System.Windows.Forms.ToolStripButton tSB_deleteProduct;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_status;
        private System.Windows.Forms.ListView lV_products;
        private System.Windows.Forms.ColumnHeader cH_order;
        private System.Windows.Forms.ColumnHeader cH_product;
        private System.Windows.Forms.ColumnHeader cH_desc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSB_increaseIndex;
        private System.Windows.Forms.ToolStripButton tSB_decreaseIndex;
        private System.Windows.Forms.ContextMenuStrip cMS_products;
        private System.Windows.Forms.ToolStripMenuItem tSMI_add;
        private System.Windows.Forms.ToolStripMenuItem tSMI_edit;
        private System.Windows.Forms.ToolStripMenuItem tSMI_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tSMI_increaseIndex;
        private System.Windows.Forms.ToolStripMenuItem tSMI_decreaseIndex;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cB_dvd;
        private System.Windows.Forms.ImageList iL_fileStatus;
        private System.Windows.Forms.PictureBox pB_fileStatus;
        private System.Windows.Forms.Label l_fileStatus;
    }
}