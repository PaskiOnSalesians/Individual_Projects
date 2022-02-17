using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads_Files
{
    public partial class frmThreadFiles : Form
    {
        List<string> vocalsXifrades;

        public frmThreadFiles()
        {
            InitializeComponent();
        }

        private void btn_codif_Click(object sender, EventArgs e)
        {
            vocalsXifrades = new List<string>();

            vocalsXifrades.Add(string.Format("a:{0}", encriptVowel()));

            MessageBox.Show(vocalsXifrades[0]);
            //vocalsXifrades.Add("e", encriptVowel());
            //vocalsXifrades.Add("i", encriptVowel());
            //vocalsXifrades.Add("o", encriptVowel());
            //vocalsXifrades.Add("u", encriptVowel());   
        }

        private string encriptVowel()
        {
            string lletraXifrada = ""; // String Resultat

            Queue<int> cua = new Queue<int>(); // Cua

            // Aconseguir inici del Random
            #region RNGCryptoServiceProvider

            RNGCryptoServiceProvider rngC = new RNGCryptoServiceProvider();

            byte[] byteArray = new byte[4];
            rngC.GetBytes(byteArray);

            int randomInteger = (int) BitConverter.ToUInt32(byteArray, 0);

            #endregion

            Random rng = new Random(randomInteger); // numero aleatori

            int randomNumber, pos, xifratge;
            ArrayList nombres = new ArrayList(); // Array de nombres de 0-9
            ArrayList lletres = new ArrayList();

            for(int i = 0; i < 10; i++) // Omplir array de 0-9
            {
                nombres.Add(i);
            }

            foreach(Object obj in nombres)
            {
                randomNumber = rng.Next(0, 9);
                if (nombres.Contains(randomNumber)) // Si l'array conte el nombre
                {
                    pos = nombres.IndexOf(randomNumber); // Treu la posicio a l'array del nombre aleatori
                    cua.Enqueue((int)nombres[pos]); // El posa en una cua
                }
            }

            Console.WriteLine(nombres.Count);

            for (int i = 0; i < 10; i++) // Tots els nombres del array inicial
            {
                xifratge = (int)cua.Dequeue();
                lletraXifrada += xifratge.ToString();
            }

            Console.WriteLine(lletraXifrada);

            return lletraXifrada;
        }

        private void btn_files_Click(object sender, EventArgs e)
        {

        }
    }
}
