
namespace Interfaz_GUI
{
    partial class PatenteFamilias
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.btnAgregarPatente = new System.Windows.Forms.Button();
            this.btnEliminarPatente = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFamilias2 = new System.Windows.Forms.ComboBox();
            this.btnQuitarFamilia = new System.Windows.Forms.Button();
            this.btnAgregarFamilia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreFamilia = new System.Windows.Forms.TextBox();
            this.btnCrearFamilia = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.treeConfigurarFamilia = new System.Windows.Forms.TreeView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarPatente);
            this.groupBox1.Controls.Add(this.btnAgregarPatente);
            this.groupBox1.Controls.Add(this.cboPatentes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Patentes";
            this.groupBox1.Text = "Patentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todas las patentes";
            // 
            // cboPatentes
            // 
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(26, 75);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(265, 24);
            this.cboPatentes.TabIndex = 1;
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.Location = new System.Drawing.Point(26, 134);
            this.btnAgregarPatente.Name = "btnAgregarPatente";
            this.btnAgregarPatente.Size = new System.Drawing.Size(94, 33);
            this.btnAgregarPatente.TabIndex = 2;
            this.btnAgregarPatente.Tag = "Agregar";
            this.btnAgregarPatente.Text = "Agregar";
            this.btnAgregarPatente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPatente
            // 
            this.btnEliminarPatente.Location = new System.Drawing.Point(197, 134);
            this.btnEliminarPatente.Name = "btnEliminarPatente";
            this.btnEliminarPatente.Size = new System.Drawing.Size(94, 33);
            this.btnEliminarPatente.TabIndex = 3;
            this.btnEliminarPatente.Tag = "Quitar";
            this.btnEliminarPatente.Text = "Quitar";
            this.btnEliminarPatente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnQuitarFamilia);
            this.groupBox2.Controls.Add(this.btnAgregarFamilia);
            this.groupBox2.Controls.Add(this.cboFamilias2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboFamilias);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(379, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 477);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Familias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Todas las familias";
            // 
            // cboFamilias
            // 
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(35, 94);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(265, 24);
            this.cboFamilias.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Familias";
            // 
            // cboFamilias2
            // 
            this.cboFamilias2.FormattingEnabled = true;
            this.cboFamilias2.Location = new System.Drawing.Point(35, 167);
            this.cboFamilias2.Name = "cboFamilias2";
            this.cboFamilias2.Size = new System.Drawing.Size(265, 24);
            this.cboFamilias2.TabIndex = 3;
            // 
            // btnQuitarFamilia
            // 
            this.btnQuitarFamilia.Location = new System.Drawing.Point(206, 215);
            this.btnQuitarFamilia.Name = "btnQuitarFamilia";
            this.btnQuitarFamilia.Size = new System.Drawing.Size(94, 33);
            this.btnQuitarFamilia.TabIndex = 5;
            this.btnQuitarFamilia.Tag = "Quitar";
            this.btnQuitarFamilia.Text = "Quitar";
            this.btnQuitarFamilia.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.Location = new System.Drawing.Point(35, 215);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(94, 33);
            this.btnAgregarFamilia.TabIndex = 4;
            this.btnAgregarFamilia.Tag = "Agregar";
            this.btnAgregarFamilia.Text = "Agregar";
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCrearFamilia);
            this.groupBox3.Controls.Add(this.txtNombreFamilia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(35, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 181);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva Familia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // txtNombreFamilia
            // 
            this.txtNombreFamilia.Location = new System.Drawing.Point(9, 78);
            this.txtNombreFamilia.Name = "txtNombreFamilia";
            this.txtNombreFamilia.Size = new System.Drawing.Size(221, 22);
            this.txtNombreFamilia.TabIndex = 2;
            // 
            // btnCrearFamilia
            // 
            this.btnCrearFamilia.Location = new System.Drawing.Point(9, 129);
            this.btnCrearFamilia.Name = "btnCrearFamilia";
            this.btnCrearFamilia.Size = new System.Drawing.Size(94, 33);
            this.btnCrearFamilia.TabIndex = 3;
            this.btnCrearFamilia.Tag = "Crear";
            this.btnCrearFamilia.Text = "Crear";
            this.btnCrearFamilia.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardar);
            this.groupBox4.Controls.Add(this.treeConfigurarFamilia);
            this.groupBox4.Location = new System.Drawing.Point(732, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 477);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configurar Familia";
            // 
            // treeConfigurarFamilia
            // 
            this.treeConfigurarFamilia.Location = new System.Drawing.Point(6, 43);
            this.treeConfigurarFamilia.Name = "treeConfigurarFamilia";
            this.treeConfigurarFamilia.Size = new System.Drawing.Size(332, 374);
            this.treeConfigurarFamilia.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(139, 438);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 33);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Tag = "Guardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // PatenteFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 534);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatenteFamilias";
            this.Text = "PatenteFamilias";
            this.Load += new System.EventHandler(this.PatenteFamilias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarPatente;
        private System.Windows.Forms.Button btnAgregarPatente;
        private System.Windows.Forms.ComboBox cboPatentes;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCrearFamilia;
        private System.Windows.Forms.TextBox txtNombreFamilia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuitarFamilia;
        private System.Windows.Forms.Button btnAgregarFamilia;
        private System.Windows.Forms.ComboBox cboFamilias2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TreeView treeConfigurarFamilia;
    }
}