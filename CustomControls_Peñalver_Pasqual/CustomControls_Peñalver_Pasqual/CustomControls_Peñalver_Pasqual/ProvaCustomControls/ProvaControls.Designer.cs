
namespace ProvaCustomControls
{
    partial class ProvaControls
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
            this.Patata = new System.Windows.Forms.TextBox();
            this.swTextBox4 = new InheritedControls.SWTextBox();
            this.swTextBox3 = new InheritedControls.SWTextBox();
            this.swTextBox2 = new InheritedControls.SWTextBox();
            this.swTextBox1 = new InheritedControls.SWTextBox();
            this.swCodi1 = new UserControls.SWCodi();
            this.llensaApp1 = new UserControls.LlensaApp();
            this.SuspendLayout();
            // 
            // Patata
            // 
            this.Patata.Location = new System.Drawing.Point(428, 45);
            this.Patata.Name = "Patata";
            this.Patata.Size = new System.Drawing.Size(276, 22);
            this.Patata.TabIndex = 4;
            // 
            // swTextBox4
            // 
            this.swTextBox4.BackColor = System.Drawing.Color.LightGray;
            this.swTextBox4.CampBuit = false;
            this.swTextBox4.ClauForana = false;
            this.swTextBox4.Location = new System.Drawing.Point(32, 188);
            this.swTextBox4.Name = "swTextBox4";
            this.swTextBox4.NomControl = null;
            this.swTextBox4.Size = new System.Drawing.Size(232, 22);
            this.swTextBox4.TabIndex = 3;
            this.swTextBox4.Tipus = InheritedControls.SWTextBox.TipusTextBox.data;
            // 
            // swTextBox3
            // 
            this.swTextBox3.BackColor = System.Drawing.Color.LightGray;
            this.swTextBox3.CampBuit = true;
            this.swTextBox3.ClauForana = false;
            this.swTextBox3.Location = new System.Drawing.Point(32, 140);
            this.swTextBox3.Name = "swTextBox3";
            this.swTextBox3.NomControl = null;
            this.swTextBox3.Size = new System.Drawing.Size(232, 22);
            this.swTextBox3.TabIndex = 2;
            this.swTextBox3.Tipus = InheritedControls.SWTextBox.TipusTextBox.codi;
            // 
            // swTextBox2
            // 
            this.swTextBox2.BackColor = System.Drawing.Color.LightGray;
            this.swTextBox2.CampBuit = true;
            this.swTextBox2.ClauForana = false;
            this.swTextBox2.Location = new System.Drawing.Point(32, 92);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.NomControl = null;
            this.swTextBox2.Size = new System.Drawing.Size(232, 22);
            this.swTextBox2.TabIndex = 1;
            this.swTextBox2.Tipus = InheritedControls.SWTextBox.TipusTextBox.text;
            // 
            // swTextBox1
            // 
            this.swTextBox1.BackColor = System.Drawing.Color.LightGray;
            this.swTextBox1.CampBuit = true;
            this.swTextBox1.ClauForana = false;
            this.swTextBox1.Location = new System.Drawing.Point(32, 45);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.NomControl = "Patata";
            this.swTextBox1.Size = new System.Drawing.Size(232, 22);
            this.swTextBox1.TabIndex = 0;
            this.swTextBox1.Tipus = InheritedControls.SWTextBox.TipusTextBox.nombre;
            // 
            // swCodi1
            // 
            this.swCodi1.ControlID = null;
            this.swCodi1.Location = new System.Drawing.Point(29, 244);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.Nivell = UserControls.SWCodi.TipusNivell.GS;
            this.swCodi1.Requerit = false;
            this.swCodi1.Size = new System.Drawing.Size(759, 55);
            this.swCodi1.TabIndex = 6;
            // 
            // llensaApp1
            // 
            this.llensaApp1.Classe = "ProvaTest.dll";
            this.llensaApp1.Descripcio = "Test";
            this.llensaApp1.Formulari = "ProvaTest.ProvaTest";
            this.llensaApp1.Location = new System.Drawing.Point(271, 321);
            this.llensaApp1.Name = "llensaApp1";
            this.llensaApp1.Size = new System.Drawing.Size(221, 92);
            this.llensaApp1.TabIndex = 5;
            // 
            // ProvaControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.llensaApp1);
            this.Controls.Add(this.Patata);
            this.Controls.Add(this.swTextBox4);
            this.Controls.Add(this.swTextBox3);
            this.Controls.Add(this.swTextBox2);
            this.Controls.Add(this.swTextBox1);
            this.Name = "ProvaControls";
            this.Text = "CustomControls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InheritedControls.SWTextBox swTextBox1;
        private InheritedControls.SWTextBox swTextBox2;
        private InheritedControls.SWTextBox swTextBox3;
        private InheritedControls.SWTextBox swTextBox4;
        private System.Windows.Forms.TextBox Patata;
        private UserControls.LlensaApp llensaApp1;
        private UserControls.SWCodi swCodi1;
    }
}

