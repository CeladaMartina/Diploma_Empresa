using Diploma_Empresa_Final;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
using System.Windows.Documents;
using System.Windows.Forms;
using Paragraph = iTextSharp.text.Paragraph;

namespace Interfaz_GUI
{
    public partial class Compra : Form, IObserver
    {
        Negocio_BLL.Producto GestorArticulo = new Negocio_BLL.Producto();
        Negocio_BLL.Compra GestorCompra = new Negocio_BLL.Compra();
        Negocio_BLL.Detalle_Compra GestorDC = new Negocio_BLL.Detalle_Compra();
        Negocio_BLL.Proveedor GestorProveedor = new Negocio_BLL.Proveedor();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Pedido GestorPedido = new Negocio_BLL.Pedido();

        private static Compra _instancia;
        public static Compra ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new Compra();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        int IdDetalle = -1;

        public Compra()
        {
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            CargarCombos();
            TxtIdCompra.Text = "";
            dateTimePickerFecha.Text = DateTime.Now.ToShortDateString();
            Traducir();
        }

        #region metodos 
        void LimpiarTxt()
        {
            CmbCodProducto.SelectedIndex = -1;
            CmbNombreArticulo.SelectedIndex = -1;
            TxtPrecio.Text = "";
            TxtCantidad.Text = "";
            TxtCantSugerida.Text = "";
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtCantidad.Text) || string.IsNullOrEmpty(CmbCodProducto.Text)
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
        public void AltaCompra(int IdProveedor, DateTime Fecha)
        {
            GestorCompra.Alta(IdProveedor, Fecha);
        }
        void CargarCombos()
        {
            CmbCodProducto.Items.Clear();
            CmbCUITProveedor.Items.Clear();
            CmbNombreArticulo.Items.Clear();
            CmbNombreProveedor.Items.Clear();
            foreach (var CUIT in GestorProveedor.CUITProveedor())
            {
                CmbCUITProveedor.Items.Add(CUIT.ToString());
            }
            foreach (var CodProd in GestorArticulo.CodProdArticulo())
            {
                CmbCodProducto.Items.Add(CodProd);
            }
            foreach (var Descripcion in GestorArticulo.DescripcionProd())
            {
                CmbNombreArticulo.Items.Add(Descripcion);
            }
            foreach (var NombreProv in GestorProveedor.NombreProveedores())
            {
                CmbNombreProveedor.Items.Add(NombreProv);
            }
        }

        //detalle
        public void AltaDC(int Cantidad, int DVH, int IdArticulo, decimal PUnit, int IdCompra)
        {
            GestorDC.AltaDC(Cantidad, DVH, IdArticulo, PUnit, IdCompra);
            ListarDC();
            TxtIdCompra.Text = IdCompra.ToString();
            Lblsubtotal.Text = GestorDC.SubTotal(IdCompra).ToString();
        }

        public void ModificarDC(int IdDetalle, int IdArticulo, decimal PUnit, int Cantidad, int DVH)
        {
            GestorDC.ModificarDC(IdDetalle, IdArticulo, PUnit, Cantidad, DVH);
            ListarDC();
            Lblsubtotal.Text = GestorDC.SubTotal(int.Parse(TxtIdCompra.Text)).ToString();
        }

        public void BajaDC(int IdDetalle, int IdArticulo)
        {
            GestorDC.BajaDC(IdDetalle, IdArticulo);
            ListarDC();
            Lblsubtotal.Text = GestorDC.SubTotal(int.Parse(TxtIdCompra.Text)).ToString();
        }
        public void ListarDC()
        {
            dataGridViewDC.DataSource = null;
            dataGridViewDC.DataSource = GestorDC.ListarDC(int.Parse(TxtIdCompra.Text));
            dataGridViewDC.Columns["IdDetalle"].Visible = false;
            dataGridViewDC.Columns["IdCompra"].Visible = false;
            dataGridViewDC.Columns["IdArticulo"].Visible = false;
            dataGridViewDC.Columns["DVH"].Visible = false;
            dataGridViewDC.ReadOnly = true;
        }

        void PDF(string ruta, int NumCompra, string Proveedor, string Fecha, decimal Total)
        {
            Directory.CreateDirectory(ruta);
            DirectorySecurity sec = Directory.GetAccessControl(ruta);

            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            Directory.SetAccessControl(ruta, sec);

            string fecha_final = Fecha.Replace("/", "-");

            string ruta_final = "" + ruta + "\\Compra_" + NumCompra + "__" + fecha_final + ".pdf";

            System.IO.FileStream fs = new FileStream(ruta_final, FileMode.Create);

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40f, 40f, 40f, 40f);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            BaseFont Fuente0 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            iTextSharp.text.Font Titulo = new iTextSharp.text.Font(Fuente0, 26f, iTextSharp.text.Font.BOLD, new BaseColor(255, 128, 128));

            BaseFont Fuente1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            iTextSharp.text.Font Titulo2 = new iTextSharp.text.Font(Fuente1, 18f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            BaseFont Fuente2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, true);
            iTextSharp.text.Font TablasTitulo = new iTextSharp.text.Font(Fuente2, 14f, iTextSharp.text.Font.ITALIC, new BaseColor(255, 192, 192));

            BaseFont Fuente3 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, true);
            iTextSharp.text.Font TablasTexto = new iTextSharp.text.Font(Fuente3, 12f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            string imagepath = Directory.GetCurrentDirectory() + "\\Imagenes\\LogoTP.png";
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagepath);
            logo.ScalePercent(60);
            doc.Add(logo);

            Paragraph Compra = new Paragraph("Compra", Titulo);
            Compra.Alignment = Element.ALIGN_CENTER;
            doc.Add(Compra);
            doc.Add(new Chunk("\n"));

            Paragraph NCompra = new Paragraph("Numero de compra: " + NumCompra + "", Titulo2);
            NCompra.Alignment = Element.ALIGN_LEFT;
            doc.Add(NCompra);
            doc.Add(new Chunk("\n"));

            Paragraph ProveedorN = new Paragraph("Proveedor: " + Proveedor + "", Titulo2);
            ProveedorN.Alignment = Element.ALIGN_LEFT;
            doc.Add(ProveedorN);
            doc.Add(new Chunk("\n"));

            Paragraph FechaP = new Paragraph("Fecha: " + Fecha + "", Titulo2);
            FechaP.Alignment = Element.ALIGN_LEFT;
            doc.Add(FechaP);
            doc.Add(new Chunk("\n"));

            PdfPTable table = new PdfPTable(4);
            table.AddCell(new PdfPCell(new Phrase("Codigo Producto", TablasTitulo)) { HorizontalAlignment = Element.ALIGN_CENTER });
            table.AddCell(new PdfPCell(new Phrase("Descripcion", TablasTitulo)) { HorizontalAlignment = Element.ALIGN_CENTER });
            table.AddCell(new PdfPCell(new Phrase("Precio", TablasTitulo)) { HorizontalAlignment = Element.ALIGN_CENTER });
            table.AddCell(new PdfPCell(new Phrase("Cantidad", TablasTitulo)) { HorizontalAlignment = Element.ALIGN_CENTER });

            table.SpacingBefore = 10;
            foreach (DataGridViewRow row in dataGridViewDC.Rows)
            {
                try
                {
                    int CodProd = int.Parse(row.Cells["CodProd"].Value.ToString());
                    string Descripcion = row.Cells["Descripcion"].Value.ToString();
                    decimal PrecioU = decimal.Parse(row.Cells["PUnit"].Value.ToString());
                    int Cantidad = int.Parse(row.Cells["Cant"].Value.ToString());

                    table.AddCell(new PdfPCell(new Phrase(CodProd.ToString(), TablasTexto)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
                    table.AddCell(new PdfPCell(new Phrase(Descripcion.ToString(), TablasTexto)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
                    table.AddCell(new PdfPCell(new Phrase(PrecioU.ToString(), TablasTexto)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
                    table.AddCell(new PdfPCell(new Phrase(Cantidad.ToString(), TablasTexto)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            doc.Add(table);

            Paragraph Linea = new Paragraph("----------------------------", Titulo2);
            Linea.Alignment = Element.ALIGN_RIGHT;
            doc.Add(Linea);

            Paragraph TotalF = new Paragraph("El total es: " + Total + "", Titulo2);
            TotalF.Alignment = Element.ALIGN_RIGHT;
            doc.Add(TotalF);
            doc.Add(new Chunk("\n"));

            doc.Close();
            writer.Close();
            MessageBox.Show("PDF guardado");
        }

        #endregion

        #region traduccion 
        void IObserver.Update(ISubject Subject)
        {
            groupBox1.Text = Subject.TraducirObserver(groupBox1.Tag.ToString()) ?? groupBox1.Tag.ToString();
            LblNCompra.Text = Subject.TraducirObserver(LblNCompra.Tag.ToString()) ?? LblNCompra.Tag.ToString();
            LblProveedor.Text = Subject.TraducirObserver(LblProveedor.Tag.ToString()) ?? LblProveedor.Tag.ToString();
            LblFecha.Text = Subject.TraducirObserver(LblFecha.Tag.ToString()) ?? LblFecha.Tag.ToString();
            LblTotal.Text = Subject.TraducirObserver(LblTotal.Tag.ToString()) ?? LblTotal.Tag.ToString();
            BtnGenerarCompra.Text = Subject.TraducirObserver(BtnGenerarCompra.Tag.ToString()) ?? BtnGenerarCompra.Tag.ToString();
            BtnComprar.Text = Subject.TraducirObserver(BtnComprar.Tag.ToString()) ?? BtnComprar.Tag.ToString();
            BtnCargarDetalle.Text = Subject.TraducirObserver(BtnCargarDetalle.Tag.ToString()) ?? BtnCargarDetalle.Tag.ToString();
            BtnEditarDetalle.Text = Subject.TraducirObserver(BtnEditarDetalle.Tag.ToString()) ?? BtnEditarDetalle.Tag.ToString();
            groupBox2.Text = Subject.TraducirObserver(groupBox2.Tag.ToString()) ?? groupBox2.Tag.ToString();
            LblArticulo.Text = Subject.TraducirObserver(LblArticulo.Tag.ToString()) ?? LblArticulo.Tag.ToString();
            LblPrecioUnitario.Text = Subject.TraducirObserver(LblPrecioUnitario.Tag.ToString()) ?? LblPrecioUnitario.Tag.ToString();
            LblCantidad.Text = Subject.TraducirObserver(LblCantidad.Tag.ToString()) ?? LblCantidad.Tag.ToString();
            BtnAltaDetalle.Text = Subject.TraducirObserver(BtnAltaDetalle.Tag.ToString()) ?? BtnAltaDetalle.Tag.ToString();
            BtnModificarDetalle.Text = Subject.TraducirObserver(BtnModificarDetalle.Tag.ToString()) ?? BtnModificarDetalle.Tag.ToString();
            BtnBajaDetalle.Text = Subject.TraducirObserver(BtnBajaDetalle.Tag.ToString()) ?? BtnBajaDetalle.Tag.ToString();
            BtnCargarNuevoArt.Text = Subject.TraducirObserver(BtnCargarNuevoArt.Tag.ToString()) ?? BtnCargarNuevoArt.Tag.ToString();
            BtnCerrarDetalle.Text = Subject.TraducirObserver(BtnCerrarDetalle.Tag.ToString()) ?? BtnCerrarDetalle.Tag.ToString();
            BtnDeserializar.Text = Subject.TraducirObserver(BtnDeserializar.Tag.ToString()) ?? BtnDeserializar.Tag.ToString();
            this.Text = Subject.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            groupBox1.Text = CambiarIdioma.TraducirGlobal(groupBox1.Tag.ToString()) ?? groupBox1.Tag.ToString();
            LblNCompra.Text = CambiarIdioma.TraducirGlobal(LblNCompra.Tag.ToString()) ?? LblNCompra.Tag.ToString();
            LblProveedor.Text = CambiarIdioma.TraducirGlobal(LblProveedor.Tag.ToString()) ?? LblProveedor.Tag.ToString();
            LblFecha.Text = CambiarIdioma.TraducirGlobal(LblFecha.Tag.ToString()) ?? LblFecha.Tag.ToString();
            LblTotal.Text = CambiarIdioma.TraducirGlobal(LblTotal.Tag.ToString()) ?? LblTotal.Tag.ToString();
            BtnGenerarCompra.Text = CambiarIdioma.TraducirGlobal(BtnGenerarCompra.Tag.ToString()) ?? BtnGenerarCompra.Tag.ToString();
            BtnComprar.Text = CambiarIdioma.TraducirGlobal(BtnComprar.Tag.ToString()) ?? BtnComprar.Tag.ToString();
            BtnCargarDetalle.Text = CambiarIdioma.TraducirGlobal(BtnCargarDetalle.Tag.ToString()) ?? BtnCargarDetalle.Tag.ToString();
            BtnEditarDetalle.Text = CambiarIdioma.TraducirGlobal(BtnEditarDetalle.Tag.ToString()) ?? BtnEditarDetalle.Tag.ToString();
            groupBox2.Text = CambiarIdioma.TraducirGlobal(groupBox2.Tag.ToString()) ?? groupBox2.Tag.ToString();
            LblArticulo.Text = CambiarIdioma.TraducirGlobal(LblArticulo.Tag.ToString()) ?? LblArticulo.Tag.ToString();
            LblPrecioUnitario.Text = CambiarIdioma.TraducirGlobal(LblPrecioUnitario.Tag.ToString()) ?? LblPrecioUnitario.Tag.ToString();
            LblCantidad.Text = CambiarIdioma.TraducirGlobal(LblCantidad.Tag.ToString()) ?? LblCantidad.Tag.ToString();
            BtnAltaDetalle.Text = CambiarIdioma.TraducirGlobal(BtnAltaDetalle.Tag.ToString()) ?? BtnAltaDetalle.Tag.ToString();
            BtnModificarDetalle.Text = CambiarIdioma.TraducirGlobal(BtnModificarDetalle.Tag.ToString()) ?? BtnModificarDetalle.Tag.ToString();
            BtnBajaDetalle.Text = CambiarIdioma.TraducirGlobal(BtnBajaDetalle.Tag.ToString()) ?? BtnBajaDetalle.Tag.ToString();
            BtnCargarNuevoArt.Text = CambiarIdioma.TraducirGlobal(BtnCargarNuevoArt.Tag.ToString()) ?? BtnCargarNuevoArt.Tag.ToString();
            BtnCerrarDetalle.Text = CambiarIdioma.TraducirGlobal(BtnCerrarDetalle.Tag.ToString()) ?? BtnCerrarDetalle.Tag.ToString();
            BtnDeserializar.Text = CambiarIdioma.TraducirGlobal(BtnDeserializar.Tag.ToString()) ?? BtnDeserializar.Tag.ToString();
            this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }
        #endregion


        #region botones

        private void dataGridViewDC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdDetalle = int.Parse(Convert.ToString(dataGridViewDC.Rows[e.RowIndex].Cells["IdDetalle"].Value.ToString()));
                TxtCantidad.Text = int.Parse(Convert.ToString(dataGridViewDC.Rows[e.RowIndex].Cells["Cant"].Value.ToString())).ToString();
                TxtPrecio.Text = Convert.ToString(dataGridViewDC.Rows[e.RowIndex].Cells["PUnit"].Value.ToString());
                CmbCodProducto.Text = Convert.ToString(dataGridViewDC.Rows[e.RowIndex].Cells["CodProd"].Value.ToString());
                CmbNombreArticulo.Text = Convert.ToString(dataGridViewDC.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                TxtPrecio.Text = "";
            }
        }

        private void CmbCUITProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CmbNombreProveedor.Text = GestorProveedor.SeleccionarNombreProveedor(Int64.Parse(CmbCUITProveedor.SelectedItem.ToString()));
            }
            catch (Exception)
            {
                CmbNombreProveedor.Text = "";
            }
        }

        private void CmbNombreProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CmbCUITProveedor.Text = GestorProveedor.SeleccionarCUITProveedor(CmbNombreProveedor.SelectedItem.ToString()).ToString();
            }
            catch (Exception)
            {
                CmbCUITProveedor.Text = "";
            }
        }

        private void CmbCodProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CmbNombreArticulo.Text = GestorArticulo.SeleccionarNombreArt(int.Parse(CmbCodProducto.SelectedItem.ToString()));
                TxtPrecio.Text = GestorArticulo.SeleccionPUnit(int.Parse(CmbCodProducto.SelectedItem.ToString())).ToString();
            }
            catch (Exception)
            {
                TxtPrecio.Text = "";
            }
        }

        private void CmbNombreArticulo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CmbCodProducto.Text = GestorArticulo.SeleccionarCodArticulo(CmbNombreArticulo.SelectedItem.ToString()).ToString();
            }
            catch (Exception)
            {
                TxtPrecio.Text = "";
            }
        }

        private void BtnGenerarCompra_Click(object sender, EventArgs e)
        {
            if (CmbCUITProveedor.Text != "")
            {
                AltaCompra(GestorProveedor.SeleccionarIdProveedor(Int64.Parse(CmbCUITProveedor.Text)), DateTime.Parse(dateTimePickerFecha.Text));
                TxtIdCompra.Text = GestorCompra.TraerIdCompra().ToString();

                BtnCargarDetalle.Enabled = true;
                BtnGenerarCompra.Enabled = false;
                CmbCUITProveedor.Enabled = false;
                CmbNombreProveedor.Enabled = false;
            }
            else
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Debe seleccionar un proveedor") ?? "Debe seleccionar un proveedor");
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
                BtnCargarNuevoArt.Enabled = true;
                BtnCargarDetalle.Enabled = false;
                BtnDeserializar.Enabled = true;
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
                ListarDC();
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                Lblsubtotal.Text = TxtTotal.Text;
                TxtTotal.Text = "";
                BtnAltaDetalle.Enabled = true;
                BtnModificarDetalle.Enabled = true;
                BtnComprar.Enabled = false;
                BtnCargarNuevoArt.Enabled = true;
                BtnBajaDetalle.Enabled = true;
                BtnCerrarDetalle.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnCerrarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (GestorCompra.VerificarExistenciaMonto(int.Parse(TxtIdCompra.Text)) == true)
                {
                    TxtTotal.Text = Lblsubtotal.Text;
                    LimpiarTxt();
                    groupBox2.Enabled = false;
                    groupBox1.Enabled = true;
                    BtnComprar.Enabled = true;
                    BtnEditarDetalle.Enabled = true;
                    BtnGenerarCompra.Visible = false;
                    //dataGridViewDC.DataSource = null;
                    CmbCUITProveedor.Enabled = false;
                    BtnAltaDetalle.Enabled = false;
                    BtnModificarDetalle.Enabled = false;
                    BtnBajaDetalle.Enabled = false;
                    BtnCargarNuevoArt.Enabled = false;
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

        private void BtnCargarNuevoArt_Click(object sender, EventArgs e)
        {
            try
            {
                using (Producto p  = Producto.ObtenerInstancia())
                {
                    p.ShowDialog(this);
                    CargarCombos();
                }
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
                    if (GestorDC.ExisteProducto(int.Parse(TxtIdCompra.Text), GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodProducto.Text))) == true)
                    {
                        GestorDC.UnificarArticulos(int.Parse(TxtIdCompra.Text), GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodProducto.Text)), int.Parse(TxtCantidad.Text));
                        ListarDC();
                    }
                    else
                    {
                        AltaDC(int.Parse(TxtCantidad.Text), 0, GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodProducto.Text)), decimal.Parse(TxtPrecio.Text), int.Parse(TxtIdCompra.Text));
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
                    ModificarDC(IdDetalle, GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodProducto.Text)), decimal.Parse(TxtPrecio.Text), int.Parse(TxtCantidad.Text), 0);
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
                    BajaDC(IdDetalle, GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodProducto.Text)));
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

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = String.Concat(CambiarIdioma.TraducirGlobal("El total es de: $") ?? "El total es de: $", TxtTotal.Text, "\n", CambiarIdioma.TraducirGlobal("¿Confirma el importe?") ?? "¿Confirma el importe?");
                if (MessageBox.Show(msj, CambiarIdioma.TraducirGlobal("Confirmar") ?? "Confirmar", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TxtIdCompra.Text = GestorCompra.TraerIdCompra().ToString();
                    GestorCompra.Comprar(int.Parse(TxtIdCompra.Text));
                    folderBrowserDialog1.ShowDialog();
                    string ruta = folderBrowserDialog1.SelectedPath;
                    GestorPedido.ReduccionPedido(int.Parse(TxtIdCompra.Text));
                    PDF(ruta, int.Parse(TxtIdCompra.Text), CmbNombreProveedor.Text, DateTime.Now.ToShortDateString(), decimal.Parse(TxtTotal.Text));
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Compra realizada exitosamente.") ?? "Compra realizada exitosamente.");
                    Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Compra Realizada", "Baja", 0);
                    dataGridViewDC.DataSource = null;
                    dataGridViewPedido.DataSource = null;
                    BtnEditarDetalle.Enabled = false;
                    BtnComprar.Enabled = false;
                    CmbCUITProveedor.Enabled = true;
                    CmbNombreProveedor.Enabled = true;
                    BtnGenerarCompra.Enabled = true;
                    CmbCUITProveedor.SelectedIndex = -1;
                    CmbNombreProveedor.SelectedIndex = -1;
                    CmbNombreProveedor.Text = "";
                    Lblsubtotal.Text = "";
                    TxtIdCompra.Text = "";
                    TxtTotal.Text = "";
                    BtnGenerarCompra.Visible = true;
                    BtnGenerarCompra.Enabled = true;


                }
                else
                {
                    Lblsubtotal.Text = TxtTotal.Text;
                    ListarDC();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void Compra_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (TxtIdCompra.Text != "")
                    {
                        if (MessageBox.Show(CambiarIdioma.TraducirGlobal("Se esta por cerrar el formulario. Si posee una compra en progreso se cancelara ¿Desea continuar?") ?? "Se esta por cerrar el formulario. Si posee una compra en progreso se cancelara ¿Desea continuar?", CambiarIdioma.TraducirGlobal("Confirmar") ?? "Confirmar", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            MessageBox.Show(CambiarIdioma.TraducirGlobal(GestorCompra.CancelarCompra(int.Parse(TxtIdCompra.Text))) ?? GestorCompra.CancelarCompra(int.Parse(TxtIdCompra.Text)));
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

        #endregion

        private void BtnDeserializar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPedido.DataSource = null;
                OpenFileDialog thisDialog = new OpenFileDialog();
                string Ruta = "";
                thisDialog.Filter = "All Files |*.xml";
                thisDialog.FilterIndex = 1;

                if (thisDialog.ShowDialog() == DialogResult.OK)
                {
                    Ruta = thisDialog.FileName;
                }
                dataGridViewPedido.DataSource = GestorPedido.DeserializarPedido(Ruta);
                dataGridViewPedido.Columns["IdPedido"].Visible = false;
                dataGridViewPedido.Columns["IdArticulo"].Visible = false;
                dataGridViewPedido.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void dataGridViewPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtCantSugerida.Text = int.Parse(Convert.ToString(dataGridViewPedido.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString())).ToString();
                CmbCodProducto.Text = Convert.ToString(dataGridViewPedido.Rows[e.RowIndex].Cells["CodProd"].Value.ToString());
                groupBox2.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                TxtPrecio.Text = "";
            }
        }
    }
}
