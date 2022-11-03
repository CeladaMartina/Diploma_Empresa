using Diploma_Empresa_Final;
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
using System.Resources;

namespace Interfaz_GUI
{
    public partial class ReporteForm : Form, IObserver
    {
        Negocio_BLL.Producto GestorArticulo = new Negocio_BLL.Producto();
        
        public ReporteForm()
        {
            InitializeComponent();
        }

        private void ReporteForm_Load(object sender, EventArgs e)
        {
            Traducir();
            Listar();
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
        #region traduccion
        public void Update(ISubject Subject)
        {
            label1.Text = Subject.TraducirObserver(label1.Tag.ToString()) ?? label1.Tag.ToString();
        }

        public void Traducir()
        {
            label1.Text = CambiarIdioma.TraducirGlobal(label1.Tag.ToString()) ?? label1.Tag.ToString();
        }
        #endregion

        public void Listar()
        {
            dataGridViewProd.DataSource = null;
            dataGridViewProd.DataSource = GestorArticulo.ListarTopProductos();
            dataGridViewProd.Columns["IdArticulo"].Visible = false;
            dataGridViewProd.Columns["IdLocalidad"].Visible = false;
            dataGridViewProd.Columns["NombreLocalidad"].Visible = false;
            dataGridViewProd.Columns["Material"].Visible = false;
            dataGridViewProd.Columns["Talle"].Visible = false;
            dataGridViewProd.Columns["Stock"].Visible = false;
            dataGridViewProd.Columns["BajaLogica"].Visible = false;
            dataGridViewProd.ReadOnly = true;
        }
    }
}
