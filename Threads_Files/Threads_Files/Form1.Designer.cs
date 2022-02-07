
namespace Threads_Files
{
    partial class Form1
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
            this.lbl_files = new System.Windows.Forms.Label();
            this.lbl_lletres = new System.Windows.Forms.Label();
            this.txtbox_files = new System.Windows.Forms.TextBox();
            this.txtbox_lletres = new System.Windows.Forms.TextBox();
            this.btn_codif = new System.Windows.Forms.Button();
            this.btn_files = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_files
            // 
            this.lbl_files.AutoSize = true;
            this.lbl_files.Location = new System.Drawing.Point(34, 44);
            this.lbl_files.Name = "lbl_files";
            this.lbl_files.Size = new System.Drawing.Size(92, 13);
            this.lbl_files.TabIndex = 0;
            this.lbl_files.Text = "Número de fitxers:";
            // 
            // lbl_lletres
            // 
            this.lbl_lletres.AutoSize = true;
            this.lbl_lletres.Location = new System.Drawing.Point(34, 76);
            this.lbl_lletres.Name = "lbl_lletres";
            this.lbl_lletres.Size = new System.Drawing.Size(92, 13);
            this.lbl_lletres.TabIndex = 1;
            this.lbl_lletres.Text = "Número de lletres:";
            // 
            // txtbox_files
            // 
            this.txtbox_files.Location = new System.Drawing.Point(144, 41);
            this.txtbox_files.Name = "txtbox_files";
            this.txtbox_files.Size = new System.Drawing.Size(53, 20);
            this.txtbox_files.TabIndex = 2;
            // 
            // txtbox_lletres
            // 
            this.txtbox_lletres.Location = new System.Drawing.Point(144, 73);
            this.txtbox_lletres.Name = "txtbox_lletres";
            this.txtbox_lletres.Size = new System.Drawing.Size(53, 20);
            this.txtbox_lletres.TabIndex = 3;
            // 
            // btn_codif
            // 
            this.btn_codif.Location = new System.Drawing.Point(37, 114);
            this.btn_codif.Name = "btn_codif";
            this.btn_codif.Size = new System.Drawing.Size(75, 62);
            this.btn_codif.TabIndex = 4;
            this.btn_codif.Text = "Generar codificació";
            this.btn_codif.UseVisualStyleBackColor = true;
            this.btn_codif.Click += new System.EventHandler(this.btn_codif_Click);
            // 
            // btn_files
            // 
            this.btn_files.Location = new System.Drawing.Point(122, 114);
            this.btn_files.Name = "btn_files";
            this.btn_files.Size = new System.Drawing.Size(75, 62);
            this.btn_files.TabIndex = 5;
            this.btn_files.Text = "Generar fitxers";
            this.btn_files.UseVisualStyleBackColor = true;
            this.btn_files.Click += new System.EventHandler(this.btn_files_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 211);
            this.Controls.Add(this.btn_files);
            this.Controls.Add(this.btn_codif);
            this.Controls.Add(this.txtbox_lletres);
            this.Controls.Add(this.txtbox_files);
            this.Controls.Add(this.lbl_lletres);
            this.Controls.Add(this.lbl_files);
            this.Name = "Form1";
            this.Text = "Threads & Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_files;
        private System.Windows.Forms.Label lbl_lletres;
        private System.Windows.Forms.TextBox txtbox_files;
        private System.Windows.Forms.TextBox txtbox_lletres;
        private System.Windows.Forms.Button btn_codif;
        private System.Windows.Forms.Button btn_files;
    }
}

