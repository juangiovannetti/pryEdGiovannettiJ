namespace pryEdGiovannettiJ
{
    partial class frmDatosDelDesarrollador
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEstructuraDatos = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(98, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Juan Ignacio Giovannetti";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(98, 156);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(55, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "47265824";
            // 
            // lblEstructuraDatos
            // 
            this.lblEstructuraDatos.AutoSize = true;
            this.lblEstructuraDatos.Location = new System.Drawing.Point(98, 191);
            this.lblEstructuraDatos.Name = "lblEstructuraDatos";
            this.lblEstructuraDatos.Size = new System.Drawing.Size(101, 13);
            this.lblEstructuraDatos.TabIndex = 2;
            this.lblEstructuraDatos.Text = "Estructura de Datos";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Location = new System.Drawing.Point(38, 121);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(44, 13);
            this.lblNombreApellido.TabIndex = 3;
            this.lblNombreApellido.Text = "Nombre";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(41, 155);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(26, 13);
            this.lblDocumento.TabIndex = 4;
            this.lblDocumento.Text = "DNI";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(41, 190);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 5;
            this.lblMateria.Text = "Materia";
            // 
            // frmDatosDelDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.lblEstructuraDatos);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmDatosDelDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatosDelDesarrollador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEstructuraDatos;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblMateria;
    }
}