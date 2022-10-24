
namespace Interfaz_GUI
{
    partial class VisualizarCompra
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
            this.LblFiltrar = new System.Windows.Forms.Label();
            this.groupBoxMonto = new System.Windows.Forms.GroupBox();
            this.TxtHasta = new System.Windows.Forms.TextBox();
            this.TxtDesde = new System.Windows.Forms.TextBox();
            this.LblHastaM = new System.Windows.Forms.Label();
            this.LblDesdeM = new System.Windows.Forms.Label();
            this.groupBoxRangoFecha = new System.Windows.Forms.GroupBox();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.LblHasta = new System.Windows.Forms.Label();
            this.LblDesde = new System.Windows.Forms.Label();
            this.groupBoxProveedor = new System.Windows.Forms.GroupBox();
            this.comboBoxProveedorCUIT = new System.Windows.Forms.ComboBox();
            this.LblCUIT = new System.Windows.Forms.Label();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnCancelarFiltro = new System.Windows.Forms.Button();
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.groupBoxMonto.SuspendLayout();
            this.groupBoxRangoFecha.SuspendLayout();
            this.groupBoxProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFiltrar
            // 
            this.LblFiltrar.AutoSize = true;
            this.LblFiltrar.Location = new System.Drawing.Point(27, 28);
            this.LblFiltrar.Name = "LblFiltrar";
            this.LblFiltrar.Size = new System.Drawing.Size(69, 17);
            this.LblFiltrar.TabIndex = 0;
            this.LblFiltrar.Tag = "Filtrar por";
            this.LblFiltrar.Text = "Filtrar por";
            // 
            // groupBoxMonto
            // 
            this.groupBoxMonto.Controls.Add(this.TxtHasta);
            this.groupBoxMonto.Controls.Add(this.TxtDesde);
            this.groupBoxMonto.Controls.Add(this.LblHastaM);
            this.groupBoxMonto.Controls.Add(this.LblDesdeM);
            this.groupBoxMonto.Location = new System.Drawing.Point(30, 67);
            this.groupBoxMonto.Name = "groupBoxMonto";
            this.groupBoxMonto.Size = new System.Drawing.Size(288, 152);
            this.groupBoxMonto.TabIndex = 1;
            this.groupBoxMonto.TabStop = false;
            this.groupBoxMonto.Tag = "Monto";
            this.groupBoxMonto.Text = "Monto";
            // 
            // TxtHasta
            // 
            this.TxtHasta.Location = new System.Drawing.Point(95, 99);
            this.TxtHasta.Name = "TxtHasta";
            this.TxtHasta.Size = new System.Drawing.Size(143, 22);
            this.TxtHasta.TabIndex = 3;
            // 
            // TxtDesde
            // 
            this.TxtDesde.Location = new System.Drawing.Point(95, 53);
            this.TxtDesde.Name = "TxtDesde";
            this.TxtDesde.Size = new System.Drawing.Size(143, 22);
            this.TxtDesde.TabIndex = 2;
            // 
            // LblHastaM
            // 
            this.LblHastaM.AutoSize = true;
            this.LblHastaM.Location = new System.Drawing.Point(10, 104);
            this.LblHastaM.Name = "LblHastaM";
            this.LblHastaM.Size = new System.Drawing.Size(45, 17);
            this.LblHastaM.TabIndex = 1;
            this.LblHastaM.Tag = "Hasta";
            this.LblHastaM.Text = "Hasta";
            // 
            // LblDesdeM
            // 
            this.LblDesdeM.AutoSize = true;
            this.LblDesdeM.Location = new System.Drawing.Point(6, 56);
            this.LblDesdeM.Name = "LblDesdeM";
            this.LblDesdeM.Size = new System.Drawing.Size(49, 17);
            this.LblDesdeM.TabIndex = 0;
            this.LblDesdeM.Tag = "Desde";
            this.LblDesdeM.Text = "Desde";
            // 
            // groupBoxRangoFecha
            // 
            this.groupBoxRangoFecha.Controls.Add(this.dateTimePickerHasta);
            this.groupBoxRangoFecha.Controls.Add(this.dateTimePickerDesde);
            this.groupBoxRangoFecha.Controls.Add(this.LblHasta);
            this.groupBoxRangoFecha.Controls.Add(this.LblDesde);
            this.groupBoxRangoFecha.Location = new System.Drawing.Point(324, 67);
            this.groupBoxRangoFecha.Name = "groupBoxRangoFecha";
            this.groupBoxRangoFecha.Size = new System.Drawing.Size(288, 152);
            this.groupBoxRangoFecha.TabIndex = 4;
            this.groupBoxRangoFecha.TabStop = false;
            this.groupBoxRangoFecha.Tag = "Rango de Fecha";
            this.groupBoxRangoFecha.Text = "Rango de Fecha";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(71, 99);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerHasta.TabIndex = 3;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(71, 56);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDesde.TabIndex = 2;
            // 
            // LblHasta
            // 
            this.LblHasta.AutoSize = true;
            this.LblHasta.Location = new System.Drawing.Point(10, 104);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(45, 17);
            this.LblHasta.TabIndex = 1;
            this.LblHasta.Tag = "Hasta";
            this.LblHasta.Text = "Hasta";
            // 
            // LblDesde
            // 
            this.LblDesde.AutoSize = true;
            this.LblDesde.Location = new System.Drawing.Point(6, 56);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(49, 17);
            this.LblDesde.TabIndex = 0;
            this.LblDesde.Tag = "Desde";
            this.LblDesde.Text = "Desde";
            // 
            // groupBoxProveedor
            // 
            this.groupBoxProveedor.Controls.Add(this.comboBoxProveedorCUIT);
            this.groupBoxProveedor.Controls.Add(this.LblCUIT);
            this.groupBoxProveedor.Location = new System.Drawing.Point(618, 67);
            this.groupBoxProveedor.Name = "groupBoxProveedor";
            this.groupBoxProveedor.Size = new System.Drawing.Size(288, 152);
            this.groupBoxProveedor.TabIndex = 5;
            this.groupBoxProveedor.TabStop = false;
            this.groupBoxProveedor.Tag = "Proveedor";
            this.groupBoxProveedor.Text = "Proveedor";
            // 
            // comboBoxProveedorCUIT
            // 
            this.comboBoxProveedorCUIT.FormattingEnabled = true;
            this.comboBoxProveedorCUIT.Location = new System.Drawing.Point(66, 74);
            this.comboBoxProveedorCUIT.Name = "comboBoxProveedorCUIT";
            this.comboBoxProveedorCUIT.Size = new System.Drawing.Size(174, 24);
            this.comboBoxProveedorCUIT.TabIndex = 1;
            // 
            // LblCUIT
            // 
            this.LblCUIT.AutoSize = true;
            this.LblCUIT.Location = new System.Drawing.Point(5, 77);
            this.LblCUIT.Name = "LblCUIT";
            this.LblCUIT.Size = new System.Drawing.Size(39, 17);
            this.LblCUIT.TabIndex = 0;
            this.LblCUIT.Tag = "CUIT";
            this.LblCUIT.Text = "CUIT";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(923, 67);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(90, 48);
            this.BtnFiltrar.TabIndex = 6;
            this.BtnFiltrar.Tag = "Filtrar";
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnCancelarFiltro
            // 
            this.BtnCancelarFiltro.Location = new System.Drawing.Point(923, 171);
            this.BtnCancelarFiltro.Name = "BtnCancelarFiltro";
            this.BtnCancelarFiltro.Size = new System.Drawing.Size(90, 48);
            this.BtnCancelarFiltro.TabIndex = 7;
            this.BtnCancelarFiltro.Tag = "Cancelar Filtro";
            this.BtnCancelarFiltro.Text = "Cancelar Filtro";
            this.BtnCancelarFiltro.UseVisualStyleBackColor = true;
            this.BtnCancelarFiltro.Click += new System.EventHandler(this.BtnCancelarFiltro_Click);
            // 
            // dataGridViewCompras
            // 
            this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompras.Location = new System.Drawing.Point(39, 248);
            this.dataGridViewCompras.Name = "dataGridViewCompras";
            this.dataGridViewCompras.RowHeadersWidth = 51;
            this.dataGridViewCompras.RowTemplate.Height = 24;
            this.dataGridViewCompras.Size = new System.Drawing.Size(867, 198);
            this.dataGridViewCompras.TabIndex = 8;
            this.dataGridViewCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompras_CellClick);
            // 
            // VisualizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 458);
            this.Controls.Add(this.dataGridViewCompras);
            this.Controls.Add(this.BtnCancelarFiltro);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.groupBoxProveedor);
            this.Controls.Add(this.groupBoxRangoFecha);
            this.Controls.Add(this.groupBoxMonto);
            this.Controls.Add(this.LblFiltrar);
            this.Name = "VisualizarCompra";
            this.Tag = "Visualizar Compra";
            this.Text = "VisualizarCompra";
            this.Load += new System.EventHandler(this.VisualizarCompra_Load);
            this.groupBoxMonto.ResumeLayout(false);
            this.groupBoxMonto.PerformLayout();
            this.groupBoxRangoFecha.ResumeLayout(false);
            this.groupBoxRangoFecha.PerformLayout();
            this.groupBoxProveedor.ResumeLayout(false);
            this.groupBoxProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFiltrar;
        private System.Windows.Forms.GroupBox groupBoxMonto;
        private System.Windows.Forms.TextBox TxtHasta;
        private System.Windows.Forms.TextBox TxtDesde;
        private System.Windows.Forms.Label LblHastaM;
        private System.Windows.Forms.Label LblDesdeM;
        private System.Windows.Forms.GroupBox groupBoxRangoFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.Label LblDesde;
        private System.Windows.Forms.GroupBox groupBoxProveedor;
        private System.Windows.Forms.ComboBox comboBoxProveedorCUIT;
        private System.Windows.Forms.Label LblCUIT;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnCancelarFiltro;
        private System.Windows.Forms.DataGridView dataGridViewCompras;
    }
}