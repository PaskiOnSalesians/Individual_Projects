using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using System.Xml.Linq;

namespace TCPClient
{
    public partial class frmClient : Form
    {
        TcpClient client;
        NetworkStream stream;

        public frmClient()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            byte[] sendData;

            try
            {
                this.client = new TcpClient(txb_ip.Text, int.Parse(txb_port.Text));

                sendData = UTF8Encoding.UTF8.GetBytes(txb_message.Text);
                this.stream = this.client.GetStream();
                this.stream.Write(sendData, 0, sendData.Length);

                this.stream.Close();
                this.client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Message not sent.");
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            string address = txb_ip.Text;
            string port = txb_port.Text;

            XElement AddressPort = XElement.Load(Application.StartupPath + "\\TCPSettings.xml");

            foreach (XElement n in AddressPort.Descendants("ConfigurationData"))
            {
                foreach (XElement k in AddressPort.Descendants("Protocol"))
                {
                    foreach (XElement m in AddressPort.Descendants("TCP"))
                    {
                        if (m.Name.Equals("IP"))
                        {
                            XElement addressElement = new XElement("IP", address);
                            string currentAddress = "<IP>127.0.0.1</IP>";
                            addressElement.ReplaceWith(XElement.Parse(currentAddress));
                        }

                        if (m.Name.Equals("Port"))
                        {
                            XElement portElement = new XElement("IP", port);
                            string currentPort = "<Port>2828</Port>";
                            portElement.ReplaceWith(XElement.Parse(currentPort));
                        }
                    }
                }
            }
            

            MessageBox.Show(AddressPort.ToString());
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {

        }

        #region Comprovar la xarxa
        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            Thread filComprovar = new Thread(Comprovacio);
            filComprovar.Start();
        }

        private void Comprovacio()
        {
            string stringBool, controlError = "";
            int comptadorPing, comptadorPingCorrecte;

            pnl_status.BackColor = Color.Yellow;

            comptadorPingCorrecte = 0;
            comptadorPing = 0;
            while (comptadorPing < 10)
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("127.0.0.1", 5);

                if (reply.Address != null)
                {
                    stringBool = "OK";
                    comptadorPingCorrecte++;
                }
                else if (reply.Address == null)
                {
                    stringBool = "NOK";
                    controlError = "NoPing";
                }
                else
                {
                    stringBool = "NOK";
                    controlError = "NoNet";
                }

                lbx_console.Items.Add("Ping" + comptadorPing + " - " + stringBool);
                comptadorPing++;
            }

            if (comptadorPingCorrecte == 10)
            {
                pnl_status.BackColor = Color.Green;
                lb_statusInfo.Text = "Connexió correcte";
                lb_statusInfo.ForeColor = Color.Green;
            }
            else if (controlError.Equals("NoPing"))
            {
                pnl_status.BackColor = Color.Red;
                lb_statusInfo.Text = "Ping no contesta";
                lb_statusInfo.ForeColor = Color.Red;
            }
            else
            {
                pnl_status.BackColor = Color.Red;
                lb_statusInfo.Text = "Xarxa no disponible";
                lb_statusInfo.ForeColor = Color.Red;
            }
        }
        #endregion
    }
}
