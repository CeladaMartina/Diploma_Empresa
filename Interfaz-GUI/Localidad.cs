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
    public partial class Localidad : Form, IObserver
    {
        Negocio_BLL.Localidad GestorLocalidad = new Negocio_BLL.Localidad();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        private static Localidad _instancia;
        int IdLocalidad = -1;
        public static Localidad ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Localidad();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public Localidad()
        {
            InitializeComponent();
        }

        #region ABML

        void Alta(int IdLocalidad, string Nombre, string Descripcion, string CodPostal, string Partido)
        {
            GestorLocalidad.Alta(IdLocalidad, Nombre, Descripcion, int.Parse(CodPostal), Partido);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta Localidad", "Alta", 0);

            Listar();
            LimpiarTxt();
            IdLocalidad = -1;
        }

        void Modificar(int IdLocalidad, string Nombre, string Descripcion, string CodPostal, string Partido)
        {
            GestorLocalidad.Modificar(IdLocalidad, Nombre, Descripcion, int.Parse(CodPostal), Partido);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar Localidad", "Baja", 0);

            Listar();
            LimpiarTxt();
            IdLocalidad = -1;
        }

        void Baja(int IdLocalidad)
        {
            GestorLocalidad.Baja(IdLocalidad);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja Localidad", "Baja",0);

            Listar();
            LimpiarTxt();
            IdLocalidad = -1;
        }

        void Listar()
        {
            dataGridViewLocalidad.DataSource = null;
            dataGridViewLocalidad.DataSource = GestorLocalidad.Listar();
            dataGridViewLocalidad.Columns["IdLocalidad"].Visible = false;
            dataGridViewLocalidad.ReadOnly = true;
        }
        void LimpiarTxt()
        {
            TxtNombre.Text = "";
            TxtPartido.Text = "";
            TxtDescripcion.Text = "";
            TxtCodPostal.Text = "";
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtDescripcion.Text)
                || string.IsNullOrEmpty(TxtCodPostal.Text) || string.IsNullOrEmpty(TxtPartido.Text))
            {
                A = true;
            }
            return A;
        }
        #endregion

        #region traduccion 
        public void Update(ISubject Subject)
        {
            LblCodPostal.Text = Subject.TraducirObserver(LblCodPostal.Tag.ToString()) ?? LblCodPostal.Tag.ToString();
            LblDescripcion.Text = Subject.TraducirObserver(LblDescripcion.Tag.ToString()) ?? LblDescripcion.Tag.ToString();
            LblNombre.Text = Subject.TraducirObserver(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            LblPartido.Text = Subject.TraducirObserver(LblPartido.Tag.ToString()) ?? LblPartido.Tag.ToString();
            BtnAlta.Text = Subject.TraducirObserver(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnModificacion.Text = Subject.TraducirObserver(BtnModificacion.Tag.ToString()) ?? BtnModificacion.Tag.ToString();
            BtnBaja.Text = Subject.TraducirObserver(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            this.Text = Subject.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            LblCodPostal.Text = CambiarIdioma.TraducirGlobal(LblCodPostal.Tag.ToString()) ?? LblCodPostal.Tag.ToString();
            LblDescripcion.Text = CambiarIdioma.TraducirGlobal(LblDescripcion.Tag.ToString()) ?? LblDescripcion.Tag.ToString();
            LblNombre.Text = CambiarIdioma.TraducirGlobal(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            LblPartido.Text = CambiarIdioma.TraducirGlobal(LblPartido.Tag.ToString()) ?? LblPartido.Tag.ToString();
            BtnAlta.Text = CambiarIdioma.TraducirGlobal(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnModificacion.Text = CambiarIdioma.TraducirGlobal(BtnModificacion.Tag.ToString()) ?? BtnModificacion.Tag.ToString();
            BtnBaja.Text = CambiarIdioma.TraducirGlobal(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }
        #endregion
        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Alta(IdLocalidad, TxtNombre.Text, TxtDescripcion.Text, TxtCodPostal.Text, TxtPartido.Text);
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

        private void BtnModificacion_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Modificar(IdLocalidad, TxtNombre.Text, TxtDescripcion.Text, TxtCodPostal.Text, TxtPartido.Text);
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
                    Baja(IdLocalidad);
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

        private void Localidad_Load(object sender, EventArgs e)
        {
            Traducir();
            Listar();
        }

        private void dataGridViewLocalidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdLocalidad = int.Parse(Convert.ToString(dataGridViewLocalidad.Rows[e.RowIndex].Cells[0].Value.ToString()));
                TxtNombre.Text = Convert.ToString(dataGridViewLocalidad.Rows[e.RowIndex].Cells[1].Value.ToString());
                TxtDescripcion.Text = Convert.ToString(dataGridViewLocalidad.Rows[e.RowIndex].Cells[2].Value.ToString());
                TxtCodPostal.Text = Convert.ToString(dataGridViewLocalidad.Rows[e.RowIndex].Cells[3].Value.ToString());
                TxtPartido.Text = Convert.ToString(dataGridViewLocalidad.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
    }
}
