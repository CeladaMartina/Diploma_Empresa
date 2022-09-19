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
    public partial class Generar_Contraseña : Form, IObserver
    {
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();

        private static Generar_Contraseña _instancia;
        public static Generar_Contraseña ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Generar_Contraseña();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        public int Contador = 0;
        public Generar_Contraseña()
        {
            InitializeComponent();
        }

        #region Metodos
        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(txtNick.Text) || string.IsNullOrEmpty(txtMail.Text))
            {
                A = true;
            }
            return A;
        }

        void LimpiarTxt()
        {
            txtMail.Text = "";
            txtNick.Text = "";
        }

        void Verificar()
        {
            if (Contador >= 3)
            {
                GestorUsuario.BloquearUsuario(txtNick.Text);
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Su usuario ha sido bloqueado. Contacte al administrador del sistema") ?? "Su usuario ha sido bloqueado. Contacte al administrador del sistema");
            }
            else
            {
                if (GestorUsuario.VerificarNickMail(Seguridad.EncriptarAES(txtNick.Text), txtMail.Text) == true)
                {
                    //GestorUsuario.ReiniciarIntentos(txtNick.Text);
                    txtNick.Enabled = false;
                    txtMail.Enabled = false;
                    Contador = 0;
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Datos bien cargados") ?? "Datos bien cargados");
                    groupBoxContraseña.Visible = true;
                }
                else
                {
                    Contador += 1;
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Datos mal cargados") ?? "Datos mal cargados");
                }
            }
        }

        void ConfirmarCambio()
        {
            if (MessageBox.Show(CambiarIdioma.TraducirGlobal("¿Confirma el cambio de clave?") ?? "¿Confirma el cambio de clave?", CambiarIdioma.TraducirGlobal("Confirmar") ?? "Confirmar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (Seguridad.ValidarClave(txtContraseña.Text) == true)
                    {
                        GestorUsuario.ConfirmarCambioContraseña(txtNick.Text, txtContraseña.Text, txtMail.Text);
                        Seguridad.CargarBitacora(GestorUsuario.SeleccionarIDNick(txtNick.Text), DateTime.Now, "Contraseña cambiada", "Alta",0);
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("Contraseña cambiada con exito") ?? "Contraseña cambiada con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("Ingrese otra contraseña") ?? "Ingrese otra contraseña");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error cambiando clave, intente nuevamente") ?? "Error cambiando clave, intente nuevamente");
                }
            }
            else
            {
                Generar_Contraseña GC = new Generar_Contraseña();
                GC.Show();
            }
        }
        #endregion

        #region Botones

        
        private void Generar_Contraseña_Load(object sender, EventArgs e)
        {
            groupBoxContraseña.Visible = false;
            LimpiarTxt();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Verificar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Complete todos los campos") ?? "Complete todos los campos");
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                txtContraseña.Text = Seguridad.GenerarClave();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ConfirmarCambio();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
        #endregion

        #region Idioma
        public void Update(ISubject Sujeto)
        {
            LblContraseña.Text = Sujeto.TraducirObserver(LblContraseña.Tag.ToString()) ?? LblContraseña.Tag.ToString();
            LblMail.Text = Sujeto.TraducirObserver(LblMail.Tag.ToString()) ?? LblMail.Tag.ToString();
            LblNick.Text = Sujeto.TraducirObserver(LblNick.Tag.ToString()) ?? LblNick.Tag.ToString();
            BtnConfirmar.Text = Sujeto.TraducirObserver(BtnConfirmar.Tag.ToString()) ?? BtnConfirmar.Tag.ToString();
            BtnGenerar.Text = Sujeto.TraducirObserver(BtnGenerar.Tag.ToString()) ?? BtnGenerar.Tag.ToString();
            BtnVerificar.Text = Sujeto.TraducirObserver(BtnVerificar.Tag.ToString()) ?? BtnVerificar.Tag.ToString();
            groupBoxContraseña.Text = Sujeto.TraducirObserver(groupBoxContraseña.Tag.ToString()) ?? groupBoxContraseña.Tag.ToString();
            this.Text = Sujeto.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            LblContraseña.Text = CambiarIdioma.TraducirGlobal(LblContraseña.Tag.ToString()) ?? LblContraseña.Tag.ToString();
            LblMail.Text = CambiarIdioma.TraducirGlobal(LblMail.Tag.ToString()) ?? LblMail.Tag.ToString();
            LblNick.Text = CambiarIdioma.TraducirGlobal(LblNick.Tag.ToString()) ?? LblNick.Tag.ToString();
            BtnConfirmar.Text = CambiarIdioma.TraducirGlobal(BtnConfirmar.Tag.ToString()) ?? BtnConfirmar.Tag.ToString();
            BtnGenerar.Text = CambiarIdioma.TraducirGlobal(BtnGenerar.Tag.ToString()) ?? BtnGenerar.Tag.ToString();
            BtnVerificar.Text = CambiarIdioma.TraducirGlobal(BtnVerificar.Tag.ToString()) ?? BtnVerificar.Tag.ToString();
            groupBoxContraseña.Text = CambiarIdioma.TraducirGlobal(groupBoxContraseña.Tag.ToString()) ?? groupBoxContraseña.Tag.ToString();
            this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }
        #endregion

    }

}
