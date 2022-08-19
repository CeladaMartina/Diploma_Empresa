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
    public partial class Administrar_Traduccion : Form, IObserver
    {
        Negocio_BLL.Idioma GestorIdioma = new Negocio_BLL.Idioma();
        Negocio_BLL.Traduccion GestorTraductor = new Negocio_BLL.Traduccion();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

        int IdTraduccion = -1;

        private static Administrar_Traduccion _instancia;
        public static Administrar_Traduccion ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Administrar_Traduccion();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public Administrar_Traduccion()
        {
            InitializeComponent();
        }

        #region Metodos traduccion 
        public void Update(ISubject subject)
        {
            LblIdioma.Text = subject.TraducirObserver(LblIdioma.Tag.ToString()) ?? LblIdioma.Tag.ToString();
            LblOriginal.Text = subject.TraducirObserver(LblOriginal.Tag.ToString()) ?? LblOriginal.Tag.ToString();
            LblTraducido.Text = subject.TraducirObserver(LblTraducido.Tag.ToString()) ?? LblTraducido.Tag.ToString();
            BtnAlta.Text = subject.TraducirObserver(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnModificar.Text = subject.TraducirObserver(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            BtnBaja.Text = subject.TraducirObserver(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnFiltrar.Text = subject.TraducirObserver(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            BtnFiltrarIdioma.Text = subject.TraducirObserver(BtnFiltrarIdioma.Tag.ToString()) ?? BtnFiltrarIdioma.Tag.ToString();
            BtnCancelarFiltro.Text = subject.TraducirObserver(BtnCancelarFiltro.Tag.ToString()) ?? BtnCancelarFiltro.Tag.ToString();
           
        }

        public void Traducir()
        {
            LblIdioma.Text = CambiarIdioma.TraducirGlobal(LblIdioma.Tag.ToString()) ?? LblIdioma.Tag.ToString();
            LblOriginal.Text = CambiarIdioma.TraducirGlobal(LblOriginal.Tag.ToString()) ?? LblOriginal.Tag.ToString();
            LblTraducido.Text = CambiarIdioma.TraducirGlobal(LblTraducido.Tag.ToString()) ?? LblTraducido.Tag.ToString();
            BtnAlta.Text = CambiarIdioma.TraducirGlobal(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnModificar.Text = CambiarIdioma.TraducirGlobal(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            BtnBaja.Text = CambiarIdioma.TraducirGlobal(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnFiltrar.Text = CambiarIdioma.TraducirGlobal(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            BtnFiltrarIdioma.Text = CambiarIdioma.TraducirGlobal(BtnFiltrarIdioma.Tag.ToString()) ?? BtnFiltrarIdioma.Tag.ToString();
            BtnCancelarFiltro.Text = CambiarIdioma.TraducirGlobal(BtnCancelarFiltro.Tag.ToString()) ?? BtnCancelarFiltro.Tag.ToString();
            
        }
        #endregion

        #region Metodos
        void ListarDefault()
        {
            dataGridViewFiltrado.DataSource = null;
            dataGridViewFiltrado.DataSource = GestorTraductor.IdiomaDefault();
            dataGridViewFiltrado.Columns["IdTraduccion"].Visible = false;
            dataGridViewFiltrado.Columns["IdIdioma"].Visible = false;
            dataGridViewFiltrado.Columns["NombreIdioma"].Visible = false;
            dataGridViewFiltrado.Columns["Traducido"].Visible = false;
            dataGridViewFiltrado.Columns["IdOriginal"].Visible = false;
            dataGridViewFiltrado.ReadOnly = true;
        }

        void FiltrarDefault(string Original)
        {
            dataGridViewFiltrado.DataSource = null;
            dataGridViewFiltrado.DataSource = GestorTraductor.FiltrarIdiomaDefault(Original);
            dataGridViewFiltrado.Columns["IdTraduccion"].Visible = false;
            dataGridViewFiltrado.Columns["IdIdioma"].Visible = false;
            dataGridViewFiltrado.Columns["NombreIdioma"].Visible = false;
            dataGridViewFiltrado.Columns["Traducido"].Visible = false;
            dataGridViewFiltrado.Columns["IdOriginal"].Visible = false;
            dataGridViewFiltrado.ReadOnly = true;
        }

        void LimpiarTxt()
        {
            TxtOriginal.Text = "";
            TxtTraducido.Text = "";
            cmbIdioma.Text = "";
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(cmbIdioma.Text) || string.IsNullOrEmpty(TxtOriginal.Text)
                || string.IsNullOrEmpty(TxtTraducido.Text))
            {
                A = true;
            }
            return A;
        }
        #endregion

        #region Metodos Formulario

        void ListarTraducciones(string NombreIdioma)
        {
            dataGridViewTraducciones.DataSource = null;
            dataGridViewTraducciones.DataSource = GestorTraductor.Listar(NombreIdioma);
            dataGridViewTraducciones.Columns["IdTraduccion"].Visible = false;
            dataGridViewTraducciones.Columns["IdIdioma"].Visible = false;
            dataGridViewTraducciones.Columns["IdOriginal"].Visible = false;
            dataGridViewTraducciones.ReadOnly = true;
        }

        void Alta(string NombreIdioma, string Original, string Traducido)
        {
            GestorTraductor.Alta(NombreIdioma, Original, Traducido);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta Traduccion", "Baja");
            ListarTraducciones(NombreIdioma);
            LimpiarTxt();
        }

        void Baja(int IdTraduccion, string NombreIdioma)
        {
            if (IdTraduccion != -1)
            {
                GestorTraductor.Baja(IdTraduccion);
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja Traduccion", "Baja");
                ListarTraducciones(NombreIdioma);
                LimpiarTxt();
            }
            IdTraduccion = -1;
        }

        void Modificar(int IdTraduccion, string NombreIdioma, string Original, string Traducido)
        {
            if (IdTraduccion != -1)
            {
                GestorTraductor.Modificar(IdTraduccion, NombreIdioma, Original, Traducido);
                Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar Traduccion", "Baja");
                ListarTraducciones(NombreIdioma);
                LimpiarTxt();
            }
            IdTraduccion = -1;
        }
        #endregion

        #region Botones

        private void BtnFiltrarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                ListarTraducciones(cmbIdioma.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                BtnAlta.Enabled = false;
                BtnBaja.Enabled = false;
                BtnModificar.Enabled = false;
                TxtTraducido.Enabled = false;
                FiltrarDefault(TxtOriginal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnCancelarFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarTxt();
                ListarDefault();
                BtnAlta.Enabled = false;
                BtnBaja.Enabled = false;
                BtnModificar.Enabled = false;
                TxtTraducido.Enabled = false;
                TxtOriginal.Enabled = true;
                BtnFiltrar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Alta(cmbIdioma.SelectedItem.ToString(), TxtOriginal.Text, TxtTraducido.Text);
                    TxtTraducido.Enabled = false;
                    BtnAlta.Enabled = false;
                    BtnModificar.Enabled = false;
                    BtnBaja.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Complete todos los campos") ?? "Complete todos los campos");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Modificar(IdTraduccion, cmbIdioma.SelectedItem.ToString(), TxtOriginal.Text, TxtTraducido.Text);

                    TxtTraducido.Enabled = false;
                    BtnAlta.Enabled = false;
                    BtnModificar.Enabled = false;
                    BtnBaja.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Complete todos los campos") ?? "Complete todos los campos");
            }
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Baja(IdTraduccion, cmbIdioma.SelectedItem.ToString());

                    TxtTraducido.Enabled = false;
                    BtnAlta.Enabled = false;
                    BtnModificar.Enabled = false;
                    BtnBaja.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Complete todos los campos") ?? "Complete todos los campos");
            }
        }

        #endregion

        private void dataGridViewFiltrado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtOriginal.Text = Convert.ToString(dataGridViewFiltrado.SelectedRows[0].Cells["Original"].Value.ToString());

                TxtOriginal.Enabled = false;
                BtnFiltrar.Enabled = false;
                BtnAlta.Enabled = true;
                BtnBaja.Enabled = true;
                BtnModificar.Enabled = true;
                TxtTraducido.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void dataGridViewTraducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdTraduccion = int.Parse(dataGridViewTraducciones.SelectedRows[0].Cells["IdTraduccion"].Value.ToString());
                cmbIdioma.Text = Convert.ToString(dataGridViewTraducciones.SelectedRows[0].Cells["NombreIdioma"].Value.ToString());
                TxtOriginal.Text = Convert.ToString(dataGridViewTraducciones.SelectedRows[0].Cells["Original"].Value.ToString());
                TxtTraducido.Text = Convert.ToString(dataGridViewTraducciones.SelectedRows[0].Cells["Traducido"].Value.ToString());

                TxtOriginal.Enabled = false;
                BtnFiltrar.Enabled = false;
                TxtTraducido.Enabled = true;
                BtnAlta.Enabled = true;
                BtnBaja.Enabled = true;
                BtnModificar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Administrar_Traduccion_Load(object sender, EventArgs e)
        {
            TxtTraducido.Enabled = false;
            BtnAlta.Enabled = false;
            BtnModificar.Enabled = false;
            BtnBaja.Enabled = false;
            Traducir();
            foreach (var NomIdioma in GestorIdioma.NombreIdioma())
            {
                cmbIdioma.Items.Add(NomIdioma.ToString());
            }
            ListarDefault();
        }
    }
}
