using System;
using System.Collections;
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

namespace Threads_Files
{
    public partial class frmThreadFiles : Form
    {
        List<codificacio> vocalsXifrades;

        public frmThreadFiles()
        {
            InitializeComponent();
        }

        // Generar Codificacion
        #region Generar Codificacion
        private void btn_codif_Click(object sender, EventArgs e)
        {
            vocalsXifrades = new List<codificacio>() {
                new codificacio(){ vowel = 'a', encoded = encriptVowel()},
                new codificacio(){ vowel = 'e', encoded = encriptVowel()},
                new codificacio(){ vowel = 'i', encoded = encriptVowel()},
                new codificacio(){ vowel = 'o', encoded = encriptVowel()},
                new codificacio(){ vowel = 'u', encoded = encriptVowel()}
            };

            using(StreamWriter sw = new StreamWriter(Application.StartupPath + "\\codificacio.txt"))
            {
                for(int i = 0; i < vocalsXifrades.Count; i++)
                {
                    sw.WriteLine(vocalsXifrades[i].vowel + ":" + vocalsXifrades[i].encoded);
                }
            } 
        }
        #endregion

        // Encriptar Vocales
        #region Encriptar Vocales
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

            int randomNumber, pos, xifratge, limitNombres;
            ArrayList nombres = new ArrayList(); // Array de nombres de 0-9

            for (int i = 0; i < 10; i++) // Omplir array de 0-9
            {
                nombres.Add(i);
            }

            limitNombres = nombres.Count;

            while(limitNombres > 0)
            {
                randomNumber = rng.Next(0, 10); // Aquest ha de ser 10 perque no esta inclos, per tant genera fins al 9
                if (!cua.Contains(randomNumber)) // Si l'array conte el nombre
                {
                    pos = nombres.IndexOf(randomNumber); // Treu la posicio a l'array del nombre aleatori
                    cua.Enqueue((int)nombres[pos]); // El posa en una cua
                    nombres.RemoveAt(pos);

                    //Console.WriteLine(randomNumber);

                    limitNombres--;
                }
            }

            //Console.WriteLine(nombres.Count);

            for (int i = 0; i < 10; i++) // Tots els nombres del array inicial
            {
                xifratge = (int)cua.Dequeue();
                lletraXifrada += xifratge.ToString();
            }

            return lletraXifrada;
        }
        #endregion

        private void btn_files_Click(object sender, EventArgs e)
        {
            int nombreFitxers;
            string dir = Application.StartupPath + "\\fitxers";
            string rndChar;

            nombreFitxers = Int32.Parse(txtbox_files.Text);

            //FileStream fs = File.Create(path)
            for (int i = 0; i < nombreFitxers; i++)
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                else
                {
                    DirectoryInfo di = new DirectoryInfo(dir);

                    foreach(FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                }

                using (FileStream fs = File.Create(dir + "\\fitxer" + i + ".txt"))
                {
                    rndChar = randomChars();
                    //fs.Write(,0,);
                    //fs.Write(info, 0, info.Length);
                }
                    
            }
        }

        private string randomChars()
        {

            return "";
        }
    }

    public class codificacio
    {
        public char vowel { get; set; }
        public string encoded { get; set; }
    }
}
