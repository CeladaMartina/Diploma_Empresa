
namespace Interfaz_GUI
{
    partial class LogIn
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtnick = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRecalcular = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtErrorDV = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcontraseña);
            this.groupBox1.Controls.Add(this.txtnick);
            this.groupBox1.Location = new System.Drawing.Point(81, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(274, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Tag = "Cancelar";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(121, 240);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 33);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Tag = "Ingresar";
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Tag = "Contraseña";
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Tag = "Nick";
            this.label1.Text = "Nick";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(207, 144);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(173, 22);
            this.txtcontraseña.TabIndex = 1;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // txtnick
            // 
            this.txtnick.Location = new System.Drawing.Point(208, 75);
            this.txtnick.Name = "txtnick";
            this.txtnick.Size = new System.Drawing.Size(173, 22);
            this.txtnick.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtErrorDV);
            this.groupBox2.Controls.Add(this.BtnRecalcular);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Location = new System.Drawing.Point(103, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error DV";
            this.groupBox2.Visible = false;
            // 
            // BtnRecalcular
            // 
            this.BtnRecalcular.Location = new System.Drawing.Point(345, 266);
            this.BtnRecalcular.Name = "BtnRecalcular";
            this.BtnRecalcular.Size = new System.Drawing.Size(91, 33);
            this.BtnRecalcular.TabIndex = 7;
            this.BtnRecalcular.Tag = "Recalcular";
            this.BtnRecalcular.Text = "Recalcular";
            this.BtnRecalcular.UseVisualStyleBackColor = true;
            this.BtnRecalcular.Click += new System.EventHandler(this.BtnRecalcular_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(7, 266);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 33);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Tag = "Restore";
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtErrorDV
            // 
            this.txtErrorDV.Enabled = false;
            this.txtErrorDV.Location = new System.Drawing.Point(7, 40);
            this.txtErrorDV.Multiline = true;
            this.txtErrorDV.Name = "txtErrorDV";
            this.txtErrorDV.Size = new System.Drawing.Size(429, 207);
            this.txtErrorDV.TabIndex = 8;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 407);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtnick;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRecalcular;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtErrorDV;
    }
}