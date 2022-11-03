
namespace Interfaz_GUI
{
    partial class ReporteForm
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
            this.BtnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.dataGridViewProd = new System.Windows.Forms.DataGridView();
            this.groupBoxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(720, 418);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(94, 36);
            this.BtnVolver.TabIndex = 2;
            this.BtnVolver.Tag = "Volver";
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 3;
            this.label1.Tag = "Top 5 Productos mas caros";
            this.label1.Text = "Top 5 Productos mas caros";
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.BackColor = System.Drawing.Color.White;
            this.groupBoxLista.Controls.Add(this.dataGridViewProd);
            this.groupBoxLista.Location = new System.Drawing.Point(22, 83);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(792, 329);
            this.groupBoxLista.TabIndex = 4;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Tag = "Lista";
            this.groupBoxLista.Text = "Lista";
            // 
            // dataGridViewProd
            // 
            this.dataGridViewProd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProd.GridColor = System.Drawing.Color.White;
            this.dataGridViewProd.Location = new System.Drawing.Point(21, 29);
            this.dataGridViewProd.Name = "dataGridViewProd";
            this.dataGridViewProd.RowHeadersWidth = 51;
            this.dataGridViewProd.RowTemplate.Height = 24;
            this.dataGridViewProd.Size = new System.Drawing.Size(752, 275);
            this.dataGridViewProd.TabIndex = 0;
            // 
            // ReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 466);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVolver);
            this.Name = "ReporteForm";
            this.Text = "ReporteForm";
            this.Load += new System.EventHandler(this.ReporteForm_Load);
            this.groupBoxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.DataGridView dataGridViewProd;
    }
}