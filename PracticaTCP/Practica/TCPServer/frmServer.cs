using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaTCP
{
    public partial class frmServer : Form
    {
        TcpListener listener;
        NetworkStream stream;
        TcpClient client;

        List<string> clientMessages = new List<string>();
        Thread filServerConnect;

        public frmServer()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            filServerConnect = new Thread(connectServer);
            filServerConnect.Start();
        }

        private void connectServer()
        {
            string data;
            byte[] buffer = new byte[1024];

            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");
                IPEndPoint ServerIP = new IPEndPoint(address, int.Parse(txb_port.Text));
                listener = new TcpListener(ServerIP);
                listener.Start();

                bool isConnected = true;

                clientMessages.Clear();
                while (isConnected)
                {
                    if (listener.Pending())
                    {
                        client = listener.AcceptTcpClient();
                        stream = client.GetStream();

                        int num = stream.Read(buffer, 0, buffer.Length);
                        data = UTF8Encoding.UTF8.GetString(buffer, 0, num);

                        IPEndPoint remoteIpEndPoint = client.Client.RemoteEndPoint as IPEndPoint;
                        lbx_Missatges.Items.Add(data);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot connect!");
            }
        }

        private void CloseEverything()
        {
            if (filServerConnect.IsAlive)
            {
                filServerConnect.Abort();
            }
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            CloseEverything();
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseEverything();
        }
    }
}
