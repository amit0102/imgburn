namespace RedFlame.Forms
{
    partial class CheckLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckLicense));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_check = new System.Windows.Forms.Button();
            this.tB_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_ok = new System.Windows.Forms.Button();
            this.gB_foundProducts = new System.Windows.Forms.GroupBox();
            this.lV_products = new System.Windows.Forms.ListView();
            this.cH_product = new System.Windows.Forms.ColumnHeader();
            this.cH_productId = new System.Windows.Forms.ColumnHeader();
            this.cH_file = new System.Windows.Forms.ColumnHeader();
            this.cH_description = new System.Windows.Forms.ColumnHeader();
            this.iL_icons = new System.Windows.Forms.ImageList(this.components);
            this.gB_license = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cB_multi = new System.Windows.Forms.CheckBox();
            this.cB_distributed = new System.Windows.Forms.CheckBox();
            this.l_count = new System.Windows.Forms.Label();
            this.l_lastDistribution = new System.Windows.Forms.Label();
            this.l_insertDate = new System.Windows.Forms.Label();
            this.gB_user = new System.Windows.Forms.GroupBox();
            this.lV_user = new System.Windows.Forms.ListView();
            this.cH_user = new System.Windows.Forms.ColumnHeader();
            this.cH_display = new System.Windows.Forms.ColumnHeader();
            this.cH_domain = new System.Windows.Forms.ColumnHeader();
            this.cH_date = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gB_foundProducts.SuspendLayout();
            this.gB_license.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gB_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.b_check, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tB_key, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.gB_foundProducts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gB_license, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.20339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.79662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // b_check
            // 
            this.b_check.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_check.Location = new System.Drawing.Point(439, 8);
            this.b_check.Name = "b_check";
            this.b_check.Size = new System.Drawing.Size(75, 23);
            this.b_check.TabIndex = 1;
            this.b_check.Text = "Check";
            this.b_check.UseVisualStyleBackColor = true;
            this.b_check.Click += new System.EventHandler(this.b_check_Click);
            // 
            // tB_key
            // 
            this.tB_key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_key.Location = new System.Drawing.Point(103, 10);
            this.tB_key.Name = "tB_key";
            this.tB_key.Size = new System.Drawing.Size(330, 20);
            this.tB_key.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "License Key:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(439, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 35);
            this.panel1.TabIndex = 0;
            // 
            // b_ok
            // 
            this.b_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_ok.Location = new System.Drawing.Point(10, 3);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 0;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // gB_foundProducts
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gB_foundProducts, 3);
            this.gB_foundProducts.Controls.Add(this.lV_products);
            this.gB_foundProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_foundProducts.Location = new System.Drawing.Point(3, 43);
            this.gB_foundProducts.Name = "gB_foundProducts";
            this.gB_foundProducts.Size = new System.Drawing.Size(530, 116);
            this.gB_foundProducts.TabIndex = 2;
            this.gB_foundProducts.TabStop = false;
            this.gB_foundProducts.Text = "Licenses";
            // 
            // lV_products
            // 
            this.lV_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_product,
            this.cH_productId,
            this.cH_file,
            this.cH_description});
            this.lV_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_products.FullRowSelect = true;
            this.lV_products.GridLines = true;
            this.lV_products.Location = new System.Drawing.Point(3, 16);
            this.lV_products.Name = "lV_products";
            this.lV_products.Size = new System.Drawing.Size(524, 97);
            this.lV_products.SmallImageList = this.iL_icons;
            this.lV_products.TabIndex = 0;
            this.lV_products.UseCompatibleStateImageBehavior = false;
            this.lV_products.View = System.Windows.Forms.View.Details;
            this.lV_products.SelectedIndexChanged += new System.EventHandler(this.lV_products_SelectedIndexChanged);
            this.lV_products.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lV_products_ColumnClick);
            // 
            // cH_product
            // 
            this.cH_product.Text = "Product";
            this.cH_product.Width = 200;
            // 
            // cH_productId
            // 
            this.cH_productId.Text = "Id";
            this.cH_productId.Width = 30;
            // 
            // cH_file
            // 
            this.cH_file.Text = "Image File";
            this.cH_file.Width = 150;
            // 
            // cH_description
            // 
            this.cH_description.Text = "Description";
            this.cH_description.Width = 100;
            // 
            // iL_icons
            // 
            this.iL_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_icons.ImageStream")));
            this.iL_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_icons.Images.SetKeyName(0, "product");
            this.iL_icons.Images.SetKeyName(1, "user");
            // 
            // gB_license
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gB_license, 3);
            this.gB_license.Controls.Add(this.tableLayoutPanel3);
            this.gB_license.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_license.Location = new System.Drawing.Point(3, 165);
            this.gB_license.Name = "gB_license";
            this.gB_license.Size = new System.Drawing.Size(530, 250);
            this.gB_license.TabIndex = 7;
            this.gB_license.TabStop = false;
            this.gB_license.Text = "License";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.cB_multi, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cB_distributed, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.l_count, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.l_lastDistribution, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.l_insertDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.gB_user, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(524, 231);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Inserted:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last Distribution:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Count:";
            // 
            // cB_multi
            // 
            this.cB_multi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cB_multi.AutoSize = true;
            this.cB_multi.Location = new System.Drawing.Point(252, 6);
            this.cB_multi.Name = "cB_multi";
            this.cB_multi.Size = new System.Drawing.Size(88, 17);
            this.cB_multi.TabIndex = 3;
            this.cB_multi.Text = "Multi License";
            this.cB_multi.UseVisualStyleBackColor = true;
            // 
            // cB_distributed
            // 
            this.cB_distributed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cB_distributed.AutoSize = true;
            this.cB_distributed.Location = new System.Drawing.Point(252, 36);
            this.cB_distributed.Name = "cB_distributed";
            this.cB_distributed.Size = new System.Drawing.Size(76, 17);
            this.cB_distributed.TabIndex = 4;
            this.cB_distributed.Text = "Distributed";
            this.cB_distributed.UseVisualStyleBackColor = true;
            // 
            // l_count
            // 
            this.l_count.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_count.AutoSize = true;
            this.l_count.Location = new System.Drawing.Point(103, 68);
            this.l_count.Name = "l_count";
            this.l_count.Size = new System.Drawing.Size(42, 13);
            this.l_count.TabIndex = 5;
            this.l_count.Text = "l_count";
            // 
            // l_lastDistribution
            // 
            this.l_lastDistribution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_lastDistribution.AutoSize = true;
            this.l_lastDistribution.Location = new System.Drawing.Point(103, 38);
            this.l_lastDistribution.Name = "l_lastDistribution";
            this.l_lastDistribution.Size = new System.Drawing.Size(83, 13);
            this.l_lastDistribution.TabIndex = 6;
            this.l_lastDistribution.Text = "l_lastDistribution";
            // 
            // l_insertDate
            // 
            this.l_insertDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_insertDate.AutoSize = true;
            this.l_insertDate.Location = new System.Drawing.Point(103, 8);
            this.l_insertDate.Name = "l_insertDate";
            this.l_insertDate.Size = new System.Drawing.Size(63, 13);
            this.l_insertDate.TabIndex = 7;
            this.l_insertDate.Text = "l_insertDate";
            // 
            // gB_user
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.gB_user, 3);
            this.gB_user.Controls.Add(this.lV_user);
            this.gB_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_user.Location = new System.Drawing.Point(3, 93);
            this.gB_user.Name = "gB_user";
            this.gB_user.Size = new System.Drawing.Size(518, 135);
            this.gB_user.TabIndex = 0;
            this.gB_user.TabStop = false;
            this.gB_user.Text = "Assigned to User";
            // 
            // lV_user
            // 
            this.lV_user.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_user,
            this.cH_display,
            this.cH_domain,
            this.cH_date});
            this.lV_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_user.FullRowSelect = true;
            this.lV_user.GridLines = true;
            this.lV_user.Location = new System.Drawing.Point(3, 16);
            this.lV_user.Name = "lV_user";
            this.lV_user.Size = new System.Drawing.Size(512, 116);
            this.lV_user.SmallImageList = this.iL_icons;
            this.lV_user.TabIndex = 0;
            this.lV_user.UseCompatibleStateImageBehavior = false;
            this.lV_user.View = System.Windows.Forms.View.Details;
            this.lV_user.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lV_user_ColumnClick);
            // 
            // cH_user
            // 
            this.cH_user.Text = "User";
            this.cH_user.Width = 100;
            // 
            // cH_display
            // 
            this.cH_display.Text = "Display Name";
            this.cH_display.Width = 200;
            // 
            // cH_domain
            // 
            this.cH_domain.Text = "Domain";
            // 
            // cH_date
            // 
            this.cH_date.Text = "Date of Distribution";
            this.cH_date.Width = 120;
            // 
            // CheckLicense
            // 
            this.AcceptButton = this.b_check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckLicense";
            this.Load += new System.EventHandler(this.CheckLicense_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gB_foundProducts.ResumeLayout(false);
            this.gB_license.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gB_user.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_check;
        private System.Windows.Forms.TextBox tB_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB_foundProducts;
        private System.Windows.Forms.ListView lV_products;
        private System.Windows.Forms.GroupBox gB_license;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cB_multi;
        private System.Windows.Forms.CheckBox cB_distributed;
        private System.Windows.Forms.Label l_count;
        private System.Windows.Forms.Label l_lastDistribution;
        private System.Windows.Forms.Label l_insertDate;
        private System.Windows.Forms.GroupBox gB_user;
        private System.Windows.Forms.ListView lV_user;
        private System.Windows.Forms.ColumnHeader cH_product;
        private System.Windows.Forms.ColumnHeader cH_productId;
        private System.Windows.Forms.ColumnHeader cH_file;
        private System.Windows.Forms.ColumnHeader cH_user;
        private System.Windows.Forms.ColumnHeader cH_display;
        private System.Windows.Forms.ColumnHeader cH_domain;
        private System.Windows.Forms.ColumnHeader cH_date;
        private System.Windows.Forms.ColumnHeader cH_description;
        private System.Windows.Forms.ImageList iL_icons;
    }
}