using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Net.Sockets;


namespace WIN_Projektwoche
{
    public partial class WIN_Projektwoche_Client : Form
    {
        AsyncTcpClient Client = new AsyncTcpClient();
        string Nutzername = "Admin";
        string Passwort = "Passwort";

        public WIN_Projektwoche_Client()
        {
            InitializeComponent();
            Client.Connected += new AsyncTcpClient.ConnectedEventHandler(Connected);
            Client.Disconnected += new AsyncTcpClient.DisconnectedEventHandler(Disconnected);
            Client.ConnectionFailed += new AsyncTcpClient.ConnectionFailedEventHandler(ConnectionFailed);
            Client.PacketReceived += new AsyncTcpClient.PacketReceivedEventHandler(PacketRecived);
        }

        private void PacketRecived(object sender, PacketReceivedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void ConnectionFailed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Disconnected(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Connected(object sender, ClientConnectedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void WIN_Projektwoche_Client_Load(object sender, EventArgs e)
        {
            cboxIPAdresse.Items.Add("127.0.0.1");
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress item in localIP)
            {
                if (item.AddressFamily == AddressFamily.InterNetwork) cboxIPAdresse.Items.Add(item.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if ((tboxUsername.Text == Nutzername) && (tboxPasswort.Text == Passwort))
            {
                Client.Connect(IPAddress.Parse(cboxIPAdresse.Text), Convert.ToInt32(tboxPort.Text));
                System.Threading.Thread.Sleep(250);
                if (Client.IsConnected)
                {
                    LoginErfolgreich();
                }
                else  MessageBox.Show("Verbindung fehlgeschlagen!");
            }

            else MessageBox.Show("Benutzername oder Passwort falsch!");
            
        }

        private void LoginErfolgreich()
        {
            WIN_Projektwoche_Client.ActiveForm.Hide();
            WIN_Projektwoche_Client_Statusübersicht WIN_Projektwoche_Client_Statusübersicht1 = new WIN_Projektwoche_Client_Statusübersicht();
            WIN_Projektwoche_Client_Statusübersicht1.Show();  
        }
    }
}
