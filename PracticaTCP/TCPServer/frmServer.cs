﻿using System;
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
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1");
                IPEndPoint ServerIP = new IPEndPoint(address, 2828);
                listener = new TcpListener(ServerIP);
                listener.Start();
            }
            catch
            {
                MessageBox.Show("Connection already established.");
            }
            
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            listener.Stop();
            filServerConnect.Abort();
        }
    }
}
