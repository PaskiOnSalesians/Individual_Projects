using System;
using System.Collections;
using System.Collections.Generic;

using System.ComponentModel;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads_Files
{
    public partial class frmThreadFiles : Form
    {
        List<codificacio> vocalsXifrades;

        private static string dir = Application.StartupPath + "\\fitxers";

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

            int IntegerIni = RNGCrypto();

            Random rng = new Random(IntegerIni); // numero aleatori

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

        // RNG Crypto Service Provider
        #region RNGCryptoServiceProvider
        private int RNGCrypto()
        {
            RNGCryptoServiceProvider rngC = new RNGCryptoServiceProvider();

            byte[] byteArray = new byte[4];
            rngC.GetBytes(byteArray);

            int randomInteger = (int)BitConverter.ToUInt32(byteArray, 0);

            return randomInteger;
        }
        #endregion

        // Generar Fitxers amb lletres
        #region Generar Fitxers
        private void btn_files_Click(object sender, EventArgs e)
        {
            try
            {
                if(Int32.Parse(txtbox_files.Text) >= 100 && Int32.Parse(txtbox_lletres.Text) >= 1000)
                {
                    Thread t1 = new Thread(existeixDirectori);
                    t1.Start(); // Inicia el fil de la creacio del directori "fitxers"
                    MessageBox.Show("Fitxers Generats!");

                    Thread t2 = new Thread(crearZip);
                    t2.Start();
                    MessageBox.Show("Compressió realitzada!");
                }
                else
                {
                    MessageBox.Show("Han de ser minim 100 fitxers i 1000 lletres per fitxer.", "Error 005");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); //"Falta omplir els camps de dalt.", "Error 007"
            }
            
        }

        #endregion

        #region Creacio i comprovacio del directori
        private void existeixDirectori()
        {
            string rndChar;
            int nombreFitxers = Int32.Parse(txtbox_files.Text);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            else
            {
                DirectoryInfo di = new DirectoryInfo(dir);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }

            Parallel.For(0, nombreFitxers, (i) =>
            {
                using (FileStream fs = File.Create(dir + "\\fitxer" + i + ".txt"))
                {
                    rndChar = randomChars();
                    using (StreamWriter sw_fs = new StreamWriter(fs))
                    {
                        sw_fs.Write(rndChar);
                    }
                }
            });
        }


        private string randomChars()
        {
            int limitCaracters = Int32.Parse(txtbox_lletres.Text);
            int randomChar;
            string textFitxer = "";
            char charAleatorio;

            for (int i = 0; i < limitCaracters; i++)
            {
                Random rndCharInt = new Random(RNGCrypto());

                randomChar = rndCharInt.Next(0, 5);

                charAleatorio = vocalsXifrades[randomChar].vowel;

                for(int j = 0; j < vocalsXifrades.Count; j++)
                {
                    if (charAleatorio.Equals(vocalsXifrades[j].vowel))
                    {
                        textFitxer += vocalsXifrades[j].encoded + "\n";
                    }
                }
            }

            return textFitxer;
        }

        #endregion

        //private void crearZip()
        //{
        //    var zipFile = @"C:\data\myzip.zip";
        //    var files = Directory.GetFiles(@"c:\data");

        //    using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
        //    {
        //        foreach (var fPath in files)
        //        {
        //            archive.CreateEntryFromFile(fPath, Path.GetFileName(fPath));
        //        }
        //    }
        //}

    }

    public class codificacio
    {
        public char vowel { get; set; }
        public string encoded { get; set; }
    }
}
