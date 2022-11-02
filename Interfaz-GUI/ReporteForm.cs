using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_GUI
{
    public partial class ReporteForm : Form
    {
        Negocio_BLL.Producto GestorArticulo = new Negocio_BLL.Producto();
        public ReporteForm()
        {
            InitializeComponent();
        }

        private void ReporteForm_Load(object sender, EventArgs e)
        {

            this.reportViewerProduct.RefreshReport();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            string reportpath = Directory.GetCurrentDirectory() + "\\Reportes\\ReportProduct.rdlc";
            this.reportViewerProduct.LocalReport.ReportPath = reportpath;
            ReportDataSource rds = new ReportDataSource("ProductDataSet", GestorArticulo.ListarTopProductos());
            this.reportViewerProduct.LocalReport.DataSources.Add(rds);
            this.reportViewerProduct.RefreshReport();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Producto P = new Producto();
                P.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
    }
}
