using System;
using System.Net.Sockets;

namespace WIN_Projektwoche
{
    public class ClientConnectedEventArgs : EventArgs
    {
        public TcpClient Client { get; set; }

        public ClientConnectedEventArgs(TcpClient client)
        {
            this.Client = client;
        }
    }
}
