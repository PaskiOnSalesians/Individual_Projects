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

        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            string stringBool;
            int comptadorPing;

            pnl_status.BackColor = Color.Yellow;

            comptadorPing = 10; // S'han de fer 10 pings
            while(comptadorPing > 0) {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("127.0.0.1", 2828);

                if (reply.Address != null)
                {
                    stringBool = "OK";
                }
                else
                {
                    stringBool = "NOK";
                }

                lbx_console.Text = "Ping" + comptadorPing + " - " + stringBool;

                comptadorPing--;
            }
        }
    }
}
