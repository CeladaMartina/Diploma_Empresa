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
    public partial class Administrar_Familia : Form, IObserver
    {
        Propiedades_BE.Familia FamTemp = new Propiedades_BE.Familia();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Permisos GestorPermisos = new Negocio_BLL.Permisos();

        List<string> NomPat = new List<string>();
        List<string> NickUsuario = new List<string>();
        List<string> NombreFamilia = new List<string>();

        private static Administrar_Familia _instancia;
        public static Administrar_Familia ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Administrar_Familia();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public Administrar_Familia()
        {
            InitializeComponent();
        }

        private void Administrar_Familia_Load(object sender, EventArgs e)
        {
            ListarFamilia();
            Traducir();
        }

        #region Metodos Familia
        void ListarFamilia()
        {
            dataGridViewFamilia.DataSource = null;
            dataGridViewFamilia.DataSource = GestorPermisos.GetAllFamilias();
            dataGridViewFamilia.Columns["Id"].Visible = false;
            dataGridViewFamilia.Columns["Hijos"].Visible = false;
            dataGridViewFamilia.Columns["NombreFamilia"].Visible = false;
            dataGridViewFamilia.Columns["Permiso"].Visible = false;
            dataGridViewFamilia.ReadOnly = true;
        }

        void AltaFamilia(string NombreFamilia)
        {
            Propiedades_BE.Familia Fam = new Propiedades_BE.Familia();
            Fam.Nombre = NombreFamilia;
            GestorPermisos.GuardarComponente(Fam, true);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta familia", "Media",0);
            ListarFamilia();
            LimpiarTxt();
        }

        void ModificarFamilia(string NombreFamilia, string NombreModificado)
        {
            GestorPermisos.ModificarFamilia(NombreFamilia, NombreModificado);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar familia", "Baja",0);
            ListarFamilia();
            //ListarAdmPermisos();
            LimpiarTxt();
        }

        void BajaFamilia(string NombreFamilia)
        {
            try
            {
                Propiedades_BE.Familia Fam = new Propiedades_BE.Familia();
                Fam.Nombre = NombreFamilia;
                GestorPermisos.EliminarComponente(Fam, true);
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja familia", "Baja",0);
                ListarFamilia();
                //ListarAdmPermisos();
                LimpiarTxt();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("No se puede dar de baja a la familia") ?? "No se puede dar de baja a la familia");
            }
        }

        #endregion
        
        #region Botones
        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt(txtNombre.Text) == false)
            {
                try
                {
                    AltaFamilia(txtNombre.Text);
                    //CargarCombos();
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
            if (ChequearFallaTxt(txtNombre.Text) == false)
            {
                try
                {
                    ModificarFamilia(txtNombre.Text, txtNombreNuevo.Text);
                    //CargarCombos();
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
            if (ChequearFallaTxt(txtNombre.Text) == false)
            {
                try
                {
                    if (GestorPermisos.VerificarBorradoFam(txtNombre.Text) == 0)
                    {
                        BajaFamilia(txtNombre.Text);
                        //CargarCombos();
                    }
                    else
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("Problema por patentes") ?? "Problema por patentes");
                    }
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

        private void dataGridViewFamilia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = Convert.ToString(dataGridViewFamilia.Rows[e.RowIndex].Cells["Nombre"].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
        #endregion

        #region Traduccion
        public void Update(ISubject subject)
        {
            LblNombre.Text = subject.TraducirObserver(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            LblNombreNuevo.Text = subject.TraducirObserver(LblNombreNuevo.Tag.ToString()) ?? LblNombreNuevo.Tag.ToString();
            BtnAlta.Text = subject.TraducirObserver(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnBaja.Text = subject.TraducirObserver(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnModificar.Text = subject.TraducirObserver(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
        }

        public void Traducir()
        {
            LblNombre.Text = CambiarIdioma.TraducirGlobal(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            LblNombreNuevo.Text = CambiarIdioma.TraducirGlobal(LblNombreNuevo.Tag.ToString()) ?? LblNombreNuevo.Tag.ToString();
            BtnAlta.Text = CambiarIdioma.TraducirGlobal(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnBaja.Text = CambiarIdioma.TraducirGlobal(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnModificar.Text = CambiarIdioma.TraducirGlobal(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();      
        }

        #endregion

        #region Metodos 
        void LimpiarTxt()
        {
            txtNombre.Text = "";
            txtNombreNuevo.Text = "";
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

        void ValidarPermisos()
        {
            if (Propiedades_BE.SingletonLogIn.GetInstance.IsLoggedIn())
            {
                //((Control)this.tabPage1).Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Familia);
                //((Control)this.tabPage2).Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Patentes);
                //((Control)this.tabPage3).Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Permisos);
            }
            else
            {
                //((Control)this.tabPage1).Enabled = false;
                //((Control)this.tabPage2).Enabled = false;
                //((Control)this.tabPage3).Enabled = false;
            }
        }
        #endregion
    }
}
