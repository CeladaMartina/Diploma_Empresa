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
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "LogOut", "Baja",0);
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
                this.adminisitrarPermisosToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Familia)
                    || Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Patentes)
                    || Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Permisos));
                this.administrarTraduccionToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Traduccion));
                this.administrarUsuarioToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Usuario)
                    || Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Permisos_Usuario));
                this.administrarUsuarioFamiliaPatenteToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Usuario)
                    || Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Permisos_Usuario));
                this.productoToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Articulo));
                this.backupToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Realizar_BackUp));
                this.bitacoraToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Ver_Bitacora));
                this.clienteToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Cliente));
                this.recalcularDigitosToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Recalcular_Digitos));
                this.restoreToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Realizar_Restore));
                this.ventaToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Venta));
                this.proveedorToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Proveedor));
                this.localidadToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Localidad));
                this.compraToolStripMenuItem.Visible = (Propiedades_BE.SingletonLogIn.GetInstance.IsInRole(Propiedades_BE.TipoPermiso.Modificar_Compra));                
            }
            else
            {
                this.administrarTraduccionToolStripMenuItem.Visible = false;
                this.administrarIdiomaToolStripMenuItem.Visible = false;
                this.adminisitrarPermisosToolStripMenuItem.Visible = false;
                this.administrarTraduccionToolStripMenuItem.Visible = false;
                this.administrarUsuarioToolStripMenuItem.Visible = false;
                this.administrarUsuarioFamiliaPatenteToolStripMenuItem.Visible = false;
                this.productoToolStripMenuItem.Visible = false;
                this.backupToolStripMenuItem.Visible = false;
                this.bitacoraToolStripMenuItem.Visible = false;
                this.clienteToolStripMenuItem.Visible = false;
                this.recalcularDigitosToolStripMenuItem.Visible = false;
                this.restoreToolStripMenuItem.Visible = false;
                this.ventaToolStripMenuItem.Visible = false;
                this.proveedorToolStripMenuItem.Visible = false;
                this.localidadToolStripMenuItem.Visible = false;
                this.compraToolStripMenuItem.Visible = false;                
            }
        }

        void CheckIntegridad()
        {
            if (Propiedades_BE.SingletonLogIn.GlobalIntegridad >= 1)
            {
                this.productoToolStripMenuItem.Visible = false;
                this.clienteToolStripMenuItem.Visible = false;
                this.administrarIdiomaToolStripMenuItem.Visible = false;
                this.adminisitrarPermisosToolStripMenuItem.Visible = false;
                this.administrarTraduccionToolStripMenuItem.Visible = false;
                this.administrarUsuarioToolStripMenuItem.Visible = false;
                this.generarContraseñaToolStripMenuItem.Visible = false;
                this.backupToolStripMenuItem.Visible = false;
                this.proveedorToolStripMenuItem.Visible = false;
                this.localidadToolStripMenuItem.Visible = false;
                this.administrarUsuarioFamiliaPatenteToolStripMenuItem.Visible = false;
                this.compraToolStripMenuItem.Visible = false;
                this.ventaToolStripMenuItem.Visible = false;
            }
        }
        #endregion

        #region Metodos traduccion 
        public void Update(ISubject Subject)
        {
            productoToolStripMenuItem.Text = Subject.TraducirObserver(productoToolStripMenuItem.Tag.ToString()) ?? productoToolStripMenuItem.Tag.ToString();
            clienteToolStripMenuItem.Text = Subject.TraducirObserver(clienteToolStripMenuItem.Tag.ToString()) ?? clienteToolStripMenuItem.Tag.ToString();
            ventaToolStripMenuItem.Text = Subject.TraducirObserver(ventaToolStripMenuItem.Tag.ToString()) ?? ventaToolStripMenuItem.Tag.ToString();
            idiomaToolStripMenuItem.Text = Subject.TraducirObserver(idiomaToolStripMenuItem.Tag.ToString()) ?? idiomaToolStripMenuItem.Tag.ToString();
            seguridadToolStripMenuItem.Text = Subject.TraducirObserver(seguridadToolStripMenuItem.Tag.ToString()) ?? seguridadToolStripMenuItem.Tag.ToString();
            salirToolStripMenuItem.Text = Subject.TraducirObserver(salirToolStripMenuItem.Tag.ToString()) ?? salirToolStripMenuItem.Tag.ToString();
            visualizarVentasToolStripMenuItem.Text = Subject.TraducirObserver(visualizarVentasToolStripMenuItem.Tag.ToString()) ?? visualizarVentasToolStripMenuItem.Tag.ToString();
            cambiarIdiomaToolStripMenuItem.Text = Subject.TraducirObserver(cambiarIdiomaToolStripMenuItem.Tag.ToString()) ?? cambiarIdiomaToolStripMenuItem.Tag.ToString();
            administrarIdiomaToolStripMenuItem.Text = Subject.TraducirObserver(administrarIdiomaToolStripMenuItem.Tag.ToString()) ?? administrarIdiomaToolStripMenuItem.Tag.ToString();
            administrarTraduccionToolStripMenuItem.Text = Subject.TraducirObserver(administrarTraduccionToolStripMenuItem.Tag.ToString()) ?? administrarTraduccionToolStripMenuItem.Tag.ToString();
            backupToolStripMenuItem.Text = Subject.TraducirObserver(backupToolStripMenuItem.Tag.ToString()) ?? backupToolStripMenuItem.Tag.ToString();
            restoreToolStripMenuItem.Text = Subject.TraducirObserver(restoreToolStripMenuItem.Tag.ToString()) ?? restoreToolStripMenuItem.Tag.ToString();
            adminisitrarPermisosToolStripMenuItem.Text = Subject.TraducirObserver(adminisitrarPermisosToolStripMenuItem.Tag.ToString()) ?? adminisitrarPermisosToolStripMenuItem.Tag.ToString();
            administrarUsuarioToolStripMenuItem.Text = Subject.TraducirObserver(administrarUsuarioToolStripMenuItem.Tag.ToString()) ?? administrarUsuarioToolStripMenuItem.Tag.ToString();
            bitacoraToolStripMenuItem.Text = Subject.TraducirObserver(bitacoraToolStripMenuItem.Tag.ToString()) ?? bitacoraToolStripMenuItem.Tag.ToString();
            generarContraseñaToolStripMenuItem.Text = Subject.TraducirObserver(generarContraseñaToolStripMenuItem.Tag.ToString()) ?? generarContraseñaToolStripMenuItem.Tag.ToString();
            recalcularDigitosToolStripMenuItem.Text = Subject.TraducirObserver(recalcularDigitosToolStripMenuItem.Tag.ToString()) ?? recalcularDigitosToolStripMenuItem.Tag.ToString();
            proveedorToolStripMenuItem.Text = Subject.TraducirObserver(proveedorToolStripMenuItem.Tag.ToString()) ?? proveedorToolStripMenuItem.Tag.ToString();
            visualizarComprasToolStripMenuItem.Text = Subject.TraducirObserver(visualizarComprasToolStripMenuItem.Tag.ToString()) ?? visualizarComprasToolStripMenuItem.Tag.ToString();
            venderToolStripMenuItem.Text = Subject.TraducirObserver(venderToolStripMenuItem.Tag.ToString()) ?? venderToolStripMenuItem.Tag.ToString();
            comprarToolStripMenuItem.Text = Subject.TraducirObserver(comprarToolStripMenuItem.Tag.ToString()) ?? comprarToolStripMenuItem.Tag.ToString();
            pedidoCompraToolStripMenuItem.Text = Subject.TraducirObserver(pedidoCompraToolStripMenuItem.Tag.ToString()) ?? pedidoCompraToolStripMenuItem.Tag.ToString();
            compraToolStripMenuItem.Text = Subject.TraducirObserver(compraToolStripMenuItem.Tag.ToString()) ?? compraToolStripMenuItem.Tag.ToString();
            localidadToolStripMenuItem.Text = Subject.TraducirObserver(localidadToolStripMenuItem.Tag.ToString()) ?? localidadToolStripMenuItem.Tag.ToString();

        }

        public void Traducir()
        {
            productoToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(productoToolStripMenuItem.Tag.ToString()) ?? productoToolStripMenuItem.Tag.ToString();
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
            adminisitrarPermisosToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(adminisitrarPermisosToolStripMenuItem.Tag.ToString()) ?? adminisitrarPermisosToolStripMenuItem.Tag.ToString();
            administrarUsuariosToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(administrarUsuariosToolStripMenuItem.Tag.ToString()) ?? administrarUsuariosToolStripMenuItem.Tag.ToString();
            bitacoraToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(bitacoraToolStripMenuItem.Tag.ToString()) ?? bitacoraToolStripMenuItem.Tag.ToString();
            generarContraseñaToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(generarContraseñaToolStripMenuItem.Tag.ToString()) ?? generarContraseñaToolStripMenuItem.Tag.ToString();
            recalcularDigitosToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(recalcularDigitosToolStripMenuItem.Tag.ToString()) ?? recalcularDigitosToolStripMenuItem.Tag.ToString();
            proveedorToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(proveedorToolStripMenuItem.Tag.ToString()) ?? proveedorToolStripMenuItem.Tag.ToString();
            pedidoCompraToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(pedidoCompraToolStripMenuItem.Tag.ToString()) ?? pedidoCompraToolStripMenuItem.Tag.ToString();
            comprarToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(comprarToolStripMenuItem.Tag.ToString()) ?? comprarToolStripMenuItem.Tag.ToString();
            visualizarComprasToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(visualizarComprasToolStripMenuItem.Tag.ToString()) ?? visualizarComprasToolStripMenuItem.Tag.ToString();
            compraToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(compraToolStripMenuItem.Tag.ToString()) ?? compraToolStripMenuItem.Tag.ToString();
            localidadToolStripMenuItem.Text = CambiarIdioma.TraducirGlobal(localidadToolStripMenuItem.Tag.ToString()) ?? localidadToolStripMenuItem.Tag.ToString();

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
            if (Propiedades_BE.SingletonLogIn.GlobalIntegridad >= 1)
            {
                Recalcular_Digitos RD = Recalcular_Digitos.ObtenerInstancia();
                RD.MdiParent = this;
                RD.Show();
             }
        }

        private void adminisitrarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrar_Permisos AP = Administrar_Permisos.ObtenerInstancia();
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

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto p = Producto.ObtenerInstancia();
            p.MdiParent = this;
            p.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localidad l = Localidad.ObtenerInstancia();
            l.MdiParent = this;
            l.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente c = Cliente.ObtenerInstancia();
            c.MdiParent = this;
            c.Show();
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra c = Compra.ObtenerInstancia();
            c.MdiParent = this;
            c.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta v = Venta.ObtenerInstancia();
            v.MdiParent = this;
            v.Show();
        }

        private void pedidoCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidosCompras pc = PedidosCompras.ObtenerInstancia();
            pc.MdiParent = this;
            pc.Show();
        }

        private void visualizarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarCompra vc = VisualizarCompra.ObtenerInstancia();
            vc.MdiParent = this;
            vc.Show();
        }

        private void visualizarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizarVenta vv = VisualizarVenta.ObtenerInstancia();
            vv.MdiParent = this;
            vv.Show();
        }

        private void menuStrip1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

            
        }

        private void Menu_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"help\Help.chm";
            Help.ShowHelp(this, path);
        }
    }
}
