
namespace Interfaz_GUI
{
    partial class Venta
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
            this.BtnGenerarVenta = new System.Windows.Forms.Button();
            this.TxtIdVenta = new System.Windows.Forms.TextBox();
            this.LblNVenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEditarDetalle = new System.Windows.Forms.Button();
            this.BtnCargarDetalle = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.CmbNombreClientes = new System.Windows.Forms.ComboBox();
            this.CmbDNICliente = new System.Windows.Forms.ComboBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.BtnBajaDetalle = new System.Windows.Forms.Button();
            this.BtnModificarDetalle = new System.Windows.Forms.Button();
            this.BtnAltaDetalle = new System.Windows.Forms.Button();
            this.Lblsubtotal = new System.Windows.Forms.Label();
            this.LblSubtotalNombre = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.CmbCodArticulo = new System.Windows.Forms.ComboBox();
            this.LblArticulo = new System.Windows.Forms.Label();
            this.CmbNombreArticulo = new System.Windows.Forms.ComboBox();
            this.LblPrecioUnitario = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnVender = new System.Windows.Forms.Button();
            this.BtnCerrarDetalle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelNumeroVenta = new System.Windows.Forms.Label();
            this.LABELCliente = new System.Windows.Forms.Label();
            this.LABELNombreCliente = new System.Windows.Forms.Label();
            this.LABELFechaValor = new System.Windows.Forms.Label();
            this.dataGridViewDV = new System.Windows.Forms.DataGridView();
            this.LABELFecha = new System.Windows.Forms.Label();
            this.LblClienteNombre = new System.Windows.Forms.Label();
            this.labelNumeroVentaNombre = new System.Windows.Forms.Label();
            this.LABELVENTA = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDV)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerarVenta
            // 
            this.BtnGenerarVenta.Location = new System.Drawing.Point(357, 20);
            this.BtnGenerarVenta.Name = "BtnGenerarVenta";
            this.BtnGenerarVenta.Size = new System.Drawing.Size(143, 30);
            this.BtnGenerarVenta.TabIndex = 7;
            this.BtnGenerarVenta.Tag = "Generar Venta";
            this.BtnGenerarVenta.Text = "Generar Venta";
            this.BtnGenerarVenta.UseVisualStyleBackColor = true;
            this.BtnGenerarVenta.Click += new System.EventHandler(this.BtnGenerarVenta_Click);
            // 
            // TxtIdVenta
            // 
            this.TxtIdVenta.Location = new System.Drawing.Point(148, 24);
            this.TxtIdVenta.Name = "TxtIdVenta";
            this.TxtIdVenta.Size = new System.Drawing.Size(71, 22);
            this.TxtIdVenta.TabIndex = 6;
            // 
            // LblNVenta
            // 
            this.LblNVenta.AutoSize = true;
            this.LblNVenta.Location = new System.Drawing.Point(27, 27);
            this.LblNVenta.Name = "LblNVenta";
            this.LblNVenta.Size = new System.Drawing.Size(119, 17);
            this.LblNVenta.TabIndex = 5;
            this.LblNVenta.Tag = "Numero de Venta";
            this.LblNVenta.Text = "Numero de Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEditarDetalle);
            this.groupBox1.Controls.Add(this.BtnCargarDetalle);
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.CmbNombreClientes);
            this.groupBox1.Controls.Add(this.CmbDNICliente);
            this.groupBox1.Controls.Add(this.LblTotal);
            this.groupBox1.Controls.Add(this.LblFecha);
            this.groupBox1.Controls.Add(this.LblCliente);
            this.groupBox1.Location = new System.Drawing.Point(30, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 284);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Venta";
            this.groupBox1.Text = "Venta";
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
            // CmbNombreClientes
            // 
            this.CmbNombreClientes.DisplayMember = "IdCliente";
            this.CmbNombreClientes.FormattingEnabled = true;
            this.CmbNombreClientes.Location = new System.Drawing.Point(222, 52);
            this.CmbNombreClientes.Name = "CmbNombreClientes";
            this.CmbNombreClientes.Size = new System.Drawing.Size(207, 24);
            this.CmbNombreClientes.TabIndex = 6;
            this.CmbNombreClientes.SelectedValueChanged += new System.EventHandler(this.CmbNombreClientes_SelectedValueChanged);
            // 
            // CmbDNICliente
            // 
            this.CmbDNICliente.DisplayMember = "IdCliente";
            this.CmbDNICliente.FormattingEnabled = true;
            this.CmbDNICliente.Location = new System.Drawing.Point(95, 52);
            this.CmbDNICliente.Name = "CmbDNICliente";
            this.CmbDNICliente.Size = new System.Drawing.Size(121, 24);
            this.CmbDNICliente.TabIndex = 5;
            this.CmbDNICliente.SelectedValueChanged += new System.EventHandler(this.CmbDNICliente_SelectedValueChanged);
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
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(6, 55);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(51, 17);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Tag = "Cliente";
            this.LblCliente.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblStock);
            this.groupBox2.Controls.Add(this.BtnBajaDetalle);
            this.groupBox2.Controls.Add(this.BtnModificarDetalle);
            this.groupBox2.Controls.Add(this.BtnAltaDetalle);
            this.groupBox2.Controls.Add(this.Lblsubtotal);
            this.groupBox2.Controls.Add(this.LblSubtotalNombre);
            this.groupBox2.Controls.Add(this.TxtPrecioUnitario);
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.CmbCodArticulo);
            this.groupBox2.Controls.Add(this.LblArticulo);
            this.groupBox2.Controls.Add(this.CmbNombreArticulo);
            this.groupBox2.Controls.Add(this.LblPrecioUnitario);
            this.groupBox2.Controls.Add(this.LblCantidad);
            this.groupBox2.Location = new System.Drawing.Point(30, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 284);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Detalle";
            this.groupBox2.Text = "Detalle";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.BackColor = System.Drawing.SystemColors.Control;
            this.LblStock.Location = new System.Drawing.Point(447, 55);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(0, 17);
            this.LblStock.TabIndex = 18;
            this.LblStock.Tag = "";
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
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(107, 101);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(121, 22);
            this.TxtPrecioUnitario.TabIndex = 14;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(107, 145);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(121, 22);
            this.TxtCantidad.TabIndex = 11;
            // 
            // CmbCodArticulo
            // 
            this.CmbCodArticulo.DisplayMember = "IdCliente";
            this.CmbCodArticulo.FormattingEnabled = true;
            this.CmbCodArticulo.Location = new System.Drawing.Point(107, 52);
            this.CmbCodArticulo.Name = "CmbCodArticulo";
            this.CmbCodArticulo.Size = new System.Drawing.Size(121, 24);
            this.CmbCodArticulo.TabIndex = 12;
            this.CmbCodArticulo.SelectedValueChanged += new System.EventHandler(this.CmbCodArticulo_SelectedValueChanged);
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
            // BtnVender
            // 
            this.BtnVender.Location = new System.Drawing.Point(372, 695);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(128, 34);
            this.BtnVender.TabIndex = 11;
            this.BtnVender.Tag = "Vender";
            this.BtnVender.Text = "Vender";
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // BtnCerrarDetalle
            // 
            this.BtnCerrarDetalle.Location = new System.Drawing.Point(28, 695);
            this.BtnCerrarDetalle.Name = "BtnCerrarDetalle";
            this.BtnCerrarDetalle.Size = new System.Drawing.Size(128, 34);
            this.BtnCerrarDetalle.TabIndex = 10;
            this.BtnCerrarDetalle.Tag = "Cerrar Detalle";
            this.BtnCerrarDetalle.Text = "Cerrar Detalle";
            this.BtnCerrarDetalle.UseVisualStyleBackColor = true;
            this.BtnCerrarDetalle.Click += new System.EventHandler(this.BtnCerrarDetalle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.labelNumeroVenta);
            this.groupBox3.Controls.Add(this.LABELCliente);
            this.groupBox3.Controls.Add(this.LABELNombreCliente);
            this.groupBox3.Controls.Add(this.LABELFechaValor);
            this.groupBox3.Controls.Add(this.dataGridViewDV);
            this.groupBox3.Controls.Add(this.LABELFecha);
            this.groupBox3.Controls.Add(this.LblClienteNombre);
            this.groupBox3.Controls.Add(this.labelNumeroVentaNombre);
            this.groupBox3.Controls.Add(this.LABELVENTA);
            this.groupBox3.Location = new System.Drawing.Point(526, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 635);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "Factura";
            this.groupBox3.Text = "Factura";
            // 
            // labelNumeroVenta
            // 
            this.labelNumeroVenta.AutoSize = true;
            this.labelNumeroVenta.Location = new System.Drawing.Point(183, 125);
            this.labelNumeroVenta.Name = "labelNumeroVenta";
            this.labelNumeroVenta.Size = new System.Drawing.Size(0, 17);
            this.labelNumeroVenta.TabIndex = 8;
            // 
            // LABELCliente
            // 
            this.LABELCliente.AutoSize = true;
            this.LABELCliente.Location = new System.Drawing.Point(120, 184);
            this.LABELCliente.Name = "LABELCliente";
            this.LABELCliente.Size = new System.Drawing.Size(0, 17);
            this.LABELCliente.TabIndex = 7;
            // 
            // LABELNombreCliente
            // 
            this.LABELNombreCliente.AutoSize = true;
            this.LABELNombreCliente.Location = new System.Drawing.Point(227, 184);
            this.LABELNombreCliente.Name = "LABELNombreCliente";
            this.LABELNombreCliente.Size = new System.Drawing.Size(0, 17);
            this.LABELNombreCliente.TabIndex = 6;
            // 
            // LABELFechaValor
            // 
            this.LABELFechaValor.AutoSize = true;
            this.LABELFechaValor.Location = new System.Drawing.Point(120, 249);
            this.LABELFechaValor.Name = "LABELFechaValor";
            this.LABELFechaValor.Size = new System.Drawing.Size(0, 17);
            this.LABELFechaValor.TabIndex = 5;
            // 
            // dataGridViewDV
            // 
            this.dataGridViewDV.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDV.Location = new System.Drawing.Point(30, 322);
            this.dataGridViewDV.Name = "dataGridViewDV";
            this.dataGridViewDV.RowHeadersWidth = 51;
            this.dataGridViewDV.RowTemplate.Height = 24;
            this.dataGridViewDV.Size = new System.Drawing.Size(523, 250);
            this.dataGridViewDV.TabIndex = 4;
            this.dataGridViewDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDV_CellClick);
            // 
            // LABELFecha
            // 
            this.LABELFecha.AutoSize = true;
            this.LABELFecha.Location = new System.Drawing.Point(27, 249);
            this.LABELFecha.Name = "LABELFecha";
            this.LABELFecha.Size = new System.Drawing.Size(47, 17);
            this.LABELFecha.TabIndex = 3;
            this.LABELFecha.Tag = "Fecha";
            this.LABELFecha.Text = "Fecha";
            // 
            // LblClienteNombre
            // 
            this.LblClienteNombre.AutoSize = true;
            this.LblClienteNombre.Location = new System.Drawing.Point(27, 184);
            this.LblClienteNombre.Name = "LblClienteNombre";
            this.LblClienteNombre.Size = new System.Drawing.Size(51, 17);
            this.LblClienteNombre.TabIndex = 2;
            this.LblClienteNombre.Tag = "Cliente";
            this.LblClienteNombre.Text = "Cliente";
            // 
            // labelNumeroVentaNombre
            // 
            this.labelNumeroVentaNombre.AutoSize = true;
            this.labelNumeroVentaNombre.Location = new System.Drawing.Point(27, 125);
            this.labelNumeroVentaNombre.Name = "labelNumeroVentaNombre";
            this.labelNumeroVentaNombre.Size = new System.Drawing.Size(119, 17);
            this.labelNumeroVentaNombre.TabIndex = 1;
            this.labelNumeroVentaNombre.Tag = "Numero de Venta";
            this.labelNumeroVentaNombre.Text = "Numero de Venta";
            // 
            // LABELVENTA
            // 
            this.LABELVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LABELVENTA.Location = new System.Drawing.Point(153, 43);
            this.LABELVENTA.Name = "LABELVENTA";
            this.LABELVENTA.Size = new System.Drawing.Size(84, 33);
            this.LABELVENTA.TabIndex = 0;
            this.LABELVENTA.Tag = "Venta";
            this.LABELVENTA.Text = "Venta";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 764);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnVender);
            this.Controls.Add(this.BtnCerrarDetalle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGenerarVenta);
            this.Controls.Add(this.TxtIdVenta);
            this.Controls.Add(this.LblNVenta);
            this.Name = "Venta";
            this.Text = "Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Venta_FormClosing);
            this.Load += new System.EventHandler(this.Venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarVenta;
        private System.Windows.Forms.TextBox TxtIdVenta;
        private System.Windows.Forms.Label LblNVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEditarDetalle;
        private System.Windows.Forms.Button BtnCargarDetalle;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.ComboBox CmbNombreClientes;
        private System.Windows.Forms.ComboBox CmbDNICliente;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBajaDetalle;
        private System.Windows.Forms.Button BtnModificarDetalle;
        private System.Windows.Forms.Button BtnAltaDetalle;
        private System.Windows.Forms.Label Lblsubtotal;
        private System.Windows.Forms.Label LblSubtotalNombre;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CmbCodArticulo;
        private System.Windows.Forms.Label LblArticulo;
        private System.Windows.Forms.ComboBox CmbNombreArticulo;
        private System.Windows.Forms.Label LblPrecioUnitario;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Button BtnCerrarDetalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewDV;
        private System.Windows.Forms.Label LABELFecha;
        private System.Windows.Forms.Label LblClienteNombre;
        private System.Windows.Forms.Label labelNumeroVentaNombre;
        private System.Windows.Forms.Label LABELVENTA;
        private System.Windows.Forms.Label LABELFechaValor;
        private System.Windows.Forms.Label LABELNombreCliente;
        private System.Windows.Forms.Label LABELCliente;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelNumeroVenta;
    }
}