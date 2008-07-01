namespace RedFlame.Forms
{
    partial class EditPreferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPreferences));
            this.b_Cancel = new System.Windows.Forms.Button();
            this.b_ok = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gB_readImage = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.b_browseProg = new System.Windows.Forms.Button();
            this.tB_externalProgram = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gB_database = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tB_connectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_editConStr = new System.Windows.Forms.Button();
            this.gB_client = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.b_export = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.b_addGroup = new System.Windows.Forms.Button();
            this.lb_allowedGroups = new System.Windows.Forms.ListBox();
            this.tb_newDenied = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_removeGroup = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.gB_readImage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gB_database.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gB_client.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Cancel
            // 
            this.b_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_Cancel.Location = new System.Drawing.Point(206, 4);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 1;
            this.b_Cancel.Text = "Cancel";
            this.b_Cancel.UseVisualStyleBackColor = true;
            // 
            // b_ok
            // 
            this.b_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_ok.Location = new System.Drawing.Point(287, 4);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 2;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gB_readImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.gB_database, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gB_client, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(377, 417);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gB_readImage
            // 
            this.gB_readImage.Controls.Add(this.tableLayoutPanel3);
            this.gB_readImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_readImage.Location = new System.Drawing.Point(3, 153);
            this.gB_readImage.Name = "gB_readImage";
            this.gB_readImage.Size = new System.Drawing.Size(371, 50);
            this.gB_readImage.TabIndex = 4;
            this.gB_readImage.TabStop = false;
            this.gB_readImage.Text = "Read Image";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.b_browseProg, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tB_externalProgram, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(365, 31);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "External Program:";
            // 
            // b_browseProg
            // 
            this.b_browseProg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_browseProg.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_browseProg.Location = new System.Drawing.Point(268, 4);
            this.b_browseProg.Name = "b_browseProg";
            this.b_browseProg.Size = new System.Drawing.Size(75, 23);
            this.b_browseProg.TabIndex = 1;
            this.b_browseProg.Text = "Browse";
            this.b_browseProg.UseVisualStyleBackColor = true;
            this.b_browseProg.Click += new System.EventHandler(this.b_browseProg_Click);
            // 
            // tB_externalProgram
            // 
            this.tB_externalProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_externalProgram.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RedFlame.Properties.Settings.Default, "BurnApplication", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tB_externalProgram.Location = new System.Drawing.Point(103, 5);
            this.tB_externalProgram.Name = "tB_externalProgram";
            this.tB_externalProgram.Size = new System.Drawing.Size(159, 20);
            this.tB_externalProgram.TabIndex = 2;
            this.tB_externalProgram.Text = global::RedFlame.Properties.Settings.Default.BurnApplication;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_Cancel);
            this.panel1.Controls.Add(this.b_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 36);
            this.panel1.TabIndex = 0;
            // 
            // gB_database
            // 
            this.gB_database.Controls.Add(this.tableLayoutPanel2);
            this.gB_database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_database.Location = new System.Drawing.Point(3, 3);
            this.gB_database.Name = "gB_database";
            this.gB_database.Size = new System.Drawing.Size(371, 144);
            this.gB_database.TabIndex = 2;
            this.gB_database.TabStop = false;
            this.gB_database.Text = "Database Connection";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tB_connectionString, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.b_editConStr, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(365, 125);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tB_connectionString
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tB_connectionString, 2);
            this.tB_connectionString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_connectionString.Location = new System.Drawing.Point(103, 3);
            this.tB_connectionString.Multiline = true;
            this.tB_connectionString.Name = "tB_connectionString";
            this.tB_connectionString.Size = new System.Drawing.Size(259, 79);
            this.tB_connectionString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // b_editConStr
            // 
            this.b_editConStr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_editConStr.Location = new System.Drawing.Point(268, 93);
            this.b_editConStr.Name = "b_editConStr";
            this.b_editConStr.Size = new System.Drawing.Size(75, 23);
            this.b_editConStr.TabIndex = 2;
            this.b_editConStr.Text = "Edit";
            this.b_editConStr.UseVisualStyleBackColor = true;
            this.b_editConStr.Click += new System.EventHandler(this.b_editConStr_Click);
            // 
            // gB_client
            // 
            this.gB_client.Controls.Add(this.tableLayoutPanel4);
            this.gB_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_client.Location = new System.Drawing.Point(3, 209);
            this.gB_client.Name = "gB_client";
            this.gB_client.Size = new System.Drawing.Size(371, 50);
            this.gB_client.TabIndex = 5;
            this.gB_client.TabStop = false;
            this.gB_client.Text = "Export Configfile";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.b_export, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(365, 31);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(5, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Save the connection string to an app.config file to be used in the BlueFlame Clie" +
                "nt";
            // 
            // b_export
            // 
            this.b_export.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_export.Location = new System.Drawing.Point(268, 4);
            this.b_export.Name = "b_export";
            this.b_export.Size = new System.Drawing.Size(75, 23);
            this.b_export.TabIndex = 1;
            this.b_export.Text = "Save as...";
            this.b_export.UseVisualStyleBackColor = true;
            this.b_export.Click += new System.EventHandler(this.b_export_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Denied Groups";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.Controls.Add(this.b_addGroup, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lb_allowedGroups, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tb_newDenied, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.b_removeGroup, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(365, 88);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // b_addGroup
            // 
            this.b_addGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_addGroup.Location = new System.Drawing.Point(268, 60);
            this.b_addGroup.Name = "b_addGroup";
            this.b_addGroup.Size = new System.Drawing.Size(75, 23);
            this.b_addGroup.TabIndex = 0;
            this.b_addGroup.Text = "Add";
            this.b_addGroup.UseVisualStyleBackColor = true;
            this.b_addGroup.Click += new System.EventHandler(this.b_addGroup_Click);
            // 
            // lb_allowedGroups
            // 
            this.lb_allowedGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_allowedGroups.FormattingEnabled = true;
            this.lb_allowedGroups.Location = new System.Drawing.Point(103, 3);
            this.lb_allowedGroups.Name = "lb_allowedGroups";
            this.lb_allowedGroups.Size = new System.Drawing.Size(159, 43);
            this.lb_allowedGroups.TabIndex = 1;
            // 
            // tb_newDenied
            // 
            this.tb_newDenied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_newDenied.Location = new System.Drawing.Point(103, 61);
            this.tb_newDenied.Name = "tb_newDenied";
            this.tb_newDenied.Size = new System.Drawing.Size(159, 20);
            this.tb_newDenied.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.tableLayoutPanel5.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(94, 88);
            this.label4.TabIndex = 3;
            this.label4.Text = "Groups that are listet here will be denied to logon to the application";
            // 
            // b_removeGroup
            // 
            this.b_removeGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_removeGroup.Location = new System.Drawing.Point(268, 16);
            this.b_removeGroup.Name = "b_removeGroup";
            this.b_removeGroup.Size = new System.Drawing.Size(75, 23);
            this.b_removeGroup.TabIndex = 4;
            this.b_removeGroup.Text = "Remove";
            this.b_removeGroup.UseVisualStyleBackColor = true;
            this.b_removeGroup.Click += new System.EventHandler(this.b_removeGroup_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "exe";
            this.openFileDialog1.FileName = "Nero";
            this.openFileDialog1.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "EXE.config";
            this.saveFileDialog1.FileName = "BlueFlame.EXE.config";
            this.saveFileDialog1.Filter = "App.config Dateien(*.EXE.config)|*.EXE.config";
            // 
            // EditPreferences
            // 
            this.AcceptButton = this.b_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_Cancel;
            this.ClientSize = new System.Drawing.Size(377, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPreferences";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.EditPreferences_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gB_readImage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gB_database.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gB_client.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gB_readImage;
        private System.Windows.Forms.GroupBox gB_database;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tB_connectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_editConStr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_browseProg;
        private System.Windows.Forms.TextBox tB_externalProgram;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gB_client;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_export;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button b_addGroup;
        private System.Windows.Forms.ListBox lb_allowedGroups;
        private System.Windows.Forms.TextBox tb_newDenied;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_removeGroup;
    }
}