
namespace Interfaz_GUI
{
    partial class Backup
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
            this.LblRuta = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtRuta = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnExaminar = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // LblRuta
            // 
            this.LblRuta.AutoSize = true;
            this.LblRuta.Location = new System.Drawing.Point(32, 33);
            this.LblRuta.Name = "LblRuta";
            this.LblRuta.Size = new System.Drawing.Size(38, 17);
            this.LblRuta.TabIndex = 0;
            this.LblRuta.Tag = "Ruta";
            this.LblRuta.Text = "Ruta";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(32, 72);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Tag = "Nombre";
            this.LblNombre.Text = "Nombre";
            // 
            // TxtRuta
            // 
            this.TxtRuta.Location = new System.Drawing.Point(167, 33);
            this.TxtRuta.Name = "TxtRuta";
            this.TxtRuta.Size = new System.Drawing.Size(192, 22);
            this.TxtRuta.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(167, 72);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(192, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(272, 134);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(87, 34);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Tag = " Modificar";
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnExaminar
            // 
            this.BtnExaminar.Location = new System.Drawing.Point(383, 27);
            this.BtnExaminar.Name = "BtnExaminar";
            this.BtnExaminar.Size = new System.Drawing.Size(87, 34);
            this.BtnExaminar.TabIndex = 7;
            this.BtnExaminar.Tag = "Examinar";
            this.BtnExaminar.Text = "Examinar";
            this.BtnExaminar.UseVisualStyleBackColor = true;
            this.BtnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // BtnBackup
            // 
            this.BtnBackup.Location = new System.Drawing.Point(35, 134);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(87, 34);
            this.BtnBackup.TabIndex = 8;
            this.BtnBackup.Tag = "Realizar";
            this.BtnBackup.Text = "Realizar";
            this.BtnBackup.UseVisualStyleBackColor = true;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 205);
            this.Controls.Add(this.BtnBackup);
            this.Controls.Add(this.BtnExaminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtRuta);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblRuta);
            this.Name = "Backup";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRuta;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtRuta;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnExaminar;
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}