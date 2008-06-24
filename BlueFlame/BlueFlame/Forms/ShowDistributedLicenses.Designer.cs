namespace BlueFlame.Forms
{
    partial class ShowDistributedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDistributedLicenses));
            this.listView1 = new System.Windows.Forms.ListView();
            this.cH_product = new System.Windows.Forms.ColumnHeader();
            this.cH_key = new System.Windows.Forms.ColumnHeader();
            this.cMS_copy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tSMI_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.b_close = new System.Windows.Forms.Button();
            this.lL_save = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cMS_copy.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AccessibleDescription = null;
            this.listView1.AccessibleName = null;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.BackgroundImage = null;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_product,
            this.cH_key});
            this.listView1.ContextMenuStrip = this.cMS_copy;
            this.listView1.Font = null;
            this.listView1.FullRowSelect = true;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cH_product
            // 
            resources.ApplyResources(this.cH_product, "cH_product");
            // 
            // cH_key
            // 
            resources.ApplyResources(this.cH_key, "cH_key");
            // 
            // cMS_copy
            // 
            this.cMS_copy.AccessibleDescription = null;
            this.cMS_copy.AccessibleName = null;
            resources.ApplyResources(this.cMS_copy, "cMS_copy");
            this.cMS_copy.BackgroundImage = null;
            this.cMS_copy.Font = null;
            this.cMS_copy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI_copy});
            this.cMS_copy.Name = "cMS_copy";
            // 
            // tSMI_copy
            // 
            this.tSMI_copy.AccessibleDescription = null;
            this.tSMI_copy.AccessibleName = null;
            resources.ApplyResources(this.tSMI_copy, "tSMI_copy");
            this.tSMI_copy.BackgroundImage = null;
            this.tSMI_copy.Name = "tSMI_copy";
            this.tSMI_copy.ShortcutKeyDisplayString = null;
            this.tSMI_copy.Click += new System.EventHandler(this.tSMI_copy_Click);
            // 
            // b_close
            // 
            this.b_close.AccessibleDescription = null;
            this.b_close.AccessibleName = null;
            resources.ApplyResources(this.b_close, "b_close");
            this.b_close.BackgroundImage = null;
            this.b_close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_close.Font = null;
            this.b_close.Name = "b_close";
            this.b_close.UseVisualStyleBackColor = true;
            // 
            // lL_save
            // 
            this.lL_save.AccessibleDescription = null;
            this.lL_save.AccessibleName = null;
            resources.ApplyResources(this.lL_save, "lL_save");
            this.lL_save.Font = null;
            this.lL_save.Name = "lL_save";
            this.lL_save.TabStop = true;
            this.lL_save.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lL_excel_LinkClicked);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.FileName = "lizenzen";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // ShowDistributedLicenses
            // 
            this.AcceptButton = this.b_close;
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.lL_save);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.listView1);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowDistributedLicenses";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ShowDistributedLicenses_Load);
            this.cMS_copy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.ColumnHeader cH_product;
        private System.Windows.Forms.ColumnHeader cH_key;
        private System.Windows.Forms.LinkLabel lL_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip cMS_copy;
        private System.Windows.Forms.ToolStripMenuItem tSMI_copy;
    }
}