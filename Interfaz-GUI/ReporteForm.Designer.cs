
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
            this.reportViewerProduct = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewerProduct
            // 
            this.reportViewerProduct.Location = new System.Drawing.Point(12, 69);
            this.reportViewerProduct.Name = "reportViewerProduct";
            this.reportViewerProduct.ServerReport.BearerToken = null;
            this.reportViewerProduct.Size = new System.Drawing.Size(861, 418);
            this.reportViewerProduct.TabIndex = 0;
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Location = new System.Drawing.Point(12, 26);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(161, 27);
            this.BtnGenerarReporte.TabIndex = 1;
            this.BtnGenerarReporte.Tag = "Generar Reporte";
            this.BtnGenerarReporte.Text = "Generar Reporte";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(779, 509);
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
            this.label1.Location = new System.Drawing.Point(197, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 3;
            this.label1.Tag = "Top 5 Productos mas caros";
            this.label1.Text = "Top 5 Productos mas caros";
            // 
            // ReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnGenerarReporte);
            this.Controls.Add(this.reportViewerProduct);
            this.Name = "ReporteForm";
            this.Text = "ReporteForm";
            this.Load += new System.EventHandler(this.ReporteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerProduct;
        private System.Windows.Forms.Button BtnGenerarReporte;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Label label1;
    }
}