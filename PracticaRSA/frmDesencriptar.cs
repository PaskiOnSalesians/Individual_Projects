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
        CspParameters cspp = new CspParameters();



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
        }

        private void btn_routeXML_Click(object sender, EventArgs e)
        {

            string fileAddress = "";

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
                string keyName = tbx_container.Text;
                cspp.KeyContainerName = keyName;

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);
                rsa.PersistKeyInCsp = true;

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

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();

                string keyName = tbx_container.Text;
                cspp.KeyContainerName = keyName;

                RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider(cspp);

                byte[] DataDecrypted = rsaEnc.Decrypt(EncryptedMessage, false);

                tbx_decrypted.Text = ByteConverter.GetString(DataDecrypted);
            }
            catch
            {
                MessageBox.Show("No es pot desencriptar.","DEncrypt - Error 05");
            }
        }
    }
}
