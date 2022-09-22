
namespace Interfaz_GUI
{
    partial class Administrar_Idioma
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
            this.dataGridViewIdioma = new System.Windows.Forms.DataGridView();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.TxtNombreIdioma = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBaja);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Controls.Add(this.BtnAlta);
            this.groupBox1.Controls.Add(this.TxtNombreIdioma);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar";
            // 
            // dataGridViewIdioma
            // 
            this.dataGridViewIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIdioma.Location = new System.Drawing.Point(12, 219);
            this.dataGridViewIdioma.Name = "dataGridViewIdioma";
            this.dataGridViewIdioma.RowHeadersWidth = 51;
            this.dataGridViewIdioma.RowTemplate.Height = 24;
            this.dataGridViewIdioma.Size = new System.Drawing.Size(460, 159);
            this.dataGridViewIdioma.TabIndex = 1;
            this.dataGridViewIdioma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIdioma_CellClick);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(309, 105);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(88, 28);
            this.BtnBaja.TabIndex = 3;
            this.BtnBaja.Tag = "Baja";
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(167, 105);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(88, 28);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Tag = "Modificar";
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(20, 105);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(88, 28);
            this.BtnAlta.TabIndex = 1;
            this.BtnAlta.Tag = "Alta";
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // TxtNombreIdioma
            // 
            this.TxtNombreIdioma.Location = new System.Drawing.Point(103, 52);
            this.TxtNombreIdioma.Name = "TxtNombreIdioma";
            this.TxtNombreIdioma.Size = new System.Drawing.Size(222, 22);
            this.TxtNombreIdioma.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(18, 57);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Tag = "Nombre";
            this.LblNombre.Text = "Nombre";
            // 
            // Administrar_Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 416);
            this.Controls.Add(this.dataGridViewIdioma);
            this.Controls.Add(this.groupBox1);
            this.Name = "Administrar_Idioma";
            this.Text = "Administrar Idioma";
            this.Load += new System.EventHandler(this.Administrar_Idioma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdioma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.TextBox TxtNombreIdioma;
        private System.Windows.Forms.DataGridView dataGridViewIdioma;
    }
}