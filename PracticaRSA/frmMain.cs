using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRSA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ntnEncriptar_Click(object sender, EventArgs e)
        {
            frmEncriptar frm = new frmEncriptar();
            frm.Show();

        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            frmDesencriptar frm = new frmDesencriptar();
            frm.Show();
        }
    }
}
