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
    public partial class ControlCambioProveedor : Form, IObserver
    {
        Negocio_BLL.ControlCambioProveedor GestorControlCambio = new Negocio_BLL.ControlCambioProveedor();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Propiedades_BE.Proveedor ProveedorTemp = new Propiedades_BE.Proveedor();

        private static ControlCambioProveedor _instancia;
        public static ControlCambioProveedor ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new ControlCambioProveedor();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public ControlCambioProveedor()
        {
            InitializeComponent();
        }

        #region Metodos
        void ListarCambios()
        {
            dataGridViewControlCambio.DataSource = null;
            dataGridViewControlCambio.DataSource = GestorControlCambio.ListarControlCambioProveedor();
            dataGridViewControlCambio.Columns["IdProveedor"].Visible = false;
            dataGridViewControlCambio.ReadOnly = true;
        }

        void RetomarEstadoProveedor()
        {
            GestorControlCambio.VolverEstadoProveedor(ProveedorTemp);
        }

        void Filtrar()
        {
            dataGridViewControlCambio.DataSource = null;
            dataGridViewControlCambio.DataSource = GestorControlCambio.FiltrarCambio(txtCUIT.Text);
            dataGridViewControlCambio.Columns["IdProveedor"].Visible = false;
            dataGridViewControlCambio.ReadOnly = true;
        }

        void LimpiarTxt()
        {
            txtCUIT.Text = "";
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(txtCUIT.Text))
            {
                A = true;
            }
            return A;
        }
        #endregion

        #region Traduccion
        public void Update(ISubject Sujeto)
        {
            LblCUIT.Text = Sujeto.TraducirObserver(LblCUIT.Tag.ToString()) ?? LblCUIT.Tag.ToString();
            BtnCancelarFiltro.Text = Sujeto.TraducirObserver(BtnCancelarFiltro.Tag.ToString()) ?? BtnCancelarFiltro.Tag.ToString();
            BtnFiltrar.Text = Sujeto.TraducirObserver(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            BtnRestaurar.Text = Sujeto.TraducirObserver(BtnRestaurar.Tag.ToString()) ?? BtnRestaurar.Tag.ToString();
            BtnVolver.Text = Sujeto.TraducirObserver(BtnVolver.Tag.ToString()) ?? BtnVolver.Tag.ToString();
            //this.Text = Sujeto.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            LblCUIT.Text = CambiarIdioma.TraducirGlobal(LblCUIT.Tag.ToString()) ?? LblCUIT.Tag.ToString();
            BtnCancelarFiltro.Text = CambiarIdioma.TraducirGlobal(BtnCancelarFiltro.Tag.ToString()) ?? BtnCancelarFiltro.Tag.ToString();
            BtnFiltrar.Text = CambiarIdioma.TraducirGlobal(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            BtnRestaurar.Text = CambiarIdioma.TraducirGlobal(BtnRestaurar.Tag.ToString()) ?? BtnRestaurar.Tag.ToString();
            BtnVolver.Text = CambiarIdioma.TraducirGlobal(BtnVolver.Tag.ToString()) ?? BtnVolver.Tag.ToString();
            //this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }


        #endregion

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Filtrar();
                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Complete todos los campos") ?? "Complete todos los campos");
            }
        }

        private void BtnCancelarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                ListarCambios();
                LimpiarTxt();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                RetomarEstadoProveedor();
                ListarCambios();
                LimpiarTxt();
                //Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Cambio estado del proveedor", "Baja");
                MessageBox.Show(CambiarIdioma.TraducirGlobal("El estado del proveedor fue restaurado exitosamente") ?? "El estado del proveedor fue restaurado exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error al restaurar") ?? "Error al restaurar");
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor P = new Proveedor();
                P.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void ControlCambioProveedor_Load(object sender, EventArgs e)
        {
            ListarCambios();
            Traducir();
        }

        private void dataGridViewControlCambio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProveedorTemp.IdProveedor = int.Parse(Convert.ToString(dataGridViewControlCambio.Rows[e.RowIndex].Cells[0].Value.ToString()));
                txtCUIT.Text = Convert.ToString(dataGridViewControlCambio.Rows[e.RowIndex].Cells[1].Value.ToString());
                ProveedorTemp.CUIT = Seguridad.EncriptarAES(txtCUIT.Text);
                ProveedorTemp.Nombre = Convert.ToString(dataGridViewControlCambio.Rows[e.RowIndex].Cells[2].Value.ToString());
                ProveedorTemp.Apellido = Convert.ToString(dataGridViewControlCambio.Rows[e.RowIndex].Cells[3].Value.ToString());
                ProveedorTemp.FechaNac = DateTime.Parse(Convert.ToString(dataGridViewControlCambio.Rows[e.RowIndex].Cells[4].Value.ToString()));
                ProveedorTemp.Tel = int.Parse(Convert.ToString(dataGridViewControlCambio.Rows[e.RowIndex].Cells[5].Value.ToString()));
                ProveedorTemp.Mail = Convert.ToString(dataGridViewControlCambio.Rows[e.RowIndex].Cells[6].Value.ToString());
                ProveedorTemp.BajaLogica = bool.Parse(dataGridViewControlCambio.Rows[e.RowIndex].Cells[7].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
    }
}
