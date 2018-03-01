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
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAddresse = new System.Windows.Forms.Label();
            this.tboxPort = new System.Windows.Forms.TextBox();
            this.cboxIPAdresse = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(139, 9);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 15;
            this.lblPort.Text = "Port:";
            // 
            // lblIPAddresse
            // 
            this.lblIPAddresse.AutoSize = true;
            this.lblIPAddresse.Location = new System.Drawing.Point(12, 9);
            this.lblIPAddresse.Name = "lblIPAddresse";
            this.lblIPAddresse.Size = new System.Drawing.Size(67, 13);
            this.lblIPAddresse.TabIndex = 14;
            this.lblIPAddresse.Text = "IP-Addresse:";
            // 
            // tboxPort
            // 
            this.tboxPort.Location = new System.Drawing.Point(142, 26);
            this.tboxPort.Name = "tboxPort";
            this.tboxPort.Size = new System.Drawing.Size(100, 20);
            this.tboxPort.TabIndex = 13;
            this.tboxPort.Text = "49000";
            // 
            // cboxIPAdresse
            // 
            this.cboxIPAdresse.FormattingEnabled = true;
            this.cboxIPAdresse.Location = new System.Drawing.Point(15, 25);
            this.cboxIPAdresse.Name = "cboxIPAdresse";
            this.cboxIPAdresse.Size = new System.Drawing.Size(121, 21);
            this.cboxIPAdresse.TabIndex = 12;
            this.cboxIPAdresse.Text = "127.0.0.1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(248, 23);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // WIN_Projektwoche_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 261);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIPAddresse);
            this.Controls.Add(this.tboxPort);
            this.Controls.Add(this.cboxIPAdresse);
            this.Controls.Add(this.btnStart);
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
    }
}

