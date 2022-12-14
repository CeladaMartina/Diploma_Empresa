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
    public partial class LogIn : Form
    {
        Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Propiedades_BE.Usuario Usuario = new Propiedades_BE.Usuario();
        Negocio_BLL.Detalle_Venta GestorDetalleVenta = new Negocio_BLL.Detalle_Venta();

        private static LogIn _instancia;

        public static LogIn ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new LogIn();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cerrando la aplicacion ¿Desea cerrarla?", "Cerrar Aplicacion", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Environment.ExitCode = 1;
                Application.Exit();
            }
            else
            {
                //e.Cancel = true;
            }
        }

        #region Metodos
        public void VerificarIntegridadGeneral()
        {
            string ProblemaUsuario = GestorUsuario.VerificarIntegridadUsuario(Propiedades_BE.SingletonLogIn.GlobalIdUsuario);            
            string ProblemaDetalleVenta = GestorDetalleVenta.VerificarIntegridadDV(Propiedades_BE.SingletonLogIn.GlobalIdUsuario);

            string ProblemaDefinitivo = ProblemaUsuario + ProblemaDetalleVenta;

            if (ProblemaDefinitivo == "")
            {
                MessageBox.Show("Sistema Correcto");
                Propiedades_BE.SingletonLogIn.SumarIntegridadGeneral(0);
            }
            else
            {
                MessageBox.Show("Error -> Contacte al administrador");
                Propiedades_BE.SingletonLogIn.SumarIntegridadGeneral(1);
            }

            if (Propiedades_BE.SingletonLogIn.GlobalIntegridad == 0)
            {
                Login();
            }
            else
            {
                if (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Recalcular_Digitos))
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    txtErrorDV.Text = ProblemaDefinitivo;

                    //MessageBox.Show(ProblemaDefinitivo);
                    //Login();
                }
                else
                {
                    MessageBox.Show("Falla de integridad: No tiene los permisos necesarios");
                }
            }
        }

        void Login()
        {
            if (Propiedades_BE.SingletonLogIn.GlobalIntegridad == 0)
            {
                if (GestorUsuario.VerificarUsuarioContraseña(txtnick.Text, txtcontraseña.Text, Propiedades_BE.SingletonLogIn.GlobalIntegridad) == 1)
                {
                    if (GestorUsuario.VerificarEstado(txtnick.Text) == false)
                    {                        
                        GestorUsuario.ReiniciarIntentos(txtnick.Text);

                        try
                        {
                            GestorUsuario.LogIn(Usuario);
                            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Login", "Baja", 0);

                            Menu menu = new Menu();
                            this.Hide();
                            menu.Show();
                            
                        }
                        catch (Exception EX)
                        {
                            MessageBox.Show(EX.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show( "El usuario se encuentra bloqueado");
                    }
                }
                else if (GestorUsuario.VerificarEstado(txtnick.Text) == true)
                {
                    MessageBox.Show( "No se puede acceder, usuario bloqueado");
                }
                else if (GestorUsuario.VerificarContador(txtnick.Text) < 3)
                {
                    MessageBox.Show( "Usuarios y/o contraseña incorrectos");
                    Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Falla de LogIn", "Alta",0);
                }
                else if (GestorUsuario.VerificarContador(txtnick.Text) >= 3)
                {
                    MessageBox.Show("El usuario se encuentra bloqueado");
                    Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Bloqueo de usuario", "Alta",0);
                    GestorUsuario.BloquearUsuario(txtnick.Text);
                }
            }
            else
            {
                if (GestorUsuario.VerificarUsuarioContraseña(txtnick.Text, txtcontraseña.Text, Propiedades_BE.SingletonLogIn.GlobalIntegridad) == 1)
                {
                    if (GestorUsuario.VerificarEstado(txtnick.Text) == false)
                    {
                        if (GestorUsuario.VerificarContador(txtnick.Text) < 3)
                        {
                            MessageBox.Show("Ingreso correctamente. Error de integridad en la base de datos");

                            GestorUsuario.LogIn(Usuario);

                           Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "LogIn. Falla de integridad", "Alta",0);

                            Menu M = new Menu();
                            this.Hide();
                            M.Show();
                        }
                    }
                }
            }
        }
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.IdUsuario = GestorUsuario.SeleccionarIDNick(txtnick.Text);
                Propiedades_BE.SingletonLogIn.SetIdUsuario(Usuario);
                GestorUsuario.LogIn(Usuario);
                VerificarIntegridadGeneral();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Restore r = Restore.ObtenerInstancia();
            this.Hide();
            r.Show();
        }

        private void BtnRecalcular_Click(object sender, EventArgs e)
        {
            if (Propiedades_BE.SingletonLogIn.GlobalIntegridad >= 1)
            {
                Recalcular_Digitos RD = Recalcular_Digitos.ObtenerInstancia();
                this.Hide();
                RD.Show();
            }
            else
            {
                BtnRecalcular.Enabled = false;
            }
        }
    }
}
