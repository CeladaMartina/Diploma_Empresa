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
    public partial class Administrar_Usuario : Form, IObserver
    {
        int IdUsuario = -1;

        Propiedades_BE.Usuario UsuarioTemp = new Propiedades_BE.Usuario();
        Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Permisos GestorPermisos = new Negocio_BLL.Permisos();

        private static Administrar_Usuario _instancia;

        public Administrar_Usuario()
        {
            InitializeComponent();
            CargarComboIdioma();
            ListarUsuario();
        }

        public static Administrar_Usuario ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Administrar_Usuario();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #region Usuario
        
        void Alta(string Nick, string Contraseña, string Nombre, string Mail, bool Estado, int Contador, string Idioma, int DVH)
        {
            GestorUsuario.Alta(Nick, Contraseña, Nombre, Mail, Estado, Contador, Idioma, DVH);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta usuario", "Alta",0);
            ListarUsuario();
            LimpiarTxt();
            IdUsuario = -1;
        }

        void Modificar(int IdUsuario, string Nick, string Nombre, string Mail, bool Estado, int Contador, string Idioma, int DVH)
        {           
            GestorUsuario.Modificar(IdUsuario, Nick, Nombre, Mail, Estado, Contador, Idioma, DVH);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar usuario", "Alta",0);
            ListarUsuario();
            IdUsuario = -1;
            LimpiarTxt();
        }

        void Baja(int IdUsuario, int DVH)
        {
            GestorUsuario.Baja(IdUsuario, DVH);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja usuario", "Alta",0);
            ListarUsuario();
            IdUsuario = -1;
            LimpiarTxt();
        }

        void DesbloquearUsuario(string Nick)
        {
            GestorUsuario.Desbloquear(Seguridad.EncriptarAES(Nick));
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Desbloqueo usuario", "Alta",0);
        }

        void ListarUsuario()
        {
            dataGridViewUsuario.DataSource = null;
            dataGridViewUsuario.DataSource = GestorUsuario.Listar();
            dataGridViewUsuario.Columns["IdUsuario"].Visible = false;
            dataGridViewUsuario.Columns["Contraseña"].Visible = false;
            dataGridViewUsuario.Columns["DVH"].Visible = false;
            dataGridViewUsuario.Columns["NombrePermiso"].Visible = false;
            dataGridViewUsuario.Columns["IdIdioma"].Visible = false;
            dataGridViewUsuario.ReadOnly = true;
        }       
        #endregion

        #region Metodos

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNick.Text) || string.IsNullOrEmpty(txtMail.Text))
            {
                A = true;
            }
            return A;
        }
        
        void LimpiarTxt()
        {
            txtMail.Text = "";
            txtNick.Text = "";
            txtNombre.Text = "";
            LblContraseña.Text = "";
        }

        void CargarComboIdioma()
        {
            Negocio_BLL.Idioma GestorIdioma = new Negocio_BLL.Idioma();
            CmbIdioma.DataSource = null;
            CmbIdioma.DataSource = GestorIdioma.NombreIdioma();
        }

        #endregion

        #region Permisos

        void ValidarPermisos()
        {
            if (Propiedades_BE.SingletonLogIn.GetInstance.IsLoggedIn())
            {
                BtnAlta.Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Usuario);
                BtnBaja.Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Usuario);
                BtnModificar.Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Usuario);
                BtnDesbloquear.Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Desbloquear_Usuario);
                //((Control)this.tabPageAdmpermisos).Enabled = Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Permisos_Usuario);
            }
            else
            {
                BtnAlta.Enabled = false;
                BtnBaja.Enabled = false;
                BtnModificar.Enabled = false;
                BtnDesbloquear.Enabled = false;
                //((Control)this.tabPageAdmpermisos).Enabled = false;
            }
        }
        #endregion

        #region Traduccion 
        public void Update(ISubject subject)
        {
            LblContraseñaLabel.Text = subject.TraducirObserver(LblContraseñaLabel.Tag.ToString()) ?? LblContraseñaLabel.Tag.ToString();
            LblIdioma.Text = subject.TraducirObserver(LblIdioma.Tag.ToString()) ?? LblIdioma.Tag.ToString();
            LblMail.Text = subject.TraducirObserver(LblMail.Tag.ToString()) ?? LblMail.Tag.ToString();
            LblNick.Text = subject.TraducirObserver(LblNick.Tag.ToString()) ?? LblNick.Tag.ToString();
            LblNombre.Text = subject.TraducirObserver(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            BtnAlta.Text = subject.TraducirObserver(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnBaja.Text = subject.TraducirObserver(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnDesbloquear.Text = subject.TraducirObserver(BtnDesbloquear.Tag.ToString()) ?? BtnDesbloquear.Tag.ToString();
            BtnModificar.Text = subject.TraducirObserver(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();            
        }

        void Traducir()
        {
            LblContraseñaLabel.Text = CambiarIdioma.TraducirGlobal(LblContraseñaLabel.Tag.ToString()) ?? LblContraseñaLabel.Tag.ToString();
            LblIdioma.Text = CambiarIdioma.TraducirGlobal(LblIdioma.Tag.ToString()) ?? LblIdioma.Tag.ToString();
            LblMail.Text = CambiarIdioma.TraducirGlobal(LblMail.Tag.ToString()) ?? LblMail.Tag.ToString();
            LblNick.Text = CambiarIdioma.TraducirGlobal(LblNick.Tag.ToString()) ?? LblNick.Tag.ToString();
            LblNombre.Text = CambiarIdioma.TraducirGlobal(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            BtnAlta.Text = CambiarIdioma.TraducirGlobal(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnBaja.Text = CambiarIdioma.TraducirGlobal(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnDesbloquear.Text = CambiarIdioma.TraducirGlobal(BtnDesbloquear.Tag.ToString()) ?? BtnDesbloquear.Tag.ToString();
            BtnModificar.Text = CambiarIdioma.TraducirGlobal(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            
        }
        #endregion

        #region Botones
        private void BtnAlta_Click(object sender, EventArgs e)
        {          
           
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Alta(txtNick.Text, LblContraseña.Text, txtNombre.Text, txtMail.Text, false, 0, CmbIdioma.Text.ToString(), 0);
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
                if (GestorUsuario.VerificarBorradoUsuario(IdUsuario) == 0)
                {
                    try
                    {
                        Baja(IdUsuario, 0);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                    }
                }
                else
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Problema por patentes") ?? "Problema por patentes");
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
                    Modificar(IdUsuario, txtNick.Text, txtNombre.Text, txtMail.Text, false, 0, CmbIdioma.Text.ToString(), 0);
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

        private void BtnDesbloquear_Click(object sender, EventArgs e)
        {
            try
            {
                DesbloquearUsuario(txtNick.Text);
                ListarUsuario();
                LimpiarTxt();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error desbloqueando usuario") ?? "Error desbloqueando usuario");
            }
        }

        bool Estado = false;
        int Contador = 0;

        #endregion

        private void BtnGenerarClave_Click(object sender, EventArgs e)
        {
            try
            {
                LblContraseña.Text = Seguridad.GenerarClave();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void dataGridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdUsuario = Convert.ToInt32(dataGridViewUsuario.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString());
                txtNick.Text = Convert.ToString(dataGridViewUsuario.Rows[e.RowIndex].Cells["Nick"].Value.ToString());
                txtNombre.Text = Convert.ToString(dataGridViewUsuario.Rows[e.RowIndex].Cells["Nombre"].Value.ToString());
                txtMail.Text = Convert.ToString(dataGridViewUsuario.Rows[e.RowIndex].Cells["Mail"].Value.ToString());
                CmbIdioma.Text = Convert.ToString(dataGridViewUsuario.Rows[e.RowIndex].Cells["Idioma"].Value.ToString());
                Estado = Convert.ToBoolean(dataGridViewUsuario.Rows[e.RowIndex].Cells["Estado"].Value.ToString());
                Contador = int.Parse(dataGridViewUsuario.Rows[e.RowIndex].Cells["Contador"].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
    }
}
