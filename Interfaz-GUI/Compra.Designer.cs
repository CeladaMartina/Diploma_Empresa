
namespace Interfaz_GUI
{
    partial class Compra
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
            this.BtnEditarDetalle = new System.Windows.Forms.Button();
            this.BtnCargarDetalle = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.CmbNombreProveedor = new System.Windows.Forms.ComboBox();
            this.CmbCUITProveedor = new System.Windows.Forms.ComboBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBajaDetalle = new System.Windows.Forms.Button();
            this.BtnModificarDetalle = new System.Windows.Forms.Button();
            this.BtnAltaDetalle = new System.Windows.Forms.Button();
            this.Lblsubtotal = new System.Windows.Forms.Label();
            this.LblSubtotalNombre = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.CmbCodProducto = new System.Windows.Forms.ComboBox();
            this.LblArticulo = new System.Windows.Forms.Label();
            this.CmbNombreArticulo = new System.Windows.Forms.ComboBox();
            this.LblPrecioUnitario = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblNCompra = new System.Windows.Forms.Label();
            this.TxtIdCompra = new System.Windows.Forms.TextBox();
            this.BtnGenerarCompra = new System.Windows.Forms.Button();
            this.dataGridViewDC = new System.Windows.Forms.DataGridView();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.BtnDeserializar = new System.Windows.Forms.Button();
            this.BtnCargarNuevoArt = new System.Windows.Forms.Button();
            this.BtnCerrarDetalle = new System.Windows.Forms.Button();
            this.BtnComprar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TxtCantSugerida = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEditarDetalle);
            this.groupBox1.Controls.Add(this.BtnCargarDetalle);
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.CmbNombreProveedor);
            this.groupBox1.Controls.Add(this.CmbCUITProveedor);
            this.groupBox1.Controls.Add(this.LblTotal);
            this.groupBox1.Controls.Add(this.LblFecha);
            this.groupBox1.Controls.Add(this.LblProveedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Compra";
            this.groupBox1.Text = "Compra";
            // 
            // BtnEditarDetalle
            // 
            this.BtnEditarDetalle.Location = new System.Drawing.Point(301, 232);
            this.BtnEditarDetalle.Name = "BtnEditarDetalle";
            this.BtnEditarDetalle.Size = new System.Drawing.Size(128, 34);
            this.BtnEditarDetalle.TabIndex = 9;
            this.BtnEditarDetalle.Tag = "Editar Detalle";
            this.BtnEditarDetalle.Text = "Editar Detalle";
            this.BtnEditarDetalle.UseVisualStyleBackColor = true;
            this.BtnEditarDetalle.Click += new System.EventHandler(this.BtnEditarDetalle_Click);
            // 
            // BtnCargarDetalle
            // 
            this.BtnCargarDetalle.Location = new System.Drawing.Point(9, 232);
            this.BtnCargarDetalle.Name = "BtnCargarDetalle";
            this.BtnCargarDetalle.Size = new System.Drawing.Size(128, 34);
            this.BtnCargarDetalle.TabIndex = 8;
            this.BtnCargarDetalle.Tag = "Cargar Detalle";
            this.BtnCargarDetalle.Text = "Cargar Detalle";
            this.BtnCargarDetalle.UseVisualStyleBackColor = true;
            this.BtnCargarDetalle.Click += new System.EventHandler(this.BtnCargarDetalle_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(95, 145);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(121, 22);
            this.TxtTotal.TabIndex = 5;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(95, 99);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(234, 22);
            this.dateTimePickerFecha.TabIndex = 7;
            // 
            // CmbNombreProveedor
            // 
            this.CmbNombreProveedor.DisplayMember = "IdCliente";
            this.CmbNombreProveedor.FormattingEnabled = true;
            this.CmbNombreProveedor.Location = new System.Drawing.Point(222, 52);
            this.CmbNombreProveedor.Name = "CmbNombreProveedor";
            this.CmbNombreProveedor.Size = new System.Drawing.Size(207, 24);
            this.CmbNombreProveedor.TabIndex = 6;
            this.CmbNombreProveedor.SelectedIndexChanged += new System.EventHandler(this.CmbNombreProveedor_SelectedIndexChanged);
            // 
            // CmbCUITProveedor
            // 
            this.CmbCUITProveedor.DisplayMember = "IdCliente";
            this.CmbCUITProveedor.FormattingEnabled = true;
            this.CmbCUITProveedor.Location = new System.Drawing.Point(95, 52);
            this.CmbCUITProveedor.Name = "CmbCUITProveedor";
            this.CmbCUITProveedor.Size = new System.Drawing.Size(121, 24);
            this.CmbCUITProveedor.TabIndex = 5;
            this.CmbCUITProveedor.SelectedValueChanged += new System.EventHandler(this.CmbCUITProveedor_SelectedValueChanged);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(6, 145);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(40, 17);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Tag = "Total";
            this.LblTotal.Text = "Total";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(6, 99);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(47, 17);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Tag = "Fecha";
            this.LblFecha.Text = "Fecha";
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Location = new System.Drawing.Point(6, 55);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(74, 17);
            this.LblProveedor.TabIndex = 0;
            this.LblProveedor.Tag = "Proveedor";
            this.LblProveedor.Text = "Proveedor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCantSugerida);
            this.groupBox2.Controls.Add(this.BtnBajaDetalle);
            this.groupBox2.Controls.Add(this.BtnModificarDetalle);
            this.groupBox2.Controls.Add(this.BtnAltaDetalle);
            this.groupBox2.Controls.Add(this.Lblsubtotal);
            this.groupBox2.Controls.Add(this.LblSubtotalNombre);
            this.groupBox2.Controls.Add(this.TxtPrecio);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.CmbCodProducto);
            this.groupBox2.Controls.Add(this.LblArticulo);
            this.groupBox2.Controls.Add(this.CmbNombreArticulo);
            this.groupBox2.Controls.Add(this.LblPrecioUnitario);
            this.groupBox2.Controls.Add(this.LblCantidad);
            this.groupBox2.Location = new System.Drawing.Point(506, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Detalle";
            this.groupBox2.Text = "Detalle";
            // 
            // BtnBajaDetalle
            // 
            this.BtnBajaDetalle.Location = new System.Drawing.Point(366, 233);
            this.BtnBajaDetalle.Name = "BtnBajaDetalle";
            this.BtnBajaDetalle.Size = new System.Drawing.Size(88, 34);
            this.BtnBajaDetalle.TabIndex = 17;
            this.BtnBajaDetalle.Tag = "Baja";
            this.BtnBajaDetalle.Text = "Baja";
            this.BtnBajaDetalle.UseVisualStyleBackColor = true;
            this.BtnBajaDetalle.Click += new System.EventHandler(this.BtnBajaDetalle_Click);
            // 
            // BtnModificarDetalle
            // 
            this.BtnModificarDetalle.Location = new System.Drawing.Point(201, 234);
            this.BtnModificarDetalle.Name = "BtnModificarDetalle";
            this.BtnModificarDetalle.Size = new System.Drawing.Size(88, 32);
            this.BtnModificarDetalle.TabIndex = 16;
            this.BtnModificarDetalle.Tag = "Modificar";
            this.BtnModificarDetalle.Text = "Modificar";
            this.BtnModificarDetalle.UseVisualStyleBackColor = true;
            this.BtnModificarDetalle.Click += new System.EventHandler(this.BtnModificarDetalle_Click);
            // 
            // BtnAltaDetalle
            // 
            this.BtnAltaDetalle.Location = new System.Drawing.Point(21, 235);
            this.BtnAltaDetalle.Name = "BtnAltaDetalle";
            this.BtnAltaDetalle.Size = new System.Drawing.Size(88, 32);
            this.BtnAltaDetalle.TabIndex = 5;
            this.BtnAltaDetalle.Tag = "Alta";
            this.BtnAltaDetalle.Text = "Alta";
            this.BtnAltaDetalle.UseVisualStyleBackColor = true;
            this.BtnAltaDetalle.Click += new System.EventHandler(this.BtnAltaDetalle_Click);
            // 
            // Lblsubtotal
            // 
            this.Lblsubtotal.AutoSize = true;
            this.Lblsubtotal.BackColor = System.Drawing.SystemColors.Control;
            this.Lblsubtotal.Location = new System.Drawing.Point(104, 194);
            this.Lblsubtotal.Name = "Lblsubtotal";
            this.Lblsubtotal.Size = new System.Drawing.Size(0, 17);
            this.Lblsubtotal.TabIndex = 15;
            this.Lblsubtotal.Tag = "";
            // 
            // LblSubtotalNombre
            // 
            this.LblSubtotalNombre.AutoSize = true;
            this.LblSubtotalNombre.Location = new System.Drawing.Point(22, 194);
            this.LblSubtotalNombre.Name = "LblSubtotalNombre";
            this.LblSubtotalNombre.Size = new System.Drawing.Size(60, 17);
            this.LblSubtotalNombre.TabIndex = 8;
            this.LblSubtotalNombre.Tag = "Subtotal";
            this.LblSubtotalNombre.Text = "Subtotal";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(107, 101);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(121, 22);
            this.TxtPrecio.TabIndex = 14;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(107, 145);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(121, 22);
            this.TxtCantidad.TabIndex = 11;
            // 
            // CmbCodProducto
            // 
            this.CmbCodProducto.DisplayMember = "IdCliente";
            this.CmbCodProducto.FormattingEnabled = true;
            this.CmbCodProducto.Location = new System.Drawing.Point(107, 52);
            this.CmbCodProducto.Name = "CmbCodProducto";
            this.CmbCodProducto.Size = new System.Drawing.Size(121, 24);
            this.CmbCodProducto.TabIndex = 12;
            this.CmbCodProducto.SelectedValueChanged += new System.EventHandler(this.CmbCodProducto_SelectedValueChanged);
            // 
            // LblArticulo
            // 
            this.LblArticulo.AutoSize = true;
            this.LblArticulo.Location = new System.Drawing.Point(18, 55);
            this.LblArticulo.Name = "LblArticulo";
            this.LblArticulo.Size = new System.Drawing.Size(65, 17);
            this.LblArticulo.TabIndex = 8;
            this.LblArticulo.Tag = "Articulo";
            this.LblArticulo.Text = "Producto";
            // 
            // CmbNombreArticulo
            // 
            this.CmbNombreArticulo.DisplayMember = "IdCliente";
            this.CmbNombreArticulo.FormattingEnabled = true;
            this.CmbNombreArticulo.Location = new System.Drawing.Point(234, 52);
            this.CmbNombreArticulo.Name = "CmbNombreArticulo";
            this.CmbNombreArticulo.Size = new System.Drawing.Size(207, 24);
            this.CmbNombreArticulo.TabIndex = 13;
            this.CmbNombreArticulo.SelectedValueChanged += new System.EventHandler(this.CmbNombreArticulo_SelectedValueChanged);
            // 
            // LblPrecioUnitario
            // 
            this.LblPrecioUnitario.AutoSize = true;
            this.LblPrecioUnitario.Location = new System.Drawing.Point(18, 99);
            this.LblPrecioUnitario.Name = "LblPrecioUnitario";
            this.LblPrecioUnitario.Size = new System.Drawing.Size(48, 17);
            this.LblPrecioUnitario.TabIndex = 9;
            this.LblPrecioUnitario.Tag = "Precio";
            this.LblPrecioUnitario.Text = "Precio";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(18, 145);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(64, 17);
            this.LblCantidad.TabIndex = 10;
            this.LblCantidad.Tag = "Cantidad";
            this.LblCantidad.Text = "Cantidad";
            // 
            // LblNCompra
            // 
            this.LblNCompra.AutoSize = true;
            this.LblNCompra.Location = new System.Drawing.Point(45, 23);
            this.LblNCompra.Name = "LblNCompra";
            this.LblNCompra.Size = new System.Drawing.Size(104, 17);
            this.LblNCompra.TabIndex = 2;
            this.LblNCompra.Tag = "Numero de Compra";
            this.LblNCompra.Text = "Nro de Compra";
            // 
            // TxtIdCompra
            // 
            this.TxtIdCompra.Location = new System.Drawing.Point(166, 20);
            this.TxtIdCompra.Name = "TxtIdCompra";
            this.TxtIdCompra.Size = new System.Drawing.Size(71, 22);
            this.TxtIdCompra.TabIndex = 3;
            // 
            // BtnGenerarCompra
            // 
            this.BtnGenerarCompra.Location = new System.Drawing.Point(438, 20);
            this.BtnGenerarCompra.Name = "BtnGenerarCompra";
            this.BtnGenerarCompra.Size = new System.Drawing.Size(143, 30);
            this.BtnGenerarCompra.TabIndex = 4;
            this.BtnGenerarCompra.Tag = "Generar Compra";
            this.BtnGenerarCompra.Text = "Generar Compra";
            this.BtnGenerarCompra.UseVisualStyleBackColor = true;
            this.BtnGenerarCompra.Click += new System.EventHandler(this.BtnGenerarCompra_Click);
            // 
            // dataGridViewDC
            // 
            this.dataGridViewDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDC.Location = new System.Drawing.Point(506, 376);
            this.dataGridViewDC.Name = "dataGridViewDC";
            this.dataGridViewDC.RowHeadersWidth = 51;
            this.dataGridViewDC.RowTemplate.Height = 24;
            this.dataGridViewDC.Size = new System.Drawing.Size(482, 348);
            this.dataGridViewDC.TabIndex = 5;
            this.dataGridViewDC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDC_CellClick);
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Location = new System.Drawing.Point(12, 415);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.RowHeadersWidth = 51;
            this.dataGridViewPedido.RowTemplate.Height = 24;
            this.dataGridViewPedido.Size = new System.Drawing.Size(470, 424);
            this.dataGridViewPedido.TabIndex = 6;
            this.dataGridViewPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedido_CellClick);
            // 
            // BtnDeserializar
            // 
            this.BtnDeserializar.Location = new System.Drawing.Point(12, 375);
            this.BtnDeserializar.Name = "BtnDeserializar";
            this.BtnDeserializar.Size = new System.Drawing.Size(128, 34);
            this.BtnDeserializar.TabIndex = 10;
            this.BtnDeserializar.Tag = "Traer Pedido";
            this.BtnDeserializar.Text = "Traer Pedido";
            this.BtnDeserializar.UseVisualStyleBackColor = true;
            this.BtnDeserializar.Click += new System.EventHandler(this.BtnDeserializar_Click);
            // 
            // BtnCargarNuevoArt
            // 
            this.BtnCargarNuevoArt.Location = new System.Drawing.Point(506, 781);
            this.BtnCargarNuevoArt.Name = "BtnCargarNuevoArt";
            this.BtnCargarNuevoArt.Size = new System.Drawing.Size(179, 34);
            this.BtnCargarNuevoArt.TabIndex = 11;
            this.BtnCargarNuevoArt.Tag = "Cargar Nuevo Articulo";
            this.BtnCargarNuevoArt.Text = "Cargar Nuevo Producto";
            this.BtnCargarNuevoArt.UseVisualStyleBackColor = true;
            this.BtnCargarNuevoArt.Click += new System.EventHandler(this.BtnCargarNuevoArt_Click);
            // 
            // BtnCerrarDetalle
            // 
            this.BtnCerrarDetalle.Location = new System.Drawing.Point(506, 741);
            this.BtnCerrarDetalle.Name = "BtnCerrarDetalle";
            this.BtnCerrarDetalle.Size = new System.Drawing.Size(128, 34);
            this.BtnCerrarDetalle.TabIndex = 12;
            this.BtnCerrarDetalle.Tag = "Cerrar Detalle";
            this.BtnCerrarDetalle.Text = "Cerrar Detalle";
            this.BtnCerrarDetalle.UseVisualStyleBackColor = true;
            this.BtnCerrarDetalle.Click += new System.EventHandler(this.BtnCerrarDetalle_Click);
            // 
            // BtnComprar
            // 
            this.BtnComprar.Location = new System.Drawing.Point(860, 744);
            this.BtnComprar.Name = "BtnComprar";
            this.BtnComprar.Size = new System.Drawing.Size(128, 34);
            this.BtnComprar.TabIndex = 13;
            this.BtnComprar.Tag = "Comprar";
            this.BtnComprar.Text = "Comprar";
            this.BtnComprar.UseVisualStyleBackColor = true;
            this.BtnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // TxtCantSugerida
            // 
            this.TxtCantSugerida.BackColor = System.Drawing.Color.White;
            this.TxtCantSugerida.Enabled = false;
            this.TxtCantSugerida.Location = new System.Drawing.Point(234, 145);
            this.TxtCantSugerida.Name = "TxtCantSugerida";
            this.TxtCantSugerida.Size = new System.Drawing.Size(100, 22);
            this.TxtCantSugerida.TabIndex = 18;
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 851);
            this.Controls.Add(this.BtnComprar);
            this.Controls.Add(this.BtnCerrarDetalle);
            this.Controls.Add(this.BtnCargarNuevoArt);
            this.Controls.Add(this.BtnDeserializar);
            this.Controls.Add(this.dataGridViewPedido);
            this.Controls.Add(this.dataGridViewDC);
            this.Controls.Add(this.BtnGenerarCompra);
            this.Controls.Add(this.TxtIdCompra);
            this.Controls.Add(this.LblNCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Compra";
            this.Text = "Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compra_FormClosing);
            this.Load += new System.EventHandler(this.Compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEditarDetalle;
        private System.Windows.Forms.Button BtnCargarDetalle;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.ComboBox CmbNombreProveedor;
        private System.Windows.Forms.ComboBox CmbCUITProveedor;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBajaDetalle;
        private System.Windows.Forms.Button BtnModificarDetalle;
        private System.Windows.Forms.Button BtnAltaDetalle;
        private System.Windows.Forms.Label Lblsubtotal;
        private System.Windows.Forms.Label LblSubtotalNombre;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CmbCodProducto;
        private System.Windows.Forms.Label LblArticulo;
        private System.Windows.Forms.ComboBox CmbNombreArticulo;
        private System.Windows.Forms.Label LblPrecioUnitario;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblNCompra;
        private System.Windows.Forms.TextBox TxtIdCompra;
        private System.Windows.Forms.Button BtnGenerarCompra;
        private System.Windows.Forms.DataGridView dataGridViewDC;
        private System.Windows.Forms.Button BtnDeserializar;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Button BtnCargarNuevoArt;
        private System.Windows.Forms.Button BtnCerrarDetalle;
        private System.Windows.Forms.Button BtnComprar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TxtCantSugerida;
    }
}