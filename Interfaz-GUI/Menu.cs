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
    public partial class Menu : Form, IObserver
    {
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

        #region Metodos y Permisos 
        void Salir()
        {
            if (MessageBox.Show(CambiarIdioma.TraducirGlobal("Si continua se cerrara la sesion ¿Desea cerrar sesion?") ?? "Si continua se cerrara la sesion ¿Desea cerrar sesion?", CambiarIdioma.TraducirGlobal("Cerrar sesion") ?? "Cerrar sesion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();
                //Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "LogOut", "Baja");
                GestorUsuario.LogOut();
                this.Close();
                LogIn L = new LogIn();
                L.Show();
            }
        }

        public void Permisos()
        {
            if (Propiedades_BE.SingletonLogIn.GetInstance.IsLoggedIn())
            {
                this.administrarIdiomaToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Idioma));
                this.administrarPermisosToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Familia)
                    || Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Patentes)
                    || Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Permisos));
                this.administrarTraduccionToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Traduccion));
                this.administrarUsuarioToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Usuario)
                    || Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Permisos_Usuario));
                this.articuloToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Articulo));
                this.backupToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Realizar_BackUp));
                this.bitacoraToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Ver_Bitacora));
                this.clienteToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Cliente));
                this.recalcularDigitosToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Recalcular_Digitos));
                this.restoreToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Realizar_Restore));
                this.ventaToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Venta));
                this.proveedorToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Proveedor));
            }
            else
            {
                this.administrarTraduccionToolStripMenuItem.Visible = false;
                this.administrarIdiomaToolStripMenuItem.Visible = false;
                this.administrarPermisosToolStripMenuItem.Visible = false;
                this.administrarTraduccionToolStripMenuItem.Visible = false;
                this.administrarUsuarioToolStripMenuItem.Visible = false;
                this.articuloToolStripMenuItem.Visible = false;
                this.backupToolStripMenuItem.Visible = false;
                this.bitacoraToolStripMenuItem.Visible = false;
                this.clienteToolStripMenuItem.Visible = false;
                this.recalcularDigitosToolStripMenuItem.Visible = false;
                this.restoreToolStripMenuItem.Visible = false;
                this.ventaToolStripMenuItem.Visible = false;
                this.proveedorToolStripMenuItem.Visible = false;
            }
        }

        void CheckIntegridad()
        {
            if (Propiedades_BE.SingletonLogIn.GlobalIntegridad >= 1)
            {
                this.articuloToolStripMenuItem.Visible = false;
                this.clienteToolStripMenuItem.Visible = false;
                this.administrarIdiomaToolStripMenuItem.Visible = false;
                this.administrarPermisosToolStripMenuItem.Visible = false;
                this.administrarTraduccionToolStripMenuItem.Visible = false;
                this.administrarUsuarioToolStripMenuItem.Visible = false;
                this.generarContraseñaToolStripMenuItem.Visible = false;
                this.backupToolStripMenuItem.Visible = false;
                this.proveedorToolStripMenuItem.Visible = false;
            }
        }
        #endregion

        #region Metodos traduccion 
        public void Update(ISubject Subject)
        {
            articuloToolStripMenuItem.Text = Subject.TraducirObserver(articuloToolStripMenuItem.Tag.ToString()) ?? articuloToolStripMenuItem.Tag.ToString();
            clienteToolStripMenuItem.Text = Subject.TraducirObserver(clienteToolStripMenuItem.Tag.ToString()) ?? clienteToolStripMenuItem.Tag.ToString();
            ventaToolStripMenuItem.Text = Subject.TraducirObserver(ventaToolStripMenuItem.Tag.ToString()) ?? ventaToolStripMenuItem.Tag.ToString();
            idiomaToolStripMenuItem.Text = Subject.TraducirObserver(idiomaToolStripMenuItem.Tag.ToString()) ?? idiomaToolStripMenuItem.Tag.ToString();
            seguridadToolStripMenuItem.Text = Subject.TraducirObserver(seguridadToolStripMenuItem.Tag.ToString()) ?? seguridadToolStripMenuItem.Tag.ToString();
            salirToolStripMenuItem.Text = Subject.TraducirObserver(salirToolStripMenuItem.Tag.ToString()) ?? salirToolStripMenuItem.Tag.ToString();
            visualizarVentasToolStripMenuItem.Text = Subject.TraducirObserver(visualizarVentasToolStripMenuItem.Tag.ToString()) ?? visualizarVentasToolStripMenuItem.Tag.ToString();
            cambiarIdiomaToolStripMenuItem.Text = Subject.TraducirObserver(cambiarIdiomaToolStripMenuItem.Tag.ToString()) ?? cambiarIdiomaToolStripMenuItem.Tag.ToString();
            //administrarTraduccionToolStripMenuItem.Text = Subject.TraducirObserver(administrarTraduccionToolStripMenuItem.Tag.ToString()) ?? administrarTraduccionToolStripMenuItem.Tag.ToString();
            //administrarIdiomaToolStripMenuItem.Text = Subject.TraducirObserver(administrarIdiomaToolStripMenuItem.Tag.ToString()) ?? administrarIdiomaToolStripMenuItem.Tag.ToString();
            backupToolStripMenuItem.Text = Subject.TraducirObserver(backupToolStripMenuItem.Tag.ToString()) ?? backupToolStripMenuItem.Tag.ToString();
            restoreToolStripMenuItem.Text = Subject.TraducirObserver(restoreToolStripMenuItem.Tag.ToString()) ?? restoreToolStripMenuItem.Tag.ToString();
            //administrarPermisosToolStripMenuItem.Text = Subject.TraducirObserver(administrarPermisosToolStripMenuItem.Tag.ToString()) ?? administrarPermisosToolStripMenuItem.Tag.ToString();
            //administrarUsuarioToolStripMenuItem.Text = Subject.TraducirObserver(administrarUsuarioToolStripMenuItem.Tag.ToString()) ?? administrarUsuarioToolStripMenuItem.Tag.ToString();
            bitacoraToolStripMenuItem.Text = Subject.TraducirObserver(bitacoraToolStripMenuItem.Tag.ToString()) ?? bitacoraToolStripMenuItem.Tag.ToString();
            generarContraseñaToolStripMenuItem.Text = Subject.TraducirObserver(generarContraseñaToolStripMenuItem.Tag.ToString()) ?? generarContraseñaToolStripMenuItem.Tag.ToString();
            recalcularDigitosToolStripMenuItem.Text = Subject.TraducirObserver(recalcularDigitosToolStripMenuItem.Tag.ToString()) ?? recalcularDigitosToolStripMenuItem.Tag.ToString();
            proveedorToolStripMenuItem.Text = Subject.TraducirObserver(proveedorToolStripMenuItem.Tag.ToString()) ?? proveedorToolStripMenuItem.Tag.ToString();
        }

        public void Traducir()
        {
            articuloToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(articuloToolStripMenuItem.Tag.ToString()) ?? articuloToolStripMenuItem.Tag.ToString();
            clienteToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(clienteToolStripMenuItem.Tag.ToString()) ?? clienteToolStripMenuItem.Tag.ToString();
            ventaToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(ventaToolStripMenuItem.Tag.ToString()) ?? ventaToolStripMenuItem.Tag.ToString();
            idiomaToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(idiomaToolStripMenuItem.Tag.ToString()) ?? idiomaToolStripMenuItem.Tag.ToString();
            seguridadToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(seguridadToolStripMenuItem.Tag.ToString()) ?? seguridadToolStripMenuItem.Tag.ToString();
            salirToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(salirToolStripMenuItem.Tag.ToString()) ?? salirToolStripMenuItem.Tag.ToString();
            venderToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(venderToolStripMenuItem.Tag.ToString()) ?? venderToolStripMenuItem.Tag.ToString();
            visualizarVentasToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(visualizarVentasToolStripMenuItem.Tag.ToString()) ?? visualizarVentasToolStripMenuItem.Tag.ToString();
            cambiarIdiomaToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(cambiarIdiomaToolStripMenuItem.Tag.ToString()) ?? cambiarIdiomaToolStripMenuItem.Tag.ToString();
            administrarTraduccionToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(administrarTraduccionToolStripMenuItem.Tag.ToString()) ?? administrarTraduccionToolStripMenuItem.Tag.ToString();
            administrarIdiomaToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(administrarIdiomaToolStripMenuItem.Tag.ToString()) ?? administrarIdiomaToolStripMenuItem.Tag.ToString();
            backupToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(backupToolStripMenuItem.Tag.ToString()) ?? backupToolStripMenuItem.Tag.ToString();
            restoreToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(restoreToolStripMenuItem.Tag.ToString()) ?? restoreToolStripMenuItem.Tag.ToString();
            //administrarPermisosToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(administrarPermisosToolStripMenuItem.Tag.ToString()) ?? administrarPermisosToolStripMenuItem.Tag.ToString();
            //administrarUsuarioToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(administrarUsuarioToolStripMenuItem.Tag.ToString()) ?? administrarUsuarioToolStripMenuItem.Tag.ToString();
            bitacoraToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(bitacoraToolStripMenuItem.Tag.ToString()) ?? bitacoraToolStripMenuItem.Tag.ToString();
            generarContraseñaToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(generarContraseñaToolStripMenuItem.Tag.ToString()) ?? generarContraseñaToolStripMenuItem.Tag.ToString();
            recalcularDigitosToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(recalcularDigitosToolStripMenuItem.Tag.ToString()) ?? recalcularDigitosToolStripMenuItem.Tag.ToString();
            proveedorToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(proveedorToolStripMenuItem.Tag.ToString()) ?? proveedorToolStripMenuItem.Tag.ToString();
        }

        #endregion


        public Menu()
        {
            InitializeComponent();
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarIdioma cambiarIdioma = new CambiarIdioma();
            cambiarIdioma.MdiParent = this;
            cambiarIdioma.Show();
        }

        private void recalcularDigitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Propiedades_BE.SingletonLogIn.GlobalIntegridad >= 1)
            //{
                Recalcular_Digitos RD = Recalcular_Digitos.ObtenerInstancia();
                RD.MdiParent = this;
                RD.Show();
           // }
        }

        private void adminisitrarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Permisos AP = Administrar_Permisos.ObtenerInstancia();
            AP.MdiParent = this;
            AP.Show();
        }

        private void administrarFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Familia AF = Administrar_Familia.ObtenerInstancia();
            AF.MdiParent = this;
            AF.Show();
        }

        private void administrarPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Patente AP = Administrar_Patente.ObtenerInstancia();
            AP.MdiParent = this;
            AP.Show();
        }

        private void administrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Usuario AU = Administrar_Usuario.ObtenerInstancia();
            AU.MdiParent = this;
            AU.Show();
        }

        private void administrarUsuarioFamiliaPatenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Usu_Fam_Pat AUFP = Administrar_Usu_Fam_Pat.ObtenerInstancia();
            AUFP.MdiParent = this;
            AUFP.Show();
        }

        private void administrarTraduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Traduccion AT = Administrar_Traduccion.ObtenerInstancia();
            AT.MdiParent = this;
            AT.Show();
        }

        private void administrarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Idioma AI = Administrar_Idioma.ObtenerInstancia();
            AI.MdiParent = this;
            AI.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Permisos();
            CheckIntegridad();
            Traducir();
        }

        private void generarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generar_Contraseña GC = Generar_Contraseña.ObtenerInstancia();
            GC.MdiParent = this;
            GC.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup BU = Backup.ObtenerInstancia();
            BU.MdiParent = this;
            BU.Show();
                
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore R = Restore.ObtenerInstancia();
            R.MdiParent = this;
            R.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora B = Bitacora.ObtenerInstancia();
            B.MdiParent = this;
            B.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor P = Proveedor.ObtenerInstancia();
            P.MdiParent = this;
            P.Show();
        }
    }
}
