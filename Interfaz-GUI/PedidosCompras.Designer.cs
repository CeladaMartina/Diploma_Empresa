
namespace Interfaz_GUI
{
    partial class PedidosCompras
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
            this.LblArticulo = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.CmbCodProducto = new System.Windows.Forms.ComboBox();
            this.CmbNombreArticulo = new System.Windows.Forms.ComboBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.dataGridViewPedido = new System.Windows.Forms.DataGridView();
            this.BtnCerrarPedido = new System.Windows.Forms.Button();
            this.btnPedidosViejos = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // LblArticulo
            // 
            this.LblArticulo.AutoSize = true;
            this.LblArticulo.Location = new System.Drawing.Point(43, 41);
            this.LblArticulo.Name = "LblArticulo";
            this.LblArticulo.Size = new System.Drawing.Size(55, 17);
            this.LblArticulo.TabIndex = 0;
            this.LblArticulo.Tag = "Articulo";
            this.LblArticulo.Text = "Articulo";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(43, 82);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(64, 17);
            this.LblCantidad.TabIndex = 1;
            this.LblCantidad.Tag = "Cantidad";
            this.LblCantidad.Text = "Cantidad";
            // 
            // CmbCodProducto
            // 
            this.CmbCodProducto.FormattingEnabled = true;
            this.CmbCodProducto.Location = new System.Drawing.Point(143, 34);
            this.CmbCodProducto.Name = "CmbCodProducto";
            this.CmbCodProducto.Size = new System.Drawing.Size(134, 24);
            this.CmbCodProducto.TabIndex = 2;
            this.CmbCodProducto.SelectedValueChanged += new System.EventHandler(this.CmbCodProducto_SelectedValueChanged);
            // 
            // CmbNombreArticulo
            // 
            this.CmbNombreArticulo.FormattingEnabled = true;
            this.CmbNombreArticulo.Location = new System.Drawing.Point(283, 34);
            this.CmbNombreArticulo.Name = "CmbNombreArticulo";
            this.CmbNombreArticulo.Size = new System.Drawing.Size(166, 24);
            this.CmbNombreArticulo.TabIndex = 3;
            this.CmbNombreArticulo.SelectedValueChanged += new System.EventHandler(this.CmbNombreArticulo_SelectedValueChanged);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(143, 77);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 22);
            this.TxtCantidad.TabIndex = 4;
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(46, 137);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(93, 33);
            this.BtnAlta.TabIndex = 5;
            this.BtnAlta.Tag = "Alta";
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(143, 137);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(93, 33);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Tag = "Modificar";
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(244, 137);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(93, 33);
            this.BtnBaja.TabIndex = 7;
            this.BtnBaja.Tag = "Borrar";
            this.BtnBaja.Text = "Borrar";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // dataGridViewPedido
            // 
            this.dataGridViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedido.Location = new System.Drawing.Point(46, 189);
            this.dataGridViewPedido.Name = "dataGridViewPedido";
            this.dataGridViewPedido.RowHeadersWidth = 51;
            this.dataGridViewPedido.RowTemplate.Height = 24;
            this.dataGridViewPedido.Size = new System.Drawing.Size(633, 525);
            this.dataGridViewPedido.TabIndex = 8;
            this.dataGridViewPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedido_CellClick);
            // 
            // BtnCerrarPedido
            // 
            this.BtnCerrarPedido.Location = new System.Drawing.Point(706, 190);
            this.BtnCerrarPedido.Name = "BtnCerrarPedido";
            this.BtnCerrarPedido.Size = new System.Drawing.Size(99, 62);
            this.BtnCerrarPedido.TabIndex = 9;
            this.BtnCerrarPedido.Tag = "Cerrar Pedido";
            this.BtnCerrarPedido.Text = "Cerrar Pedido";
            this.BtnCerrarPedido.UseVisualStyleBackColor = true;
            this.BtnCerrarPedido.Click += new System.EventHandler(this.BtnCerrarPedido_Click);
            // 
            // btnPedidosViejos
            // 
            this.btnPedidosViejos.Location = new System.Drawing.Point(706, 286);
            this.btnPedidosViejos.Name = "btnPedidosViejos";
            this.btnPedidosViejos.Size = new System.Drawing.Size(99, 62);
            this.btnPedidosViejos.TabIndex = 10;
            this.btnPedidosViejos.Tag = "Mostrar pedidos cerrados";
            this.btnPedidosViejos.Text = "Mostrar pedidos cerrados";
            this.btnPedidosViejos.UseVisualStyleBackColor = true;
            this.btnPedidosViejos.Click += new System.EventHandler(this.btnPedidosViejos_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(706, 381);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(99, 62);
            this.BtnImprimir.TabIndex = 11;
            this.BtnImprimir.Tag = "Imprimir en PDF";
            this.BtnImprimir.Text = "Imprimir en PDF";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // PedidosCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 726);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.btnPedidosViejos);
            this.Controls.Add(this.BtnCerrarPedido);
            this.Controls.Add(this.dataGridViewPedido);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.CmbNombreArticulo);
            this.Controls.Add(this.CmbCodProducto);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblArticulo);
            this.Name = "PedidosCompras";
            this.Text = "PedidosCompras";
            this.Load += new System.EventHandler(this.PedidosCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblArticulo;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.ComboBox CmbCodProducto;
        private System.Windows.Forms.ComboBox CmbNombreArticulo;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.DataGridView dataGridViewPedido;
        private System.Windows.Forms.Button BtnCerrarPedido;
        private System.Windows.Forms.Button btnPedidosViejos;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}