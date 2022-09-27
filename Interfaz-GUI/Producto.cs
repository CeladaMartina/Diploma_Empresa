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
    public partial class Producto : Form
    {
        Negocio_BLL.Producto GestorArticulo = new Negocio_BLL.Producto();
        Negocio_BLL.Localidad GestorLocalidad = new Negocio_BLL.Localidad();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

        int IdArticulo = -1;

        private static Producto _instancia;
        public static Producto ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Producto();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            TxtStock.Enabled = false;
            Listar();
            foreach (var NombreLocalidad in GestorLocalidad.TraerNomLoc())
            {
                CmbLocalidad.Items.Add(NombreLocalidad.ToString());
            }
            TxtStock.Text = "0";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        void Listar()
        {
            dataGridViewArticulo.DataSource = null;
            dataGridViewArticulo.DataSource = GestorArticulo.Listar();
            dataGridViewArticulo.Columns["IdArticulo"].Visible = false;
            dataGridViewArticulo.Columns["IdLocalidad"].Visible = false;
            dataGridViewArticulo.ReadOnly = true;
        }

        void Alta(int IdArticulo, int CodProd, string Nombre, string Descripcion, string Material, int IdLocalidad, int Talle, int Stock, decimal PUnit)
        {
            GestorArticulo.Alta(IdArticulo, CodProd, Nombre, Descripcion, Material, IdLocalidad, Talle, 0, PUnit);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta Articulo", "Media",0);

            Listar();
            LimpiarTxt();
            IdArticulo = -1;
        }

        void Modificar(int IdArticulo, int CodProd, string Nombre, string Descripcion, string Material, int IdLocalidad, int Talle, int Stock, decimal PUnit)
        {
            GestorArticulo.Modificar(IdArticulo, CodProd, Nombre, Descripcion, Material, IdLocalidad, Talle, 0, PUnit);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar Articulo", "Baja",0);

            Listar();
            LimpiarTxt();
            IdArticulo = -1;
        }

        void Baja(int IdArticulo)
        {
            GestorArticulo.Baja(IdArticulo);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja Articulo", "Baja",0);

            Listar();
            LimpiarTxt();
            IdArticulo = -1;
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtCodProd.Text) || string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtDescripcion.Text) ||
                string.IsNullOrEmpty(TxtMaterial.Text) || string.IsNullOrEmpty(CmbLocalidad.Text) || string.IsNullOrEmpty(TxtTalle.Text) ||
                string.IsNullOrEmpty(TxtPrecio.Text))
            {
                A = true;
            }
            return A;
        }

        void LimpiarTxt()
        {
            TxtCodProd.Text = "";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            TxtMaterial.Text = "";
            CmbLocalidad.SelectedIndex = -1;
            TxtTalle.Text = "";
            TxtStock.Text = "";
            TxtPrecio.Text = "";
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Alta(IdArticulo, int.Parse(TxtCodProd.Text), TxtNombre.Text, TxtDescripcion.Text, TxtMaterial.Text, GestorLocalidad.TraerIdLoc(CmbLocalidad.Text), int.Parse(TxtTalle.Text), int.Parse(TxtStock.Text), decimal.Parse(TxtPrecio.Text));
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

        private void BtnModificacion_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Modificar(IdArticulo, int.Parse(TxtCodProd.Text), TxtNombre.Text, TxtDescripcion.Text, TxtMaterial.Text, GestorLocalidad.TraerIdLoc(CmbLocalidad.Text), int.Parse(TxtTalle.Text), int.Parse(TxtStock.Text), decimal.Parse(TxtPrecio.Text));
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
                    Baja(IdArticulo);
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

        private void dataGridViewArticulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdArticulo = int.Parse(Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["IdArticulo"].Value.ToString()));
                TxtCodProd.Text = int.Parse(Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["CodProd"].Value.ToString())).ToString();
                TxtNombre.Text = Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["Nombre"].Value.ToString());
                TxtDescripcion.Text = Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString());
                TxtMaterial.Text = Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["Material"].Value.ToString());
                CmbLocalidad.Text = Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["NombreLocalidad"].Value.ToString());
                TxtTalle.Text = int.Parse(Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["Talle"].Value.ToString())).ToString();
                TxtStock.Text = Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["Stock"].Value.ToString());
                TxtPrecio.Text = decimal.Parse(Convert.ToString(dataGridViewArticulo.Rows[e.RowIndex].Cells["PUnit"].Value.ToString())).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
    }
}
