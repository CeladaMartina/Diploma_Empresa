
namespace Interfaz_GUI
{
    partial class CambiarIdioma
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
            this.groupBoxIdioma = new System.Windows.Forms.GroupBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblElegirIdioma = new System.Windows.Forms.Label();
            this.comboBoxIdiomas = new System.Windows.Forms.ComboBox();
            this.groupBoxIdioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIdioma
            // 
            this.groupBoxIdioma.Controls.Add(this.comboBoxIdiomas);
            this.groupBoxIdioma.Controls.Add(this.BtnAceptar);
            this.groupBoxIdioma.Controls.Add(this.LblElegirIdioma);
            this.groupBoxIdioma.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIdioma.Name = "groupBoxIdioma";
            this.groupBoxIdioma.Size = new System.Drawing.Size(344, 248);
            this.groupBoxIdioma.TabIndex = 0;
            this.groupBoxIdioma.TabStop = false;
            this.groupBoxIdioma.Tag = "Elegir Idioma";
            this.groupBoxIdioma.Text = "Elegir Idioma";
            this.groupBoxIdioma.Enter += new System.EventHandler(this.groupBoxIdioma_Enter);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(102, 162);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(91, 31);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Tag = "Aceptar";
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // LblElegirIdioma
            // 
            this.LblElegirIdioma.AutoSize = true;
            this.LblElegirIdioma.Location = new System.Drawing.Point(66, 48);
            this.LblElegirIdioma.Name = "LblElegirIdioma";
            this.LblElegirIdioma.Size = new System.Drawing.Size(184, 17);
            this.LblElegirIdioma.TabIndex = 0;
            this.LblElegirIdioma.Tag = "¿Que idioma desea utilizar?";
            this.LblElegirIdioma.Text = "¿Que idioma desea utilizar?";
            // 
            // comboBoxIdiomas
            // 
            this.comboBoxIdiomas.FormattingEnabled = true;
            this.comboBoxIdiomas.Location = new System.Drawing.Point(69, 99);
            this.comboBoxIdiomas.Name = "comboBoxIdiomas";
            this.comboBoxIdiomas.Size = new System.Drawing.Size(172, 24);
            this.comboBoxIdiomas.TabIndex = 4;
            // 
            // CambiarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 285);
            this.Controls.Add(this.groupBoxIdioma);
            this.Name = "CambiarIdioma";
            this.Text = "CambiarIdioma";
            this.Load += new System.EventHandler(this.CambiarIdioma_Load);
            this.groupBoxIdioma.ResumeLayout(false);
            this.groupBoxIdioma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIdioma;
        private System.Windows.Forms.Label LblElegirIdioma;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox comboBoxIdiomas;
    }
}