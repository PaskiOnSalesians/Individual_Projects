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
        private static CspParameters cspp = new CspParameters();
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);

        string keyName;

        public static string folderKey;

        //public static byte[] EncryptedMessage;

        private byte[] _EncryptedMessage;

        public byte[] EncryptedMessage
        {
            get { return _EncryptedMessage; }
            set { _EncryptedMessage = value; }
        }

        bool KeysGenerated = false;

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

            KeysGenerated = true;
        }

        private void frmDesencriptar_Activated(object sender, EventArgs e)
        {
            if(KeysGenerated == true)
            {
                this.tbx_crypted.Text = BitConverter.ToString(EncryptedMessage);
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            // tbx_crypted.Text = BitConverter.ToString(dataEncrypted);

            CspParameters cspp = new CspParameters();
            //string keyName = tbx_container.Text;

            cspp.KeyContainerName = keyName;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);

            byte[] DataDecrypted = rsa.Decrypt(EncryptedMessage, false);

            tbx_decrypted.Text = Encoding.Default.GetString(DataDecrypted);
        }
    }
}
