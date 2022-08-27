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
    public partial class Proveedor : Form, IObserver
    {
        Negocio_BLL.Proveedor GestorProveedor = new Negocio_BLL.Proveedor();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.ControlCambioProveedor GestorControlCambio = new Negocio_BLL.ControlCambioProveedor();
        DateTime Fecha;

        int IdProveedor = -1;

        private static Proveedor _instancia;
        public static Proveedor ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Proveedor();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public Proveedor()
        {
            InitializeComponent();
        }

        #region Metodos
        void CargarCambiosProveedor(string CUIT, string Nombre, string Apellido, DateTime FechaNac, int Tel, string Mail, int IdUsuario, DateTime FechaModificacion)
        {
            GestorControlCambio.InsertarCambios(CUIT, Nombre, Apellido, FechaNac, Tel, Mail, IdUsuario, FechaModificacion);
        }

        void LimpiarTxt()
        {
            txtCUIT.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            dateTimePickerFecNac.Value = Fecha;
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(txtCUIT.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtTelefono.Text) ||
                string.IsNullOrEmpty(txtMail.Text))
            {
                A = true;
            }
            return A;
        }

        void Listar()
        {
            dataGridViewProveedor.DataSource = null;
            dataGridViewProveedor.DataSource = GestorProveedor.Listar();
            dataGridViewProveedor.Columns["IdProveedor"].Visible = false;
            dataGridViewProveedor.ReadOnly = true;
        }

        void Alta(int IdProveedor, string CUIT, string Nombre, string Apellido, DateTime FechaNac, int Tel, string Mail)
        {
            GestorProveedor.Alta(IdProveedor, CUIT, Nombre, Apellido, FechaNac, Tel, Mail);
            CargarCambiosProveedor(CUIT, Nombre, Apellido, FechaNac, Tel, Mail, Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta Proveedor", "Media");

            Listar();
            LimpiarTxt();
            IdProveedor = -1;
        }

        void Modificar(int IdProveedor, string CUIT, string Nombre, string Apellido, DateTime FechaNac, int Tel, string Mail)
        {
            GestorProveedor.Modificar(IdProveedor, CUIT, Nombre, Apellido, FechaNac, Tel, Mail);
            CargarCambiosProveedor(CUIT, Nombre, Apellido, FechaNac, Tel, Mail, Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar Proveedor", "Baja");

            Listar();
            LimpiarTxt();
            IdProveedor = -1;
        }

        void Baja(int IdProveedor, string CUIT, string Nombre, string Apellido, DateTime FechaNac, int Tel, string Mail)
        {
            GestorProveedor.Baja(IdProveedor);
            CargarCambiosProveedor(CUIT, Nombre, Apellido, FechaNac, Tel, Mail, Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja Proveedor", "Baja");

            Listar();
            LimpiarTxt();
            IdProveedor = -1;
        }
        #endregion

        #region Traduccion
        public void Update(ISubject Sujeto)
        {
            LblApellido.Text = Sujeto.TraducirObserver(LblApellido.Tag.ToString()) ?? LblApellido.Tag.ToString();
            LblCUIT.Text = Sujeto.TraducirObserver(LblCUIT.Tag.ToString()) ?? LblCUIT.Tag.ToString();
            LblFechaNac.Text = Sujeto.TraducirObserver(LblFechaNac.Tag.ToString()) ?? LblFechaNac.Tag.ToString();
            LblMail.Text = Sujeto.TraducirObserver(LblMail.Tag.ToString()) ?? LblMail.Tag.ToString();
            LblNombre.Text = Sujeto.TraducirObserver(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            LblTelefono.Text = Sujeto.TraducirObserver(LblTelefono.Tag.ToString()) ?? LblTelefono.Tag.ToString();
            BtnAlta.Text = Sujeto.TraducirObserver(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnBaja.Text = Sujeto.TraducirObserver(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnControlCambio.Text = Sujeto.TraducirObserver(BtnControlCambio.Tag.ToString()) ?? BtnControlCambio.Tag.ToString();
            BtnModificar.Text = Sujeto.TraducirObserver(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            //this.Text = Sujeto.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            LblApellido.Text = CambiarIdioma.TraducirGlobal(LblApellido.Tag.ToString()) ?? LblApellido.Tag.ToString();
            LblCUIT.Text = CambiarIdioma.TraducirGlobal(LblCUIT.Tag.ToString()) ?? LblCUIT.Tag.ToString();
            LblFechaNac.Text = CambiarIdioma.TraducirGlobal(LblFechaNac.Tag.ToString()) ?? LblFechaNac.Tag.ToString();
            LblMail.Text = CambiarIdioma.TraducirGlobal(LblMail.Tag.ToString()) ?? LblMail.Tag.ToString();
            LblNombre.Text = CambiarIdioma.TraducirGlobal(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            LblTelefono.Text = CambiarIdioma.TraducirGlobal(LblTelefono.Tag.ToString()) ?? LblTelefono.Tag.ToString();
            BtnAlta.Text = CambiarIdioma.TraducirGlobal(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnBaja.Text = CambiarIdioma.TraducirGlobal(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnControlCambio.Text = CambiarIdioma.TraducirGlobal(BtnControlCambio.Tag.ToString()) ?? BtnControlCambio.Tag.ToString();
            BtnModificar.Text = CambiarIdioma.TraducirGlobal(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            //this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        #endregion

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Alta(IdProveedor, Seguridad.EncriptarAES(txtCUIT.Text), txtNombre.Text, txtApellido.Text, DateTime.Parse(dateTimePickerFecNac.Text), int.Parse(txtTelefono.Text), txtMail.Text);
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Modificar(IdProveedor, Seguridad.EncriptarAES(txtCUIT.Text), txtNombre.Text, txtApellido.Text, DateTime.Parse(dateTimePickerFecNac.Text), int.Parse(txtTelefono.Text), txtMail.Text);
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

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Baja(IdProveedor, Seguridad.EncriptarAES(txtCUIT.Text), txtNombre.Text, txtApellido.Text, DateTime.Parse(dateTimePickerFecNac.Text), int.Parse(txtTelefono.Text), txtMail.Text);
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

        private void BtnControlCambio_Click(object sender, EventArgs e)
        {
            try
            {
                ControlCambioProveedor CCP = new ControlCambioProveedor();
                CCP.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void dataGridViewProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdProveedor = int.Parse(Convert.ToString(dataGridViewProveedor.Rows[e.RowIndex].Cells[0].Value.ToString()));
                txtCUIT.Text = Convert.ToString(dataGridViewProveedor.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtNombre.Text = Convert.ToString(dataGridViewProveedor.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtApellido.Text = Convert.ToString(dataGridViewProveedor.Rows[e.RowIndex].Cells[3].Value.ToString());
                dateTimePickerFecNac.Text = Convert.ToString(dataGridViewProveedor.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtTelefono.Text = Convert.ToString(dataGridViewProveedor.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtMail.Text = Convert.ToString(dataGridViewProveedor.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            Listar();
            Traducir();
            Fecha = DateTime.Now;
            dateTimePickerFecNac.MaxDate = Fecha;
        }
    }
}
