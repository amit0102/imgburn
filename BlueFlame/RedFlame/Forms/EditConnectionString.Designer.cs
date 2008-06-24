namespace RedFlame.Forms
{
    partial class EditConnectionString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditConnectionString));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.tB_userId = new System.Windows.Forms.TextBox();
            this.tB_dataBase = new System.Windows.Forms.TextBox();
            this.tB_port = new System.Windows.Forms.TextBox();
            this.tB_server = new System.Windows.Forms.TextBox();
            this.l_status = new System.Windows.Forms.Label();
            this.b_test = new System.Windows.Forms.Button();
            this.pB_connectionStatus = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.l_message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iL_connection = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_connectionStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tB_password, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tB_userId, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tB_dataBase, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tB_port, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tB_server, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.l_status, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.b_test, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pB_connectionStatus, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.l_message, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 352);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "UserId:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Database:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Passwort:";
            // 
            // tB_password
            // 
            this.tB_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tB_password, 2);
            this.tB_password.Location = new System.Drawing.Point(103, 147);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(125, 20);
            this.tB_password.TabIndex = 4;
            this.tB_password.UseSystemPasswordChar = true;
            // 
            // tB_userId
            // 
            this.tB_userId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tB_userId, 2);
            this.tB_userId.Location = new System.Drawing.Point(103, 112);
            this.tB_userId.Name = "tB_userId";
            this.tB_userId.Size = new System.Drawing.Size(125, 20);
            this.tB_userId.TabIndex = 3;
            // 
            // tB_dataBase
            // 
            this.tB_dataBase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tB_dataBase, 2);
            this.tB_dataBase.Location = new System.Drawing.Point(103, 77);
            this.tB_dataBase.Name = "tB_dataBase";
            this.tB_dataBase.Size = new System.Drawing.Size(125, 20);
            this.tB_dataBase.TabIndex = 2;
            // 
            // tB_port
            // 
            this.tB_port.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tB_port, 2);
            this.tB_port.Location = new System.Drawing.Point(103, 42);
            this.tB_port.Name = "tB_port";
            this.tB_port.Size = new System.Drawing.Size(57, 20);
            this.tB_port.TabIndex = 1;
            // 
            // tB_server
            // 
            this.tB_server.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.tB_server, 2);
            this.tB_server.Location = new System.Drawing.Point(103, 7);
            this.tB_server.Name = "tB_server";
            this.tB_server.Size = new System.Drawing.Size(125, 20);
            this.tB_server.TabIndex = 0;
            // 
            // l_status
            // 
            this.l_status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_status.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.l_status, 2);
            this.l_status.Location = new System.Drawing.Point(103, 221);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(43, 13);
            this.l_status.TabIndex = 13;
            this.l_status.Text = "l_status";
            // 
            // b_test
            // 
            this.b_test.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_test.Location = new System.Drawing.Point(103, 181);
            this.b_test.Name = "b_test";
            this.b_test.Size = new System.Drawing.Size(75, 23);
            this.b_test.TabIndex = 5;
            this.b_test.Text = "Test";
            this.b_test.UseVisualStyleBackColor = true;
            this.b_test.Click += new System.EventHandler(this.b_test_Click);
            // 
            // pB_connectionStatus
            // 
            this.pB_connectionStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pB_connectionStatus.Location = new System.Drawing.Point(204, 182);
            this.pB_connectionStatus.Name = "pB_connectionStatus";
            this.pB_connectionStatus.Size = new System.Drawing.Size(20, 20);
            this.pB_connectionStatus.TabIndex = 12;
            this.pB_connectionStatus.TabStop = false;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.b_ok);
            this.panel1.Controls.Add(this.b_cancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(103, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 41);
            this.panel1.TabIndex = 6;
            // 
            // b_ok
            // 
            this.b_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_ok.Location = new System.Drawing.Point(111, 9);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 0;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(30, 9);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 1;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // l_message
            // 
            this.l_message.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_message.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.l_message, 2);
            this.l_message.Location = new System.Drawing.Point(103, 268);
            this.l_message.Name = "l_message";
            this.l_message.Size = new System.Drawing.Size(57, 13);
            this.l_message.TabIndex = 14;
            this.l_message.Text = "l_message";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Status:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Message:";
            // 
            // iL_connection
            // 
            this.iL_connection.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iL_connection.ImageStream")));
            this.iL_connection.TransparentColor = System.Drawing.Color.Transparent;
            this.iL_connection.Images.SetKeyName(0, "disconnected");
            this.iL_connection.Images.SetKeyName(1, "connected");
            // 
            // EditConnectionString
            // 
            this.AcceptButton = this.b_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(301, 352);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditConnectionString";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditConnectionString";
            this.Load += new System.EventHandler(this.EditConnectionString_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_connectionStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_test;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.TextBox tB_userId;
        private System.Windows.Forms.TextBox tB_dataBase;
        private System.Windows.Forms.TextBox tB_port;
        private System.Windows.Forms.TextBox tB_server;
        private System.Windows.Forms.PictureBox pB_connectionStatus;
        private System.Windows.Forms.ImageList iL_connection;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label l_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}