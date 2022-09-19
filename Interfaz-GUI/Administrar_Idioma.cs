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
    public partial class Administrar_Idioma : Form, IObserver
    {
        Negocio_BLL.Idioma GestorIdioma = new Negocio_BLL.Idioma();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

        int IdIdioma = -1;

        private static Administrar_Idioma _instancia;
        public static Administrar_Idioma ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Administrar_Idioma();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public Administrar_Idioma()
        {
            InitializeComponent();
        }

        #region Metodos Traduccion
        public void Update(ISubject subject)
        {
            LblNombre.Text = subject.TraducirObserver(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            BtnAlta.Text = subject.TraducirObserver(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnModificar.Text = subject.TraducirObserver(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            BtnBaja.Text = subject.TraducirObserver(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            
        }

        public void Traducir()
        {
            LblNombre.Text = CambiarIdioma.TraducirGlobal(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            BtnAlta.Text = CambiarIdioma.TraducirGlobal(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnModificar.Text = CambiarIdioma.TraducirGlobal(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            BtnBaja.Text = CambiarIdioma.TraducirGlobal(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
           
        }
        #endregion

        #region Metodos funcionales 
        void LimpiarTxt()
        {
            TxtNombreIdioma.Text = "";
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtNombreIdioma.Text))
            {
                A = true;
            }
            return A;
        }
        #endregion

        #region Metodos
        void Listar()
        {
            dataGridViewIdioma.DataSource = null;
            dataGridViewIdioma.DataSource = GestorIdioma.Listar();
            dataGridViewIdioma.Columns["IdIdioma"].Visible = false;
            dataGridViewIdioma.ReadOnly = true;
        }

        void Alta(int IdIdioma, string Nombre)
        {
            GestorIdioma.Alta(IdIdioma, Nombre);
            //Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta Idioma", "Media");

            Listar();
            LimpiarTxt();
            IdIdioma = -1;
        }

        void Modificar(int IdIdioma, string Nombre)
        {
            GestorIdioma.Modificar(IdIdioma, Nombre);
            //Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar Idioma", "Baja");

            Listar();
            LimpiarTxt();
            IdIdioma = -1;
        }

        void Baja(int IdIdioma)
        {
            GestorIdioma.Baja(IdIdioma);
            //Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja Idioma", "Baja");

            Listar();
            LimpiarTxt();
            IdIdioma = -1;
        }
        #endregion

        #region Botones
        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Alta(IdIdioma, TxtNombreIdioma.Text);
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
                    Modificar(IdIdioma, TxtNombreIdioma.Text);
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
                    Baja(IdIdioma);
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

        private void Administrar_Idioma_Load(object sender, EventArgs e)
        {
            Listar();
            Traducir();
        }

        private void dataGridViewIdioma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdIdioma = int.Parse(Convert.ToString(dataGridViewIdioma.Rows[e.RowIndex].Cells[0].Value.ToString()));
                TxtNombreIdioma.Text = Convert.ToString(dataGridViewIdioma.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        #endregion
    }
}
