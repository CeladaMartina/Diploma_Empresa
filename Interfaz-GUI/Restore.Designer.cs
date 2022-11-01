
namespace Interfaz_GUI
{
    partial class Restore
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
            this.BtnAgregarPartes = new System.Windows.Forms.Button();
            this.BtnLimpiarLista = new System.Windows.Forms.Button();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAgregarPartes
            // 
            this.BtnAgregarPartes.Location = new System.Drawing.Point(350, 12);
            this.BtnAgregarPartes.Name = "BtnAgregarPartes";
            this.BtnAgregarPartes.Size = new System.Drawing.Size(85, 32);
            this.BtnAgregarPartes.TabIndex = 1;
            this.BtnAgregarPartes.Tag = "Agregar";
            this.BtnAgregarPartes.Text = "Agregar";
            this.BtnAgregarPartes.UseVisualStyleBackColor = true;
            this.BtnAgregarPartes.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLimpiarLista
            // 
            this.BtnLimpiarLista.Location = new System.Drawing.Point(222, 81);
            this.BtnLimpiarLista.Name = "BtnLimpiarLista";
            this.BtnLimpiarLista.Size = new System.Drawing.Size(85, 30);
            this.BtnLimpiarLista.TabIndex = 2;
            this.BtnLimpiarLista.Tag = "Limpiar";
            this.BtnLimpiarLista.Text = "Limpiar";
            this.BtnLimpiarLista.UseVisualStyleBackColor = true;
            this.BtnLimpiarLista.Click += new System.EventHandler(this.BtnLimpiarLista_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.Location = new System.Drawing.Point(12, 81);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(85, 30);
            this.BtnRestore.TabIndex = 3;
            this.BtnRestore.Tag = "Realizar";
            this.BtnRestore.Text = "Realizar";
            this.BtnRestore.UseVisualStyleBackColor = true;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(12, 22);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(295, 22);
            this.txtRestore.TabIndex = 4;
            // 
            // Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 144);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.BtnLimpiarLista);
            this.Controls.Add(this.BtnAgregarPartes);
            this.Name = "Restore";
            this.Text = "Restore";
            this.Load += new System.EventHandler(this.Restore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregarPartes;
        private System.Windows.Forms.Button BtnLimpiarLista;
        private System.Windows.Forms.Button BtnRestore;
        private System.Windows.Forms.TextBox txtRestore;
    }
}