
namespace Interfaz_GUI
{
    partial class Recalcular_Digitos
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblDV = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtDV = new System.Windows.Forms.TextBox();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.BtnDV = new System.Windows.Forms.Button();
            this.BtnRecalcularDVV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDV);
            this.groupBox1.Controls.Add(this.BtnUsuario);
            this.groupBox1.Controls.Add(this.TxtDV);
            this.groupBox1.Controls.Add(this.TxtUsuario);
            this.groupBox1.Controls.Add(this.LblDV);
            this.groupBox1.Controls.Add(this.LblUsuario);
            this.groupBox1.Location = new System.Drawing.Point(49, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tablas";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(18, 47);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(97, 17);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Tag = "Tabla Usuario";
            this.LblUsuario.Text = "Tabla Usuario";
            // 
            // LblDV
            // 
            this.LblDV.AutoSize = true;
            this.LblDV.Location = new System.Drawing.Point(18, 145);
            this.LblDV.Name = "LblDV";
            this.LblDV.Size = new System.Drawing.Size(133, 17);
            this.LblDV.TabIndex = 1;
            this.LblDV.Tag = "Tabla Detalle Venta";
            this.LblDV.Text = "Tabla Detalle Venta";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(21, 81);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(148, 22);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.Tag = "TxtUsuario";
            // 
            // TxtDV
            // 
            this.TxtDV.Location = new System.Drawing.Point(21, 189);
            this.TxtDV.Name = "TxtDV";
            this.TxtDV.Size = new System.Drawing.Size(148, 22);
            this.TxtDV.TabIndex = 3;
            this.TxtDV.Tag = "TxtDV";
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.Location = new System.Drawing.Point(234, 81);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(144, 25);
            this.BtnUsuario.TabIndex = 4;
            this.BtnUsuario.Tag = "Recalcular DVH";
            this.BtnUsuario.Text = "Recalcular DVH";
            this.BtnUsuario.UseVisualStyleBackColor = true;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // BtnDV
            // 
            this.BtnDV.Location = new System.Drawing.Point(234, 189);
            this.BtnDV.Name = "BtnDV";
            this.BtnDV.Size = new System.Drawing.Size(144, 25);
            this.BtnDV.TabIndex = 5;
            this.BtnDV.Tag = "Recalcular DVH";
            this.BtnDV.Text = "Recalcular DVH";
            this.BtnDV.UseVisualStyleBackColor = true;
            this.BtnDV.Click += new System.EventHandler(this.BtnDV_Click);
            // 
            // BtnRecalcularDVV
            // 
            this.BtnRecalcularDVV.Location = new System.Drawing.Point(540, 187);
            this.BtnRecalcularDVV.Name = "BtnRecalcularDVV";
            this.BtnRecalcularDVV.Size = new System.Drawing.Size(138, 37);
            this.BtnRecalcularDVV.TabIndex = 1;
            this.BtnRecalcularDVV.Tag = "Recalcular DVV";
            this.BtnRecalcularDVV.Text = "Recalcular DVV";
            this.BtnRecalcularDVV.UseVisualStyleBackColor = true;
            this.BtnRecalcularDVV.Click += new System.EventHandler(this.BtnRecalcularDVV_Click);
            // 
            // Recalcular_Digitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 369);
            this.Controls.Add(this.BtnRecalcularDVV);
            this.Controls.Add(this.groupBox1);
            this.Name = "Recalcular_Digitos";
            this.Text = "Recalcular_Digitos";
            this.Load += new System.EventHandler(this.Recalcular_Digitos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDV;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.TextBox TxtDV;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblDV;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnRecalcularDVV;
    }
}