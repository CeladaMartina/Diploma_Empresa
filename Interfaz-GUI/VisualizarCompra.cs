using Diploma_Empresa_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_GUI
{
    public partial class VisualizarCompra : Form, IObserver
    {
        Negocio_BLL.Proveedor GestorProveedor = new Negocio_BLL.Proveedor();
        Negocio_BLL.Compra GestorCompra = new Negocio_BLL.Compra();

        private static VisualizarCompra _instancia;
        public static VisualizarCompra ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new VisualizarCompra();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public VisualizarCompra()
        {
            InitializeComponent();
        }

        private void VisualizarCompra_Load(object sender, EventArgs e)
        {
            Traducir();
            Listar();
            CargarComboCUIT();
            dateTimePickerDesde.MaxDate = DateTime.Now;
            dateTimePickerHasta.MaxDate = DateTime.Now;
        }

        #region metodos
        void Listar()
        {
            dataGridViewCompras.DataSource = null;
            dataGridViewCompras.DataSource = GestorCompra.Listar();
            dataGridViewCompras.Columns["IdCompra"].Visible = false;
            dataGridViewCompras.Columns["IdProveedor"].Visible = false;
            dataGridViewCompras.ReadOnly = true;
        }        

        void CargarComboCUIT()
        {
            List<string> CUITs = GestorProveedor.CUITProveedor();
            foreach (var CUITp in CUITs)
            {
                comboBoxProveedorCUIT.Items.Add(CUITp.ToString());
            }
        }

        void LimpiarTxt()
        {
            TxtDesde.Text = "";
            TxtHasta.Text = "";
            comboBoxProveedorCUIT.SelectedIndex = -1;
        }

        void Filtrar()
        {
            dataGridViewCompras.DataSource = null;
            dataGridViewCompras.DataSource = GestorCompra.FiltradoCompleto(decimal.Parse(TxtDesde.Text), decimal.Parse(TxtHasta.Text), dateTimePickerDesde.Value.Date, dateTimePickerHasta.Value.Date, comboBoxProveedorCUIT.SelectedItem.ToString());           
            dataGridViewCompras.Columns["IdCompra"].Visible = false;
            dataGridViewCompras.Columns["IdProveedor"].Visible = false;
            dataGridViewCompras.ReadOnly = true;
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtDesde.Text) || string.IsNullOrEmpty(TxtHasta.Text)
                || string.IsNullOrEmpty(comboBoxProveedorCUIT.Text))
            {
                A = true;
            }
            return A;
        }
        #endregion

        #region traduccion
        void IObserver.Update(ISubject subject)
        {
            LblFiltrar.Text = subject.TraducirObserver(LblFiltrar.Tag.ToString()) ?? LblFiltrar.Tag.ToString();
            groupBoxMonto.Text = subject.TraducirObserver(groupBoxMonto.Tag.ToString()) ?? groupBoxMonto.Tag.ToString();
            groupBoxProveedor.Text = subject.TraducirObserver(groupBoxProveedor.Tag.ToString()) ?? groupBoxProveedor.Tag.ToString();
            groupBoxRangoFecha.Text = subject.TraducirObserver(groupBoxRangoFecha.Tag.ToString()) ?? groupBoxRangoFecha.Tag.ToString();
            LblCUIT.Text = subject.TraducirObserver(LblCUIT.Tag.ToString()) ?? LblCUIT.Tag.ToString();
            LblDesde.Text = subject.TraducirObserver(LblDesde.Tag.ToString()) ?? LblDesde.Tag.ToString();
            LblDesdeM.Text = subject.TraducirObserver(LblDesdeM.Tag.ToString()) ?? LblDesdeM.Tag.ToString();
            LblHasta.Text = subject.TraducirObserver(LblHasta.Tag.ToString()) ?? LblHasta.Tag.ToString();
            LblHastaM.Text = subject.TraducirObserver(LblHastaM.Tag.ToString()) ?? LblHastaM.Tag.ToString();
            BtnFiltrar.Text = subject.TraducirObserver(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            BtnCancelarFiltro.Text = subject.TraducirObserver(BtnCancelarFiltro.Tag.ToString()) ?? BtnCancelarFiltro.Tag.ToString();
            this.Text = subject.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            LblFiltrar.Text = CambiarIdioma.TraducirGlobal(LblFiltrar.Tag.ToString()) ?? LblFiltrar.Tag.ToString();
            groupBoxMonto.Text = CambiarIdioma.TraducirGlobal(groupBoxMonto.Tag.ToString()) ?? groupBoxMonto.Tag.ToString();
            groupBoxProveedor.Text = CambiarIdioma.TraducirGlobal(groupBoxProveedor.Tag.ToString()) ?? groupBoxProveedor.Tag.ToString();
            groupBoxRangoFecha.Text = CambiarIdioma.TraducirGlobal(groupBoxRangoFecha.Tag.ToString()) ?? groupBoxRangoFecha.Tag.ToString();
            LblCUIT.Text = CambiarIdioma.TraducirGlobal(LblCUIT.Tag.ToString()) ?? LblCUIT.Tag.ToString();
            LblDesde.Text = CambiarIdioma.TraducirGlobal(LblDesde.Tag.ToString()) ?? LblDesde.Tag.ToString();
            LblDesdeM.Text = CambiarIdioma.TraducirGlobal(LblDesdeM.Tag.ToString()) ?? LblDesdeM.Tag.ToString();
            LblHasta.Text = CambiarIdioma.TraducirGlobal(LblHasta.Tag.ToString()) ?? LblHasta.Tag.ToString();
            LblHastaM.Text = CambiarIdioma.TraducirGlobal(LblHastaM.Tag.ToString()) ?? LblHastaM.Tag.ToString();
            BtnFiltrar.Text = CambiarIdioma.TraducirGlobal(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            BtnCancelarFiltro.Text = CambiarIdioma.TraducirGlobal(BtnCancelarFiltro.Tag.ToString()) ?? BtnCancelarFiltro.Tag.ToString();
            this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }
        #endregion

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChequearFallaTxt() == false)
                {
                    Filtrar();
                }
                else
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error filtrando") ?? "Error filtrando");
                Listar();
            }
        }

        private void BtnCancelarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                Listar();                
                LimpiarTxt();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void dataGridViewCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
