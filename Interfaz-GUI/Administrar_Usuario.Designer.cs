
namespace Interfaz_GUI
{
    partial class Administrar_Usuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGenerarClave = new System.Windows.Forms.Button();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.CmbIdioma = new System.Windows.Forms.ComboBox();
            this.BtnDesbloquear = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.LblIdioma = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblContraseñaLabel = new System.Windows.Forms.Label();
            this.LblNick = new System.Windows.Forms.Label();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGenerarClave);
            this.groupBox1.Controls.Add(this.LblContraseña);
            this.groupBox1.Controls.Add(this.CmbIdioma);
            this.groupBox1.Controls.Add(this.BtnDesbloquear);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Controls.Add(this.BtnBaja);
            this.groupBox1.Controls.Add(this.BtnAlta);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtNick);
            this.groupBox1.Controls.Add(this.LblIdioma);
            this.groupBox1.Controls.Add(this.LblMail);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.LblContraseñaLabel);
            this.groupBox1.Controls.Add(this.LblNick);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1069, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnGenerarClave
            // 
            this.BtnGenerarClave.Location = new System.Drawing.Point(408, 84);
            this.BtnGenerarClave.Name = "BtnGenerarClave";
            this.BtnGenerarClave.Size = new System.Drawing.Size(150, 30);
            this.BtnGenerarClave.TabIndex = 17;
            this.BtnGenerarClave.Tag = "Generar Contraseña";
            this.BtnGenerarClave.Text = "Generar Contraseña";
            this.BtnGenerarClave.UseVisualStyleBackColor = true;
            this.BtnGenerarClave.Click += new System.EventHandler(this.BtnGenerarClave_Click);
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(164, 84);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(0, 17);
            this.LblContraseña.TabIndex = 16;
            // 
            // CmbIdioma
            // 
            this.CmbIdioma.FormattingEnabled = true;
            this.CmbIdioma.Location = new System.Drawing.Point(167, 231);
            this.CmbIdioma.Name = "CmbIdioma";
            this.CmbIdioma.Size = new System.Drawing.Size(176, 24);
            this.CmbIdioma.TabIndex = 15;
            // 
            // BtnDesbloquear
            // 
            this.BtnDesbloquear.Location = new System.Drawing.Point(945, 30);
            this.BtnDesbloquear.Name = "BtnDesbloquear";
            this.BtnDesbloquear.Size = new System.Drawing.Size(105, 35);
            this.BtnDesbloquear.TabIndex = 14;
            this.BtnDesbloquear.Tag = "Desbloquear";
            this.BtnDesbloquear.Text = "Desbloquear";
            this.BtnDesbloquear.UseVisualStyleBackColor = true;
            this.BtnDesbloquear.Click += new System.EventHandler(this.BtnDesbloquear_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(951, 190);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(99, 35);
            this.BtnModificar.TabIndex = 13;
            this.BtnModificar.Tag = "Modificar";
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(951, 231);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(99, 35);
            this.BtnBaja.TabIndex = 12;
            this.BtnBaja.Tag = "Baja";
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(951, 149);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(99, 35);
            this.BtnAlta.TabIndex = 11;
            this.BtnAlta.Tag = "Alta";
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(167, 177);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(176, 22);
            this.txtMail.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 132);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(176, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(167, 43);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(176, 22);
            this.txtNick.TabIndex = 5;
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Location = new System.Drawing.Point(20, 238);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(49, 17);
            this.LblIdioma.TabIndex = 4;
            this.LblIdioma.Tag = "Idioma";
            this.LblIdioma.Text = "Idioma";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(20, 177);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(33, 17);
            this.LblMail.TabIndex = 3;
            this.LblMail.Tag = "Mail";
            this.LblMail.Text = "Mail";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(20, 132);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Tag = "Nombre";
            this.LblNombre.Text = "Nombre";
            // 
            // LblContraseñaLabel
            // 
            this.LblContraseñaLabel.AutoSize = true;
            this.LblContraseñaLabel.Location = new System.Drawing.Point(20, 84);
            this.LblContraseñaLabel.Name = "LblContraseñaLabel";
            this.LblContraseñaLabel.Size = new System.Drawing.Size(81, 17);
            this.LblContraseñaLabel.TabIndex = 1;
            this.LblContraseñaLabel.Tag = "Contraseña";
            this.LblContraseñaLabel.Text = "Contraseña";
            // 
            // LblNick
            // 
            this.LblNick.AutoSize = true;
            this.LblNick.Location = new System.Drawing.Point(20, 46);
            this.LblNick.Name = "LblNick";
            this.LblNick.Size = new System.Drawing.Size(35, 17);
            this.LblNick.TabIndex = 0;
            this.LblNick.Tag = "Nick";
            this.LblNick.Text = "Nick";
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(24, 317);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.RowHeadersWidth = 51;
            this.dataGridViewUsuario.RowTemplate.Height = 24;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(1069, 360);
            this.dataGridViewUsuario.TabIndex = 1;
            this.dataGridViewUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuario_CellClick);
            // 
            // Administrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 689);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "Administrar_Usuario";
            this.Text = "Administrar_Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDesbloquear;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblContraseñaLabel;
        private System.Windows.Forms.Label LblNick;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Button BtnGenerarClave;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.ComboBox CmbIdioma;
    }
}