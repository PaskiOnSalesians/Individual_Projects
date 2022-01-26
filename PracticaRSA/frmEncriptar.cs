using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;



namespace PracticaRSA
{
    public partial class frmEncriptar : Form
    {
        private static RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();
        string xmlKey;
        byte[] dataEncrypted;
        string address;

        public frmEncriptar()
        {
            InitializeComponent();
        }

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileExplorer = new OpenFileDialog();
                fileExplorer.DefaultExt = "xml";
                fileExplorer.InitialDirectory = @"C:\Desktop";
                fileExplorer.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                fileExplorer.RestoreDirectory = true;

                if (fileExplorer.ShowDialog() == DialogResult.OK)
                {
                    address = Path.GetFullPath(fileExplorer.FileName);
                }

                xmlKey = File.ReadAllText(address);
                rsaEnc.FromXmlString(xmlKey);
            }
            catch
            {
                MessageBox.Show("No s'ha pogut carregar la clau.", "DEncrypter - Error 07");
            }

        }

        private void btn_showKey_Click(object sender, EventArgs e)
        {
            try
            {
                tbx_pubkey.Text = xmlKey;
            }
            catch
            {
                MessageBox.Show("No es pot mostra la clau.", "DEncrypter - Error 11");
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] dataToEncrypt = ByteConverter.GetBytes(tbx_original.Text);

                dataEncrypted = rsaEnc.Encrypt(dataToEncrypt, false);
                tbx_crypted.Text = BitConverter.ToString(dataEncrypted);
                //encryptedData = rsaEnc.Encrypt(dataToEncrypt, false);
            }
            catch
            {
                MessageBox.Show("No es pot encriptar el missatge.", "DEncrypter - Error 13");
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TextBox txtBox in )
                {

                }
            }
            catch
            {
                MessageBox.Show("No s'ha pogut enviar el missatge encriptat.", "DEncrypt - Error 17");
            }

            //frmDesencriptar.EncryptedMessage = dataEncrypted;
        }
    }
}
