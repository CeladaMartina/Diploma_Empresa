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
    public partial class Administrar_Patente : Form, IObserver
    {
        Propiedades_BE.Familia FamTemp = new Propiedades_BE.Familia();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Permisos GestorPermisos = new Negocio_BLL.Permisos();

        List<string> NomPat = new List<string>();
        List<string> NickUsuario = new List<string>();
        List<string> NombreFamilia = new List<string>();

        private static Administrar_Patente _instancia;
        public static Administrar_Patente ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Administrar_Patente();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Administrar_Patente()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void Administrar_Patente_Load(object sender, EventArgs e)
        {
            ListarPatente();
            Traducir();
        }

        #region Metodos Patente
        void ListarPatente()
        {
            dataGridViewAdmPatente.DataSource = null;
            dataGridViewAdmPatente.DataSource = GestorPermisos.GetAllPatentes();
            dataGridViewAdmPatente.Columns["Hijos"].Visible = false;
            dataGridViewAdmPatente.Columns["Id"].Visible = false;
            dataGridViewAdmPatente.ReadOnly = true;
        }

        void AltaPatente(string NombrePatente)
        {
            Propiedades_BE.Patente Pat = new Propiedades_BE.Patente();
            Pat.Nombre = NombrePatente;
            Pat.Permiso = (Propiedades_BE.TipoPermiso)this.CmbPermisos.SelectedItem;
            GestorPermisos.GuardarComponente(Pat, false);
            //Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta patente", "Baja");
            ListarPatente();
            LimpiarTxt();
        }

        void BajaPatente(string NombrePatente)
        {
            Propiedades_BE.Patente Pat = new Propiedades_BE.Patente();
            Pat.Nombre = NombrePatente;
            Pat.Permiso = (Propiedades_BE.TipoPermiso)this.CmbPermisos.SelectedItem;
            GestorPermisos.EliminarComponente(Pat, false);
            //Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja patente", "Baja");
            ListarPatente();
            LimpiarTxt();
        }
        #endregion

        #region Botones
        private void BtnCargarNomPat_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt(txtNombrePatente.Text) == false)
            {
                try
                {
                    AltaPatente(txtNombrePatente.Text);
                    CargarCombos();
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

        private void BtnQuitarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (GestorPermisos.VerificarBorradoPatente(txtNombrePatente.Text) == 0)
                {
                    BajaPatente(txtNombrePatente.Text);
                    CargarCombos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void dataGridViewAdmPatente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombrePatente.Text = Convert.ToString(dataGridViewAdmPatente.Rows[e.RowIndex].Cells["Nombre"].Value.ToString());
                CmbPermisos.Text = Convert.ToString(dataGridViewAdmPatente.Rows[e.RowIndex].Cells["Permiso"].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        #endregion

        #region Metodos 
        void CargarCombos()
        {
            this.CmbPermisos.DataSource = GestorPermisos.GetAllPermisos();           
        }

        void LimpiarTxt()
        {           
            txtNombrePatente.Text = "";           
            CmbPermisos.SelectedIndex = -1;            
        }

        bool ChequearFallaTxt(string Nombre)
        {
            bool A = false;
            if (string.IsNullOrEmpty(Nombre))
            {
                A = true;
            }
            return A;
        }


        #endregion

        #region Traduccion
        public void Update(ISubject subject)
        {
           
            LblNombrePatente.Text = subject.TraducirObserver(LblNombrePatente.Tag.ToString()) ?? LblNombrePatente.Tag.ToString();
            LblPermiso.Text = subject.TraducirObserver(LblPermiso.Tag.ToString()) ?? LblPermiso.Tag.ToString();
            BtnCargarNomPat.Text = subject.TraducirObserver(BtnCargarNomPat.Tag.ToString()) ?? BtnCargarNomPat.Tag.ToString();
            BtnQuitarPermiso.Text = subject.TraducirObserver(BtnQuitarPermiso.Tag.ToString()) ?? BtnQuitarPermiso.Tag.ToString();
        }

        public void Traducir()
        {
            LblNombrePatente.Text = CambiarIdioma.TraducirGlobal(LblNombrePatente.Tag.ToString()) ?? LblNombrePatente.Tag.ToString();
            LblPermiso.Text = CambiarIdioma.TraducirGlobal(LblPermiso.Tag.ToString()) ?? LblPermiso.Tag.ToString();
            BtnCargarNomPat.Text = CambiarIdioma.TraducirGlobal(BtnCargarNomPat.Tag.ToString()) ?? BtnCargarNomPat.Tag.ToString();
            BtnQuitarPermiso.Text = CambiarIdioma.TraducirGlobal(BtnQuitarPermiso.Tag.ToString()) ?? BtnQuitarPermiso.Tag.ToString();
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
