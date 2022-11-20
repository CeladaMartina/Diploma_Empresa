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
    public partial class Recalcular_Digitos : Form, IObserver
    {
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();       
        Negocio_BLL.Detalle_Venta GestorDetalleVenta = new Negocio_BLL.Detalle_Venta();       

        private static Recalcular_Digitos _instancia;
        public static Recalcular_Digitos ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Recalcular_Digitos();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public Recalcular_Digitos()
        {
            InitializeComponent();
        }

        private void Recalcular_Digitos_Load(object sender, EventArgs e)
        {
            Recalcular_digitos();
            Traducir();
        }

        #region Metodos        

        void Recalcular_digitos()
        {
            BtnRecalcularDVV.Enabled = false;

            if (GestorUsuario.VerificarIntegridadUsuario(Propiedades_BE.SingletonLogIn.GlobalIdUsuario) != "")
            {
                TxtTablas.Text = "ERROR.";
                BtnUsuario.Enabled = true;

            }
            
            if(GestorDetalleVenta.VerificarIntegridadDV(Propiedades_BE.SingletonLogIn.GlobalIdUsuario) != "")
            {
                TxtTablas.Text = "ERROR.";
                BtnUsuario.Enabled = true;
            }

            //else if (Seguridad.VerificarIntegridadBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario) != "")
            //{
            //    TxtTablas.Text = "ERROR.";
            //    BtnUsuario.Enabled = true;
            //}
        }

        void RDVV()
        {
            Seguridad.RecalcularDVV();
            MessageBox.Show(CambiarIdioma.TraducirGlobal("Se han calculado los digitos verificadores verticales correctamente") ?? "Se han calculado los digitos verificadores verticales correctamente");
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Digitos DVV recalculados", "Alta",0);
            BtnRecalcularDVV.Enabled = false;
        }

        void RUsuario()
        {
            GestorUsuario.RecalcularDVH();
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "DVH Usuario recalculado", "Alta", 0);
            
        }

        void RDV()
        {
            GestorDetalleVenta.RecalcularDVH();
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "DVH DV recalculado", "Alta",0);
            
        }

        void RBitacora()
        {
            //Seguridad.RecalcularDVH();
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Digitos DVV recalculados", "Alta",0);
            
        }

        #endregion

        #region Metodos Traduccion
        public void Update(ISubject Sujeto)
        {   
            BtnRecalcularDVV.Text = Sujeto.TraducirObserver(BtnRecalcularDVV.Tag.ToString()) ?? BtnRecalcularDVV.Tag.ToString();
            BtnUsuario.Text = Sujeto.TraducirObserver(BtnUsuario.Tag.ToString()) ?? BtnUsuario.Tag.ToString();
            //this.Text = Sujeto.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {   
            BtnRecalcularDVV.Text = CambiarIdioma.TraducirGlobal(BtnRecalcularDVV.Tag.ToString()) ?? BtnRecalcularDVV.Tag.ToString();
            BtnUsuario.Text = CambiarIdioma.TraducirGlobal(BtnUsuario.Tag.ToString()) ?? BtnUsuario.Tag.ToString();
            //this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }
        #endregion

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                RUsuario();
                RDV();
                RBitacora();
                TxtTablas.Text = "OK";
                BtnUsuario.Enabled = false;
                BtnRecalcularDVV.Enabled = true;
                Propiedades_BE.SingletonLogIn.GlobalIntegridad = 0;
            }
            catch (Exception)
            {
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Error DVH ", "Alta",0);
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error calculando los digitos verificadores horizontales." ) ?? "Error calculando los digitos verificadores horizontales.");
            }
        }

        private void BtnRecalcularDVV_Click(object sender, EventArgs e)
        {
            try
            {
                RDVV();
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            catch (Exception)
            {
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Error DVH DVV", "Alta", 0);
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error calculando los digitos verificadores verticales") ?? "Error calculando los digitos verificadores verticales");
            }
        }
    }
}
