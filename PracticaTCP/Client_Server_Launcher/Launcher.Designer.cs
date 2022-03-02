
namespace Client_Server_Launcher
{
    partial class Launcher
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
            this.btn_Client = new System.Windows.Forms.Button();
            this.btn_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Client
            // 
            this.btn_Client.Location = new System.Drawing.Point(49, 74);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(133, 75);
            this.btn_Client.TabIndex = 0;
            this.btn_Client.Text = "Client";
            this.btn_Client.UseVisualStyleBackColor = true;
            // 
            // btn_server
            // 
            this.btn_server.Location = new System.Drawing.Point(220, 74);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(133, 75);
            this.btn_server.TabIndex = 1;
            this.btn_server.Text = "Server";
            this.btn_server.UseVisualStyleBackColor = true;
            this.btn_server.Click += new System.EventHandler(this.btn_server_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 213);
            this.Controls.Add(this.btn_server);
            this.Controls.Add(this.btn_Client);
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.Button btn_server;
    }
}

