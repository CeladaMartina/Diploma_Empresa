
namespace Interfaz_GUI
{
    partial class ConexionBD
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
            this.gbConexion = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.NombreBD = new System.Windows.Forms.Label();
            this.UsuariosServidor = new System.Windows.Forms.Label();
            this.UsuarioBase = new System.Windows.Forms.TextBox();
            this.UsuarioServidor = new System.Windows.Forms.TextBox();
            this.gbConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConexion
            // 
            this.gbConexion.Controls.Add(this.btnCancelar);
            this.gbConexion.Controls.Add(this.btnAceptar);
            this.gbConexion.Controls.Add(this.NombreBD);
            this.gbConexion.Controls.Add(this.UsuariosServidor);
            this.gbConexion.Controls.Add(this.UsuarioBase);
            this.gbConexion.Controls.Add(this.UsuarioServidor);
            this.gbConexion.Location = new System.Drawing.Point(46, 48);
            this.gbConexion.Name = "gbConexion";
            this.gbConexion.Size = new System.Drawing.Size(514, 311);
            this.gbConexion.TabIndex = 1;
            this.gbConexion.TabStop = false;
            this.gbConexion.Tag = "Conexion";
            this.gbConexion.Text = "Conexion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(274, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Tag = "Cancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(121, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Tag = "Aceptar";
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // NombreBD
            // 
            this.NombreBD.AutoSize = true;
            this.NombreBD.Location = new System.Drawing.Point(35, 149);
            this.NombreBD.Name = "NombreBD";
            this.NombreBD.Size = new System.Drawing.Size(172, 17);
            this.NombreBD.TabIndex = 3;
            this.NombreBD.Tag = "NombreBD";
            this.NombreBD.Text = "Nombre de base de datos";
            // 
            // UsuariosServidor
            // 
            this.UsuariosServidor.AutoSize = true;
            this.UsuariosServidor.Location = new System.Drawing.Point(35, 80);
            this.UsuariosServidor.Name = "UsuariosServidor";
            this.UsuariosServidor.Size = new System.Drawing.Size(154, 17);
            this.UsuariosServidor.TabIndex = 2;
            this.UsuariosServidor.Tag = "UsuariosServidor";
            this.UsuariosServidor.Text = "Usuarios en el servidor";
            // 
            // UsuarioBase
            // 
            this.UsuarioBase.Location = new System.Drawing.Point(250, 146);
            this.UsuarioBase.Name = "UsuarioBase";
            this.UsuarioBase.Size = new System.Drawing.Size(173, 22);
            this.UsuarioBase.TabIndex = 1;
            this.UsuarioBase.Tag = "UsuarioBase";
            // 
            // UsuarioServidor
            // 
            this.UsuarioServidor.Location = new System.Drawing.Point(251, 77);
            this.UsuarioServidor.Name = "UsuarioServidor";
            this.UsuarioServidor.Size = new System.Drawing.Size(173, 22);
            this.UsuarioServidor.TabIndex = 0;
            this.UsuarioServidor.Tag = "UsuarioServidor";
            // 
            // ConexionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 409);
            this.Controls.Add(this.gbConexion);
            this.Name = "ConexionBD";
            this.Text = "ConexionBD";
            this.Load += new System.EventHandler(this.ConexionBD_Load);
            this.gbConexion.ResumeLayout(false);
            this.gbConexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConexion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label NombreBD;
        private System.Windows.Forms.Label UsuariosServidor;
        private System.Windows.Forms.TextBox UsuarioBase;
        private System.Windows.Forms.TextBox UsuarioServidor;
    }
}