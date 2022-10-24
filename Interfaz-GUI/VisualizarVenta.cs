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
    public partial class VisualizarVenta : Form, IObserver
    {
        Negocio_BLL.Venta GestorVenta = new Negocio_BLL.Venta();
        Negocio_BLL.Cliente GestorCliente = new Negocio_BLL.Cliente();

        private static VisualizarVenta _instancia;
        public static VisualizarVenta ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new VisualizarVenta();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public VisualizarVenta()
        {
            InitializeComponent();
        }

        #region metodos
        void Listar()
        {
            dataGridViewDV.DataSource = null;
            dataGridViewDV.DataSource = GestorVenta.Listar();
            dataGridViewDV.Columns["IdVenta"].Visible = false;
            dataGridViewDV.Columns["IdCliente"].Visible = false;
            dataGridViewDV.ReadOnly = true;
        }

        void CargarComboDNI()
        {
            List<string> DNIs = GestorCliente.DNIsClientes();
            foreach (var DNIc in DNIs)
            {
                CmbDNIClientes.Items.Add(DNIc.ToString());
            }
        }

        void Filtrar()
        {
            dataGridViewDV.DataSource = null;
            dataGridViewDV.DataSource =  GestorVenta.FiltradoCompleto(CmbDNIClientes.SelectedItem.ToString(), dateTimePickerDesde.Value.Date, dateTimePickerHasta.Value.Date, decimal.Parse(TxtDesde.Text), decimal.Parse(TxtHasta.Text));
            dataGridViewDV.Columns["IdVenta"].Visible = false;
            dataGridViewDV.Columns["IdCliente"].Visible = false;
            dataGridViewDV.ReadOnly = true;
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtDesde.Text) || string.IsNullOrEmpty(TxtHasta.Text)
                || string.IsNullOrEmpty(CmbDNIClientes.Text))
            {
                A = true;
            }
            return A;
        }

        void LimpiarTxt()
        {
            TxtDesde.Text = "";
            TxtHasta.Text = "";
            CmbDNIClientes.SelectedIndex = -1;
        }
        #endregion

        #region traduccion 
        void IObserver.Update(ISubject Subject)
        {
            LblFiltrar.Text = Subject.TraducirObserver(LblFiltrar.Tag.ToString()) ?? LblFiltrar.Tag.ToString();
            groupBoxCliente.Text = Subject.TraducirObserver(groupBoxCliente.Tag.ToString()) ?? groupBoxCliente.Tag.ToString();
            groupBoxMonto.Text = Subject.TraducirObserver(groupBoxMonto.Tag.ToString()) ?? groupBoxMonto.Tag.ToString();
            groupBoxRangoFecha.Text = Subject.TraducirObserver(groupBoxRangoFecha.Tag.ToString()) ?? groupBoxRangoFecha.Tag.ToString();
            LblDesdeM.Text = Subject.TraducirObserver(LblDesdeM.Tag.ToString()) ?? LblDesdeM.Tag.ToString();
            LblDesde.Text = Subject.TraducirObserver(LblDesde.Tag.ToString()) ?? LblDesde.Tag.ToString();
            LblDNI.Text = Subject.TraducirObserver(LblDNI.Tag.ToString()) ?? LblDNI.Tag.ToString();
            LblHastaM.Text = Subject.TraducirObserver(LblHastaM.Tag.ToString()) ?? LblHastaM.Tag.ToString();
            LblHasta.Text = Subject.TraducirObserver(LblHasta.Tag.ToString()) ?? LblHasta.Tag.ToString();
            BtnCancelarFiltro.Text = Subject.TraducirObserver(BtnCancelarFiltro.Tag.ToString()) ?? BtnCancelarFiltro.Tag.ToString();
            BtnFiltrar.Text = Subject.TraducirObserver(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            this.Text = Subject.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        void Traducir()
        {
            LblFiltrar.Text = CambiarIdioma.TraducirGlobal(LblFiltrar.Tag.ToString()) ?? LblFiltrar.Tag.ToString();
            groupBoxCliente.Text = CambiarIdioma.TraducirGlobal(groupBoxCliente.Tag.ToString()) ?? groupBoxCliente.Tag.ToString();
            groupBoxMonto.Text = CambiarIdioma.TraducirGlobal(groupBoxMonto.Tag.ToString()) ?? groupBoxMonto.Tag.ToString();
            groupBoxRangoFecha.Text = CambiarIdioma.TraducirGlobal(groupBoxRangoFecha.Tag.ToString()) ?? groupBoxRangoFecha.Tag.ToString();
            LblDesdeM.Text = CambiarIdioma.TraducirGlobal(LblDesdeM.Tag.ToString()) ?? LblDesdeM.Tag.ToString();
            LblDesde.Text = CambiarIdioma.TraducirGlobal(LblDesde.Tag.ToString()) ?? LblDesde.Tag.ToString();
            LblDNI.Text = CambiarIdioma.TraducirGlobal(LblDNI.Tag.ToString()) ?? LblDNI.Tag.ToString();
            LblHastaM.Text = CambiarIdioma.TraducirGlobal(LblHastaM.Tag.ToString()) ?? LblHastaM.Tag.ToString();
            LblHasta.Text = CambiarIdioma.TraducirGlobal(LblHasta.Tag.ToString()) ?? LblHasta.Tag.ToString();
            BtnCancelarFiltro.Text = CambiarIdioma.TraducirGlobal(BtnCancelarFiltro.Tag.ToString()) ?? BtnCancelarFiltro.Tag.ToString();
            BtnFiltrar.Text = CambiarIdioma.TraducirGlobal(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }
        #endregion
        private void VisualizarVenta_Load(object sender, EventArgs e)
        {
            Traducir();
            Listar();
            CargarComboDNI();
            dateTimePickerDesde.MaxDate = DateTime.Now;
            dateTimePickerHasta.MaxDate = DateTime.Now;
        }

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
    }
}
