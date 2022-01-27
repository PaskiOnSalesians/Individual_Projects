using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class SWCodi: UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }

        // Propietats
        #region Propietats

        // Propietat Requerit
        #region Requerit
        private bool _Requerit;

        public bool Requerit
        {
            get { return _Requerit; }
            set { _Requerit = value; }
        }
        #endregion

        // Propietat ControlID
        #region ControlID
        private string _ControlID;

        public string ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }
        #endregion

        // Propietat Nivell
        #region Nivell
        public enum TipusNivell
        {
            GS,
            GM
        }

        private TipusNivell _Nivell;

        public TipusNivell Nivell
        {
            get { return _Nivell; }
            set { _Nivell = value; }
        }
        #endregion

        #endregion

        // Metodes
        #region Mètodes
        public void ValidaCodi(object sender, EventArgs e)
        {
            if (Requerit)
            {
                if (txt_codi.Equals(""))
                {
                    txt_codi.Clear();
                    txt_codi.Focus();
                }
            }

            switch (Nivell)
            {
                case TipusNivell.GS:
                    if (txt_codi.Text.Equals("S2AM"))
                    {
                        txt_desc.Text = "Desenvolupament aplicacions multiplataforma";
                    }
                    else if (txt_codi.Text.Equals("S2SX"))
                    {
                        txt_desc.Text = "Administració de sistemes Informàtics en xarxa";
                    }
                    else if (txt_codi.Text.Equals("M2SX"))
                    {
                        txt_desc.Text = "Codi Incorrecte";
                        txt_codi.Clear();
                        txt_codi.Focus();
                    }
                    else
                    {
                        txt_desc.Text = "Data Unknown";
                    }
                    break;
                case TipusNivell.GM:
                    if (txt_codi.Text.Equals("M2SX"))
                    {
                        txt_desc.Text = "Sistemes MicroInformàtics i Xarxes";
                    }
                    else if (txt_codi.Text.Equals("S2SX") || txt_codi.Text.Equals("S2AM"))
                    {
                        txt_desc.Text = "Codi Incorrecte";
                        txt_codi.Clear();
                        txt_codi.Focus();
                    }
                    else
                    {
                        txt_desc.Text = "Data Unknown";
                    }
                    break;
            }
        }
        #endregion
    }
}
