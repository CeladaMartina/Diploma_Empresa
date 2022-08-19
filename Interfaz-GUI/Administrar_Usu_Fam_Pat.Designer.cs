
namespace Interfaz_GUI
{
    partial class Administrar_Usu_Fam_Pat
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnQuitarPatente = new System.Windows.Forms.Button();
            this.BtnAgregarPatente = new System.Windows.Forms.Button();
            this.BtnQuitarFamilia = new System.Windows.Forms.Button();
            this.BtnAgregarFamilia = new System.Windows.Forms.Button();
            this.CmbPatente = new System.Windows.Forms.ComboBox();
            this.CmbFamilia = new System.Windows.Forms.ComboBox();
            this.CmbUsuario = new System.Windows.Forms.ComboBox();
            this.LblPatente = new System.Windows.Forms.Label();
            this.LblFamilia = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.dataGridViewPermisos = new System.Windows.Forms.DataGridView();
            this.treeViewPermisos = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewPermisos);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(363, 462);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Tag = "Guardar";
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Location = new System.Drawing.Point(224, 60);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(112, 27);
            this.BtnSeleccionar.TabIndex = 11;
            this.BtnSeleccionar.Tag = "Seleccionar";
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnQuitarPatente
            // 
            this.BtnQuitarPatente.Location = new System.Drawing.Point(200, 92);
            this.BtnQuitarPatente.Name = "BtnQuitarPatente";
            this.BtnQuitarPatente.Size = new System.Drawing.Size(75, 32);
            this.BtnQuitarPatente.TabIndex = 10;
            this.BtnQuitarPatente.Tag = "Quitar";
            this.BtnQuitarPatente.Text = "Quitar";
            this.BtnQuitarPatente.UseVisualStyleBackColor = true;
            this.BtnQuitarPatente.Click += new System.EventHandler(this.BtnQuitarPatente_Click);
            // 
            // BtnAgregarPatente
            // 
            this.BtnAgregarPatente.Location = new System.Drawing.Point(18, 92);
            this.BtnAgregarPatente.Name = "BtnAgregarPatente";
            this.BtnAgregarPatente.Size = new System.Drawing.Size(87, 32);
            this.BtnAgregarPatente.TabIndex = 9;
            this.BtnAgregarPatente.Tag = "Agregar";
            this.BtnAgregarPatente.Text = "Agregar";
            this.BtnAgregarPatente.UseVisualStyleBackColor = true;
            this.BtnAgregarPatente.Click += new System.EventHandler(this.BtnAgregarPatente_Click);
            // 
            // BtnQuitarFamilia
            // 
            this.BtnQuitarFamilia.Location = new System.Drawing.Point(200, 86);
            this.BtnQuitarFamilia.Name = "BtnQuitarFamilia";
            this.BtnQuitarFamilia.Size = new System.Drawing.Size(86, 32);
            this.BtnQuitarFamilia.TabIndex = 6;
            this.BtnQuitarFamilia.Tag = "Quitar";
            this.BtnQuitarFamilia.Text = "Quitar";
            this.BtnQuitarFamilia.UseVisualStyleBackColor = true;
            this.BtnQuitarFamilia.Click += new System.EventHandler(this.BtnQuitarFamilia_Click);
            // 
            // BtnAgregarFamilia
            // 
            this.BtnAgregarFamilia.Location = new System.Drawing.Point(18, 86);
            this.BtnAgregarFamilia.Name = "BtnAgregarFamilia";
            this.BtnAgregarFamilia.Size = new System.Drawing.Size(88, 32);
            this.BtnAgregarFamilia.TabIndex = 5;
            this.BtnAgregarFamilia.Tag = "Agregar";
            this.BtnAgregarFamilia.Text = "Agregar";
            this.BtnAgregarFamilia.UseVisualStyleBackColor = true;
            this.BtnAgregarFamilia.Click += new System.EventHandler(this.BtnAgregarFamilia_Click);
            // 
            // CmbPatente
            // 
            this.CmbPatente.FormattingEnabled = true;
            this.CmbPatente.Location = new System.Drawing.Point(73, 41);
            this.CmbPatente.Name = "CmbPatente";
            this.CmbPatente.Size = new System.Drawing.Size(213, 24);
            this.CmbPatente.TabIndex = 4;
            // 
            // CmbFamilia
            // 
            this.CmbFamilia.FormattingEnabled = true;
            this.CmbFamilia.Location = new System.Drawing.Point(73, 34);
            this.CmbFamilia.Name = "CmbFamilia";
            this.CmbFamilia.Size = new System.Drawing.Size(213, 24);
            this.CmbFamilia.TabIndex = 3;
            // 
            // CmbUsuario
            // 
            this.CmbUsuario.FormattingEnabled = true;
            this.CmbUsuario.Location = new System.Drawing.Point(6, 62);
            this.CmbUsuario.Name = "CmbUsuario";
            this.CmbUsuario.Size = new System.Drawing.Size(175, 24);
            this.CmbUsuario.TabIndex = 1;
            // 
            // LblPatente
            // 
            this.LblPatente.AutoSize = true;
            this.LblPatente.Location = new System.Drawing.Point(6, 41);
            this.LblPatente.Name = "LblPatente";
            this.LblPatente.Size = new System.Drawing.Size(57, 17);
            this.LblPatente.TabIndex = 2;
            this.LblPatente.Tag = "Patente";
            this.LblPatente.Text = "Patente";
            // 
            // LblFamilia
            // 
            this.LblFamilia.AutoSize = true;
            this.LblFamilia.Location = new System.Drawing.Point(15, 37);
            this.LblFamilia.Name = "LblFamilia";
            this.LblFamilia.Size = new System.Drawing.Size(52, 17);
            this.LblFamilia.TabIndex = 1;
            this.LblFamilia.Tag = "Familia";
            this.LblFamilia.Text = "Familia";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(6, 42);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Tag = "Usuario";
            this.LblUsuario.Text = "Usuario";
            // 
            // dataGridViewPermisos
            // 
            this.dataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPermisos.Location = new System.Drawing.Point(831, 36);
            this.dataGridViewPermisos.Name = "dataGridViewPermisos";
            this.dataGridViewPermisos.RowHeadersWidth = 51;
            this.dataGridViewPermisos.RowTemplate.Height = 24;
            this.dataGridViewPermisos.Size = new System.Drawing.Size(277, 492);
            this.dataGridViewPermisos.TabIndex = 1;
            this.dataGridViewPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPermisos_CellClick);
            // 
            // treeViewPermisos
            // 
            this.treeViewPermisos.Location = new System.Drawing.Point(363, 57);
            this.treeViewPermisos.Name = "treeViewPermisos";
            this.treeViewPermisos.Size = new System.Drawing.Size(411, 399);
            this.treeViewPermisos.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblUsuario);
            this.groupBox2.Controls.Add(this.CmbUsuario);
            this.groupBox2.Controls.Add(this.BtnSeleccionar);
            this.groupBox2.Location = new System.Drawing.Point(6, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 122);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbFamilia);
            this.groupBox3.Controls.Add(this.LblFamilia);
            this.groupBox3.Controls.Add(this.BtnAgregarFamilia);
            this.groupBox3.Controls.Add(this.BtnQuitarFamilia);
            this.groupBox3.Location = new System.Drawing.Point(6, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 151);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Familia:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmbPatente);
            this.groupBox4.Controls.Add(this.LblPatente);
            this.groupBox4.Controls.Add(this.BtnAgregarPatente);
            this.groupBox4.Controls.Add(this.BtnQuitarPatente);
            this.groupBox4.Location = new System.Drawing.Point(6, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 153);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Patente:";
            // 
            // Administrar_Usu_Fam_Pat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 551);
            this.Controls.Add(this.dataGridViewPermisos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Administrar_Usu_Fam_Pat";
            this.Text = "Administrar_Usu_Fam_Pat";
            this.Load += new System.EventHandler(this.Administrar_Usu_Fam_Pat_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPermisos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblPatente;
        private System.Windows.Forms.Label LblFamilia;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnQuitarPatente;
        private System.Windows.Forms.Button BtnAgregarPatente;
        private System.Windows.Forms.Button BtnQuitarFamilia;
        private System.Windows.Forms.Button BtnAgregarFamilia;
        private System.Windows.Forms.ComboBox CmbPatente;
        private System.Windows.Forms.ComboBox CmbFamilia;
        private System.Windows.Forms.ComboBox CmbUsuario;
        private System.Windows.Forms.DataGridView dataGridViewPermisos;
        private System.Windows.Forms.TreeView treeViewPermisos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}