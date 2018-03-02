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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_Projektwoche_Server));
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
            this.lblCPUAuslastungText = new System.Windows.Forms.Label();
            this.lblSchreibauslastungText = new System.Windows.Forms.Label();
            this.lblLeseauslastungText = new System.Windows.Forms.Label();
            this.lblRAMAuslastungText = new System.Windows.Forms.Label();
            this.lblServerLaufzeitText = new System.Windows.Forms.Label();
            this.lblAnzahlProzzessorenText = new System.Windows.Forms.Label();
            this.lblCPUSpeedText = new System.Windows.Forms.Label();
            this.lblAnzahlKerneText = new System.Windows.Forms.Label();
            this.lblAnzahlThreadsText = new System.Windows.Forms.Label();
            this.lblCPUTemperaturText = new System.Windows.Forms.Label();
            this.lblNetzwerkgeschwindigkeitText = new System.Windows.Forms.Label();
            this.lblCPUAuslastungAusgabe = new System.Windows.Forms.Label();
            this.lblSchreibauslastungAusgabe = new System.Windows.Forms.Label();
            this.lblLeseauslastungAusgabe = new System.Windows.Forms.Label();
            this.lblRAMAuslastungAusgabe = new System.Windows.Forms.Label();
            this.lblServerLaufzeitAusgabe = new System.Windows.Forms.Label();
            this.lblAnzahlProzzessorenAusgabe = new System.Windows.Forms.Label();
            this.lblCPUSpeedAusgabe = new System.Windows.Forms.Label();
            this.lblAnzahlKerneAusgabe = new System.Windows.Forms.Label();
            this.lblAnzahlThreadsAusgabe = new System.Windows.Forms.Label();
            this.lblCPUTemperaturAusgabe = new System.Windows.Forms.Label();
            this.lblNetzwerkgeschwindigkeitAusgabe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxLog
            // 
            this.lboxLog.BackColor = System.Drawing.Color.LightGray;
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.Location = new System.Drawing.Point(12, 15);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(386, 381);
            this.lboxLog.TabIndex = 0;
            // 
            // lboxConnectedClients
            // 
            this.lboxConnectedClients.BackColor = System.Drawing.Color.LightGray;
            this.lboxConnectedClients.FormattingEnabled = true;
            this.lboxConnectedClients.Location = new System.Drawing.Point(419, 87);
            this.lboxConnectedClients.Name = "lboxConnectedClients";
            this.lboxConnectedClients.Size = new System.Drawing.Size(308, 95);
            this.lboxConnectedClients.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.Location = new System.Drawing.Point(652, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboxIPAdresse
            // 
            this.cboxIPAdresse.BackColor = System.Drawing.Color.LightGray;
            this.cboxIPAdresse.FormattingEnabled = true;
            this.cboxIPAdresse.Location = new System.Drawing.Point(419, 35);
            this.cboxIPAdresse.Name = "cboxIPAdresse";
            this.cboxIPAdresse.Size = new System.Drawing.Size(121, 21);
            this.cboxIPAdresse.TabIndex = 3;
            this.cboxIPAdresse.Text = "127.0.0.1";
            // 
            // tboxPort
            // 
            this.tboxPort.BackColor = System.Drawing.Color.LightGray;
            this.tboxPort.Location = new System.Drawing.Point(546, 36);
            this.tboxPort.Name = "tboxPort";
            this.tboxPort.Size = new System.Drawing.Size(100, 20);
            this.tboxPort.TabIndex = 4;
            this.tboxPort.Text = "49000";
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
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(543, 19);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 10;
            this.lblPort.Text = "Port:";
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
            // lblCPUAuslastungText
            // 
            this.lblCPUAuslastungText.AutoSize = true;
            this.lblCPUAuslastungText.Location = new System.Drawing.Point(419, 256);
            this.lblCPUAuslastungText.Name = "lblCPUAuslastungText";
            this.lblCPUAuslastungText.Size = new System.Drawing.Size(87, 13);
            this.lblCPUAuslastungText.TabIndex = 13;
            this.lblCPUAuslastungText.Text = "CPU Auslastung:";
            // 
            // lblSchreibauslastungText
            // 
            this.lblSchreibauslastungText.AutoSize = true;
            this.lblSchreibauslastungText.Location = new System.Drawing.Point(419, 269);
            this.lblSchreibauslastungText.Name = "lblSchreibauslastungText";
            this.lblSchreibauslastungText.Size = new System.Drawing.Size(97, 13);
            this.lblSchreibauslastungText.TabIndex = 14;
            this.lblSchreibauslastungText.Text = "Schreibauslastung:";
            // 
            // lblLeseauslastungText
            // 
            this.lblLeseauslastungText.AutoSize = true;
            this.lblLeseauslastungText.Location = new System.Drawing.Point(419, 282);
            this.lblLeseauslastungText.Name = "lblLeseauslastungText";
            this.lblLeseauslastungText.Size = new System.Drawing.Size(84, 13);
            this.lblLeseauslastungText.TabIndex = 15;
            this.lblLeseauslastungText.Text = "Leseauslastung:";
            // 
            // lblRAMAuslastungText
            // 
            this.lblRAMAuslastungText.AutoSize = true;
            this.lblRAMAuslastungText.Location = new System.Drawing.Point(419, 295);
            this.lblRAMAuslastungText.Name = "lblRAMAuslastungText";
            this.lblRAMAuslastungText.Size = new System.Drawing.Size(89, 13);
            this.lblRAMAuslastungText.TabIndex = 16;
            this.lblRAMAuslastungText.Text = "RAM Auslastung:";
            // 
            // lblServerLaufzeitText
            // 
            this.lblServerLaufzeitText.AutoSize = true;
            this.lblServerLaufzeitText.Location = new System.Drawing.Point(419, 308);
            this.lblServerLaufzeitText.Name = "lblServerLaufzeitText";
            this.lblServerLaufzeitText.Size = new System.Drawing.Size(77, 13);
            this.lblServerLaufzeitText.TabIndex = 17;
            this.lblServerLaufzeitText.Text = "Systemlaufzeit:";
            // 
            // lblAnzahlProzzessorenText
            // 
            this.lblAnzahlProzzessorenText.AutoSize = true;
            this.lblAnzahlProzzessorenText.Location = new System.Drawing.Point(419, 321);
            this.lblAnzahlProzzessorenText.Name = "lblAnzahlProzzessorenText";
            this.lblAnzahlProzzessorenText.Size = new System.Drawing.Size(126, 13);
            this.lblAnzahlProzzessorenText.TabIndex = 18;
            this.lblAnzahlProzzessorenText.Text = "Anzahl der Prozzessoren:";
            // 
            // lblCPUSpeedText
            // 
            this.lblCPUSpeedText.AutoSize = true;
            this.lblCPUSpeedText.Location = new System.Drawing.Point(419, 334);
            this.lblCPUSpeedText.Name = "lblCPUSpeedText";
            this.lblCPUSpeedText.Size = new System.Drawing.Size(92, 13);
            this.lblCPUSpeedText.TabIndex = 19;
            this.lblCPUSpeedText.Text = "Max. CPU Speed:";
            // 
            // lblAnzahlKerneText
            // 
            this.lblAnzahlKerneText.AutoSize = true;
            this.lblAnzahlKerneText.Location = new System.Drawing.Point(419, 347);
            this.lblAnzahlKerneText.Name = "lblAnzahlKerneText";
            this.lblAnzahlKerneText.Size = new System.Drawing.Size(73, 13);
            this.lblAnzahlKerneText.TabIndex = 20;
            this.lblAnzahlKerneText.Text = "Anzahl Kerne:";
            // 
            // lblAnzahlThreadsText
            // 
            this.lblAnzahlThreadsText.AutoSize = true;
            this.lblAnzahlThreadsText.Location = new System.Drawing.Point(419, 360);
            this.lblAnzahlThreadsText.Name = "lblAnzahlThreadsText";
            this.lblAnzahlThreadsText.Size = new System.Drawing.Size(84, 13);
            this.lblAnzahlThreadsText.TabIndex = 21;
            this.lblAnzahlThreadsText.Text = "Anzahl Threads:";
            // 
            // lblCPUTemperaturText
            // 
            this.lblCPUTemperaturText.AutoSize = true;
            this.lblCPUTemperaturText.Location = new System.Drawing.Point(419, 373);
            this.lblCPUTemperaturText.Name = "lblCPUTemperaturText";
            this.lblCPUTemperaturText.Size = new System.Drawing.Size(89, 13);
            this.lblCPUTemperaturText.TabIndex = 22;
            this.lblCPUTemperaturText.Text = "CPU Temperatur:";
            // 
            // lblNetzwerkgeschwindigkeitText
            // 
            this.lblNetzwerkgeschwindigkeitText.AutoSize = true;
            this.lblNetzwerkgeschwindigkeitText.Location = new System.Drawing.Point(419, 386);
            this.lblNetzwerkgeschwindigkeitText.Name = "lblNetzwerkgeschwindigkeitText";
            this.lblNetzwerkgeschwindigkeitText.Size = new System.Drawing.Size(131, 13);
            this.lblNetzwerkgeschwindigkeitText.TabIndex = 23;
            this.lblNetzwerkgeschwindigkeitText.Text = "Netzwerkgeschwindigkeit:";
            // 
            // lblCPUAuslastungAusgabe
            // 
            this.lblCPUAuslastungAusgabe.AutoSize = true;
            this.lblCPUAuslastungAusgabe.Location = new System.Drawing.Point(605, 256);
            this.lblCPUAuslastungAusgabe.Name = "lblCPUAuslastungAusgabe";
            this.lblCPUAuslastungAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblCPUAuslastungAusgabe.TabIndex = 24;
            // 
            // lblSchreibauslastungAusgabe
            // 
            this.lblSchreibauslastungAusgabe.AutoSize = true;
            this.lblSchreibauslastungAusgabe.Location = new System.Drawing.Point(605, 269);
            this.lblSchreibauslastungAusgabe.Name = "lblSchreibauslastungAusgabe";
            this.lblSchreibauslastungAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblSchreibauslastungAusgabe.TabIndex = 25;
            // 
            // lblLeseauslastungAusgabe
            // 
            this.lblLeseauslastungAusgabe.AutoSize = true;
            this.lblLeseauslastungAusgabe.Location = new System.Drawing.Point(605, 282);
            this.lblLeseauslastungAusgabe.Name = "lblLeseauslastungAusgabe";
            this.lblLeseauslastungAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblLeseauslastungAusgabe.TabIndex = 26;
            // 
            // lblRAMAuslastungAusgabe
            // 
            this.lblRAMAuslastungAusgabe.AutoSize = true;
            this.lblRAMAuslastungAusgabe.Location = new System.Drawing.Point(605, 295);
            this.lblRAMAuslastungAusgabe.Name = "lblRAMAuslastungAusgabe";
            this.lblRAMAuslastungAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblRAMAuslastungAusgabe.TabIndex = 27;
            // 
            // lblServerLaufzeitAusgabe
            // 
            this.lblServerLaufzeitAusgabe.AutoSize = true;
            this.lblServerLaufzeitAusgabe.Location = new System.Drawing.Point(605, 308);
            this.lblServerLaufzeitAusgabe.Name = "lblServerLaufzeitAusgabe";
            this.lblServerLaufzeitAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblServerLaufzeitAusgabe.TabIndex = 28;
            // 
            // lblAnzahlProzzessorenAusgabe
            // 
            this.lblAnzahlProzzessorenAusgabe.AutoSize = true;
            this.lblAnzahlProzzessorenAusgabe.Location = new System.Drawing.Point(605, 321);
            this.lblAnzahlProzzessorenAusgabe.Name = "lblAnzahlProzzessorenAusgabe";
            this.lblAnzahlProzzessorenAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblAnzahlProzzessorenAusgabe.TabIndex = 29;
            // 
            // lblCPUSpeedAusgabe
            // 
            this.lblCPUSpeedAusgabe.AutoSize = true;
            this.lblCPUSpeedAusgabe.Location = new System.Drawing.Point(605, 334);
            this.lblCPUSpeedAusgabe.Name = "lblCPUSpeedAusgabe";
            this.lblCPUSpeedAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblCPUSpeedAusgabe.TabIndex = 30;
            // 
            // lblAnzahlKerneAusgabe
            // 
            this.lblAnzahlKerneAusgabe.AutoSize = true;
            this.lblAnzahlKerneAusgabe.Location = new System.Drawing.Point(605, 347);
            this.lblAnzahlKerneAusgabe.Name = "lblAnzahlKerneAusgabe";
            this.lblAnzahlKerneAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblAnzahlKerneAusgabe.TabIndex = 31;
            // 
            // lblAnzahlThreadsAusgabe
            // 
            this.lblAnzahlThreadsAusgabe.AutoSize = true;
            this.lblAnzahlThreadsAusgabe.Location = new System.Drawing.Point(605, 360);
            this.lblAnzahlThreadsAusgabe.Name = "lblAnzahlThreadsAusgabe";
            this.lblAnzahlThreadsAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblAnzahlThreadsAusgabe.TabIndex = 32;
            // 
            // lblCPUTemperaturAusgabe
            // 
            this.lblCPUTemperaturAusgabe.AutoSize = true;
            this.lblCPUTemperaturAusgabe.Location = new System.Drawing.Point(605, 373);
            this.lblCPUTemperaturAusgabe.Name = "lblCPUTemperaturAusgabe";
            this.lblCPUTemperaturAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblCPUTemperaturAusgabe.TabIndex = 33;
            // 
            // lblNetzwerkgeschwindigkeitAusgabe
            // 
            this.lblNetzwerkgeschwindigkeitAusgabe.AutoSize = true;
            this.lblNetzwerkgeschwindigkeitAusgabe.Location = new System.Drawing.Point(605, 386);
            this.lblNetzwerkgeschwindigkeitAusgabe.Name = "lblNetzwerkgeschwindigkeitAusgabe";
            this.lblNetzwerkgeschwindigkeitAusgabe.Size = new System.Drawing.Size(0, 13);
            this.lblNetzwerkgeschwindigkeitAusgabe.TabIndex = 34;
            // 
            // WIN_Projektwoche_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(740, 408);
            this.Controls.Add(this.lblNetzwerkgeschwindigkeitAusgabe);
            this.Controls.Add(this.lblCPUTemperaturAusgabe);
            this.Controls.Add(this.lblAnzahlThreadsAusgabe);
            this.Controls.Add(this.lblAnzahlKerneAusgabe);
            this.Controls.Add(this.lblCPUSpeedAusgabe);
            this.Controls.Add(this.lblAnzahlProzzessorenAusgabe);
            this.Controls.Add(this.lblServerLaufzeitAusgabe);
            this.Controls.Add(this.lblRAMAuslastungAusgabe);
            this.Controls.Add(this.lblLeseauslastungAusgabe);
            this.Controls.Add(this.lblSchreibauslastungAusgabe);
            this.Controls.Add(this.lblCPUAuslastungAusgabe);
            this.Controls.Add(this.lblNetzwerkgeschwindigkeitText);
            this.Controls.Add(this.lblCPUTemperaturText);
            this.Controls.Add(this.lblAnzahlThreadsText);
            this.Controls.Add(this.lblAnzahlKerneText);
            this.Controls.Add(this.lblCPUSpeedText);
            this.Controls.Add(this.lblAnzahlProzzessorenText);
            this.Controls.Add(this.lblServerLaufzeitText);
            this.Controls.Add(this.lblRAMAuslastungText);
            this.Controls.Add(this.lblLeseauslastungText);
            this.Controls.Add(this.lblSchreibauslastungText);
            this.Controls.Add(this.lblCPUAuslastungText);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label lblCPUAuslastungText;
        private System.Windows.Forms.Label lblSchreibauslastungText;
        private System.Windows.Forms.Label lblLeseauslastungText;
        private System.Windows.Forms.Label lblRAMAuslastungText;
        private System.Windows.Forms.Label lblServerLaufzeitText;
        private System.Windows.Forms.Label lblAnzahlProzzessorenText;
        private System.Windows.Forms.Label lblCPUSpeedText;
        private System.Windows.Forms.Label lblAnzahlKerneText;
        private System.Windows.Forms.Label lblAnzahlThreadsText;
        private System.Windows.Forms.Label lblCPUTemperaturText;
        private System.Windows.Forms.Label lblNetzwerkgeschwindigkeitText;
        private System.Windows.Forms.Label lblCPUAuslastungAusgabe;
        private System.Windows.Forms.Label lblSchreibauslastungAusgabe;
        private System.Windows.Forms.Label lblLeseauslastungAusgabe;
        private System.Windows.Forms.Label lblRAMAuslastungAusgabe;
        private System.Windows.Forms.Label lblServerLaufzeitAusgabe;
        private System.Windows.Forms.Label lblAnzahlProzzessorenAusgabe;
        private System.Windows.Forms.Label lblCPUSpeedAusgabe;
        private System.Windows.Forms.Label lblAnzahlKerneAusgabe;
        private System.Windows.Forms.Label lblAnzahlThreadsAusgabe;
        private System.Windows.Forms.Label lblCPUTemperaturAusgabe;
        private System.Windows.Forms.Label lblNetzwerkgeschwindigkeitAusgabe;
    }
}

