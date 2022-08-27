
namespace Interfaz_GUI
{
    partial class ControlCambioProveedor
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
            this.LblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnCancelarFiltro = new System.Windows.Forms.Button();
            this.dataGridViewControlCambio = new System.Windows.Forms.DataGridView();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewControlCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCUIT
            // 
            this.LblCUIT.AutoSize = true;
            this.LblCUIT.Location = new System.Drawing.Point(22, 40);
            this.LblCUIT.Name = "LblCUIT";
            this.LblCUIT.Size = new System.Drawing.Size(39, 17);
            this.LblCUIT.TabIndex = 0;
            this.LblCUIT.Tag = "CUIT";
            this.LblCUIT.Text = "CUIT";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(94, 35);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(192, 22);
            this.txtCUIT.TabIndex = 1;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(346, 28);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(118, 29);
            this.BtnFiltrar.TabIndex = 2;
            this.BtnFiltrar.Tag = "Filtrar";
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnCancelarFiltro
            // 
            this.BtnCancelarFiltro.Location = new System.Drawing.Point(488, 28);
            this.BtnCancelarFiltro.Name = "BtnCancelarFiltro";
            this.BtnCancelarFiltro.Size = new System.Drawing.Size(118, 29);
            this.BtnCancelarFiltro.TabIndex = 3;
            this.BtnCancelarFiltro.Tag = "Cancelar Filtro";
            this.BtnCancelarFiltro.Text = "Cancelar Filtro";
            this.BtnCancelarFiltro.UseVisualStyleBackColor = true;
            this.BtnCancelarFiltro.Click += new System.EventHandler(this.BtnCancelarFiltro_Click);
            // 
            // dataGridViewControlCambio
            // 
            this.dataGridViewControlCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewControlCambio.Location = new System.Drawing.Point(25, 77);
            this.dataGridViewControlCambio.Name = "dataGridViewControlCambio";
            this.dataGridViewControlCambio.RowHeadersWidth = 51;
            this.dataGridViewControlCambio.RowTemplate.Height = 24;
            this.dataGridViewControlCambio.Size = new System.Drawing.Size(993, 335);
            this.dataGridViewControlCambio.TabIndex = 4;
            this.dataGridViewControlCambio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewControlCambio_CellClick);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(900, 427);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(118, 29);
            this.BtnVolver.TabIndex = 6;
            this.BtnVolver.Tag = "Volver";
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Location = new System.Drawing.Point(25, 427);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(170, 29);
            this.BtnRestaurar.TabIndex = 5;
            this.BtnRestaurar.Tag = "Restaurar Cambio";
            this.BtnRestaurar.Text = "Restaurar Cambio";
            this.BtnRestaurar.UseVisualStyleBackColor = true;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // ControlCambioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 468);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnRestaurar);
            this.Controls.Add(this.dataGridViewControlCambio);
            this.Controls.Add(this.BtnCancelarFiltro);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.LblCUIT);
            this.Name = "ControlCambioProveedor";
            this.Text = "ControlCambioProveedor";
            this.Load += new System.EventHandler(this.ControlCambioProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewControlCambio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnCancelarFiltro;
        private System.Windows.Forms.DataGridView dataGridViewControlCambio;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnRestaurar;
    }
}