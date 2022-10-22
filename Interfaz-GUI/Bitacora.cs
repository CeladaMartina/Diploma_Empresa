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
    public partial class Bitacora : Form,IObserver
    {
        Propiedades_BE.Bitacora BitacoraTemp = new Propiedades_BE.Bitacora();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Usuario GestorUsuario = new Negocio_BLL.Usuario();

        private static Bitacora _instancia;
        public static Bitacora ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Bitacora();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public Bitacora()
        {
            InitializeComponent();
        }

        #region Metodos
        void Listar()
        {
            dataGridViewBitacora.DataSource = null;
            dataGridViewBitacora.DataSource = Seguridad.Listar();
            dataGridViewBitacora.Columns["IdUsuario"].Visible = false;
            dataGridViewBitacora.Columns["IdBitacora"].Visible = false;
            dataGridViewBitacora.Columns["DVH"].Visible = false;
            dataGridViewBitacora.ReadOnly = true;
        }

        void Filtrar()
        {
            string criticidad = "";
            dataGridViewBitacora.DataSource = null;

            if (radioButtonAlta.Checked == true)
            {
                 criticidad = "Alta";
            }

            if (radioButtonBaja.Checked == true)
            {
                criticidad = "Baja";
            }

            if (radioButtonMedia.Checked == true)
            {
                criticidad = "Media";
            }                
            

            dataGridViewBitacora.DataSource = Seguridad.FiltradoCompleto(comboBoxUsuario.SelectedItem.ToString(), dateTimePickerDesde.Value.Date, dateTimePickerHasta.Value.Date, criticidad);
            
            dataGridViewBitacora.Columns["IdUsuario"].Visible = false;
            dataGridViewBitacora.Columns["IdBitacora"].Visible = false;
            dataGridViewBitacora.Columns["DVH"].Visible = false;
            dataGridViewBitacora.ReadOnly = true;
        }

        void CargarComboUsuario()
        {
            List<string> NickUsuarios = GestorUsuario.NickUsuario();
            foreach (var NickUs in NickUsuarios)
            {
                comboBoxUsuario.Items.Add(NickUs.ToString());
            }
        }
        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(comboBoxUsuario.Text))
            {
                A = true;
            }
            return A;
        }
        #endregion

        #region Traducccion
        public void Update(ISubject Sujeto)
        {
            LblElegirFiltro.Text = Sujeto.TraducirObserver(LblElegirFiltro.Tag.ToString()) ?? LblElegirFiltro.Tag.ToString();
            LblDesde.Text = Sujeto.TraducirObserver(LblDesde.Tag.ToString()) ?? LblDesde.Tag.ToString();
            LblHasta.Text = Sujeto.TraducirObserver(LblHasta.Tag.ToString()) ?? LblHasta.Tag.ToString();
            groupBoxCriticidad.Text = Sujeto.TraducirObserver(groupBoxCriticidad.Tag.ToString()) ?? groupBoxCriticidad.Tag.ToString();
            groupBoxRangodefecha.Text = Sujeto.TraducirObserver(groupBoxRangodefecha.Tag.ToString()) ?? groupBoxRangodefecha.Tag.ToString();
            groupBoxUsuario.Text = Sujeto.TraducirObserver(groupBoxUsuario.Tag.ToString()) ?? groupBoxUsuario.Tag.ToString();
            BtnCancelarfiltro.Text = Sujeto.TraducirObserver(BtnCancelarfiltro.Tag.ToString()) ?? BtnCancelarfiltro.Tag.ToString();
            BtnFiltrar.Text = Sujeto.TraducirObserver(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            radioButtonAlta.Text = Sujeto.TraducirObserver(radioButtonAlta.Tag.ToString()) ?? radioButtonAlta.Tag.ToString();
            radioButtonBaja.Text = Sujeto.TraducirObserver(radioButtonBaja.Tag.ToString()) ?? radioButtonBaja.Tag.ToString();
            radioButtonMedia.Text = Sujeto.TraducirObserver(radioButtonMedia.Tag.ToString()) ?? radioButtonMedia.Tag.ToString();
            //this.Text = Sujeto.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            LblElegirFiltro.Text = CambiarIdioma.TraducirGlobal(LblElegirFiltro.Tag.ToString()) ?? LblElegirFiltro.Tag.ToString();
            LblDesde.Text = CambiarIdioma.TraducirGlobal(LblDesde.Tag.ToString()) ?? LblDesde.Tag.ToString();
            LblHasta.Text = CambiarIdioma.TraducirGlobal(LblHasta.Tag.ToString()) ?? LblHasta.Tag.ToString();
            groupBoxCriticidad.Text = CambiarIdioma.TraducirGlobal(groupBoxCriticidad.Tag.ToString()) ?? groupBoxCriticidad.Tag.ToString();
            groupBoxRangodefecha.Text = CambiarIdioma.TraducirGlobal(groupBoxRangodefecha.Tag.ToString()) ?? groupBoxRangodefecha.Tag.ToString();
            groupBoxUsuario.Text = CambiarIdioma.TraducirGlobal(groupBoxUsuario.Tag.ToString()) ?? groupBoxUsuario.Tag.ToString();
            BtnCancelarfiltro.Text = CambiarIdioma.TraducirGlobal(BtnCancelarfiltro.Tag.ToString()) ?? BtnCancelarfiltro.Tag.ToString();
            BtnFiltrar.Text = CambiarIdioma.TraducirGlobal(BtnFiltrar.Tag.ToString()) ?? BtnFiltrar.Tag.ToString();
            radioButtonAlta.Text = CambiarIdioma.TraducirGlobal(radioButtonAlta.Tag.ToString()) ?? radioButtonAlta.Tag.ToString();
            radioButtonBaja.Text = CambiarIdioma.TraducirGlobal(radioButtonBaja.Tag.ToString()) ?? radioButtonBaja.Tag.ToString();
            radioButtonMedia.Text = CambiarIdioma.TraducirGlobal(radioButtonMedia.Tag.ToString()) ?? radioButtonMedia.Tag.ToString();
            //this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        #endregion

        #region Botones
        private void Bitacora_Load(object sender, EventArgs e)
        {
            CargarComboUsuario();           
            Listar();
            Traducir();
            dateTimePickerDesde.MaxDate = DateTime.Now;
            dateTimePickerHasta.MaxDate = DateTime.Now;           
            
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChequearFallaTxt() == false)
                {
                    Filtrar();
                }
                else
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error filtrando") ?? "Error filtrando");
                Listar();
            }
        }

        private void BtnCancelarfiltro_Click(object sender, EventArgs e)
        {
            try
            {
                Listar();                
                radioButtonAlta.Checked = false;
                radioButtonBaja.Checked = false;
                radioButtonMedia.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        #endregion
    }
}
