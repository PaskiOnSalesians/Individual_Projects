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
        

        public frmEncriptar()
        {
            InitializeComponent();
        }

        private void btn_obtainKey_Click(object sender, EventArgs e)
        {
            xmlKey = File.ReadAllText(frmDesencriptar.folderKey);
            rsaEnc.FromXmlString(xmlKey);
        }

        private void btn_showKey_Click(object sender, EventArgs e)
        {
            tbx_pubkey.Text = xmlKey;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(tbx_original.Text);

            byte[] dataEncrypted = rsaEnc.Encrypt(dataToEncrypt, false);
            tbx_crypted.Text = BitConverter.ToString(dataEncrypted);
            //encryptedData = rsaEnc.Encrypt(dataToEncrypt, false);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            frmDesencriptar.EncryptedMessage = this.tbx_crypted.Text;
        }
    }
}
