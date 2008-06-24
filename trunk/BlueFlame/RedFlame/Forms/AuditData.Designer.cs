namespace RedFlame.Forms
{
    partial class AuditData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditData));
            this.lV_audit = new System.Windows.Forms.ListView();
            this.iL_icons = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSB_user = new System.Windows.Forms.ToolStripButton();
            this.tSB_license = new System.Windows.Forms.ToolStripButton();
            this.tSB_media = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB_clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB_close = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lV_audit
            // 
            this.lV_audit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lV_audit.FullRowSelect = true;
            this.lV_audit.GridLines = true;
            this.lV_audit.Location = new System.Drawing.Point(0, 0);
            this.lV_audit.Name = "lV_audit";
            this.lV_audit.Size = new System.Drawing.Size(864, 468);
            this.lV_audit.TabIndex = 2;
            this.lV_audit.UseCompatibleStateImageBehavior = false;
            this.lV_audit.View = System.Windows.Forms.View.Details;
            this.lV_audit.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lV_audit_ColumnClick);
            // 
            // iL_icons
            // 
            this.iL_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_icons.ImageStream")));
            this.iL_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_icons.Images.SetKeyName(0, "user");
            this.iL_icons.Images.SetKeyName(1, "license");
            this.iL_icons.Images.SetKeyName(2, "media");
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lV_audit);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(864, 468);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(864, 493);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_user,
            this.tSB_license,
            this.tSB_media,
            this.toolStripSeparator1,
            this.tSB_clear,
            this.toolStripSeparator2,
            this.tSB_close});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(317, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tSB_user
            // 
            this.tSB_user.Checked = true;
            this.tSB_user.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tSB_user.Image = global::RedFlame.Properties.Resources.user;
            this.tSB_user.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_user.Name = "tSB_user";
            this.tSB_user.Size = new System.Drawing.Size(50, 22);
            this.tSB_user.Text = "User";
            this.tSB_user.Click += new System.EventHandler(this.tSB_user_Click);
            // 
            // tSB_license
            // 
            this.tSB_license.Image = global::RedFlame.Properties.Resources.license;
            this.tSB_license.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_license.Name = "tSB_license";
            this.tSB_license.Size = new System.Drawing.Size(66, 22);
            this.tSB_license.Text = "License";
            this.tSB_license.Click += new System.EventHandler(this.tSB_license_Click);
            // 
            // tSB_media
            // 
            this.tSB_media.Image = global::RedFlame.Properties.Resources.disc;
            this.tSB_media.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_media.Name = "tSB_media";
            this.tSB_media.Size = new System.Drawing.Size(60, 22);
            this.tSB_media.Text = "Media";
            this.tSB_media.Click += new System.EventHandler(this.tSB_media_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSB_clear
            // 
            this.tSB_clear.Image = global::RedFlame.Properties.Resources.resetSearch;
            this.tSB_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_clear.Name = "tSB_clear";
            this.tSB_clear.Size = new System.Drawing.Size(77, 22);
            this.tSB_clear.Text = "Clear Log";
            this.tSB_clear.Click += new System.EventHandler(this.tSB_clear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tSB_close
            // 
            this.tSB_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSB_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_close.Name = "tSB_close";
            this.tSB_close.Size = new System.Drawing.Size(40, 22);
            this.tSB_close.Text = "Close";
            this.tSB_close.Click += new System.EventHandler(this.tSB_close_Click);
            // 
            // AuditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 493);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "AuditData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AuditData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AuditData_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lV_audit;
        private System.Windows.Forms.ImageList iL_icons;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_user;
        private System.Windows.Forms.ToolStripButton tSB_license;
        private System.Windows.Forms.ToolStripButton tSB_media;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tSB_clear;
        private System.Windows.Forms.ToolStripButton tSB_close;
    }
}