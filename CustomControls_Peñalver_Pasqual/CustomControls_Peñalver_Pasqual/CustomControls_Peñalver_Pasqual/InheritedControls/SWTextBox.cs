using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InheritedControls
{
    public class SWTextBox : TextBox
    {
        // Inici del programa + Events
        #region Inicialitzacio + Events
        public SWTextBox()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextBox
            // 
            this.TextChanged += new System.EventHandler(this.SWTextBox_TextChanged);
            this.Enter += new System.EventHandler(this.SWTextBox_Enter);
            this.Leave += new System.EventHandler(this.SWTextBox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextBox_Validating);
            this.ResumeLayout(false);

        }
        #endregion

        // Tipus a introduir
        #region Tipus
        public enum TipusTextBox
        {
            nombre,
            text,
            codi,
            data
        }

        private TipusTextBox _Tipus;

        public TipusTextBox Tipus
        {
            get { return _Tipus; }
            set
            {
                _Tipus = value;
            }
        }
        #endregion

        // Color del focus del TextBox
        #region Color Focus
        private void SWTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void SWTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }
        #endregion

        // Comprovar el Contingut
        #region Comprobar el contingut
        private void SWTextBox_TextChanged(object sender, EventArgs e)
        {
            bool VerificarCodi = true;
            switch (Tipus)
            {
                case TipusTextBox.nombre:
                    Regex rgx_nombre = new Regex(@"^\d{1,}$");
                    VerificarCodi = rgx_nombre.IsMatch(this.Text);
                    break;
                case TipusTextBox.text:
                    Regex rgx_text = new Regex(@"^\D{1,}$");
                    VerificarCodi = rgx_text.IsMatch(this.Text);
                    break;
                case TipusTextBox.codi:
                    Regex rgx_codi = new Regex(@"^[A-Z]{4}\-[0-9]{3}/[1,3,5,7,9][AEIOU]$");
                    VerificarCodi = rgx_codi.IsMatch(this.Text);
                    break;
                case TipusTextBox.data:
                    Regex rgx_data = new Regex(@"^([1-3]?[0-9])\/?\-?([1]?[0-9])\/?\-?\d{4}$");
                    VerificarCodi = rgx_data.IsMatch(this.Text);
                    break;
                default:
                    break;
            }

            if (VerificarCodi)
            {
                this.BackColor = Color.LightGreen;
            }
            else
            {
                this.BackColor = Color.PaleVioletRed;
            }
        }
        #endregion

        // Camp Buit
        #region Camp Buit
        private bool _CampBuit;
        public bool CampBuit
        {
            get { return _CampBuit; }
            set { _CampBuit = value; }
        }
        #endregion

        // Verificacions
        #region Verificacions
        private void SWTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(this.Text == "" && CampBuit == false)
            {
                e.Cancel = true;
                this.Select(0, this.Text.Length);
                MessageBox.Show(this, "Has d'omplir el camp.");
            }

            Form NomForm = this.FindForm();
            foreach(Control control in NomForm.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name.Equals(TxtBox))
                    {
                        control.Text = this.Text;
                    }
                }
            }
        }
        #endregion

        // Clau forana
        #region Clau Forana
        private bool _ForeignKey;

        public bool ClauForana
        {
            get { return _ForeignKey; }
            set { _ForeignKey = value; }
        }
        #endregion

        // Nom Control Nou
        #region Nom Control Nou
        private string TxtBox;

        public string NomControl
        {
            get { return TxtBox; }
            set { TxtBox = value; }
        }
        #endregion
    }
}
