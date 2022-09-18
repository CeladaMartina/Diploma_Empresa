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

        void ChequearRecalcularDVV()
        {
            if (BtnUsuario.Enabled == false && BtnDV.Enabled == false)
            {
                BtnRecalcularDVV.Enabled = true;
            }
            else
            {
                BtnRecalcularDVV.Enabled = false;
            }
        }

        void Recalcular_digitos()
        {
            BtnRecalcularDVV.Enabled = false;
            if (GestorUsuario.VerificarIntegridadUsuario(Propiedades_BE.SingletonLogIn.GlobalIdUsuario) != "")
            {
                TxtUsuario.Text = "ERROR";
                BtnUsuario.Enabled = true;
            }            
            if (GestorDetalleVenta.VerificarIntegridadDV(Propiedades_BE.SingletonLogIn.GlobalIdUsuario) != "")
            {
                TxtDV.Text = "ERROR";
                BtnDV.Enabled = true;
            }
        }

        void RUsuario()
        {
            GestorUsuario.RecalcularDVH();
            MessageBox.Show(CambiarIdioma.TraducirGlobal("Se ha recalculado el digito de usuarios") ?? "Se ha recalculado el digito de usuarios");
            BtnUsuario.Enabled = false;
            TxtUsuario.Text = "OK";
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "DVH Usu recalculado", "Alta");
            ChequearRecalcularDVV();
        }

        void RDVV()
        {
            Seguridad.RecalcularDVV();
            MessageBox.Show(CambiarIdioma.TraducirGlobal("Se han calculado los digitos verificadores verticales correctamente") ?? "Se han calculado los digitos verificadores verticales correctamente");
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Digitos DVV recalculados", "Alta");
            BtnRecalcularDVV.Enabled = false;
        }

        void RDV()
        {
            GestorDetalleVenta.RecalcularDVH();
            MessageBox.Show(CambiarIdioma.TraducirGlobal("Se ha recalculado el digito de detalle de venta") ?? "Se ha recalculado el digito de detalle de venta");
            BtnDV.Enabled = false;
            TxtDV.Text = "OK";
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "DVH DV recalculado", "Alta");
            ChequearRecalcularDVV();
        }

        void RBitacora()
        {
            Seguridad.RecalcularDVH();
            MessageBox.Show(CambiarIdioma.TraducirGlobal("Se han calculado los digitos verificadores de la Bitacora.") ?? "Se han calculado los digitos verificadores de la Bitacora.");
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Digitos DVV recalculados", "Alta");
            BtnRecalcularDVV.Enabled = false;
        }

        #endregion

        #region Metodos Traduccion
        public void Update(ISubject Sujeto)
        {           
            LblDV.Text = Sujeto.TraducirObserver(LblDV.Tag.ToString()) ?? LblDV.Tag.ToString();
            LblUsuario.Text = Sujeto.TraducirObserver(LblUsuario.Tag.ToString()) ?? LblUsuario.Tag.ToString();            
            BtnDV.Text = Sujeto.TraducirObserver(BtnDV.Tag.ToString()) ?? BtnDV.Tag.ToString();
            BtnRecalcularDVV.Text = Sujeto.TraducirObserver(BtnRecalcularDVV.Tag.ToString()) ?? BtnRecalcularDVV.Tag.ToString();
            BtnUsuario.Text = Sujeto.TraducirObserver(BtnUsuario.Tag.ToString()) ?? BtnUsuario.Tag.ToString();
            //this.Text = Sujeto.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {           
            LblDV.Text = CambiarIdioma.TraducirGlobal(LblDV.Tag.ToString()) ?? LblDV.Tag.ToString();
            LblUsuario.Text = CambiarIdioma.TraducirGlobal(LblUsuario.Tag.ToString()) ?? LblUsuario.Tag.ToString();            
            BtnDV.Text = CambiarIdioma.TraducirGlobal(BtnDV.Tag.ToString()) ?? BtnDV.Tag.ToString();
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
            }
            catch (Exception)
            {
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Error DVH Usuario", "Alta");
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error calculando los digitos verificadores de usuario") ?? "Error calculando los digitos verificadores de usuario");
            }
        }

        private void BtnDV_Click(object sender, EventArgs e)
        {
            try
            {
                RDV();
            }
            catch (Exception)
            {
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Error DVH DV", "Alta");
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error calculando los digitos verificadores de detalle de venta") ?? "Error calculando los digitos verificadores de detalle de venta");
            }
        }

        private void BtnRecalcularDVV_Click(object sender, EventArgs e)
        {
            try
            {
                RDVV();
            }
            catch (Exception)
            {
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Error DVH DVV", "Alta");
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error calculando los digitos verificadores verticales") ?? "Error calculando los digitos verificadores verticales");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBitacora_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                //RBitacora();
                long Dv;
                string QueryDv = "select * from Bitacora where IdBitacora = " + TxtBitacora.Text+ " ";
                Dv = Seguridad.CalcularDVH(QueryDv, "Bitacora");
                Seguridad.EjecutarConsulta("Update Bitacora set DVH = " + Dv + " where IdBitacora = " + TxtBitacora.Text + "");
            }
            catch (Exception)
            {
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Error DVH DV", "Alta");
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error calculando los digitos verificadores de la bitacora") ?? "Error calculando los digitos verificadores de la bitacora");
            }
        }
    }
}
