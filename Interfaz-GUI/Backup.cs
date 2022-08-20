using Diploma_Empresa_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_GUI
{
    public partial class Backup : Form
    {
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

        private static Backup _instancia;
        public static Backup ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Backup();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        #region Metodos
        public void LimpiarTxt()
        {
            BtnExaminar.Enabled = true;
            BtnBackup.Enabled = false;
            TxtRuta.Text = "";
            TxtNombre.Text = "";
            TxtCantCopias.Text = "";
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtCantCopias.Text)
                || string.IsNullOrEmpty(TxtRuta.Text))
            {
                A = true;
            }
            else if (int.Parse(TxtCantCopias.Text) < 1)
            {
                A = true;
            }
            return A;
        }

        void RealizarBackUp()
        {
            Directory.CreateDirectory(TxtRuta.Text);
            DirectorySecurity sec = Directory.GetAccessControl(TxtRuta.Text);

            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            Directory.SetAccessControl(TxtRuta.Text, sec);

            string Backup = Seguridad.GenerarBackUp(TxtNombre.Text, TxtRuta.Text, int.Parse(TxtCantCopias.Text));
            if (Backup == "ok")
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Backup realizado correctamente") ?? "Backup realizado correctamente");
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "BackUp realizado", "Media");
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Se produjo error al realizar el backup") ?? "Se produjo error al realizar el backup");
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "BackUp Fallo", "Alta");
            }
            LimpiarTxt();
        }

        void Examinar()
        {
            folderBrowserDialog1.ShowDialog();
            TxtRuta.Text = folderBrowserDialog1.SelectedPath;
            BtnExaminar.Enabled = false;
            BtnBackup.Enabled = true;
        }

        public Backup()
        {
            InitializeComponent();
        }
        #endregion

        #region Traduccion
        public void Update(ISubject Subject)
        {
            LblRuta.Text = Subject.TraducirObserver(LblRuta.Tag.ToString()) ?? LblRuta.Tag.ToString();
            LblNombre.Text = Subject.TraducirObserver(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            LblCantCopias.Text = Subject.TraducirObserver(LblCantCopias.Tag.ToString()) ?? LblCantCopias.Tag.ToString();
            BtnBackup.Text = Subject.TraducirObserver(BtnBackup.Tag.ToString()) ?? BtnBackup.Tag.ToString();
            BtnExaminar.Text = Subject.TraducirObserver(BtnExaminar.Tag.ToString()) ?? BtnExaminar.Tag.ToString();
            //this.Text = Subject.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
            BtnModificar.Text = Subject.TraducirObserver(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
        }

        public void Traducir()
        {
            LblRuta.Text = CambiarIdioma.TraducirGlobal(LblRuta.Tag.ToString()) ?? LblRuta.Tag.ToString();
            LblNombre.Text = CambiarIdioma.TraducirGlobal(LblNombre.Tag.ToString()) ?? LblNombre.Tag.ToString();
            LblCantCopias.Text = CambiarIdioma.TraducirGlobal(LblCantCopias.Tag.ToString()) ?? LblCantCopias.Tag.ToString();
            BtnBackup.Text = CambiarIdioma.TraducirGlobal(BtnBackup.Tag.ToString()) ?? BtnBackup.Tag.ToString();
            BtnExaminar.Text = CambiarIdioma.TraducirGlobal(BtnExaminar.Tag.ToString()) ?? BtnExaminar.Tag.ToString();
            //this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
            BtnModificar.Text = CambiarIdioma.TraducirGlobal(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
        }
        #endregion

        #region Botones
        #endregion

        private void Backup_Load(object sender, EventArgs e)
        {
            BtnExaminar.Enabled = true;
            BtnBackup.Enabled = false;
            BtnModificar.Enabled = false;
            Traducir();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                BtnExaminar.Enabled = true;
                BtnModificar.Enabled = false;
                TxtRuta.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                Examinar();
                BtnExaminar.Enabled = false;
                BtnModificar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChequearFallaTxt() == false)
                {
                    RealizarBackUp();
                    BtnExaminar.Enabled = true;
                    BtnModificar.Enabled = false;
                }
                else
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
    }
}
