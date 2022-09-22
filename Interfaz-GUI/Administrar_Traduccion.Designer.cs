
namespace Interfaz_GUI
{
    partial class Administrar_Traduccion
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
            this.LblIdioma = new System.Windows.Forms.Label();
            this.LblOriginal = new System.Windows.Forms.Label();
            this.LblTraducido = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.TxtOriginal = new System.Windows.Forms.TextBox();
            this.TxtTraducido = new System.Windows.Forms.TextBox();
            this.BtnFiltrarIdioma = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnCancelarFiltro = new System.Windows.Forms.Button();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.dataGridViewTraducciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFiltrado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraducciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltrado)).BeginInit();
            this.SuspendLayout();
            // 
            // LblIdioma
            // 
            this.LblIdioma.AutoSize = true;
            this.LblIdioma.Location = new System.Drawing.Point(23, 50);
            this.LblIdioma.Name = "LblIdioma";
            this.LblIdioma.Size = new System.Drawing.Size(49, 17);
            this.LblIdioma.TabIndex = 0;
            this.LblIdioma.Tag = "Idioma";
            this.LblIdioma.Text = "Idioma";
            // 
            // LblOriginal
            // 
            this.LblOriginal.AutoSize = true;
            this.LblOriginal.Location = new System.Drawing.Point(21, 100);
            this.LblOriginal.Name = "LblOriginal";
            this.LblOriginal.Size = new System.Drawing.Size(57, 17);
            this.LblOriginal.TabIndex = 1;
            this.LblOriginal.Tag = "Original";
            this.LblOriginal.Text = "Original";
            // 
            // LblTraducido
            // 
            this.LblTraducido.AutoSize = true;
            this.LblTraducido.Location = new System.Drawing.Point(19, 144);
            this.LblTraducido.Name = "LblTraducido";
            this.LblTraducido.Size = new System.Drawing.Size(72, 17);
            this.LblTraducido.TabIndex = 2;
            this.LblTraducido.Tag = "Traducido";
            this.LblTraducido.Text = "Traducido";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(116, 43);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(161, 24);
            this.cmbIdioma.TabIndex = 3;
            // 
            // TxtOriginal
            // 
            this.TxtOriginal.Location = new System.Drawing.Point(114, 95);
            this.TxtOriginal.Name = "TxtOriginal";
            this.TxtOriginal.Size = new System.Drawing.Size(161, 22);
            this.TxtOriginal.TabIndex = 4;
            // 
            // TxtTraducido
            // 
            this.TxtTraducido.Location = new System.Drawing.Point(112, 139);
            this.TxtTraducido.Name = "TxtTraducido";
            this.TxtTraducido.Size = new System.Drawing.Size(340, 22);
            this.TxtTraducido.TabIndex = 5;
            // 
            // BtnFiltrarIdioma
            // 
            this.BtnFiltrarIdioma.Location = new System.Drawing.Point(351, 44);
            this.BtnFiltrarIdioma.Name = "BtnFiltrarIdioma";
            this.BtnFiltrarIdioma.Size = new System.Drawing.Size(172, 30);
            this.BtnFiltrarIdioma.TabIndex = 6;
            this.BtnFiltrarIdioma.Tag = "Filtrar Idioma";
            this.BtnFiltrarIdioma.Text = "Filtrar Idioma";
            this.BtnFiltrarIdioma.UseVisualStyleBackColor = true;
            this.BtnFiltrarIdioma.Click += new System.EventHandler(this.BtnFiltrarIdioma_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(349, 84);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(105, 29);
            this.BtnFiltrar.TabIndex = 7;
            this.BtnFiltrar.Tag = "Filtrar";
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnCancelarFiltro
            // 
            this.BtnCancelarFiltro.Location = new System.Drawing.Point(472, 84);
            this.BtnCancelarFiltro.Name = "BtnCancelarFiltro";
            this.BtnCancelarFiltro.Size = new System.Drawing.Size(123, 29);
            this.BtnCancelarFiltro.TabIndex = 8;
            this.BtnCancelarFiltro.Tag = "Cancelar Filtro";
            this.BtnCancelarFiltro.Text = "Cancelar Filtro";
            this.BtnCancelarFiltro.UseVisualStyleBackColor = true;
            this.BtnCancelarFiltro.Click += new System.EventHandler(this.BtnCancelarFiltro_Click);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(108, 196);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(88, 38);
            this.BtnAlta.TabIndex = 9;
            this.BtnAlta.Tag = "Alta";
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(236, 196);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(88, 38);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Tag = "Modificar";
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(364, 196);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(88, 38);
            this.BtnBaja.TabIndex = 11;
            this.BtnBaja.Tag = "Baja";
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // dataGridViewTraducciones
            // 
            this.dataGridViewTraducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraducciones.Location = new System.Drawing.Point(12, 276);
            this.dataGridViewTraducciones.Name = "dataGridViewTraducciones";
            this.dataGridViewTraducciones.RowHeadersWidth = 51;
            this.dataGridViewTraducciones.RowTemplate.Height = 24;
            this.dataGridViewTraducciones.Size = new System.Drawing.Size(610, 236);
            this.dataGridViewTraducciones.TabIndex = 12;
            this.dataGridViewTraducciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTraducciones_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtOriginal);
            this.groupBox1.Controls.Add(this.LblIdioma);
            this.groupBox1.Controls.Add(this.BtnBaja);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Controls.Add(this.LblOriginal);
            this.groupBox1.Controls.Add(this.BtnAlta);
            this.groupBox1.Controls.Add(this.LblTraducido);
            this.groupBox1.Controls.Add(this.cmbIdioma);
            this.groupBox1.Controls.Add(this.BtnCancelarFiltro);
            this.groupBox1.Controls.Add(this.TxtTraducido);
            this.groupBox1.Controls.Add(this.BtnFiltrar);
            this.groupBox1.Controls.Add(this.BtnFiltrarIdioma);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 247);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewFiltrado
            // 
            this.dataGridViewFiltrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiltrado.Location = new System.Drawing.Point(628, 34);
            this.dataGridViewFiltrado.Name = "dataGridViewFiltrado";
            this.dataGridViewFiltrado.RowHeadersWidth = 51;
            this.dataGridViewFiltrado.RowTemplate.Height = 24;
            this.dataGridViewFiltrado.Size = new System.Drawing.Size(440, 478);
            this.dataGridViewFiltrado.TabIndex = 14;
            this.dataGridViewFiltrado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFiltrado_CellClick);
            // 
            // Administrar_Traduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 524);
            this.Controls.Add(this.dataGridViewFiltrado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTraducciones);
            this.Name = "Administrar_Traduccion";
            this.Text = "Administrar_Traduccion";
            this.Load += new System.EventHandler(this.Administrar_Traduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraducciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblIdioma;
        private System.Windows.Forms.Label LblOriginal;
        private System.Windows.Forms.Label LblTraducido;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.TextBox TxtOriginal;
        private System.Windows.Forms.TextBox TxtTraducido;
        private System.Windows.Forms.Button BtnFiltrarIdioma;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnCancelarFiltro;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.DataGridView dataGridViewTraducciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewFiltrado;
    }
}