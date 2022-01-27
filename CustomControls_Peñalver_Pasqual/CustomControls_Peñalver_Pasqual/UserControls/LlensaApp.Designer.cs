
namespace UserControls
{
    partial class LlensaApp
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
            this.Open_App = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open_App
            // 
            this.Open_App.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Open_App.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Open_App.FlatAppearance.BorderSize = 0;
            this.Open_App.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Open_App.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Open_App.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_App.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_App.ForeColor = System.Drawing.Color.White;
            this.Open_App.Location = new System.Drawing.Point(0, 0);
            this.Open_App.Name = "Open_App";
            this.Open_App.Size = new System.Drawing.Size(218, 98);
            this.Open_App.TabIndex = 0;
            this.Open_App.Text = "OPEN APP";
            this.Open_App.UseVisualStyleBackColor = false;
            this.Open_App.Click += new System.EventHandler(this.Open_App_Click);
            // 
            // LlensaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Open_App);
            this.Name = "LlensaApp";
            this.Size = new System.Drawing.Size(218, 98);
            this.Load += new System.EventHandler(this.LlensaApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_App;
    }
}
