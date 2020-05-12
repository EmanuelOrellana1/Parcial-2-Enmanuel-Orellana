namespace Parcial_2_Enmanuel_Orellana
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
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblNombrepersona = new System.Windows.Forms.Label();
            this.lblbeneficiario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.Location = new System.Drawing.Point(12, 29);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(180, 29);
            this.btnAdministrador.TabIndex = 0;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(329, 245);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(130, 30);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(193, 190);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(410, 22);
            this.txtConsultar.TabIndex = 2;
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.Location = new System.Drawing.Point(318, 129);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(141, 24);
            this.lblConsultar.TabIndex = 3;
            this.lblConsultar.Text = "Consultar DUI";
            // 
            // lblNombrepersona
            // 
            this.lblNombrepersona.AutoSize = true;
            this.lblNombrepersona.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrepersona.Location = new System.Drawing.Point(74, 345);
            this.lblNombrepersona.Name = "lblNombrepersona";
            this.lblNombrepersona.Size = new System.Drawing.Size(199, 18);
            this.lblNombrepersona.TabIndex = 4;
            this.lblNombrepersona.Text = "NOMBRE DE LA PERSONA";
            // 
            // lblbeneficiario
            // 
            this.lblbeneficiario.AutoSize = true;
            this.lblbeneficiario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbeneficiario.Location = new System.Drawing.Point(341, 345);
            this.lblbeneficiario.Name = "lblbeneficiario";
            this.lblbeneficiario.Size = new System.Drawing.Size(251, 18);
            this.lblbeneficiario.TabIndex = 5;
            this.lblbeneficiario.Text = "ERES BENEFICIADO DE LOS $300";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblbeneficiario);
            this.Controls.Add(this.lblNombrepersona);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAdministrador);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblNombrepersona;
        private System.Windows.Forms.Label lblbeneficiario;
    }
}

