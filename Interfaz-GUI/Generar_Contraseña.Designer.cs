
namespace Interfaz_GUI
{
    partial class Generar_Contraseña
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
            this.LblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.groupBoxContraseña = new System.Windows.Forms.GroupBox();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.LblNick = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.groupBoxContraseña.SuspendLayout();
            this.groupBoxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(27, 43);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(81, 17);
            this.LblContraseña.TabIndex = 0;
            this.LblContraseña.Tag = "Contraseña";
            this.LblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(175, 45);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(152, 22);
            this.txtContraseña.TabIndex = 3;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Location = new System.Drawing.Point(30, 112);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(75, 31);
            this.BtnGenerar.TabIndex = 6;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(218, 112);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(133, 31);
            this.BtnConfirmar.TabIndex = 7;
            this.BtnConfirmar.Text = "Confirmar cambio";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // groupBoxContraseña
            // 
            this.groupBoxContraseña.Controls.Add(this.LblContraseña);
            this.groupBoxContraseña.Controls.Add(this.BtnConfirmar);
            this.groupBoxContraseña.Controls.Add(this.BtnGenerar);
            this.groupBoxContraseña.Controls.Add(this.txtContraseña);
            this.groupBoxContraseña.Location = new System.Drawing.Point(441, 39);
            this.groupBoxContraseña.Name = "groupBoxContraseña";
            this.groupBoxContraseña.Size = new System.Drawing.Size(373, 180);
            this.groupBoxContraseña.TabIndex = 8;
            this.groupBoxContraseña.TabStop = false;
            this.groupBoxContraseña.Tag = "Contraseña";
            this.groupBoxContraseña.Text = "Contraseña";
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.BtnVerificar);
            this.groupBoxUsuario.Controls.Add(this.txtMail);
            this.groupBoxUsuario.Controls.Add(this.txtNick);
            this.groupBoxUsuario.Controls.Add(this.LblMail);
            this.groupBoxUsuario.Controls.Add(this.LblNick);
            this.groupBoxUsuario.Location = new System.Drawing.Point(14, 38);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(406, 181);
            this.groupBoxUsuario.TabIndex = 9;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Tag = "Usuario";
            this.groupBoxUsuario.Text = "Usuario";
            // 
            // LblNick
            // 
            this.LblNick.AutoSize = true;
            this.LblNick.Location = new System.Drawing.Point(31, 45);
            this.LblNick.Name = "LblNick";
            this.LblNick.Size = new System.Drawing.Size(35, 17);
            this.LblNick.TabIndex = 0;
            this.LblNick.Tag = "Nick";
            this.LblNick.Text = "Nick";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(33, 95);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(33, 17);
            this.LblMail.TabIndex = 1;
            this.LblMail.Tag = "Mail";
            this.LblMail.Text = "Mail";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(115, 46);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(152, 22);
            this.txtNick.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(115, 95);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 22);
            this.txtMail.TabIndex = 9;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(307, 135);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 31);
            this.BtnVerificar.TabIndex = 8;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // Generar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 262);
            this.Controls.Add(this.groupBoxUsuario);
            this.Controls.Add(this.groupBoxContraseña);
            this.Name = "Generar_Contraseña";
            this.Text = "Generar_Contraseña";
            this.Load += new System.EventHandler(this.Generar_Contraseña_Load);
            this.groupBoxContraseña.ResumeLayout(false);
            this.groupBoxContraseña.PerformLayout();
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.GroupBox groupBoxContraseña;
        private System.Windows.Forms.GroupBox groupBoxUsuario;
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblNick;
    }
}