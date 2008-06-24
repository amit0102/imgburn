namespace BlueFlame
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cH_product = new System.Windows.Forms.ColumnHeader();
            this.cH_description = new System.Windows.Forms.ColumnHeader();
            this.cH_date = new System.Windows.Forms.ColumnHeader();
            this.cH_language = new System.Windows.Forms.ColumnHeader();
            this.iL_disc = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_burn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSMI_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_showalllicences = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMI_showlog = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSCB_search = new System.Windows.Forms.ToolStripComboBox();
            this.tSB_search = new System.Windows.Forms.ToolStripButton();
            this.tSB_reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSB_licenses = new System.Windows.Forms.ToolStripButton();
            this.tSB_burn = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.brennenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listView1);
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_product,
            this.cH_description,
            this.cH_date,
            this.cH_language});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.Name = "listView1";
            this.listView1.SmallImageList = this.iL_disc;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.tSMI_burn_Click);
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // cH_product
            // 
            resources.ApplyResources(this.cH_product, "cH_product");
            // 
            // cH_description
            // 
            resources.ApplyResources(this.cH_description, "cH_description");
            // 
            // cH_date
            // 
            resources.ApplyResources(this.cH_date, "cH_date");
            // 
            // cH_language
            // 
            resources.ApplyResources(this.cH_language, "cH_language");
            // 
            // iL_disc
            // 
            this.iL_disc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_disc.ImageStream")));
            this.iL_disc.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_disc.Images.SetKeyName(0, "cd");
            this.iL_disc.Images.SetKeyName(1, "dvd");
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI_burn,
            this.toolStripSeparator2,
            this.tSMI_quit});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            resources.ApplyResources(this.dateiToolStripMenuItem, "dateiToolStripMenuItem");
            // 
            // tSMI_burn
            // 
            this.tSMI_burn.Image = global::BlueFlame.Properties.Resources.burn;
            this.tSMI_burn.Name = "tSMI_burn";
            resources.ApplyResources(this.tSMI_burn, "tSMI_burn");
            this.tSMI_burn.Click += new System.EventHandler(this.tSMI_burn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tSMI_quit
            // 
            this.tSMI_quit.Name = "tSMI_quit";
            resources.ApplyResources(this.tSMI_quit, "tSMI_quit");
            this.tSMI_quit.Click += new System.EventHandler(this.tSMI_quit_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMI_showalllicences,
            this.tSMI_showlog});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            resources.ApplyResources(this.extrasToolStripMenuItem, "extrasToolStripMenuItem");
            // 
            // tSMI_showalllicences
            // 
            this.tSMI_showalllicences.Image = global::BlueFlame.Properties.Resources.licences;
            this.tSMI_showalllicences.Name = "tSMI_showalllicences";
            resources.ApplyResources(this.tSMI_showalllicences, "tSMI_showalllicences");
            this.tSMI_showalllicences.Click += new System.EventHandler(this.tSMI_showalllicences_Click);
            // 
            // tSMI_showlog
            // 
            this.tSMI_showlog.Name = "tSMI_showlog";
            resources.ApplyResources(this.tSMI_showlog, "tSMI_showlog");
            this.tSMI_showlog.Click += new System.EventHandler(this.tSMI_showlog_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            resources.ApplyResources(this.hilfeToolStripMenuItem, "hilfeToolStripMenuItem");
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCB_search,
            this.tSB_search,
            this.tSB_reset,
            this.toolStripSeparator1,
            this.tSB_licenses,
            this.tSB_burn});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tSCB_search
            // 
            this.tSCB_search.Name = "tSCB_search";
            resources.ApplyResources(this.tSCB_search, "tSCB_search");
            this.tSCB_search.SelectedIndexChanged += new System.EventHandler(this.tSCB_search_SelectedIndexChanged);
            this.tSCB_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tSCB_search_KeyDown);
            this.tSCB_search.Click += new System.EventHandler(this.tSCB_search_Click);
            // 
            // tSB_search
            // 
            this.tSB_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_search.Image = global::BlueFlame.Properties.Resources.adapter_details;
            resources.ApplyResources(this.tSB_search, "tSB_search");
            this.tSB_search.Name = "tSB_search";
            this.tSB_search.Click += new System.EventHandler(this.tSB_search_Click);
            // 
            // tSB_reset
            // 
            this.tSB_reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_reset.Image = global::BlueFlame.Properties.Resources.resetSearch;
            resources.ApplyResources(this.tSB_reset, "tSB_reset");
            this.tSB_reset.Name = "tSB_reset";
            this.tSB_reset.Click += new System.EventHandler(this.tSB_reset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tSB_licenses
            // 
            this.tSB_licenses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_licenses.Image = global::BlueFlame.Properties.Resources.licences;
            resources.ApplyResources(this.tSB_licenses, "tSB_licenses");
            this.tSB_licenses.Name = "tSB_licenses";
            this.tSB_licenses.Click += new System.EventHandler(this.tSMI_showalllicences_Click);
            // 
            // tSB_burn
            // 
            this.tSB_burn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSB_burn.Image = global::BlueFlame.Properties.Resources.burn;
            resources.ApplyResources(this.tSB_burn, "tSB_burn");
            this.tSB_burn.Name = "tSB_burn";
            this.tSB_burn.Click += new System.EventHandler(this.tSMI_burn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brennenToolStripMenuItem1,
            this.hinzufügenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // brennenToolStripMenuItem1
            // 
            this.brennenToolStripMenuItem1.Name = "brennenToolStripMenuItem1";
            resources.ApplyResources(this.brennenToolStripMenuItem1, "brennenToolStripMenuItem1");
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            resources.ApplyResources(this.hinzufügenToolStripMenuItem, "hinzufügenToolStripMenuItem");
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "nrg";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSMI_showalllicences;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem tSMI_showlog;
        private System.Windows.Forms.ColumnHeader cH_product;
        private System.Windows.Forms.ColumnHeader cH_description;
        private System.Windows.Forms.ColumnHeader cH_date;
        private System.Windows.Forms.ColumnHeader cH_language;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSB_reset;
        private System.Windows.Forms.ToolStripButton tSB_licenses;
        private System.Windows.Forms.ToolStripButton tSB_burn;
        private System.Windows.Forms.ToolStripButton tSB_search;
        private System.Windows.Forms.ToolStripComboBox tSCB_search;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSMI_burn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tSMI_quit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem brennenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ImageList iL_disc;
    }
}

