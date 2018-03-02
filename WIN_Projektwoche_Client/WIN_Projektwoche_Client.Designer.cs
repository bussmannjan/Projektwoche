namespace WIN_Projektwoche
{
    partial class WIN_Projektwoche_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_Projektwoche_Client));
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAddresse = new System.Windows.Forms.Label();
            this.tboxPort = new System.Windows.Forms.TextBox();
            this.cboxIPAdresse = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPasswort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(10, 61);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 15;
            this.lblPort.Text = "Port:";
            // 
            // lblIPAddresse
            // 
            this.lblIPAddresse.AutoSize = true;
            this.lblIPAddresse.Location = new System.Drawing.Point(10, 16);
            this.lblIPAddresse.Name = "lblIPAddresse";
            this.lblIPAddresse.Size = new System.Drawing.Size(67, 13);
            this.lblIPAddresse.TabIndex = 14;
            this.lblIPAddresse.Text = "IP-Addresse:";
            // 
            // tboxPort
            // 
            this.tboxPort.BackColor = System.Drawing.Color.LightGray;
            this.tboxPort.Location = new System.Drawing.Point(13, 78);
            this.tboxPort.Name = "tboxPort";
            this.tboxPort.Size = new System.Drawing.Size(100, 20);
            this.tboxPort.TabIndex = 13;
            this.tboxPort.Text = "49000";
            // 
            // cboxIPAdresse
            // 
            this.cboxIPAdresse.BackColor = System.Drawing.Color.LightGray;
            this.cboxIPAdresse.FormattingEnabled = true;
            this.cboxIPAdresse.Location = new System.Drawing.Point(13, 32);
            this.cboxIPAdresse.Name = "cboxIPAdresse";
            this.cboxIPAdresse.Size = new System.Drawing.Size(121, 21);
            this.cboxIPAdresse.TabIndex = 12;
            this.cboxIPAdresse.Text = "127.0.0.1";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.Location = new System.Drawing.Point(25, 210);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(10, 108);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 13);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Nutzername:";
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(11, 154);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(53, 13);
            this.lblPasswort.TabIndex = 17;
            this.lblPasswort.Text = "Passwort:";
            // 
            // tboxUsername
            // 
            this.tboxUsername.BackColor = System.Drawing.Color.LightGray;
            this.tboxUsername.Location = new System.Drawing.Point(13, 124);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(100, 20);
            this.tboxUsername.TabIndex = 18;
            // 
            // tboxPasswort
            // 
            this.tboxPasswort.BackColor = System.Drawing.Color.LightGray;
            this.tboxPasswort.Location = new System.Drawing.Point(13, 170);
            this.tboxPasswort.Name = "tboxPasswort";
            this.tboxPasswort.Size = new System.Drawing.Size(100, 20);
            this.tboxPasswort.TabIndex = 19;
            // 
            // WIN_Projektwoche_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(152, 249);
            this.Controls.Add(this.tboxPasswort);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIPAddresse);
            this.Controls.Add(this.tboxPort);
            this.Controls.Add(this.cboxIPAdresse);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_Projektwoche_Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.WIN_Projektwoche_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIPAddresse;
        private System.Windows.Forms.TextBox tboxPort;
        private System.Windows.Forms.ComboBox cboxIPAdresse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPasswort;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPasswort;
    }
}

