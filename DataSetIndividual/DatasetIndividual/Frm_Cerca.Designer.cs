
namespace DatasetIndividual
{
    partial class Frm_Cerca
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cerca));
            this.SWText_Codi = new InheritedControls.SWTextBox();
            this.lbl_Codi = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.SWText_Desc = new InheritedControls.SWTextBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.agenciesDataSet = new DatasetIndividual.AgenciesDataSet();
            this.agenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agenciesTableAdapter = new DatasetIndividual.AgenciesDataSetTableAdapters.AgenciesTableAdapter();
            this.idAgencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAgencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descAgencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SWText_Codi
            // 
            this.SWText_Codi.BackColor = System.Drawing.Color.White;
            this.SWText_Codi.CampBuit = true;
            this.SWText_Codi.ClauForana = false;
            this.SWText_Codi.Location = new System.Drawing.Point(493, 46);
            this.SWText_Codi.Name = "SWText_Codi";
            this.SWText_Codi.NomControl = null;
            this.SWText_Codi.Size = new System.Drawing.Size(229, 22);
            this.SWText_Codi.TabIndex = 0;
            this.SWText_Codi.Tag = "CodeAgency";
            this.SWText_Codi.Tipus = InheritedControls.SWTextBox.TipusTextBox.text;
            // 
            // lbl_Codi
            // 
            this.lbl_Codi.AutoSize = true;
            this.lbl_Codi.Location = new System.Drawing.Point(416, 49);
            this.lbl_Codi.Name = "lbl_Codi";
            this.lbl_Codi.Size = new System.Drawing.Size(40, 17);
            this.lbl_Codi.TabIndex = 1;
            this.lbl_Codi.Text = "Codi:";
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Location = new System.Drawing.Point(378, 87);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(78, 17);
            this.lbl_Desc.TabIndex = 3;
            this.lbl_Desc.Text = "Descripció:";
            // 
            // SWText_Desc
            // 
            this.SWText_Desc.BackColor = System.Drawing.Color.White;
            this.SWText_Desc.CampBuit = true;
            this.SWText_Desc.ClauForana = false;
            this.SWText_Desc.Location = new System.Drawing.Point(493, 84);
            this.SWText_Desc.Name = "SWText_Desc";
            this.SWText_Desc.NomControl = null;
            this.SWText_Desc.Size = new System.Drawing.Size(229, 22);
            this.SWText_Desc.TabIndex = 2;
            this.SWText_Desc.Tag = "DescAgency";
            this.SWText_Desc.Tipus = InheritedControls.SWTextBox.TipusTextBox.text;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAgencyDataGridViewTextBoxColumn,
            this.codeAgencyDataGridViewTextBoxColumn,
            this.descAgencyDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.agenciesBindingSource;
            this.DataGrid.Location = new System.Drawing.Point(71, 123);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(651, 242);
            this.DataGrid.TabIndex = 4;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Update.Location = new System.Drawing.Point(71, 382);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(99, 44);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Actualitzar";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Insert.Location = new System.Drawing.Point(187, 382);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(99, 44);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.Text = "Insertar";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // agenciesDataSet
            // 
            this.agenciesDataSet.DataSetName = "AgenciesDataSet";
            this.agenciesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agenciesBindingSource
            // 
            this.agenciesBindingSource.DataMember = "Agencies";
            this.agenciesBindingSource.DataSource = this.agenciesDataSet;
            // 
            // agenciesTableAdapter
            // 
            this.agenciesTableAdapter.ClearBeforeFill = true;
            // 
            // idAgencyDataGridViewTextBoxColumn
            // 
            this.idAgencyDataGridViewTextBoxColumn.DataPropertyName = "idAgency";
            this.idAgencyDataGridViewTextBoxColumn.HeaderText = "idAgency";
            this.idAgencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAgencyDataGridViewTextBoxColumn.Name = "idAgencyDataGridViewTextBoxColumn";
            this.idAgencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAgencyDataGridViewTextBoxColumn.Visible = false;
            this.idAgencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeAgencyDataGridViewTextBoxColumn
            // 
            this.codeAgencyDataGridViewTextBoxColumn.DataPropertyName = "CodeAgency";
            this.codeAgencyDataGridViewTextBoxColumn.HeaderText = "CodeAgency";
            this.codeAgencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeAgencyDataGridViewTextBoxColumn.Name = "codeAgencyDataGridViewTextBoxColumn";
            this.codeAgencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAgencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // descAgencyDataGridViewTextBoxColumn
            // 
            this.descAgencyDataGridViewTextBoxColumn.DataPropertyName = "DescAgency";
            this.descAgencyDataGridViewTextBoxColumn.HeaderText = "DescAgency";
            this.descAgencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descAgencyDataGridViewTextBoxColumn.Name = "descAgencyDataGridViewTextBoxColumn";
            this.descAgencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.descAgencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // Frm_Cerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.SWText_Desc);
            this.Controls.Add(this.lbl_Codi);
            this.Controls.Add(this.SWText_Codi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cerca";
            this.Text = "Cerca";
            this.Load += new System.EventHandler(this.Frm_Cerca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InheritedControls.SWTextBox SWText_Codi;
        private System.Windows.Forms.Label lbl_Codi;
        private System.Windows.Forms.Label lbl_Desc;
        private InheritedControls.SWTextBox SWText_Desc;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private AgenciesDataSet agenciesDataSet;
        private System.Windows.Forms.BindingSource agenciesBindingSource;
        private AgenciesDataSetTableAdapters.AgenciesTableAdapter agenciesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descAgencyDataGridViewTextBoxColumn;
    }
}

