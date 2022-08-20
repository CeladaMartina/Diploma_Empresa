
namespace Interfaz_GUI
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarTraduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminisitrarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarFamiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPatenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuarioFamiliaPatenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recalcularDigitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Tag = "";
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.articuloToolStripMenuItem.Tag = "Articulo";
            this.articuloToolStripMenuItem.Text = "Articulo";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.clienteToolStripMenuItem.Tag = "Cliente";
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderToolStripMenuItem,
            this.visualizarVentasToolStripMenuItem});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ventaToolStripMenuItem.Tag = "Venta";
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.venderToolStripMenuItem.Tag = "Vender";
            this.venderToolStripMenuItem.Text = "Vender";
            // 
            // visualizarVentasToolStripMenuItem
            // 
            this.visualizarVentasToolStripMenuItem.Name = "visualizarVentasToolStripMenuItem";
            this.visualizarVentasToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.visualizarVentasToolStripMenuItem.Tag = "Visualizar Ventas";
            this.visualizarVentasToolStripMenuItem.Text = "Visualizar ventas";
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarIdiomaToolStripMenuItem,
            this.administrarTraduccionToolStripMenuItem,
            this.administrarIdiomaToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.idiomaToolStripMenuItem.Tag = "Idioma";
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.cambiarIdiomaToolStripMenuItem.Tag = "Cambiar Idioma";
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            this.cambiarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.cambiarIdiomaToolStripMenuItem_Click);
            // 
            // administrarTraduccionToolStripMenuItem
            // 
            this.administrarTraduccionToolStripMenuItem.Name = "administrarTraduccionToolStripMenuItem";
            this.administrarTraduccionToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.administrarTraduccionToolStripMenuItem.Tag = "Administrar Traduccion";
            this.administrarTraduccionToolStripMenuItem.Text = "Administrar traduccion";
            this.administrarTraduccionToolStripMenuItem.Click += new System.EventHandler(this.administrarTraduccionToolStripMenuItem_Click);
            // 
            // administrarIdiomaToolStripMenuItem
            // 
            this.administrarIdiomaToolStripMenuItem.Name = "administrarIdiomaToolStripMenuItem";
            this.administrarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.administrarIdiomaToolStripMenuItem.Tag = "Administrar Idioma";
            this.administrarIdiomaToolStripMenuItem.Text = "Administrar Idioma";
            this.administrarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.administrarIdiomaToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.adminisitrarPermisosToolStripMenuItem,
            this.administrarUsuariosToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.generarContraseñaToolStripMenuItem,
            this.recalcularDigitosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.seguridadToolStripMenuItem.Tag = "Seguridad";
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.backupToolStripMenuItem.Tag = "BackUp";
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.restoreToolStripMenuItem.Tag = "Restore";
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // adminisitrarPermisosToolStripMenuItem
            // 
            this.adminisitrarPermisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarFamiliaToolStripMenuItem,
            this.administrarPatenteToolStripMenuItem,
            this.administrarPermisosToolStripMenuItem});
            this.adminisitrarPermisosToolStripMenuItem.Name = "adminisitrarPermisosToolStripMenuItem";
            this.adminisitrarPermisosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.adminisitrarPermisosToolStripMenuItem.Tag = "Adminisitrar Permisos";
            this.adminisitrarPermisosToolStripMenuItem.Text = "Adminisitrar permisos";
            this.adminisitrarPermisosToolStripMenuItem.Click += new System.EventHandler(this.adminisitrarPermisosToolStripMenuItem_Click);
            // 
            // administrarFamiliaToolStripMenuItem
            // 
            this.administrarFamiliaToolStripMenuItem.Name = "administrarFamiliaToolStripMenuItem";
            this.administrarFamiliaToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.administrarFamiliaToolStripMenuItem.Text = "Administrar Familia";
            this.administrarFamiliaToolStripMenuItem.Click += new System.EventHandler(this.administrarFamiliaToolStripMenuItem_Click);
            // 
            // administrarPatenteToolStripMenuItem
            // 
            this.administrarPatenteToolStripMenuItem.Name = "administrarPatenteToolStripMenuItem";
            this.administrarPatenteToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.administrarPatenteToolStripMenuItem.Text = "Administrar Patente";
            this.administrarPatenteToolStripMenuItem.Click += new System.EventHandler(this.administrarPatenteToolStripMenuItem_Click);
            // 
            // administrarPermisosToolStripMenuItem
            // 
            this.administrarPermisosToolStripMenuItem.Name = "administrarPermisosToolStripMenuItem";
            this.administrarPermisosToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.administrarPermisosToolStripMenuItem.Text = "Administrar Permisos";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuarioToolStripMenuItem,
            this.administrarUsuarioFamiliaPatenteToolStripMenuItem});
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.administrarUsuariosToolStripMenuItem.Tag = "Administrar Usuario";
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
            // 
            // administrarUsuarioToolStripMenuItem
            // 
            this.administrarUsuarioToolStripMenuItem.Name = "administrarUsuarioToolStripMenuItem";
            this.administrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.administrarUsuarioToolStripMenuItem.Text = "Administrar Usuario";
            this.administrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuarioToolStripMenuItem_Click);
            // 
            // administrarUsuarioFamiliaPatenteToolStripMenuItem
            // 
            this.administrarUsuarioFamiliaPatenteToolStripMenuItem.Name = "administrarUsuarioFamiliaPatenteToolStripMenuItem";
            this.administrarUsuarioFamiliaPatenteToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.administrarUsuarioFamiliaPatenteToolStripMenuItem.Text = "Administrar Usuario Familia Patente";
            this.administrarUsuarioFamiliaPatenteToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuarioFamiliaPatenteToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.bitacoraToolStripMenuItem.Tag = "Bitacora";
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            // 
            // generarContraseñaToolStripMenuItem
            // 
            this.generarContraseñaToolStripMenuItem.Name = "generarContraseñaToolStripMenuItem";
            this.generarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.generarContraseñaToolStripMenuItem.Tag = "Generar Contraseña";
            this.generarContraseñaToolStripMenuItem.Text = "Generar contraseña";
            this.generarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.generarContraseñaToolStripMenuItem_Click);
            // 
            // recalcularDigitosToolStripMenuItem
            // 
            this.recalcularDigitosToolStripMenuItem.Name = "recalcularDigitosToolStripMenuItem";
            this.recalcularDigitosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.recalcularDigitosToolStripMenuItem.Tag = "Recalcular Digitos";
            this.recalcularDigitosToolStripMenuItem.Text = "Recalcular Digitos";
            this.recalcularDigitosToolStripMenuItem.Click += new System.EventHandler(this.recalcularDigitosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Tag = "Salir";
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 454);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Tag = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarTraduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminisitrarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recalcularDigitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarFamiliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPatenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuarioFamiliaPatenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPermisosToolStripMenuItem;
    }
}

