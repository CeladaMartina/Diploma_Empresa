using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_GUI
{
    public partial class ConexionBD : Form
    {
        Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();
        public ConexionBD()
        {
            InitializeComponent();
        }

        private void ConexionBD_Load(object sender, EventArgs e)
        {          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conexion = new SqlConnection();
                GestorUsuario.GenerarConexion(UsuarioServidor.Text, UsuarioBase.Text);                
                Conexion.ConnectionString = GestorUsuario.GetConexion();
                Conexion.Open();
                MessageBox.Show(CambiarIdioma.TraducirGlobal("La conexion funciona correctamente") ?? "La conexion funciona correctamente");
                
                LogIn formLogIn = new LogIn();
                this.Hide();
                formLogIn.Show();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("La conexion no funciona correctamente.") ?? "La conexion no funciona correctamente.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Al cancelar no tendra conexion a la base. ¿Desea continuar?", "Confirmar", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                GestorUsuario.CancelarConexion();
            }
        }

        
    }
}
