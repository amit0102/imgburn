namespace BlueFlame.Forms
{
    partial class LogonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogonForm));
            this.b_login = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.cB_domains = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iL_language = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iCB_language = new BlueFlame.Classes.UserControls.ImageComboBox();
            this.b_set = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_login
            // 
            resources.ApplyResources(this.b_login, "b_login");
            this.b_login.Name = "b_login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.b_cancel, "b_cancel");
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // tB_name
            // 
            resources.ApplyResources(this.tB_name, "tB_name");
            this.tB_name.Name = "tB_name";
            // 
            // tB_password
            // 
            resources.ApplyResources(this.tB_password, "tB_password");
            this.tB_password.Name = "tB_password";
            this.tB_password.UseSystemPasswordChar = true;
            // 
            // cB_domains
            // 
            resources.ApplyResources(this.cB_domains, "cB_domains");
            this.cB_domains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_domains.FormattingEnabled = true;
            this.cB_domains.Name = "cB_domains";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cB_domains, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tB_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tB_password, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // iL_language
            // 
            this.iL_language.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_language.ImageStream")));
            this.iL_language.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_language.Images.SetKeyName(0, "english");
            this.iL_language.Images.SetKeyName(1, "german");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlueFlame.Properties.Resources.BlueFlameBanner;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // iCB_language
            // 
            this.iCB_language.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.iCB_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iCB_language.FormattingEnabled = true;
            this.iCB_language.ImageList = this.iL_language;
            resources.ApplyResources(this.iCB_language, "iCB_language");
            this.iCB_language.Name = "iCB_language";
            // 
            // b_set
            // 
            resources.ApplyResources(this.b_set, "b_set");
            this.b_set.Name = "b_set";
            this.b_set.UseVisualStyleBackColor = true;
            this.b_set.Click += new System.EventHandler(this.b_set_Click);
            // 
            // LogonForm
            // 
            this.AcceptButton = this.b_login;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.b_cancel;
            this.Controls.Add(this.b_set);
            this.Controls.Add(this.iCB_language);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogonForm";
            this.Load += new System.EventHandler(this.LogonForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.ComboBox cB_domains;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList iL_language;
        private BlueFlame.Classes.UserControls.ImageComboBox iCB_language;
        private System.Windows.Forms.Button b_set;
    }
}