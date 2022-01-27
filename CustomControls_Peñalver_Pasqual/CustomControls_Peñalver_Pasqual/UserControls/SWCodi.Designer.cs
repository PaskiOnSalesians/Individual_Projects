namespace UserControls
{
    partial class SWCodi
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_codi = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_codi
            // 
            this.txt_codi.Location = new System.Drawing.Point(20, 16);
            this.txt_codi.Name = "txt_codi";
            this.txt_codi.Size = new System.Drawing.Size(100, 22);
            this.txt_codi.TabIndex = 0;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(161, 16);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.Size = new System.Drawing.Size(518, 22);
            this.txt_desc.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_codi);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(702, 55);
            this.Leave += new System.EventHandler(this.ValidaCodi);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codi;
        private System.Windows.Forms.TextBox txt_desc;
    }
}
