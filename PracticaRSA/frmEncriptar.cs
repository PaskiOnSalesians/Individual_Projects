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
                RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();
                string xmlKey = File.ReadAllText(address);
                rsaEnc.FromXmlString(xmlKey);

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

                RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();
                string xmlKey = File.ReadAllText(address);
                rsaEnc.FromXmlString(xmlKey);

                using (rsaEnc)
                {
                    dataEncrypted = rsaEnc.Encrypt(dataToEncrypt, false);
                }

                tbx_crypted.Text = ByteConverter.GetString(dataEncrypted);
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
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name.Equals("frmDesencriptar"))
                    {
                        frmDesencriptar frmDes = (frmDesencriptar)frm;
                        frmDes.EncryptedMessage = dataEncrypted;
                        foreach (Control txtbox in frmDes.Controls)
                        {
                            if (txtbox.Name.Equals("tbx_crypted"))
                            {
                                txtbox.Text = tbx_crypted.Text;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("No s'ha pogut enviar el missatge encriptat.", "DEncrypt - Error 17");
            }
        }
    }
}
