namespace RedFlame.Forms
{
    partial class EditLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLicense));
            this.gB_licenses = new System.Windows.Forms.GroupBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.lV_licenses = new System.Windows.Forms.ListView();
            this.cH_key = new System.Windows.Forms.ColumnHeader();
            this.cH_multi = new System.Windows.Forms.ColumnHeader();
            this.cH_distributed = new System.Windows.Forms.ColumnHeader();
            this.cH_date = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iL_licenses = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_add = new System.Windows.Forms.ToolStripButton();
            this.tSB_editLicense = new System.Windows.Forms.ToolStripButton();
            this.tSB_removeLicense = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gB_fromFile = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_licenseFromFilename = new System.Windows.Forms.Label();
            this.l_licenseFromProduct = new System.Windows.Forms.Label();
            this.l_licenseFromProductId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.b_choose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_ok = new System.Windows.Forms.Button();
            this.rB_license = new System.Windows.Forms.RadioButton();
            this.rB_fromProduct = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_filename = new System.Windows.Forms.Label();
            this.l_product = new System.Windows.Forms.Label();
            this.l_productid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tSB_import = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gB_licenses.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gB_fromFile.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_licenses
            // 
            this.gB_licenses.Controls.Add(this.toolStripContainer1);
            this.gB_licenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_licenses.Location = new System.Drawing.Point(3, 159);
            this.gB_licenses.Name = "gB_licenses";
            this.gB_licenses.Size = new System.Drawing.Size(526, 231);
            this.gB_licenses.TabIndex = 0;
            this.gB_licenses.TabStop = false;
            this.gB_licenses.Text = "Licenses";
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lV_licenses);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(520, 165);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 16);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(520, 212);
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
            this.tSSL_count});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(520, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // tSSL_count
            // 
            this.tSSL_count.Name = "tSSL_count";
            this.tSSL_count.Size = new System.Drawing.Size(61, 17);
            this.tSSL_count.Text = "tSSL_count";
            // 
            // lV_licenses
            // 
            this.lV_licenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_key,
            this.cH_multi,
            this.cH_distributed,
            this.cH_date});
            this.lV_licenses.ContextMenuStrip = this.contextMenuStrip1;
            this.lV_licenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_licenses.FullRowSelect = true;
            this.lV_licenses.GridLines = true;
            this.lV_licenses.Location = new System.Drawing.Point(0, 0);
            this.lV_licenses.Name = "lV_licenses";
            this.lV_licenses.Size = new System.Drawing.Size(520, 165);
            this.lV_licenses.SmallImageList = this.iL_licenses;
            this.lV_licenses.TabIndex = 1;
            this.lV_licenses.UseCompatibleStateImageBehavior = false;
            this.lV_licenses.View = System.Windows.Forms.View.Details;
            // 
            // cH_key
            // 
            this.cH_key.Text = "Licensekey";
            this.cH_key.Width = 200;
            // 
            // cH_multi
            // 
            this.cH_multi.Text = "Multi";
            // 
            // cH_distributed
            // 
            this.cH_distributed.Text = "Distributed";
            this.cH_distributed.Width = 100;
            // 
            // cH_date
            // 
            this.cH_date.Text = "Date";
            this.cH_date.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLicenseToolStripMenuItem,
            this.editLicenseToolStripMenuItem,
            this.removeLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 70);
            // 
            // addLicenseToolStripMenuItem
            // 
            this.addLicenseToolStripMenuItem.Image = global::RedFlame.Properties.Resources.addLicense;
            this.addLicenseToolStripMenuItem.Name = "addLicenseToolStripMenuItem";
            this.addLicenseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addLicenseToolStripMenuItem.Text = "Add License";
            this.addLicenseToolStripMenuItem.Click += new System.EventHandler(this.tSB_add_Click);
            // 
            // editLicenseToolStripMenuItem
            // 
            this.editLicenseToolStripMenuItem.Image = global::RedFlame.Properties.Resources.editLicense;
            this.editLicenseToolStripMenuItem.Name = "editLicenseToolStripMenuItem";
            this.editLicenseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editLicenseToolStripMenuItem.Text = "Edit License";
            this.editLicenseToolStripMenuItem.Click += new System.EventHandler(this.tSB_editLicense_Click);
            // 
            // removeLicenseToolStripMenuItem
            // 
            this.removeLicenseToolStripMenuItem.Image = global::RedFlame.Properties.Resources.removeLicense;
            this.removeLicenseToolStripMenuItem.Name = "removeLicenseToolStripMenuItem";
            this.removeLicenseToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removeLicenseToolStripMenuItem.Text = "Remove License";
            this.removeLicenseToolStripMenuItem.Click += new System.EventHandler(this.tSB_removeLicense_Click);
            // 
            // iL_licenses
            // 
            this.iL_licenses.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_licenses.ImageStream")));
            this.iL_licenses.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_licenses.Images.SetKeyName(0, "productlicense");
            this.iL_licenses.Images.SetKeyName(1, "userlicense");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_add,
            this.tSB_editLicense,
            this.tSB_removeLicense,
            this.tSB_import});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(135, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tSB_add
            // 
            this.tSB_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_add.Image = global::RedFlame.Properties.Resources.addLicense;
            this.tSB_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_add.Name = "tSB_add";
            this.tSB_add.Size = new System.Drawing.Size(23, 22);
            this.tSB_add.Text = "Add License";
            this.tSB_add.Click += new System.EventHandler(this.tSB_add_Click);
            // 
            // tSB_editLicense
            // 
            this.tSB_editLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_editLicense.Image = global::RedFlame.Properties.Resources.editLicense;
            this.tSB_editLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_editLicense.Name = "tSB_editLicense";
            this.tSB_editLicense.Size = new System.Drawing.Size(23, 22);
            this.tSB_editLicense.Text = "Edit License";
            this.tSB_editLicense.Click += new System.EventHandler(this.tSB_editLicense_Click);
            // 
            // tSB_removeLicense
            // 
            this.tSB_removeLicense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_removeLicense.Image = global::RedFlame.Properties.Resources.removeLicense;
            this.tSB_removeLicense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_removeLicense.Name = "tSB_removeLicense";
            this.tSB_removeLicense.Size = new System.Drawing.Size(23, 22);
            this.tSB_removeLicense.Text = "Remove License";
            this.tSB_removeLicense.Click += new System.EventHandler(this.tSB_removeLicense_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gB_licenses, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gB_fromFile, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rB_license, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rB_fromProduct, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 583);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gB_fromFile
            // 
            this.gB_fromFile.Controls.Add(this.tableLayoutPanel3);
            this.gB_fromFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_fromFile.Enabled = false;
            this.gB_fromFile.Location = new System.Drawing.Point(3, 427);
            this.gB_fromFile.Name = "gB_fromFile";
            this.gB_fromFile.Size = new System.Drawing.Size(526, 113);
            this.gB_fromFile.TabIndex = 1;
            this.gB_fromFile.TabStop = false;
            this.gB_fromFile.Text = "File Data";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.l_licenseFromFilename, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.l_licenseFromProduct, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.l_licenseFromProductId, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.b_choose, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(520, 94);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Filename:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product:";
            // 
            // l_licenseFromFilename
            // 
            this.l_licenseFromFilename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_licenseFromFilename.AutoSize = true;
            this.l_licenseFromFilename.Location = new System.Drawing.Point(103, 9);
            this.l_licenseFromFilename.Name = "l_licenseFromFilename";
            this.l_licenseFromFilename.Size = new System.Drawing.Size(113, 13);
            this.l_licenseFromFilename.TabIndex = 2;
            this.l_licenseFromFilename.Text = "l_licenseFromFilename";
            // 
            // l_licenseFromProduct
            // 
            this.l_licenseFromProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_licenseFromProduct.AutoSize = true;
            this.l_licenseFromProduct.Location = new System.Drawing.Point(103, 40);
            this.l_licenseFromProduct.Name = "l_licenseFromProduct";
            this.l_licenseFromProduct.Size = new System.Drawing.Size(108, 13);
            this.l_licenseFromProduct.TabIndex = 3;
            this.l_licenseFromProduct.Text = "l_licenseFromProduct";
            // 
            // l_licenseFromProductId
            // 
            this.l_licenseFromProductId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_licenseFromProductId.AutoSize = true;
            this.l_licenseFromProductId.Location = new System.Drawing.Point(103, 71);
            this.l_licenseFromProductId.Name = "l_licenseFromProductId";
            this.l_licenseFromProductId.Size = new System.Drawing.Size(117, 13);
            this.l_licenseFromProductId.TabIndex = 4;
            this.l_licenseFromProductId.Text = "l_licenseFromProductId";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Product Id:";
            // 
            // b_choose
            // 
            this.b_choose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_choose.Location = new System.Drawing.Point(423, 66);
            this.b_choose.Name = "b_choose";
            this.b_choose.Size = new System.Drawing.Size(75, 23);
            this.b_choose.TabIndex = 6;
            this.b_choose.Text = "Choose";
            this.b_choose.UseVisualStyleBackColor = true;
            this.b_choose.Click += new System.EventHandler(this.b_choose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_cancel);
            this.panel1.Controls.Add(this.b_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 34);
            this.panel1.TabIndex = 2;
            // 
            // b_cancel
            // 
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(361, 3);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 1;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(442, 3);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 0;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // rB_license
            // 
            this.rB_license.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rB_license.AutoSize = true;
            this.rB_license.Checked = true;
            this.rB_license.Location = new System.Drawing.Point(3, 132);
            this.rB_license.Name = "rB_license";
            this.rB_license.Size = new System.Drawing.Size(159, 17);
            this.rB_license.TabIndex = 3;
            this.rB_license.TabStop = true;
            this.rB_license.Text = "Manually specify license key";
            this.rB_license.UseVisualStyleBackColor = true;
            this.rB_license.CheckedChanged += new System.EventHandler(this.rB_license_CheckedChanged);
            // 
            // rB_fromProduct
            // 
            this.rB_fromProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rB_fromProduct.AutoSize = true;
            this.rB_fromProduct.Location = new System.Drawing.Point(3, 400);
            this.rB_fromProduct.Name = "rB_fromProduct";
            this.rB_fromProduct.Size = new System.Drawing.Size(152, 17);
            this.rB_fromProduct.TabIndex = 4;
            this.rB_fromProduct.Text = "Inherit license from product";
            this.rB_fromProduct.UseVisualStyleBackColor = true;
            this.rB_fromProduct.CheckedChanged += new System.EventHandler(this.rB_fromProduct_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Informations";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.l_filename, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.l_product, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.l_productid, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // l_filename
            // 
            this.l_filename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_filename.AutoSize = true;
            this.l_filename.Location = new System.Drawing.Point(103, 10);
            this.l_filename.Name = "l_filename";
            this.l_filename.Size = new System.Drawing.Size(54, 13);
            this.l_filename.TabIndex = 2;
            this.l_filename.Text = "l_filename";
            // 
            // l_product
            // 
            this.l_product.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_product.AutoSize = true;
            this.l_product.Location = new System.Drawing.Point(103, 43);
            this.l_product.Name = "l_product";
            this.l_product.Size = new System.Drawing.Size(51, 13);
            this.l_product.TabIndex = 3;
            this.l_product.Text = "l_product";
            // 
            // l_productid
            // 
            this.l_productid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_productid.AutoSize = true;
            this.l_productid.Location = new System.Drawing.Point(103, 76);
            this.l_productid.Name = "l_productid";
            this.l_productid.Size = new System.Drawing.Size(59, 13);
            this.l_productid.TabIndex = 4;
            this.l_productid.Text = "l_productid";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Id:";
            // 
            // tSB_import
            // 
            this.tSB_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_import.Image = global::RedFlame.Properties.Resources.license;
            this.tSB_import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_import.Name = "tSB_import";
            this.tSB_import.Size = new System.Drawing.Size(23, 22);
            this.tSB_import.Text = "Import";
            this.tSB_import.Click += new System.EventHandler(this.tSB_import_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditLicense
            // 
            this.AcceptButton = this.b_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(532, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLicense";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditLicense";
            this.Load += new System.EventHandler(this.EditLicense_Load);
            this.gB_licenses.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gB_fromFile.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_licenses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gB_fromFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.RadioButton rB_license;
        private System.Windows.Forms.RadioButton rB_fromProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_filename;
        private System.Windows.Forms.Label l_product;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_count;
        private System.Windows.Forms.ListView lV_licenses;
        private System.Windows.Forms.ColumnHeader cH_key;
        private System.Windows.Forms.ColumnHeader cH_multi;
        private System.Windows.Forms.ColumnHeader cH_distributed;
        private System.Windows.Forms.ColumnHeader cH_date;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_add;
        private System.Windows.Forms.ToolStripButton tSB_editLicense;
        private System.Windows.Forms.ToolStripButton tSB_removeLicense;
        private System.Windows.Forms.Label l_productid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList iL_licenses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLicenseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_licenseFromFilename;
        private System.Windows.Forms.Label l_licenseFromProduct;
        private System.Windows.Forms.Label l_licenseFromProductId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button b_choose;
        private System.Windows.Forms.ToolStripButton tSB_import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}