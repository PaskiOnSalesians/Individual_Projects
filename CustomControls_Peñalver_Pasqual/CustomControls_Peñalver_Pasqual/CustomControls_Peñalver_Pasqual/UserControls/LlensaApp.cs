using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace UserControls
{
    public partial class LlensaApp : UserControl
    {
        public LlensaApp()
        {
            InitializeComponent();
        }

        // Propietats 
        #region Properties
        private string _Classe;

        public string Classe
        {
            get { return _Classe; }
            set { _Classe = value; }
        }

        private string _Formulari;

        public string Formulari
        {
            get { return _Formulari; }
            set { _Formulari = value; }
        }

        private string _Descripcio;

        public string Descripcio
        {
            get { return _Descripcio; }
            set { _Descripcio = value; }
        }
        #endregion

        //Events
        #region Events
        private void Open_App_Click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(Classe); // Carreguem l'arxiu dll que necessita

            Object dllBD;
            Type tipus;

            tipus = ensamblat.GetType(Formulari); // Carreguem el Formulari que volem
            dllBD = Activator.CreateInstance(tipus);
            ((Form) dllBD).Show();
        }
        #endregion

        private void LlensaApp_Load(object sender, EventArgs e)
        {
            Open_App.Text = Descripcio;
        }
    }
}
