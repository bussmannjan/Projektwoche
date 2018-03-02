namespace WIN_Projektwoche
{
    partial class WIN_Projektwoche_Server
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
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.lboxConnectedClients = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cboxIPAdresse = new System.Windows.Forms.ComboBox();
            this.tboxPort = new System.Windows.Forms.TextBox();
            this.lblServerstatusText = new System.Windows.Forms.Label();
            this.lblServerstatusAusgabe = new System.Windows.Forms.Label();
            this.lblAnzahlClentsText = new System.Windows.Forms.Label();
            this.lblAnzahlClentsAusgabe = new System.Windows.Forms.Label();
            this.lblIPAddresse = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblVerbundeneClientsText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxLog
            // 
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.Location = new System.Drawing.Point(12, 2);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(386, 342);
            this.lboxLog.TabIndex = 0;
            // 
            // lboxConnectedClients
            // 
            this.lboxConnectedClients.FormattingEnabled = true;
            this.lboxConnectedClients.Location = new System.Drawing.Point(419, 87);
            this.lboxConnectedClients.Name = "lboxConnectedClients";
            this.lboxConnectedClients.Size = new System.Drawing.Size(308, 95);
            this.lboxConnectedClients.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(652, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboxIPAdresse
            // 
            this.cboxIPAdresse.FormattingEnabled = true;
            this.cboxIPAdresse.Location = new System.Drawing.Point(419, 35);
            this.cboxIPAdresse.Name = "cboxIPAdresse";
            this.cboxIPAdresse.Size = new System.Drawing.Size(121, 21);
            this.cboxIPAdresse.TabIndex = 3;
            this.cboxIPAdresse.Text = "127.0.0.1";
            this.cboxIPAdresse.SelectedIndexChanged += new System.EventHandler(this.cboxIPAdresse_SelectedIndexChanged);
            // 
            // tboxPort
            // 
            this.tboxPort.Location = new System.Drawing.Point(546, 36);
            this.tboxPort.Name = "tboxPort";
            this.tboxPort.Size = new System.Drawing.Size(100, 20);
            this.tboxPort.TabIndex = 4;
            this.tboxPort.Text = "49000";
            this.tboxPort.TextChanged += new System.EventHandler(this.tboxPort_TextChanged);
            // 
            // lblServerstatusText
            // 
            this.lblServerstatusText.AutoSize = true;
            this.lblServerstatusText.Location = new System.Drawing.Point(419, 204);
            this.lblServerstatusText.Name = "lblServerstatusText";
            this.lblServerstatusText.Size = new System.Drawing.Size(69, 13);
            this.lblServerstatusText.TabIndex = 5;
            this.lblServerstatusText.Text = "Serverstatus:";
            // 
            // lblServerstatusAusgabe
            // 
            this.lblServerstatusAusgabe.AutoSize = true;
            this.lblServerstatusAusgabe.Location = new System.Drawing.Point(543, 204);
            this.lblServerstatusAusgabe.Name = "lblServerstatusAusgabe";
            this.lblServerstatusAusgabe.Size = new System.Drawing.Size(35, 13);
            this.lblServerstatusAusgabe.TabIndex = 6;
            this.lblServerstatusAusgabe.Text = "offline";
            // 
            // lblAnzahlClentsText
            // 
            this.lblAnzahlClentsText.AutoSize = true;
            this.lblAnzahlClentsText.Location = new System.Drawing.Point(419, 231);
            this.lblAnzahlClentsText.Name = "lblAnzahlClentsText";
            this.lblAnzahlClentsText.Size = new System.Drawing.Size(102, 13);
            this.lblAnzahlClentsText.TabIndex = 7;
            this.lblAnzahlClentsText.Text = "Verbundene Clients:";
            // 
            // lblAnzahlClentsAusgabe
            // 
            this.lblAnzahlClentsAusgabe.AutoSize = true;
            this.lblAnzahlClentsAusgabe.Location = new System.Drawing.Point(543, 231);
            this.lblAnzahlClentsAusgabe.Name = "lblAnzahlClentsAusgabe";
            this.lblAnzahlClentsAusgabe.Size = new System.Drawing.Size(13, 13);
            this.lblAnzahlClentsAusgabe.TabIndex = 8;
            this.lblAnzahlClentsAusgabe.Text = "0";
            // 
            // lblIPAddresse
            // 
            this.lblIPAddresse.AutoSize = true;
            this.lblIPAddresse.Location = new System.Drawing.Point(416, 19);
            this.lblIPAddresse.Name = "lblIPAddresse";
            this.lblIPAddresse.Size = new System.Drawing.Size(67, 13);
            this.lblIPAddresse.TabIndex = 9;
            this.lblIPAddresse.Text = "IP-Addresse:";
            this.lblIPAddresse.Click += new System.EventHandler(this.lblIPAddresse_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(543, 19);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 10;
            this.lblPort.Text = "Port:";
            this.lblPort.Click += new System.EventHandler(this.lblPort_Click);
            // 
            // lblVerbundeneClientsText
            // 
            this.lblVerbundeneClientsText.AutoSize = true;
            this.lblVerbundeneClientsText.Location = new System.Drawing.Point(416, 71);
            this.lblVerbundeneClientsText.Name = "lblVerbundeneClientsText";
            this.lblVerbundeneClientsText.Size = new System.Drawing.Size(102, 13);
            this.lblVerbundeneClientsText.TabIndex = 11;
            this.lblVerbundeneClientsText.Text = "Verbundene Clients:";
            // 
            // WIN_Projektwoche_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 346);
            this.Controls.Add(this.lblVerbundeneClientsText);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIPAddresse);
            this.Controls.Add(this.lblAnzahlClentsAusgabe);
            this.Controls.Add(this.lblAnzahlClentsText);
            this.Controls.Add(this.lblServerstatusAusgabe);
            this.Controls.Add(this.lblServerstatusText);
            this.Controls.Add(this.tboxPort);
            this.Controls.Add(this.cboxIPAdresse);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lboxConnectedClients);
            this.Controls.Add(this.lboxLog);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(756, 385);
            this.MinimumSize = new System.Drawing.Size(756, 385);
            this.Name = "WIN_Projektwoche_Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.WIN_Projektwoche_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.ListBox lboxConnectedClients;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cboxIPAdresse;
        private System.Windows.Forms.TextBox tboxPort;
        private System.Windows.Forms.Label lblServerstatusText;
        private System.Windows.Forms.Label lblServerstatusAusgabe;
        private System.Windows.Forms.Label lblAnzahlClentsText;
        private System.Windows.Forms.Label lblAnzahlClentsAusgabe;
        private System.Windows.Forms.Label lblIPAddresse;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblVerbundeneClientsText;
    }
}

