using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBRecuperacio
{
    public partial class frmPOO : Form
    {
        Missatges.MissatgeHeredat ms = new Missatges.MissatgeHeredat();
        public frmPOO()
        {
            InitializeComponent();
        }
        private void btnHolaOriginal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ms.salutacio());
        }

        private void btnHola1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ms.salutacio(txtNom.Text));
        }

        private void btnHola2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ms.salutacio(txtNom.Text, cmbBandol.Text));
        }

        private void btnAdeuOriginal_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ms.comiatCatala());
        }

        private void btnAdeu1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ms.comiat());
        }
    }
}
