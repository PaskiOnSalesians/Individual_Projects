namespace PracticaRSA
{
    partial class frmEncriptar
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
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.tbx_pubkey = new System.Windows.Forms.TextBox();
            this.btn_showKey = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.tbx_original = new System.Windows.Forms.TextBox();
            this.tbx_crypted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_obtainKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(409, 70);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(78, 23);
            this.btn_encrypt.TabIndex = 34;
            this.btn_encrypt.Text = "Encriptar";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // tbx_pubkey
            // 
            this.tbx_pubkey.Location = new System.Drawing.Point(25, 183);
            this.tbx_pubkey.Multiline = true;
            this.tbx_pubkey.Name = "tbx_pubkey";
            this.tbx_pubkey.Size = new System.Drawing.Size(460, 145);
            this.tbx_pubkey.TabIndex = 33;
            // 
            // btn_showKey
            // 
            this.btn_showKey.Location = new System.Drawing.Point(25, 154);
            this.btn_showKey.Name = "btn_showKey";
            this.btn_showKey.Size = new System.Drawing.Size(84, 23);
            this.btn_showKey.TabIndex = 32;
            this.btn_showKey.Text = "Mostrar clau";
            this.btn_showKey.UseVisualStyleBackColor = true;
            this.btn_showKey.Click += new System.EventHandler(this.btn_showKey_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(409, 110);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(78, 23);
            this.btn_send.TabIndex = 27;
            this.btn_send.Text = "Enviar";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tbx_original
            // 
            this.tbx_original.Location = new System.Drawing.Point(115, 72);
            this.tbx_original.Name = "tbx_original";
            this.tbx_original.Size = new System.Drawing.Size(288, 20);
            this.tbx_original.TabIndex = 31;
            // 
            // tbx_crypted
            // 
            this.tbx_crypted.Location = new System.Drawing.Point(115, 110);
            this.tbx_crypted.Name = "tbx_crypted";
            this.tbx_crypted.Size = new System.Drawing.Size(288, 20);
            this.tbx_crypted.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Missatge original";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Missatge encriptat";
            // 
            // btn_obtainKey
            // 
            this.btn_obtainKey.Location = new System.Drawing.Point(25, 28);
            this.btn_obtainKey.Name = "btn_obtainKey";
            this.btn_obtainKey.Size = new System.Drawing.Size(95, 23);
            this.btn_obtainKey.TabIndex = 26;
            this.btn_obtainKey.Text = "Obtenir clau";
            this.btn_obtainKey.UseVisualStyleBackColor = true;
            this.btn_obtainKey.Click += new System.EventHandler(this.btn_obtainKey_Click);
            // 
            // frmEncriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.tbx_pubkey);
            this.Controls.Add(this.btn_showKey);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tbx_original);
            this.Controls.Add(this.tbx_crypted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_obtainKey);
            this.Name = "frmEncriptar";
            this.Text = "Encriptar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.TextBox tbx_pubkey;
        private System.Windows.Forms.Button btn_showKey;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox tbx_original;
        private System.Windows.Forms.TextBox tbx_crypted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_obtainKey;
    }
}

