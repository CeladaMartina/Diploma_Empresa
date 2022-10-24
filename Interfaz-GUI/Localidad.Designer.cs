
namespace Interfaz_GUI
{
    partial class Localidad
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblCodPostal = new System.Windows.Forms.Label();
            this.LblPartido = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCodPostal = new System.Windows.Forms.TextBox();
            this.TxtPartido = new System.Windows.Forms.TextBox();
            this.dataGridViewLocalidad = new System.Windows.Forms.DataGridView();
            this.BtnModificacion = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(36, 22);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Tag = "Nombre";
            this.LblNombre.Text = "Nombre";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(36, 70);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.LblDescripcion.TabIndex = 1;
            this.LblDescripcion.Tag = "Descripcion";
            this.LblDescripcion.Text = "Descripcion";
            // 
            // LblCodPostal
            // 
            this.LblCodPostal.AutoSize = true;
            this.LblCodPostal.Location = new System.Drawing.Point(38, 115);
            this.LblCodPostal.Name = "LblCodPostal";
            this.LblCodPostal.Size = new System.Drawing.Size(80, 17);
            this.LblCodPostal.TabIndex = 2;
            this.LblCodPostal.Tag = "Codigo Postal";
            this.LblCodPostal.Text = "Cod Postal ";
            // 
            // LblPartido
            // 
            this.LblPartido.AutoSize = true;
            this.LblPartido.Location = new System.Drawing.Point(38, 152);
            this.LblPartido.Name = "LblPartido";
            this.LblPartido.Size = new System.Drawing.Size(53, 17);
            this.LblPartido.TabIndex = 3;
            this.LblPartido.Tag = "Partido";
            this.LblPartido.Text = "Partido";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(152, 22);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(158, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(152, 70);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(158, 22);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // TxtCodPostal
            // 
            this.TxtCodPostal.Location = new System.Drawing.Point(152, 112);
            this.TxtCodPostal.Name = "TxtCodPostal";
            this.TxtCodPostal.Size = new System.Drawing.Size(158, 22);
            this.TxtCodPostal.TabIndex = 6;
            // 
            // TxtPartido
            // 
            this.TxtPartido.Location = new System.Drawing.Point(152, 152);
            this.TxtPartido.Name = "TxtPartido";
            this.TxtPartido.Size = new System.Drawing.Size(158, 22);
            this.TxtPartido.TabIndex = 7;
            // 
            // dataGridViewLocalidad
            // 
            this.dataGridViewLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalidad.Location = new System.Drawing.Point(353, 19);
            this.dataGridViewLocalidad.Name = "dataGridViewLocalidad";
            this.dataGridViewLocalidad.RowHeadersWidth = 51;
            this.dataGridViewLocalidad.RowTemplate.Height = 24;
            this.dataGridViewLocalidad.Size = new System.Drawing.Size(817, 224);
            this.dataGridViewLocalidad.TabIndex = 8;
            this.dataGridViewLocalidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocalidad_CellClick);
            // 
            // BtnModificacion
            // 
            this.BtnModificacion.Location = new System.Drawing.Point(115, 211);
            this.BtnModificacion.Name = "BtnModificacion";
            this.BtnModificacion.Size = new System.Drawing.Size(114, 31);
            this.BtnModificacion.TabIndex = 22;
            this.BtnModificacion.Tag = "Modificar";
            this.BtnModificacion.Text = "Modificacion";
            this.BtnModificacion.UseVisualStyleBackColor = true;
            this.BtnModificacion.Click += new System.EventHandler(this.BtnModificacion_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(235, 211);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(98, 32);
            this.BtnBaja.TabIndex = 21;
            this.BtnBaja.Tag = "Baja";
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(11, 211);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(98, 29);
            this.BtnAlta.TabIndex = 20;
            this.BtnAlta.Tag = "Alta";
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // Localidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 261);
            this.Controls.Add(this.BtnModificacion);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.dataGridViewLocalidad);
            this.Controls.Add(this.TxtPartido);
            this.Controls.Add(this.TxtCodPostal);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblPartido);
            this.Controls.Add(this.LblCodPostal);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Name = "Localidad";
            this.Tag = "Localidad";
            this.Text = "Localidad";
            this.Load += new System.EventHandler(this.Localidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblCodPostal;
        private System.Windows.Forms.Label LblPartido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCodPostal;
        private System.Windows.Forms.TextBox TxtPartido;
        private System.Windows.Forms.DataGridView dataGridViewLocalidad;
        private System.Windows.Forms.Button BtnModificacion;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnAlta;
    }
}