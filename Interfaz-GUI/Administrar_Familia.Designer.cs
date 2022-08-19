
namespace Interfaz_GUI
{
    partial class Administrar_Familia
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
            this.dataGridViewFamilia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblNombreNuevo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFamilia
            // 
            this.dataGridViewFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFamilia.Location = new System.Drawing.Point(28, 213);
            this.dataGridViewFamilia.Name = "dataGridViewFamilia";
            this.dataGridViewFamilia.RowHeadersWidth = 51;
            this.dataGridViewFamilia.RowTemplate.Height = 24;
            this.dataGridViewFamilia.Size = new System.Drawing.Size(576, 209);
            this.dataGridViewFamilia.TabIndex = 3;
            this.dataGridViewFamilia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFamilia_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Controls.Add(this.txtNombreNuevo);
            this.groupBox1.Controls.Add(this.BtnBaja);
            this.groupBox1.Controls.Add(this.BtnAlta);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.LblNombreNuevo);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Familia";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(430, 67);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(79, 37);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Tag = "Modificar";
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(175, 106);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(144, 22);
            this.txtNombreNuevo.TabIndex = 6;
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(430, 113);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(79, 37);
            this.BtnBaja.TabIndex = 5;
            this.BtnBaja.Tag = "Baja";
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(430, 21);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(79, 37);
            this.BtnAlta.TabIndex = 4;
            this.BtnAlta.Tag = "Alta";
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(175, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // LblNombreNuevo
            // 
            this.LblNombreNuevo.AutoSize = true;
            this.LblNombreNuevo.Location = new System.Drawing.Point(36, 113);
            this.LblNombreNuevo.Name = "LblNombreNuevo";
            this.LblNombreNuevo.Size = new System.Drawing.Size(101, 17);
            this.LblNombreNuevo.TabIndex = 1;
            this.LblNombreNuevo.Tag = "Permisos";
            this.LblNombreNuevo.Text = "Nombre nuevo";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(36, 50);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(106, 17);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Tag = "Nombre ";
            this.LblNombre.Text = "Nombre Familia";
            // 
            // Administrar_Familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.dataGridViewFamilia);
            this.Controls.Add(this.groupBox1);
            this.Name = "Administrar_Familia";
            this.Text = "Administrar_Familia";
            this.Load += new System.EventHandler(this.Administrar_Familia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFamilia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFamilia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblNombreNuevo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Button BtnModificar;
    }
}