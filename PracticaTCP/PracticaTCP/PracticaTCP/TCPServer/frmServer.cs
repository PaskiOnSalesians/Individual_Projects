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
        public frmServer()
        {
            InitializeComponent();
        }

        Thread filEscoltar;
        bool isListening = true;
        TcpListener Listener;
        TcpClient client;
        NetworkStream stream;

        private void frmServer_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //Botó per començar a escoltar clients per rebre el missatge
        private void btn_connect_Click(object sender, EventArgs e)
        {
            filEscoltar = new Thread(Escoltar);
            filEscoltar.Start();
        }

        //Permet establir connexió d'espera amb clients per poder conectarse
        private void Escoltar()
        {
            string ipClient = "127.0.0.1";
            try
            {
                if (txb_port.Text != null)
                {
                    Listener = new TcpListener(IPAddress.Parse(ipClient), int.Parse(txb_port.Text));

                    byte[] bytes = new byte[1024];
                    string data;

                    Listener.Start();

                    while (isListening)
                    {
                        if (Listener.Pending())
                        {
                            client = Listener.AcceptTcpClient();
                            stream = client.GetStream();
                            data = null;
                            int i;

                            i = stream.Read(bytes, 0, bytes.Length);
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            data = data.ToUpper();


                            lbx_Missatges.Items.Add("IP:" + ipClient + " ha enviat:");
                            lbx_Missatges.Items.Add(data);
                        }

                    }
                    stream.Close();
                    client.Close();
                    Listener.Stop();
                    Tancar();
                } 
                
            }
            catch (FormatException)
            {
                MessageBox.Show("No s'ha escrit el port");
            }
            

        }
        private void Tancar()
        {
            isListening = false;
            if (filEscoltar != null)
            {
                filEscoltar.Abort();
            }
      
        }

        //Botó per desconectar o tancar fils i objectes
        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            Tancar();
        }

        //Event que permet que encara que no es premi el botó desconectar, parant el programa o premem la creueta tancarem fils
        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tancar();
        }

        
    }
}
