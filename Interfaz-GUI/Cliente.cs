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
    public partial class Cliente : Form
    {
        Negocio_BLL.Cliente GestorCliente = new Negocio_BLL.Cliente();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        DateTime Fecha;

        int IdCliente = -1;

        private static Cliente _instancia;
        public static Cliente ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Cliente();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        void Alta(int IdCliente, string Nombre, string Apellido, string DNI, string Mail, int Tel, DateTime FechaNac)
        {
            GestorCliente.Alta(IdCliente, Nombre, Apellido, DNI, Mail, Tel, FechaNac);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta Cliente", "Media",0);

            Listar();
            LimpiarTxt();
            IdCliente = -1;
        }

        void Modificar(int IdCliente, string Nombre, string Apellido, string DNI, string Mail, int Tel, DateTime FechaNac)
        {
            GestorCliente.Modificar(IdCliente, Nombre, Apellido, DNI, Mail, Tel, FechaNac);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar Cliente", "Baja",0);

            Listar();
            LimpiarTxt();
            IdCliente = -1;
        }

        void Baja(int IdCliente)
        {
            GestorCliente.Baja(IdCliente);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja Cliente", "Baja",0);

            Listar();
            LimpiarTxt();
            IdCliente = -1;
        }

        void Listar()
        {
            dataGridViewCliente.DataSource = null;
            dataGridViewCliente.DataSource = GestorCliente.Listar();
            dataGridViewCliente.Columns["IdCliente"].Visible = false;
            dataGridViewCliente.ReadOnly = true;
        }
        void LimpiarTxt()
        {
            TxtDNI.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtTelefono.Text = "";
            TxtMail.Text = "";
            dateTimePickerFecNac.Value = Fecha;
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtDNI.Text) || string.IsNullOrEmpty(TxtNombre.Text) ||
                string.IsNullOrEmpty(TxtApellido.Text) || string.IsNullOrEmpty(TxtTelefono.Text) ||
                string.IsNullOrEmpty(TxtMail.Text))
            {
                A = true;
            }
            return A;
        }

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            Listar();
            Fecha = DateTime.Now;
            dateTimePickerFecNac.MaxDate = Fecha;
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Alta(IdCliente, TxtNombre.Text, TxtApellido.Text, Seguridad.EncriptarAES(TxtDNI.Text), TxtMail.Text, int.Parse(TxtTelefono.Text), DateTime.Parse(dateTimePickerFecNac.Text));
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
                    Modificar(IdCliente, TxtNombre.Text, TxtApellido.Text, Seguridad.EncriptarAES(TxtDNI.Text), TxtMail.Text, int.Parse(TxtTelefono.Text), DateTime.Parse(dateTimePickerFecNac.Text));
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
                    Baja(IdCliente);
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

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdCliente = int.Parse(Convert.ToString(dataGridViewCliente.Rows[e.RowIndex].Cells[0].Value.ToString()));
                TxtDNI.Text = Convert.ToString(dataGridViewCliente.Rows[e.RowIndex].Cells[1].Value.ToString());
                TxtNombre.Text = Convert.ToString(dataGridViewCliente.Rows[e.RowIndex].Cells[2].Value.ToString());
                TxtApellido.Text = Convert.ToString(dataGridViewCliente.Rows[e.RowIndex].Cells[3].Value.ToString());
                dateTimePickerFecNac.Text = Convert.ToString(dataGridViewCliente.Rows[e.RowIndex].Cells[4].Value.ToString());
                TxtTelefono.Text = Convert.ToString(dataGridViewCliente.Rows[e.RowIndex].Cells[5].Value.ToString());
                TxtMail.Text = Convert.ToString(dataGridViewCliente.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
    }
}
