using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaRSA
{
    public partial class frmDesencriptar : Form
    {
        string keyName;

        private static CspParameters cspp = new CspParameters();
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);

        public static string folderKey;

        public static string EncryptedMessage;

        public frmDesencriptar()
        {
            InitializeComponent();

            keyName = tbx_container.Text;

            CryptoRSA(keyName);
        }

        private void CryptoRSA(string nomClau)
        {
            cspp.KeyContainerName = nomClau;

            rsa.PersistKeyInCsp = true;
        }

        private void btn_routeXML_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileExplorer = new FolderBrowserDialog();

            if(fileExplorer.ShowDialog() == DialogResult.OK)
            {
                tbx_routeXML.Text = fileExplorer.SelectedPath + "\\" + tbx_container.Text + ".xml";
                folderKey = tbx_routeXML.Text;
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            string publicKey = rsa.ToXmlString(false);
            string privateKey = rsa.ToXmlString(true);

            File.WriteAllText(tbx_routeXML.Text, publicKey);

            MessageBox.Show("Keys Generated!");
        }
    }
}
