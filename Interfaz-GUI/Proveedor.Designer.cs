
namespace Interfaz_GUI
{
    partial class Proveedor
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
            this.LblCUIT = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblFechaNac = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecNac = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.dataGridViewProveedor = new System.Windows.Forms.DataGridView();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnControlCambio = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.dateTimePickerFecNac);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCUIT);
            this.groupBox1.Controls.Add(this.LblMail);
            this.groupBox1.Controls.Add(this.LblTelefono);
            this.groupBox1.Controls.Add(this.LblFechaNac);
            this.groupBox1.Controls.Add(this.LblApellido);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Controls.Add(this.LblCUIT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblCUIT
            // 
            this.LblCUIT.AutoSize = true;
            this.LblCUIT.Location = new System.Drawing.Point(32, 46);
            this.LblCUIT.Name = "LblCUIT";
            this.LblCUIT.Size = new System.Drawing.Size(39, 17);
            this.LblCUIT.TabIndex = 0;
            this.LblCUIT.Tag = "CUIT";
            this.LblCUIT.Text = "CUIT";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(32, 96);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Tag = "Nombre";
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Location = new System.Drawing.Point(32, 149);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(58, 17);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Tag = "Apellido";
            this.LblApellido.Text = "Apellido";
            // 
            // LblFechaNac
            // 
            this.LblFechaNac.AutoSize = true;
            this.LblFechaNac.Location = new System.Drawing.Point(32, 212);
            this.LblFechaNac.Name = "LblFechaNac";
            this.LblFechaNac.Size = new System.Drawing.Size(141, 17);
            this.LblFechaNac.TabIndex = 3;
            this.LblFechaNac.Tag = "Fecha de Nacimiento";
            this.LblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(32, 271);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(64, 17);
            this.LblTelefono.TabIndex = 4;
            this.LblTelefono.Tag = "Telefono";
            this.LblTelefono.Text = "Telefono";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(38, 320);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(33, 17);
            this.LblMail.TabIndex = 5;
            this.LblMail.Tag = "Mail";
            this.LblMail.Text = "Mail";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(142, 46);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(185, 22);
            this.txtCUIT.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(142, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(142, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 22);
            this.txtApellido.TabIndex = 8;
            // 
            // dateTimePickerFecNac
            // 
            this.dateTimePickerFecNac.Location = new System.Drawing.Point(196, 207);
            this.dateTimePickerFecNac.Name = "dateTimePickerFecNac";
            this.dateTimePickerFecNac.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFecNac.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(142, 266);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(185, 22);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(142, 315);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(185, 22);
            this.txtMail.TabIndex = 11;
            // 
            // dataGridViewProveedor
            // 
            this.dataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedor.Location = new System.Drawing.Point(467, 12);
            this.dataGridViewProveedor.Name = "dataGridViewProveedor";
            this.dataGridViewProveedor.RowHeadersWidth = 51;
            this.dataGridViewProveedor.RowTemplate.Height = 24;
            this.dataGridViewProveedor.Size = new System.Drawing.Size(736, 361);
            this.dataGridViewProveedor.TabIndex = 1;
            this.dataGridViewProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProveedor_CellClick);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(12, 389);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(110, 32);
            this.BtnAlta.TabIndex = 2;
            this.BtnAlta.Tag = "Alta";
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(185, 389);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(110, 32);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Tag = "Modificacion";
            this.BtnModificar.Text = "Modificacion";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(351, 389);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(110, 32);
            this.BtnBaja.TabIndex = 4;
            this.BtnBaja.Tag = "Baja";
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnControlCambio
            // 
            this.BtnControlCambio.Location = new System.Drawing.Point(1050, 389);
            this.BtnControlCambio.Name = "BtnControlCambio";
            this.BtnControlCambio.Size = new System.Drawing.Size(153, 32);
            this.BtnControlCambio.TabIndex = 5;
            this.BtnControlCambio.Tag = "Control de cambios";
            this.BtnControlCambio.Text = "Control de cambios";
            this.BtnControlCambio.UseVisualStyleBackColor = true;
            this.BtnControlCambio.Click += new System.EventHandler(this.BtnControlCambio_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 448);
            this.Controls.Add(this.BtnControlCambio);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.dataGridViewProveedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecNac;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblFechaNac;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCUIT;
        private System.Windows.Forms.DataGridView dataGridViewProveedor;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnControlCambio;
    }
}