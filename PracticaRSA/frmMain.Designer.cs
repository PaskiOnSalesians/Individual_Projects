namespace PracticaRSA
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ntnEncriptar = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ntnEncriptar
            // 
            this.ntnEncriptar.Location = new System.Drawing.Point(136, 84);
            this.ntnEncriptar.Name = "ntnEncriptar";
            this.ntnEncriptar.Size = new System.Drawing.Size(75, 45);
            this.ntnEncriptar.TabIndex = 0;
            this.ntnEncriptar.Text = "Encriptar";
            this.ntnEncriptar.UseVisualStyleBackColor = true;
            this.ntnEncriptar.Click += new System.EventHandler(this.ntnEncriptar_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(240, 84);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(75, 45);
            this.btnDesencriptar.TabIndex = 1;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 192);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.ntnEncriptar);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ntnEncriptar;
        private System.Windows.Forms.Button btnDesencriptar;
    }
}