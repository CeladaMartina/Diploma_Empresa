
namespace Interfaz_GUI
{
    partial class Administrar_Permisos
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
            this.LblFamilia = new System.Windows.Forms.Label();
            this.LblPatente = new System.Windows.Forms.Label();
            this.CmbFamiliaP = new System.Windows.Forms.ComboBox();
            this.CmbPatenteP = new System.Windows.Forms.ComboBox();
            this.BtnCargarFP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewFamilia = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnAgregarFamilia = new System.Windows.Forms.Button();
            this.txtNombreFamilia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBorrarF = new System.Windows.Forms.Button();
            this.BtnAgregarF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBorrarP = new System.Windows.Forms.Button();
            this.BtnAgregarP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFamilia
            // 
            this.LblFamilia.AutoSize = true;
            this.LblFamilia.Location = new System.Drawing.Point(16, 34);
            this.LblFamilia.Name = "LblFamilia";
            this.LblFamilia.Size = new System.Drawing.Size(121, 17);
            this.LblFamilia.TabIndex = 0;
            this.LblFamilia.Tag = "Todas las Familias";
            this.LblFamilia.Text = "Todas las familias";
            // 
            // LblPatente
            // 
            this.LblPatente.AutoSize = true;
            this.LblPatente.Location = new System.Drawing.Point(9, 35);
            this.LblPatente.Name = "LblPatente";
            this.LblPatente.Size = new System.Drawing.Size(57, 17);
            this.LblPatente.TabIndex = 1;
            this.LblPatente.Tag = "Patente";
            this.LblPatente.Text = "Patente";
            // 
            // CmbFamiliaP
            // 
            this.CmbFamiliaP.FormattingEnabled = true;
            this.CmbFamiliaP.Location = new System.Drawing.Point(19, 58);
            this.CmbFamiliaP.Name = "CmbFamiliaP";
            this.CmbFamiliaP.Size = new System.Drawing.Size(223, 24);
            this.CmbFamiliaP.TabIndex = 2;
            // 
            // CmbPatenteP
            // 
            this.CmbPatenteP.FormattingEnabled = true;
            this.CmbPatenteP.Location = new System.Drawing.Point(12, 61);
            this.CmbPatenteP.Name = "CmbPatenteP";
            this.CmbPatenteP.Size = new System.Drawing.Size(218, 24);
            this.CmbPatenteP.TabIndex = 3;
            // 
            // BtnCargarFP
            // 
            this.BtnCargarFP.Location = new System.Drawing.Point(379, 437);
            this.BtnCargarFP.Name = "BtnCargarFP";
            this.BtnCargarFP.Size = new System.Drawing.Size(108, 27);
            this.BtnCargarFP.TabIndex = 4;
            this.BtnCargarFP.Tag = "Guardar";
            this.BtnCargarFP.Text = "Guardar";
            this.BtnCargarFP.UseVisualStyleBackColor = true;
            this.BtnCargarFP.Click += new System.EventHandler(this.BtnCargarFP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewFamilia);
            this.groupBox1.Controls.Add(this.BtnCargarFP);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 477);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Administrar Patentes";
            this.groupBox1.Text = "Administrar Patentes";
            // 
            // treeViewFamilia
            // 
            this.treeViewFamilia.Location = new System.Drawing.Point(379, 39);
            this.treeViewFamilia.Name = "treeViewFamilia";
            this.treeViewFamilia.Size = new System.Drawing.Size(421, 392);
            this.treeViewFamilia.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSeleccionar);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.BtnBorrarF);
            this.groupBox3.Controls.Add(this.LblFamilia);
            this.groupBox3.Controls.Add(this.CmbFamiliaP);
            this.groupBox3.Controls.Add(this.BtnAgregarF);
            this.groupBox3.Location = new System.Drawing.Point(23, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 307);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "Familia";
            this.groupBox3.Text = "Familias";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Location = new System.Drawing.Point(248, 49);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(93, 33);
            this.BtnSeleccionar.TabIndex = 11;
            this.BtnSeleccionar.Tag = "Seleccionar";
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnAgregarFamilia);
            this.groupBox4.Controls.Add(this.txtNombreFamilia);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(19, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 124);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "Nueva Familia";
            this.groupBox4.Text = "Nueva Familia";
            // 
            // BtnAgregarFamilia
            // 
            this.BtnAgregarFamilia.Location = new System.Drawing.Point(208, 67);
            this.BtnAgregarFamilia.Name = "BtnAgregarFamilia";
            this.BtnAgregarFamilia.Size = new System.Drawing.Size(76, 33);
            this.BtnAgregarFamilia.TabIndex = 11;
            this.BtnAgregarFamilia.Tag = "Crear";
            this.BtnAgregarFamilia.Text = "Crear";
            this.BtnAgregarFamilia.UseVisualStyleBackColor = true;
            this.BtnAgregarFamilia.Click += new System.EventHandler(this.BtnAgregarFamilia_Click);
            // 
            // txtNombreFamilia
            // 
            this.txtNombreFamilia.Location = new System.Drawing.Point(23, 72);
            this.txtNombreFamilia.Name = "txtNombreFamilia";
            this.txtNombreFamilia.Size = new System.Drawing.Size(162, 22);
            this.txtNombreFamilia.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 11;
            this.label2.Tag = "Nombre";
            this.label2.Text = "Nombre";
            // 
            // BtnBorrarF
            // 
            this.BtnBorrarF.Location = new System.Drawing.Point(166, 97);
            this.BtnBorrarF.Name = "BtnBorrarF";
            this.BtnBorrarF.Size = new System.Drawing.Size(76, 33);
            this.BtnBorrarF.TabIndex = 7;
            this.BtnBorrarF.Tag = "Borrar";
            this.BtnBorrarF.Text = "Borrar";
            this.BtnBorrarF.UseVisualStyleBackColor = true;
            this.BtnBorrarF.Click += new System.EventHandler(this.BtnBorrarF_Click);
            // 
            // BtnAgregarF
            // 
            this.BtnAgregarF.Location = new System.Drawing.Point(19, 97);
            this.BtnAgregarF.Name = "BtnAgregarF";
            this.BtnAgregarF.Size = new System.Drawing.Size(76, 33);
            this.BtnAgregarF.TabIndex = 6;
            this.BtnAgregarF.Tag = "Agregar";
            this.BtnAgregarF.Text = "Agregar";
            this.BtnAgregarF.UseVisualStyleBackColor = true;
            this.BtnAgregarF.Click += new System.EventHandler(this.BtnAgregarF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBorrarP);
            this.groupBox2.Controls.Add(this.LblPatente);
            this.groupBox2.Controls.Add(this.CmbPatenteP);
            this.groupBox2.Controls.Add(this.BtnAgregarP);
            this.groupBox2.Location = new System.Drawing.Point(23, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Patentes";
            this.groupBox2.Text = "Patentes";
            // 
            // BtnBorrarP
            // 
            this.BtnBorrarP.Location = new System.Drawing.Point(248, 71);
            this.BtnBorrarP.Name = "BtnBorrarP";
            this.BtnBorrarP.Size = new System.Drawing.Size(87, 36);
            this.BtnBorrarP.TabIndex = 9;
            this.BtnBorrarP.Tag = "Borrar";
            this.BtnBorrarP.Text = "Borrar";
            this.BtnBorrarP.UseVisualStyleBackColor = true;
            this.BtnBorrarP.Click += new System.EventHandler(this.BtnBorrarP_Click);
            // 
            // BtnAgregarP
            // 
            this.BtnAgregarP.Location = new System.Drawing.Point(248, 21);
            this.BtnAgregarP.Name = "BtnAgregarP";
            this.BtnAgregarP.Size = new System.Drawing.Size(87, 37);
            this.BtnAgregarP.TabIndex = 8;
            this.BtnAgregarP.Tag = "Agregar";
            this.BtnAgregarP.Text = "Agregar";
            this.BtnAgregarP.UseVisualStyleBackColor = true;
            this.BtnAgregarP.Click += new System.EventHandler(this.BtnAgregarP_Click);
            // 
            // Administrar_Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 523);
            this.Controls.Add(this.groupBox1);
            this.Name = "Administrar_Permisos";
            this.Text = "Administrar_Permisos";
            this.Load += new System.EventHandler(this.Administrar_Permisos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblFamilia;
        private System.Windows.Forms.Label LblPatente;
        private System.Windows.Forms.ComboBox CmbFamiliaP;
        private System.Windows.Forms.ComboBox CmbPatenteP;
        private System.Windows.Forms.Button BtnCargarFP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBorrarP;
        private System.Windows.Forms.Button BtnAgregarP;
        private System.Windows.Forms.Button BtnBorrarF;
        private System.Windows.Forms.Button BtnAgregarF;
        private System.Windows.Forms.TreeView treeViewFamilia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAgregarFamilia;
        private System.Windows.Forms.TextBox txtNombreFamilia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSeleccionar;
    }
}