using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DatasetIndividual
{
    public partial class Frm_Cerca : Form
    {
        public Frm_Cerca()
        {
            InitializeComponent();
        }

        // Variables d'us del DataSet
        #region Variables del DataSet
        
        SqlConnection cns; // Variable de la connexió SQL
        SqlDataAdapter adapter; // Variable que ens permet omplir el DataSet
        DataSet dts; // Dades de la base de dades en format DataSet
        string query; // Aquesta és la consulta que farem a la DB

        bool verify = false;

        #endregion

        // Botons d'acció
        #region Botons

        // Boto d'actualitzar
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (verify)
            {
                DataRow DataR = dts.Tables[0].NewRow(); // Creem una nova fila
                DataR["CodeAgency"] = SWText_Codi.Text; // S'actualitzen les dades introduides dins dels
                DataR["DescAgency"] = SWText_Desc.Text; // textbox a la Base de Dades
                dts.Tables[0].Rows.Add(DataR); // Afegim la nova fila
            }

            UpdateDB(); // Actualitza les dades
            QueryDB(); // Consulta a la Base de Dades
            DBinding(); // Executa els DataBindings per agafar les dades
            verify = false;
        }

        // Boto d'insertar
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            SWText_Codi.DataBindings.Clear(); // Borrar possibles Dades que tingui el DataBinding
            SWText_Desc.DataBindings.Clear();

            SWText_Codi.Clear(); // Borrem el contingut del TextBox
            SWText_Desc.Clear();

            verify = true;
        }

        #endregion

        // Connexió amb la Base de Dades
        #region Connexió a la BBDD
        private void ConnectDB()
        {
            string connexio;
            connexio = "Data Source = WHITEWOLF\\SQLEXPRESS; Initial Catalog = Agencies; Integrated Security = True";
            cns = new SqlConnection(connexio);
        }
        #endregion

        // Consulta cap a la Base de Dades + DataSet
        #region Consulta a la BBDD + DataSet ple
        private void QueryDB()
        {
            query = "select * from Agencies"; // Query o Consulta a fer
            adapter = new SqlDataAdapter(query, cns); // Fa la consulta

            cns.Open(); // Obrim la connexió
            dts = new DataSet(); // Nou DataSet
            adapter.Fill(dts, "Agencies"); // Afegim les dades d'Agencies al DataSet
            cns.Close(); // Tanquem la connexió
            DataGrid.DataSource = dts.Tables[0]; // Mostra les dades del DataSet
            DBinding();
        }

        #endregion

        //Events
        #region Events

        // Event en que càrrega el Formulari
        private void Frm_Cerca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agenciesDataSet.Agencies' Puede moverla o quitarla según sea necesario.
            this.agenciesTableAdapter.Fill(this.agenciesDataSet.Agencies);
            ConnectDB();
            QueryDB();
        }

        #endregion

        // Actualitzar Base de Dades
        #region Actualitzar Base de Dades (UpdateDB)
        private void UpdateDB()
        {
            int solution;

            cns.Open();
            
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, cns);

            SqlCommandBuilder Cmd = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                solution = adapter.Update(dts.Tables[0]);
                MessageBox.Show("Dades modificades: " + solution.ToString());
            }

            cns.Close();
            QueryDB();
        }

        #endregion

        // Inicialitzar DataBindings
        #region DataBindings

        private void DBinding()
        {
            SWText_Codi.DataBindings.Clear(); // Borra el DataBinding
            SWText_Codi.DataBindings.Add("Text", dts.Tables[0], SWText_Codi.Tag.ToString()); // Introdueix les dades com a Text dins del TextBox
            this.SWText_Codi.Validated += new System.EventHandler(this.VerifyDB);

            SWText_Desc.DataBindings.Clear();
            SWText_Desc.DataBindings.Add("Text", dts.Tables[0], SWText_Desc.Tag.ToString());
            this.SWText_Desc.Validated += new System.EventHandler(this.VerifyDB);
        }

        #endregion

        // Validar les Dades a la Base de Dades
        #region Validació de Dades

        private void VerifyDB(object sender, EventArgs e)
        {
            if (((TextBox)sender).DataBindings.Count > 0)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        #endregion

        // Mostrar les Dades del DataBinding al DataGridView
        #region Mostrar Dades al DataGridView

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewColumn viewDB = DataGrid.Columns[0];
            viewDB.Visible = false;

            DataGrid.Columns[1].HeaderText = "Codi";
            DataGrid.Columns[2].HeaderText = "Descripció";

            //DataGrid.Columns[1].Width = 120;
            //DataGrid.Columns[2].Width = 120;
        }

        #endregion
    }
}
