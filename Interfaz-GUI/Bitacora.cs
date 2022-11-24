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

        void CargarComboUsuario()
        {
            comboBoxUsuario.Items.Add("Todos");
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
        

        void Filtrar()
        {
            try
            {
                DateTime fechaDesde = dateTimePickerDesde.Value.Date;
                DateTime fechaHasta = dateTimePickerHasta.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                string criticidad = comboBoxCriticidad.Text;
                string usuario = comboBoxUsuario.Text;
                string consultaUsuario = "";
                string consultaCriticidad = "";

                switch (usuario)
                {
                    case "":
                        MessageBox.Show("seccione un usuario", "Usuario Vacio", MessageBoxButtons.OK,
                     MessageBoxIcon.Hand);
                        break;
                    case "Todos":
                        consultaUsuario = "select IdUsuario from Usuario";
                        break;
                    default:
                        consultaUsuario = "select IdUsuario from Usuario where Nick = '" + Seguridad.EncriptarAES(usuario) + "'";
                        break;
                }

                switch (criticidad)
                {
                    case "":
                        MessageBox.Show("seccione un usuario", "Usuario Vacio", MessageBoxButtons.OK,
                     MessageBoxIcon.Hand);
                        break;
                    case "Todos":
                        consultaCriticidad = "select distinct criticidad from Bitacora";
                        break;
                    default:
                        consultaCriticidad = "select criticidad from Bitacora where criticidad = '" + criticidad + "'";
                        break;
                }

                dataGridViewBitacora.DataSource = Seguridad.ConsultarBitacora(fechaDesde, fechaHasta, consultaCriticidad, consultaUsuario);

                if (dataGridViewBitacora.Rows.Count == 0)
                {
                    dataGridViewBitacora.DataSource = null;
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("No hay valores para mostrar en la grilla.") ?? "No hay valores para mostrar en la grilla.");
                    Listar();                   
                }
                else
                {
                    dataGridViewBitacora.Columns["IdUsuario"].Visible = false;
                    dataGridViewBitacora.Columns["IdBitacora"].Visible = false;
                    dataGridViewBitacora.Columns["DVH"].Visible = false;
                    dataGridViewBitacora.ReadOnly = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            //radioButtonAlta.Text = Sujeto.TraducirObserver(radioButtonAlta.Tag.ToString()) ?? radioButtonAlta.Tag.ToString();
            //radioButtonBaja.Text = Sujeto.TraducirObserver(radioButtonBaja.Tag.ToString()) ?? radioButtonBaja.Tag.ToString();
            //radioButtonMedia.Text = Sujeto.TraducirObserver(radioButtonMedia.Tag.ToString()) ?? radioButtonMedia.Tag.ToString();
            this.Text = Sujeto.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
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
            //radioButtonAlta.Text = CambiarIdioma.TraducirGlobal(radioButtonAlta.Tag.ToString()) ?? radioButtonAlta.Tag.ToString();
            //radioButtonBaja.Text = CambiarIdioma.TraducirGlobal(radioButtonBaja.Tag.ToString()) ?? radioButtonBaja.Tag.ToString();
            //radioButtonMedia.Text = CambiarIdioma.TraducirGlobal(radioButtonMedia.Tag.ToString()) ?? radioButtonMedia.Tag.ToString();
            this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
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
            DateTime fechaDesde = dateTimePickerDesde.Value.Date;
            DateTime fechaHasta = dateTimePickerHasta.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            try
            {
                if (ChequearFallaTxt() == false)
                {
                    if (fechaDesde >= fechaHasta)
                    {
                        MessageBox.Show(CambiarIdioma.TraducirGlobal("La fecha Hasta no puede ser menor que Desde.") ?? "La fecha Hasta no puede ser menor que Desde.");
                    }
                    else
                    {
                        Filtrar();
                    }
                    
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
            Listar();
            comboBoxUsuario.ResetText();
        }

        #endregion

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i <= dataGridViewBitacora.Rows.Count - 1; i++)
            //{
            //    foreach (DataGridViewRow dr in dataGridViewBitacora.Rows)
            //    {
            //        if (dr.Visible)
            //        {
            //            if (dr.Cells[2].Value.ToString().Contains(comboBoxUsuario.SelectedItem.ToString()))
            //            {
            //                dr.Visible = true;
            //            }
            //            else
            //            {
            //                this.dataGridViewBitacora.CurrentCell = null;
            //                dr.Visible = false;
            //            }
            //        }

            //    }
            //}
        }

        private void dateTimePickerHasta_ValueChanged(object sender, EventArgs e)
        {   
             
        }
    }
}
