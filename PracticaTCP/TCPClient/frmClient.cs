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
            bool pingCorrecte = false;

            pnl_status.BackColor = Color.Yellow;

            for(int i = 0; i < 10; i++)
            {
                if (pingCorrecte)
                {
                    stringBool = "OK";
                }
                else
                {
                    stringBool = "NOK";
                }

                lbx_console.Text = "Ping" + i + " - " + stringBool;
            }
        }
    }
}
