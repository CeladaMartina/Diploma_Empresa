
namespace Interfaz_GUI
{
    partial class Producto
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
            this.LblCodProd = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblMaterial = new System.Windows.Forms.Label();
            this.LblLocalidad = new System.Windows.Forms.Label();
            this.LblTalle = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtCodProd = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.TxtTalle = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.CmbLocalidad = new System.Windows.Forms.ComboBox();
            this.dataGridViewArticulo = new System.Windows.Forms.DataGridView();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnModificacion = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodProd
            // 
            this.LblCodProd.AutoSize = true;
            this.LblCodProd.Location = new System.Drawing.Point(17, 49);
            this.LblCodProd.Name = "LblCodProd";
            this.LblCodProd.Size = new System.Drawing.Size(94, 17);
            this.LblCodProd.TabIndex = 0;
            this.LblCodProd.Tag = "Codigo de Producto";
            this.LblCodProd.Text = "Cod Producto";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(17, 100);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Tag = "Nombre";
            this.LblNombre.Text = "Nombre";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(17, 142);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Tag = "Descripcion";
            this.LblDescripcion.Text = "Descripcion";
            // 
            // LblMaterial
            // 
            this.LblMaterial.AutoSize = true;
            this.LblMaterial.Location = new System.Drawing.Point(17, 187);
            this.LblMaterial.Name = "LblMaterial";
            this.LblMaterial.Size = new System.Drawing.Size(58, 17);
            this.LblMaterial.TabIndex = 3;
            this.LblMaterial.Tag = "Material";
            this.LblMaterial.Text = "Material";
            // 
            // LblLocalidad
            // 
            this.LblLocalidad.AutoSize = true;
            this.LblLocalidad.Location = new System.Drawing.Point(12, 230);
            this.LblLocalidad.Name = "LblLocalidad";
            this.LblLocalidad.Size = new System.Drawing.Size(69, 17);
            this.LblLocalidad.TabIndex = 4;
            this.LblLocalidad.Tag = "Localidad";
            this.LblLocalidad.Text = "Localidad";
            // 
            // LblTalle
            // 
            this.LblTalle.AutoSize = true;
            this.LblTalle.Location = new System.Drawing.Point(17, 274);
            this.LblTalle.Name = "LblTalle";
            this.LblTalle.Size = new System.Drawing.Size(39, 17);
            this.LblTalle.TabIndex = 5;
            this.LblTalle.Tag = "Talle";
            this.LblTalle.Text = "Talle";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(17, 321);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(43, 17);
            this.LblStock.TabIndex = 6;
            this.LblStock.Tag = "Stock";
            this.LblStock.Text = "Stock";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(17, 370);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(48, 17);
            this.LblPrecio.TabIndex = 7;
            this.LblPrecio.Tag = "Precio";
            this.LblPrecio.Text = "Precio";
            // 
            // TxtCodProd
            // 
            this.TxtCodProd.Location = new System.Drawing.Point(135, 44);
            this.TxtCodProd.Name = "TxtCodProd";
            this.TxtCodProd.Size = new System.Drawing.Size(167, 22);
            this.TxtCodProd.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(135, 100);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(167, 22);
            this.TxtNombre.TabIndex = 9;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(135, 142);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(167, 22);
            this.TxtDescripcion.TabIndex = 10;
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Location = new System.Drawing.Point(135, 187);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.Size = new System.Drawing.Size(167, 22);
            this.TxtMaterial.TabIndex = 11;
            // 
            // TxtTalle
            // 
            this.TxtTalle.Location = new System.Drawing.Point(135, 269);
            this.TxtTalle.Name = "TxtTalle";
            this.TxtTalle.Size = new System.Drawing.Size(167, 22);
            this.TxtTalle.TabIndex = 12;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(135, 316);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(167, 22);
            this.TxtStock.TabIndex = 13;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(135, 365);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(167, 22);
            this.TxtPrecio.TabIndex = 14;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // CmbLocalidad
            // 
            this.CmbLocalidad.FormattingEnabled = true;
            this.CmbLocalidad.Location = new System.Drawing.Point(135, 230);
            this.CmbLocalidad.Name = "CmbLocalidad";
            this.CmbLocalidad.Size = new System.Drawing.Size(167, 24);
            this.CmbLocalidad.TabIndex = 15;
            // 
            // dataGridViewArticulo
            // 
            this.dataGridViewArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulo.Location = new System.Drawing.Point(343, 44);
            this.dataGridViewArticulo.Name = "dataGridViewArticulo";
            this.dataGridViewArticulo.RowHeadersWidth = 51;
            this.dataGridViewArticulo.RowTemplate.Height = 24;
            this.dataGridViewArticulo.Size = new System.Drawing.Size(745, 294);
            this.dataGridViewArticulo.TabIndex = 16;
            this.dataGridViewArticulo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticulo_CellClick);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(343, 344);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(90, 46);
            this.BtnAlta.TabIndex = 17;
            this.BtnAlta.Tag = "Alta";
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(550, 344);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(90, 46);
            this.BtnBaja.TabIndex = 18;
            this.BtnBaja.Tag = "Baja";
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnModificacion
            // 
            this.BtnModificacion.Location = new System.Drawing.Point(439, 344);
            this.BtnModificacion.Name = "BtnModificacion";
            this.BtnModificacion.Size = new System.Drawing.Size(105, 46);
            this.BtnModificacion.TabIndex = 19;
            this.BtnModificacion.Tag = "Modificar";
            this.BtnModificacion.Text = "Modificacion";
            this.BtnModificacion.UseVisualStyleBackColor = true;
            this.BtnModificacion.Click += new System.EventHandler(this.BtnModificacion_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Location = new System.Drawing.Point(911, 344);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(177, 46);
            this.BtnReporte.TabIndex = 20;
            this.BtnReporte.Tag = "Baja";
            this.BtnReporte.Text = "Generar Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 410);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnModificacion);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.dataGridViewArticulo);
            this.Controls.Add(this.CmbLocalidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtTalle);
            this.Controls.Add(this.TxtMaterial);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodProd);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.LblTalle);
            this.Controls.Add(this.LblLocalidad);
            this.Controls.Add(this.LblMaterial);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblCodProd);
            this.Name = "Producto";
            this.Tag = "Articulo";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodProd;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblMaterial;
        private System.Windows.Forms.Label LblLocalidad;
        private System.Windows.Forms.Label LblTalle;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtCodProd;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtMaterial;
        private System.Windows.Forms.TextBox TxtTalle;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.ComboBox CmbLocalidad;
        private System.Windows.Forms.DataGridView dataGridViewArticulo;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnModificacion;
        private System.Windows.Forms.Button BtnReporte;
    }
}