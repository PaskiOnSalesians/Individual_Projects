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

        string keyName, fileAddress;

        public static string fileKey;

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
            try
            {
                SaveFileDialog fileExplorer = new SaveFileDialog();

                fileExplorer.DefaultExt = "xml";
                fileExplorer.InitialDirectory = @"C:\Desktop";
                fileExplorer.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                fileExplorer.RestoreDirectory = true;

                if (fileExplorer.ShowDialog() == DialogResult.OK)
                {
                    fileAddress = Path.GetFullPath(fileExplorer.FileName.ToString());
                }

                tbx_routeXML.Text = fileAddress;
                fileKey = tbx_routeXML.Text;
            }
            catch
            {
                MessageBox.Show("No es pot carregar l'arxiu XML.", "DEncrypt - Error 02");
            }
            
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            try
            {
                string publicKey = rsa.ToXmlString(false);
                string privateKey = rsa.ToXmlString(true);

                File.WriteAllText(tbx_routeXML.Text, publicKey);

                MessageBox.Show("Keys Generated!");

                KeysGenerated = true;
            }
            catch
            {
                MessageBox.Show("No es poden generar les claus.", "DEncrypt - Error 03");
            }
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
            try
            {
                // tbx_crypted.Text = BitConverter.ToString(dataEncrypted);

                CspParameters cspp = new CspParameters();
                //string keyName = tbx_container.Text;

                cspp.KeyContainerName = keyName;
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);

                byte[] DataDecrypted = rsa.Decrypt(EncryptedMessage, false);

                tbx_decrypted.Text = Encoding.Default.GetString(DataDecrypted);
            }
            catch
            {
                MessageBox.Show("No es pot desencriptar.","DEncrypt - Error 05");
            }
        }
    }
}
