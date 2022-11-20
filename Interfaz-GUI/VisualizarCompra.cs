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
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

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
            comboBoxProveedorCUIT.Items.Add("Todos");
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
            try
            {
                DateTime fechaDesde = Convert.ToDateTime(dateTimePickerDesde.Text);
                DateTime fechaHasta = Convert.ToDateTime(dateTimePickerHasta.Text);
                string proveedor = comboBoxProveedorCUIT.Text;
                string montoDesde = TxtDesde.Text;
                string montoHasta = TxtHasta.Text;
                string consultarProveedor = "";
                string consultaMonto = "";

                switch (proveedor)
                {
                    case "":
                        MessageBox.Show("seccione un proveedor", "Proveedor Vacio", MessageBoxButtons.OK,
                     MessageBoxIcon.Hand);
                        break;
                    case "Todos":
                        consultarProveedor = "select CUIT from Proveedor";
                        break;
                    default:
                        consultarProveedor = "select CUIT from Proveedor where CUIT = '" + Seguridad.EncriptarAES(proveedor) + "'";
                        break;
                }

                if (montoDesde != "" && montoHasta != "")
                {
                    consultaMonto = "(select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) >= '" + montoDesde + "' and (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) <= '" + montoHasta + "'";
                }
                else
                {
                    consultaMonto = "";
                }

                dataGridViewCompras.DataSource = GestorCompra.ConsultaCompra(fechaDesde, fechaHasta, consultarProveedor, consultaMonto);

                if (dataGridViewCompras.Rows.Count == 0)
                {
                    dataGridViewCompras.DataSource = null;
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("No hay valores para mostrar en la grilla.") ?? "No hay valores para mostrar en la grilla.");
                    Listar();
                    LimpiarTxt();
                }
                else
                {
                    dataGridViewCompras.Columns["IdCompra"].Visible = false;
                    dataGridViewCompras.Columns["IdProveedor"].Visible = false;
                    dataGridViewCompras.ReadOnly = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(comboBoxProveedorCUIT.Text))
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
                    if (dateTimePickerDesde.Value >= dateTimePickerHasta.Value)
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("La fecha Hasta no puede ser menor que Desde.") ?? "La fecha Hasta no puede ser menor que Desde.");
                    }
                    else if (TxtDesde.Text != "" && TxtHasta.Text != "")
                    {
                        if (Convert.ToInt32(TxtDesde.Text) >= Convert.ToInt32(TxtHasta.Text))
                        {
                            MessageBox.Show(CambiarIdioma.TraducirGlobal("El Monto Hasta no puede ser menor que el Monto Desde.") ?? "El Monto Hasta no puede ser menor que el Monto Desde.");
                        }
                        else
                        {
                            Filtrar();
                        }                            
                    }
                    else
                    {
                        Filtrar();
                    }
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
