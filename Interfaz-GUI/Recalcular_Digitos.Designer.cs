
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
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.TxtTablas = new System.Windows.Forms.TextBox();
            this.BtnRecalcularDVV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnUsuario);
            this.groupBox1.Controls.Add(this.TxtTablas);
            this.groupBox1.Location = new System.Drawing.Point(49, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tablas";
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
            // TxtTablas
            // 
            this.TxtTablas.Location = new System.Drawing.Point(21, 81);
            this.TxtTablas.Name = "TxtTablas";
            this.TxtTablas.Size = new System.Drawing.Size(192, 22);
            this.TxtTablas.TabIndex = 2;
            this.TxtTablas.Tag = "TxtUsuario";
            this.TxtTablas.Text = "ERROR";
            // 
            // BtnRecalcularDVV
            // 
            this.BtnRecalcularDVV.Location = new System.Drawing.Point(197, 216);
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
            this.ClientSize = new System.Drawing.Size(544, 288);
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
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.TextBox TxtTablas;
        private System.Windows.Forms.Button BtnRecalcularDVV;
    }
}