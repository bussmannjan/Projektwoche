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
        Systemvalues SystemWerte = new Systemvalues();

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
                    try
                    {
                        lblCPUAuslastungAusgabe.Text = string.Format("{0}%", SystemWerte.get_CPU_Load()) ;
                    }
                    catch (Exception)
                    {

                        lblCPUAuslastungAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblSchreibauslastungAusgabe.Text = string.Format("{0}%", SystemWerte.get_Diskwrite_load()) ;
                    }
                    catch (Exception)
                    {

                        lblSchreibauslastungAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblLeseauslastungAusgabe.Text = string.Format("{0}%", SystemWerte.get_Diskread_load()) ;
                    }
                    catch (Exception)
                    {

                        lblLeseauslastungAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblRAMAuslastungAusgabe.Text = string.Format("{0}%", SystemWerte.get_RAM_load());
                    }
                    catch (Exception)
                    {

                        lblRAMAuslastungAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblServerLaufzeitAusgabe.Text = SystemWerte.get_Uptime();
                    }
                    catch (Exception)
                    {

                        lblServerLaufzeitAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblAnzahlProzzessorenAusgabe.Text = SystemWerte.GetCPUProcessor();
                    }
                    catch (Exception)
                    {

                        lblAnzahlProzzessorenAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblCPUSpeedAusgabe.Text = string.Format("{0}MHz", SystemWerte.GetCPUMaxSpeed()) ;
                    }
                    catch (Exception)
                    {

                        lblCPUSpeedAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblAnzahlKerneAusgabe.Text = SystemWerte.GetCPUCores();
                    }
                    catch (Exception)
                    {

                        lblAnzahlKerneAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblAnzahlThreadsAusgabe.Text = SystemWerte.GetThreads();
                    }
                    catch (Exception)
                    {

                        lblAnzahlThreadsAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        lblCPUTemperaturAusgabe.Text = string.Format("{0}C°", SystemWerte.GetCPUTemp()) ;
                    }
                    catch (Exception)
                    {

                        lblCPUTemperaturAusgabe.Text = "Service nicht verfügbar!";
                    }
                    try
                    {
                        //lblNetzwerkgeschwindigkeitAusgabe.Text = SystemWerte.ShowNetworkTraffic();
                        throw new NotImplementedException();
                    }
                    catch (Exception)
                    {

                        lblNetzwerkgeschwindigkeitAusgabe.Text = "Service nicht verfügbar!";
                    } 
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
    }
}
