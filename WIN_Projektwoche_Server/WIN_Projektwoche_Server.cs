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
    public partial class WIN_Projektwoche_Server : Form
    {
        AsyncTcpServer Server;
        private System.Threading.Timer _timer;

        public WIN_Projektwoche_Server()
        {
            InitializeComponent();
        }

        private void WIN_Projektwoche_Server_Load(object sender, EventArgs e)
        {
            _timer = new System.Threading.Timer(new System.Threading.TimerCallback(TimerMethode));
            cboxIPAdresse.Items.Add("127.0.0.1");
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress item in localIP)
            {
                if (item.AddressFamily == AddressFamily.InterNetwork) cboxIPAdresse.Items.Add(item.ToString());
            }
        }

        private void TimerMethode(object state)
        {
            MethodInvoker LabelUpdate = delegate
            {
                if (Server.IsActive)
                {
                    lblServerstatusAusgabe.Text = "online";
                }
                else { lblServerstatusAusgabe.Text = "offline"; }
                lblAnzahlClentsAusgabe.Text = Convert.ToString(Server.NumberOfConnectedClients) ;
            };
            Invoke(LabelUpdate);
            }

        private void Packet_Recieved(object sender, PacketReceivedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            RemoveClient(Convert.ToString(e.Client.Client.RemoteEndPoint));
        }

        private void Connected(object sender, ClientConnectedEventArgs e)
        {
            AddClient(Convert.ToString(e.Client.Client.RemoteEndPoint));
        }

        private void RemoveClient(string client)
        {
            MethodInvoker tmp = delegate { lboxConnectedClients.Items.Remove(client); lboxLog.Items.Add(String.Format("{0} Ein Client die Verbindung getrennt ({1})",DateTime.Now ,client)); };
            Invoke(tmp);
        }

        private void AddClient(string client)
        {
            MethodInvoker tmp = delegate { lboxConnectedClients.Items.Add(client); lboxLog.Items.Add(String.Format("{0} Ein Client hat sich verbunden ({1})",DateTime.Now,client)); };
            Invoke(tmp);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Server = new AsyncTcpServer(IPAddress.Parse(cboxIPAdresse.Text), Convert.ToInt32(tboxPort.Text));
            Server.Start();
            btnStart.Enabled = false;
            cboxIPAdresse.Enabled = false;
            tboxPort.Enabled = false;
            lboxLog.Items.Add(string.Format( "{0} Der Server wurde gestartet",DateTime.Now));
            Server.ClientConnected += new AsyncTcpServer.ClientConnectedEventHandler(Connected);
            Server.ClientDisconnected += new AsyncTcpServer.ClientDisconnectedEventHandler(Disconnected);
            Server.PacketReceived += new AsyncTcpServer.PacketReceivedEventHandler(Packet_Recieved);
            _timer.Change(0, 500);
        }

        private void lblIPAddresse_Click(object sender, EventArgs e)
        {

        }

        private void tboxPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxIPAdresse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPort_Click(object sender, EventArgs e)
        {

        }
    }
}
