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
    public partial class Restore : Form, IObserver
    {
        public Restore()
        {
            InitializeComponent();
        }

        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

        private static Restore _instancia;
        public static Restore ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Restore();
            }
            _instancia.BringToFront();
            return _instancia;
        }


        #region Metodos

        void AgregarPartes()
        {
            System.IO.Stream myStream;
            OpenFileDialog thisDialog = new OpenFileDialog();

            thisDialog.InitialDirectory = "c:\\";
            thisDialog.Filter = "bak files (*.bak)|*.bak";
            thisDialog.FilterIndex = 2;
            thisDialog.RestoreDirectory = true;
            thisDialog.Multiselect = true;
            thisDialog.Title = "Seleccione el archivo para restaurar la base de datos.";

            if (thisDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in thisDialog.FileNames)
                {
                    try
                    {
                        if ((myStream = thisDialog.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                txtRestore.Text = file;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("Error -> No se puede leer el archivo: ") ?? "Error -> No se puede leer el archivo: " + ex.Message);
                    }
                }
            }            
        }

        void RealizarRestore()
        {  
            string restore = Seguridad.Restaurar(txtRestore.Text);
            if (restore == "ok")
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Restore realizado correctamente") ?? "Restore realizado correctamente");
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Restore exitoso", "Alta", 0);
                Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();
                GestorUsuario.LogOut();

                for(int i = Application.OpenForms.Count -1; i >= 0; i--)
                {
                    if(Application.OpenForms[i].Name == "Menu" || Application.OpenForms[i].Name == "Restore")
                    {
                        Application.OpenForms[i].Close();                       
                    }
                }

                LogIn L = new LogIn();
                L.Show();
            }
            else
            {
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Restore fallido", "Alta",0);
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error al realizar el restore") ?? "Error al realizar el restore");
            }
        }
        #endregion

        #region Traduccion
        public void Update(ISubject Sujeto)
        {
            BtnAgregarPartes.Text = Sujeto.TraducirObserver(BtnAgregarPartes.Tag.ToString()) ?? BtnAgregarPartes.Tag.ToString();
            BtnLimpiarLista.Text = Sujeto.TraducirObserver(BtnLimpiarLista.Tag.ToString()) ?? BtnLimpiarLista.Tag.ToString();
            BtnRestore.Text = Sujeto.TraducirObserver(BtnRestore.Tag.ToString()) ?? BtnRestore.Tag.ToString();
            this.Text = Sujeto.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            BtnAgregarPartes.Text = CambiarIdioma.TraducirGlobal(BtnAgregarPartes.Tag.ToString()) ?? BtnAgregarPartes.Tag.ToString();
            BtnLimpiarLista.Text = CambiarIdioma.TraducirGlobal(BtnLimpiarLista.Tag.ToString()) ?? BtnLimpiarLista.Tag.ToString();
            BtnRestore.Text = CambiarIdioma.TraducirGlobal(BtnRestore.Tag.ToString()) ?? BtnRestore.Tag.ToString();
            //this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        #endregion

        #region Botones
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarPartes();
                BtnAgregarPartes.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error al agregar partes") ?? "Error al agregar partes");
            }
        }

        private void BtnLimpiarLista_Click(object sender, EventArgs e)
        {
            try
            {                
                txtRestore.Clear();
                BtnAgregarPartes.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            if(txtRestore.Text == "")
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Seleccione un .bak para poder continuar.") ?? "Seleccione un .bak para poder continuar.");
            }
            else
            {
                try
                {
                    RealizarRestore();

                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            
        }

        private void Restore_Load(object sender, EventArgs e)
        {
            Traducir();
        }
    }
}
