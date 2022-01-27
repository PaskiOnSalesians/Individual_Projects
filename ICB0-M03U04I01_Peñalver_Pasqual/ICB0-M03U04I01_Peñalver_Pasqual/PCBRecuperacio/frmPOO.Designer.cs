namespace PCBRecuperacio
{
    partial class frmPOO
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
            this.btnHolaOriginal = new System.Windows.Forms.Button();
            this.btnAdeuOriginal = new System.Windows.Forms.Button();
            this.btnHola1 = new System.Windows.Forms.Button();
            this.btnHola2 = new System.Windows.Forms.Button();
            this.btnAdeu1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBandol = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHolaOriginal
            // 
            this.btnHolaOriginal.Location = new System.Drawing.Point(27, 49);
            this.btnHolaOriginal.Name = "btnHolaOriginal";
            this.btnHolaOriginal.Size = new System.Drawing.Size(75, 46);
            this.btnHolaOriginal.TabIndex = 0;
            this.btnHolaOriginal.Text = "Salutació Original";
            this.btnHolaOriginal.UseVisualStyleBackColor = true;
            this.btnHolaOriginal.Click += new System.EventHandler(this.btnHolaOriginal_Click);
            // 
            // btnAdeuOriginal
            // 
            this.btnAdeuOriginal.Location = new System.Drawing.Point(368, 49);
            this.btnAdeuOriginal.Name = "btnAdeuOriginal";
            this.btnAdeuOriginal.Size = new System.Drawing.Size(75, 46);
            this.btnAdeuOriginal.TabIndex = 1;
            this.btnAdeuOriginal.Text = "Comiat Original";
            this.btnAdeuOriginal.UseVisualStyleBackColor = true;
            this.btnAdeuOriginal.Click += new System.EventHandler(this.btnAdeuOriginal_Click);
            // 
            // btnHola1
            // 
            this.btnHola1.Location = new System.Drawing.Point(127, 49);
            this.btnHola1.Name = "btnHola1";
            this.btnHola1.Size = new System.Drawing.Size(75, 46);
            this.btnHola1.TabIndex = 2;
            this.btnHola1.Text = "Salutació amb nom";
            this.btnHola1.UseVisualStyleBackColor = true;
            this.btnHola1.Click += new System.EventHandler(this.btnHola1_Click);
            // 
            // btnHola2
            // 
            this.btnHola2.Location = new System.Drawing.Point(230, 42);
            this.btnHola2.Name = "btnHola2";
            this.btnHola2.Size = new System.Drawing.Size(75, 60);
            this.btnHola2.TabIndex = 3;
            this.btnHola2.Text = "Salutació amb nom i bàndol";
            this.btnHola2.UseVisualStyleBackColor = true;
            this.btnHola2.Click += new System.EventHandler(this.btnHola2_Click);
            // 
            // btnAdeu1
            // 
            this.btnAdeu1.Location = new System.Drawing.Point(458, 49);
            this.btnAdeu1.Name = "btnAdeu1";
            this.btnAdeu1.Size = new System.Drawing.Size(75, 46);
            this.btnAdeu1.TabIndex = 4;
            this.btnAdeu1.Text = "Comiat en Anglés";
            this.btnAdeu1.UseVisualStyleBackColor = true;
            this.btnAdeu1.Click += new System.EventHandler(this.btnAdeu1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom:";
            // 
            // cmbBandol
            // 
            this.cmbBandol.FormattingEnabled = true;
            this.cmbBandol.Items.AddRange(new object[] {
            "Rebel Alliance",
            "First Order"});
            this.cmbBandol.Location = new System.Drawing.Point(108, 162);
            this.cmbBandol.Name = "cmbBandol";
            this.cmbBandol.Size = new System.Drawing.Size(121, 21);
            this.cmbBandol.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(108, 126);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(72, 20);
            this.txtNom.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bàndol:";
            // 
            // frmPOO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cmbBandol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdeu1);
            this.Controls.Add(this.btnHola2);
            this.Controls.Add(this.btnHola1);
            this.Controls.Add(this.btnAdeuOriginal);
            this.Controls.Add(this.btnHolaOriginal);
            this.Name = "frmPOO";
            this.Text = "POO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHolaOriginal;
        private System.Windows.Forms.Button btnAdeuOriginal;
        private System.Windows.Forms.Button btnHola1;
        private System.Windows.Forms.Button btnHola2;
        private System.Windows.Forms.Button btnAdeu1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBandol;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
    }
}