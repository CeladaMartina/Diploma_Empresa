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
    public partial class Venta : Form
    {
        Negocio_BLL.Venta GestorVenta = new Negocio_BLL.Venta();
        Negocio_BLL.Detalle_Venta GestorDV = new Negocio_BLL.Detalle_Venta();
        Negocio_BLL.Cliente GestorCliente = new Negocio_BLL.Cliente();
        Negocio_BLL.Producto GestorArticulo = new Negocio_BLL.Producto();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();

        private static Venta _instancia;
        public static Venta ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Venta();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        int IdDetalle = -1;
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            CargarCombos();
            TxtIdVenta.Text = "";
            dateTimePickerFecha.Text = DateTime.Now.ToShortDateString();
            LABELFechaValor.Text = dateTimePickerFecha.Text;
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
        }

        #region metodos 
        void CargarCombos()
        {
            foreach (var DNI in GestorCliente.DNIsClientes())
            {
                CmbDNICliente.Items.Add(DNI.ToString());
            }
            foreach (var CodProd in GestorArticulo.CodProdArticulo())
            {
                CmbCodArticulo.Items.Add(CodProd);
            }
            foreach (var Descripcion in GestorArticulo.DescripcionProd())
            {
                CmbNombreArticulo.Items.Add(Descripcion);
            }
            foreach (var NombreClientes in GestorCliente.NombresClientes())
            {
                CmbNombreClientes.Items.Add(NombreClientes);
            }
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtCantidad.Text) || string.IsNullOrEmpty(CmbCodArticulo.Text)
                || string.IsNullOrEmpty(CmbNombreArticulo.Text))
            {
                A = true;
            }
            else if (int.Parse(TxtCantidad.Text) < 1)
            {
                A = true;
            }
            return A;
        }
        void LimpiarTxt()
        {
            TxtCantidad.Text = "";
            TxtPrecioUnitario.Text = "";
            CmbCodArticulo.SelectedIndex = -1;
            CmbNombreArticulo.SelectedIndex = -1;
            LblStock.Text = "";
        }
        public void ListarDV()
        {
            dataGridViewDV.DataSource = null;
            dataGridViewDV.DataSource = GestorDV.ListarDV(int.Parse(TxtIdVenta.Text));
            dataGridViewDV.Columns["IdDetalle"].Visible = false;
            dataGridViewDV.Columns["IdVenta"].Visible = false;
            dataGridViewDV.Columns["IdArticulo"].Visible = false;
            dataGridViewDV.Columns["DVH"].Visible = false;
            dataGridViewDV.ReadOnly = true;
        }

        public void AltaVenta(int IdCliente, DateTime Fecha)
        {
            GestorVenta.Alta(IdCliente, Fecha);
        }

        public void AltaDV(int IdVenta, int IdArticulo, decimal PUnit, int Cantidad, int DVH)
        {
            int CantidadChequeoStock = GestorArticulo.VerificarCantStock(int.Parse(CmbCodArticulo.SelectedItem.ToString()));
            if (Cantidad <= CantidadChequeoStock && GestorDV.ChequearStock(IdArticulo, int.Parse(TxtIdVenta.Text), Cantidad, 0) <= CantidadChequeoStock)
            {
                GestorDV.AltaDV(PUnit, IdArticulo, DVH, Cantidad, IdVenta);
                TxtIdVenta.Text = IdVenta.ToString();
                ListarDV();
                CmbDNICliente.Enabled = false;
                Lblsubtotal.Text = GestorDV.SubTotal(int.Parse(TxtIdVenta.Text)).ToString();
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("No hay Stock suficiente") ?? "No hay Stock suficiente");
            }
        }

        public void BajaDV(int IdDetalle, int IdArticle)
        {
            GestorDV.BajaDV(IdDetalle, IdArticle);
            ListarDV();
            Lblsubtotal.Text = GestorDV.SubTotal(int.Parse(TxtIdVenta.Text)).ToString();
        }

        public void ModificarDV(int IdDetalle, int IdArticulo, decimal PUnit, int Cantidad, int DVH)
        {
            int CantidadChequeoStock = GestorArticulo.VerificarCantStock(int.Parse(CmbCodArticulo.SelectedItem.ToString()));
            if (Cantidad <= CantidadChequeoStock && GestorDV.ChequearStock(IdArticulo, int.Parse(TxtIdVenta.Text), Cantidad, IdDetalle) <= CantidadChequeoStock)
            {
                GestorDV.ModificarDV(IdDetalle, IdArticulo, PUnit, Cantidad, DVH);
                ListarDV();
                Lblsubtotal.Text = GestorDV.SubTotal(int.Parse(TxtIdVenta.Text)).ToString();
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("No hay Stock suficiente") ?? "No hay Stock suficiente");
            }
        }
        #endregion

        #region botones combo
        private void CmbDNICliente_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CmbNombreClientes.Text = GestorCliente.SeleccionarNombreCliente(CmbDNICliente.SelectedItem.ToString());
                LABELNombreCliente.Text = CmbNombreClientes.Text;
            }
            catch (Exception)
            {
                CmbNombreClientes.Text = "";
            }
        }

        private void CmbNombreClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CmbDNICliente.Text = GestorCliente.SeleccionarDNICliente(CmbNombreClientes.SelectedItem.ToString()).ToString();
                LABELCliente.Text = CmbDNICliente.Text;

            }
            catch (Exception)
            {
                CmbDNICliente.Text = "";
            }
        }

        private void CmbCodArticulo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CmbNombreArticulo.Text = GestorArticulo.SeleccionarNombreArt(int.Parse(CmbCodArticulo.SelectedItem.ToString()));
                TxtPrecioUnitario.Text = GestorArticulo.SeleccionPUnit(int.Parse(CmbCodArticulo.SelectedItem.ToString())).ToString();
                LblStock.Text = GestorArticulo.SeleccionarStock(int.Parse(CmbCodArticulo.SelectedItem.ToString())).ToString();
            }
            catch (Exception)
            {
                TxtPrecioUnitario.Text = "";
            }
        }

        private void CmbNombreArticulo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CmbCodArticulo.Text = GestorArticulo.SeleccionarCodArticulo(CmbNombreArticulo.SelectedItem.ToString()).ToString();
                LblStock.Text = GestorArticulo.SeleccionarStock(int.Parse(CmbCodArticulo.SelectedItem.ToString())).ToString();
            }
            catch (Exception)
            {
                TxtPrecioUnitario.Text = "";
            }
        }


        #endregion

        #region botones

        #endregion

        private void dataGridViewDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdDetalle = int.Parse(Convert.ToString(dataGridViewDV.Rows[e.RowIndex].Cells["IdDetalle"].Value.ToString()));
                TxtCantidad.Text = int.Parse(Convert.ToString(dataGridViewDV.Rows[e.RowIndex].Cells["Cant"].Value.ToString())).ToString();
                TxtPrecioUnitario.Text = decimal.Parse(Convert.ToString(dataGridViewDV.Rows[e.RowIndex].Cells["PUnit"].Value.ToString())).ToString();
                CmbCodArticulo.Text = int.Parse(Convert.ToString(dataGridViewDV.Rows[e.RowIndex].Cells["CodProd"].Value.ToString())).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnGenerarVenta_Click(object sender, EventArgs e)
        {
            if (CmbDNICliente.Text != "")
            {
                AltaVenta(GestorCliente.SeleccionarID(CmbDNICliente.Text), DateTime.Parse(dateTimePickerFecha.Text));
                TxtIdVenta.Text = GestorVenta.TraerIdVenta().ToString();
                labelNumeroVenta.Text = TxtIdVenta.Text;
                CmbDNICliente.Enabled = false;
                CmbNombreClientes.Enabled = false;
                BtnCargarDetalle.Visible = true;                
                BtnEditarDetalle.Enabled = true;
                BtnGenerarVenta.Visible = false;
                groupBox2.Enabled = true;
                groupBox1.Enabled = true;
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Debe seleccionar un cliente") ?? "Debe seleccionar un cliente");
            }
        }

        private void BtnCargarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                BtnAltaDetalle.Enabled = true;
                BtnModificarDetalle.Enabled = true;
                BtnBajaDetalle.Enabled = true;
                BtnCargarDetalle.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnEditarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                ListarDV();
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                Lblsubtotal.Text = TxtTotal.Text;
                TxtTotal.Text = "";
                BtnAltaDetalle.Enabled = true;
                BtnModificarDetalle.Enabled = true;
                BtnVender.Enabled = false;
                BtnBajaDetalle.Enabled = true;
                CmbCodArticulo.Enabled = true;
                BtnCerrarDetalle.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnAltaDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChequearFallaTxt() == false)
                {
                    if (GestorDV.ExisteProducto(int.Parse(TxtIdVenta.Text), GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodArticulo.Text))) == true)
                    {
                        GestorDV.UnificarArticulos(int.Parse(TxtIdVenta.Text), GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodArticulo.Text)), int.Parse(TxtCantidad.Text));
                        ListarDV();
                    }
                    else
                    {
                        AltaDV(int.Parse(TxtIdVenta.Text), GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodArticulo.Text)), decimal.Parse(TxtPrecioUnitario.Text), int.Parse(TxtCantidad.Text), 0);
                    }
                    LimpiarTxt();
                    BtnCerrarDetalle.Enabled = true;
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

        private void BtnModificarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChequearFallaTxt() == false)
                {
                    ModificarDV(IdDetalle, GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodArticulo.Text)), decimal.Parse(TxtPrecioUnitario.Text), int.Parse(TxtCantidad.Text), 0);
                    LimpiarTxt();
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

        private void BtnBajaDetalle_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    BajaDV(IdDetalle, GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodArticulo.Text)));
                    LimpiarTxt();
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

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (GestorVenta.VerificarExistenciaMonto(int.Parse(TxtIdVenta.Text)) == true)
                {
                    TxtTotal.Text = Lblsubtotal.Text;
                    LimpiarTxt();
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    BtnVender.Enabled = true;
                    BtnEditarDetalle.Enabled = true;
                    BtnGenerarVenta.Visible = false;
                    CmbCodArticulo.Enabled = false;
                    BtnAltaDetalle.Enabled = false;
                    BtnModificarDetalle.Enabled = false;
                    BtnBajaDetalle.Enabled = false;
                    BtnCerrarDetalle.Enabled = false;
                    Lblsubtotal.Text = "";
                }
                else
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Detalle vacio") ?? "Detalle vacio");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = String.Concat(CambiarIdioma.TraducirGlobal("El total es de: $") ?? "El total es de: $", TxtTotal.Text, "\n", CambiarIdioma.TraducirGlobal("¿Confirma el importe?") ?? "¿Confirma el importe?");
                if (MessageBox.Show(msj, CambiarIdioma.TraducirGlobal("Confirmar") ?? "Confirmar", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TxtIdVenta.Text = GestorVenta.TraerIdVenta().ToString();
                    GestorVenta.Vender(int.Parse(TxtIdVenta.Text));
                    //folderBrowserDialog1.ShowDialog();
                    //string ruta = folderBrowserDialog1.SelectedPath;
                    //PDF(ruta, int.Parse(TxtIdVenta.Text), CmbNombreClientes.Text, DateTime.Now.ToShortDateString(), decimal.Parse(TxtTotal.Text));
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Venta realizada exitosamente.") ?? "Venta realizada exitosamente.");
                    Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Venta Realizada", "Baja", 0);
                    dataGridViewDV.DataSource = null;
                    BtnEditarDetalle.Enabled = false;
                    BtnVender.Enabled = false;
                    CmbCodArticulo.Enabled = true;
                    BtnGenerarVenta.Enabled = true;
                    CmbCodArticulo.SelectedIndex = -1;
                    CmbNombreArticulo.SelectedIndex = -1;
                    CmbNombreClientes.Text = "";
                    Lblsubtotal.Text = "";
                    TxtIdVenta.Text = "";
                    TxtTotal.Text = "";
                    BtnGenerarVenta.Visible = true;
                    BtnGenerarVenta.Enabled = true;
                    CmbDNICliente.Enabled = true;
                    CmbNombreClientes.Enabled = true;
                    LABELCliente.Text = "";
                    LABELFechaValor.Text = "";
                    labelNumeroVenta.Text = "";
                    LABELNombreCliente.Text = "";
                }
                else
                {
                    Lblsubtotal.Text = TxtTotal.Text;
                    ListarDV();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void Venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (TxtIdVenta.Text != "")
                    {
                        if (MessageBox.Show(CambiarIdioma.TraducirGlobal("Se esta por cerrar el formulario. Si posee una venta en progreso se cancelara ¿Desea continuar?") ?? "Se esta por cerrar el formulario. Si posee una venta en progreso se cancelara ¿Desea continuar?", CambiarIdioma.TraducirGlobal("Confirmar") ?? "Confirmar", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            MessageBox.Show(CambiarIdioma.TraducirGlobal(GestorVenta.CancelarVenta(int.Parse(TxtIdVenta.Text))) ?? GestorVenta.CancelarVenta(int.Parse(TxtIdVenta.Text)));
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }
    }
}
