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

namespace TCPClient
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {

        }

        private void btn_config_Click(object sender, EventArgs e)
        {

        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {

        }

        #region Comprovar la xarxa
        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
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
                else if(reply.Address == null)
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
            else if(controlError.Equals("NoPing"))
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
