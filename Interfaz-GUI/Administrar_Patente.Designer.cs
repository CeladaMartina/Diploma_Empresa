
namespace Interfaz_GUI
{
    partial class Administrar_Patente
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
            this.BtnQuitarPermiso = new System.Windows.Forms.Button();
            this.BtnCargarNomPat = new System.Windows.Forms.Button();
            this.CmbPermisos = new System.Windows.Forms.ComboBox();
            this.txtNombrePatente = new System.Windows.Forms.TextBox();
            this.LblPermiso = new System.Windows.Forms.Label();
            this.LblNombrePatente = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewAdmPatente = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmPatente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnQuitarPermiso);
            this.groupBox1.Controls.Add(this.BtnCargarNomPat);
            this.groupBox1.Controls.Add(this.CmbPermisos);
            this.groupBox1.Controls.Add(this.txtNombrePatente);
            this.groupBox1.Controls.Add(this.LblPermiso);
            this.groupBox1.Controls.Add(this.LblNombrePatente);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnQuitarPermiso
            // 
            this.BtnQuitarPermiso.Location = new System.Drawing.Point(440, 99);
            this.BtnQuitarPermiso.Name = "BtnQuitarPermiso";
            this.BtnQuitarPermiso.Size = new System.Drawing.Size(79, 37);
            this.BtnQuitarPermiso.TabIndex = 5;
            this.BtnQuitarPermiso.Tag = "Quitar";
            this.BtnQuitarPermiso.Text = "Quitar";
            this.BtnQuitarPermiso.UseVisualStyleBackColor = true;
            this.BtnQuitarPermiso.Click += new System.EventHandler(this.BtnQuitarPermiso_Click);
            // 
            // BtnCargarNomPat
            // 
            this.BtnCargarNomPat.Location = new System.Drawing.Point(440, 43);
            this.BtnCargarNomPat.Name = "BtnCargarNomPat";
            this.BtnCargarNomPat.Size = new System.Drawing.Size(79, 37);
            this.BtnCargarNomPat.TabIndex = 4;
            this.BtnCargarNomPat.Tag = "Cargar";
            this.BtnCargarNomPat.Text = "Cargar";
            this.BtnCargarNomPat.UseVisualStyleBackColor = true;
            this.BtnCargarNomPat.Click += new System.EventHandler(this.BtnCargarNomPat_Click);
            // 
            // CmbPermisos
            // 
            this.CmbPermisos.FormattingEnabled = true;
            this.CmbPermisos.Location = new System.Drawing.Point(175, 106);
            this.CmbPermisos.Name = "CmbPermisos";
            this.CmbPermisos.Size = new System.Drawing.Size(144, 24);
            this.CmbPermisos.TabIndex = 3;
            // 
            // txtNombrePatente
            // 
            this.txtNombrePatente.Location = new System.Drawing.Point(175, 45);
            this.txtNombrePatente.Name = "txtNombrePatente";
            this.txtNombrePatente.Size = new System.Drawing.Size(144, 22);
            this.txtNombrePatente.TabIndex = 2;
            // 
            // LblPermiso
            // 
            this.LblPermiso.AutoSize = true;
            this.LblPermiso.Location = new System.Drawing.Point(36, 113);
            this.LblPermiso.Name = "LblPermiso";
            this.LblPermiso.Size = new System.Drawing.Size(66, 17);
            this.LblPermiso.TabIndex = 1;
            this.LblPermiso.Tag = "Permisos";
            this.LblPermiso.Text = "Permisos";
            // 
            // LblNombrePatente
            // 
            this.LblNombrePatente.AutoSize = true;
            this.LblNombrePatente.Location = new System.Drawing.Point(36, 50);
            this.LblNombrePatente.Name = "LblNombrePatente";
            this.LblNombrePatente.Size = new System.Drawing.Size(111, 17);
            this.LblNombrePatente.TabIndex = 0;
            this.LblNombrePatente.Tag = "Nombre Patente";
            this.LblNombrePatente.Text = "Nombre Patente";
            // 
            // dataGridViewAdmPatente
            // 
            this.dataGridViewAdmPatente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmPatente.Location = new System.Drawing.Point(23, 210);
            this.dataGridViewAdmPatente.Name = "dataGridViewAdmPatente";
            this.dataGridViewAdmPatente.RowHeadersWidth = 51;
            this.dataGridViewAdmPatente.RowTemplate.Height = 24;
            this.dataGridViewAdmPatente.Size = new System.Drawing.Size(576, 209);
            this.dataGridViewAdmPatente.TabIndex = 1;
            this.dataGridViewAdmPatente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmPatente_CellClick);
            // 
            // Administrar_Patente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.dataGridViewAdmPatente);
            this.Controls.Add(this.groupBox1);
            this.Name = "Administrar_Patente";
            this.Text = "Administrar_Patente";
            this.Load += new System.EventHandler(this.Administrar_Patente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmPatente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnQuitarPermiso;
        private System.Windows.Forms.Button BtnCargarNomPat;
        private System.Windows.Forms.ComboBox CmbPermisos;
        private System.Windows.Forms.TextBox txtNombrePatente;
        private System.Windows.Forms.Label LblPermiso;
        private System.Windows.Forms.Label LblNombrePatente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewAdmPatente;
    }
}