using PracticaTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPClient;

namespace Client_Server_Launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            frmServer frm = new frmServer();
            frm.Show();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            frmClient frm = new frmClient();
            frm.Show();
        }
    }
}
