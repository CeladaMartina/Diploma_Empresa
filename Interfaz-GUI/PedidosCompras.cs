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
using System.Windows.Forms;

namespace Interfaz_GUI
{
    public partial class PedidosCompras : Form, IObserver

    {
        Negocio_BLL.Pedido GestorPedido = new Negocio_BLL.Pedido();
        Negocio_BLL.Seguridad Seguridad = new Negocio_BLL.Seguridad();
        Negocio_BLL.Producto GestorArticulo = new Negocio_BLL.Producto();
        public PedidosCompras()
        {
            InitializeComponent();
        }

        private static PedidosCompras _instancia;
        public static PedidosCompras ObtenerInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new PedidosCompras();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private void PedidosCompras_Load(object sender, EventArgs e)
        {
            Traducir();
            CargarCombos();
            Listar();
        }

        #region metodos
        void CargarCombos()
        {
            CmbCodProducto.Items.Clear();
            CmbNombreArticulo.Items.Clear();
            foreach (var CodProd in GestorArticulo.CodProdArticulo())
            {
                CmbCodProducto.Items.Add(CodProd);
            }
            foreach (var Descripcion in GestorArticulo.DescripcionProd())
            {
                CmbNombreArticulo.Items.Add(Descripcion);
            }
        }

        void Listar()
        {
            dataGridViewPedido.DataSource = null;
            dataGridViewPedido.DataSource = GestorPedido.Listar();
            dataGridViewPedido.Columns["IdPedido"].Visible = false;
            dataGridViewPedido.Columns["IdArticulo"].Visible = false;
            dataGridViewPedido.ReadOnly = true;
        }

        void Alta(int IdArticulo, int Cantidad)
        {
            GestorPedido.Alta(IdArticulo, Cantidad);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Alta Pedido", "Baja",0);
            Listar();
            LimpiarTxt();
        }

        void Modificar(int IdArticulo, int Cantidad)
        {
            GestorPedido.Modificar(IdArticulo, Cantidad);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Modificar Peiddo", "Baja",0);
            Listar();
            LimpiarTxt();
        }

        void Baja(int IdArticulo)
        {
            GestorPedido.Baja(IdArticulo);
            Seguridad.CargarBitacora(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now, "Baja Pedido", "Baja",0);
            Listar();
            LimpiarTxt();
        }

        void LimpiarTxt()
        {
            CmbCodProducto.ResetText();
            CmbNombreArticulo.ResetText();
            TxtCantidad.Text = "";
        }

        bool ChequearFallaTxt()
        {
            bool A = false;
            if (string.IsNullOrEmpty(TxtCantidad.Text) || string.IsNullOrEmpty(CmbNombreArticulo.Text)
                || string.IsNullOrEmpty(CmbCodProducto.Text))
            {
                A = true;
            }
            else if (int.Parse(TxtCantidad.Text) < 1)
            {
                A = true;
            }
            return A;
        }

        void DeserializarPedido()
        {
            OpenFileDialog thisDialog = new OpenFileDialog();
            string Ruta = "";
            thisDialog.Filter = "All Files |*.xml";
            thisDialog.FilterIndex = 1;

            if (thisDialog.ShowDialog() == DialogResult.OK)
            {
                Ruta = thisDialog.FileName;
            }

            dataGridViewPedido.DataSource = null;
            dataGridViewPedido.DataSource = GestorPedido.DeserializarPedido(Ruta);
            dataGridViewPedido.Columns["IdPedido"].Visible = false;
            dataGridViewPedido.Columns["IdArticulo"].Visible = false;
            dataGridViewPedido.ReadOnly = true;
            MessageBox.Show("Deserializadion realizada correctamemte");
        }

        void PDF(int IdUsuario, string Fecha, string ruta)
        {
            Directory.CreateDirectory(ruta);
            DirectorySecurity sec = Directory.GetAccessControl(ruta);

            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            Directory.SetAccessControl(ruta, sec);

            string fecha_final = Fecha.Replace("/", "-");

            string ruta_final = "" + ruta + "\\Pedido_" + fecha_final + "_" + IdUsuario + ".pdf";

            System.IO.FileStream fs = new FileStream(ruta_final, FileMode.Create);

            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40f, 40f, 40f, 40f);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            BaseFont Fuente1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, true);
            iTextSharp.text.Font Titulo = new iTextSharp.text.Font(Fuente1, 20f, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            BaseFont Fuente2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, true);
            iTextSharp.text.Font TablasTitulo = new iTextSharp.text.Font(Fuente2, 14f, iTextSharp.text.Font.ITALIC, BaseColor.BLACK);

            BaseFont Fuente3 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, true);
            iTextSharp.text.Font TablasTexto = new iTextSharp.text.Font(Fuente3, 12f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //string imagepath = Directory.GetCurrentDirectory() + "\\Imagenes\\LogoTP.png";
            //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imagepath);
            //logo.Alignment = Element.ALIGN_CENTER;
            //logo.ScalePercent(50);
            //doc.Add(logo);

            Paragraph Pedido = new Paragraph("Pedido", Titulo);
            Pedido.Alignment = Element.ALIGN_CENTER;
            doc.Add(Pedido);
            doc.Add(new Chunk("\n"));

            Paragraph FechaP = new Paragraph("Fecha: " + Fecha + "");
            FechaP.Alignment = Element.ALIGN_LEFT;
            doc.Add(FechaP);
            doc.Add(new Chunk("\n"));

            PdfPTable table = new PdfPTable(3);
            table.AddCell(new PdfPCell(new Phrase("Codigo Producto", TablasTitulo)) { HorizontalAlignment = Element.ALIGN_CENTER });
            table.AddCell(new PdfPCell(new Phrase("Descripcion", TablasTitulo)) { HorizontalAlignment = Element.ALIGN_CENTER });
            table.AddCell(new PdfPCell(new Phrase("Cantidad", TablasTitulo)) { HorizontalAlignment = Element.ALIGN_CENTER });

            table.SpacingBefore = 10;
            foreach (DataGridViewRow row in dataGridViewPedido.Rows)
            {
                try
                {
                    int CodProd = int.Parse(row.Cells["CodProd"].Value.ToString());
                    string Descripcion = Convert.ToString(row.Cells["NombreProd"].Value.ToString());
                    int Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());

                    table.AddCell(new PdfPCell(new Phrase(CodProd.ToString(), TablasTexto)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
                    table.AddCell(new PdfPCell(new Phrase(Descripcion, TablasTexto)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
                    table.AddCell(new PdfPCell(new Phrase(Cantidad.ToString(), TablasTexto)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE });
                }
                catch (Exception)
                {
                    MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
                }
            }
            doc.Add(table);
            doc.Close();
            writer.Close();
            MessageBox.Show("PDF guardado");
        }
        #endregion

        #region botones

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChequearFallaTxt() == false)
                {
                    Alta(GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodProducto.Text)), int.Parse(TxtCantidad.Text));
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChequearFallaTxt() == false)
                {
                    Modificar(GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodProducto.Text)), int.Parse(TxtCantidad.Text));
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

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            if (ChequearFallaTxt() == false)
            {
                try
                {
                    Baja(GestorArticulo.SeleccionarIdArticulo(int.Parse(CmbCodProducto.Text)));
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

        private void BtnCerrarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowDialog();
                string Ruta = folderBrowserDialog1.SelectedPath;
                GestorPedido.SerializarPedido(Ruta, dataGridViewPedido);
                MessageBox.Show("Serializadion realizada correctamemte");
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void btnPedidosViejos_Click(object sender, EventArgs e)
        {
            try
            {
                DeserializarPedido();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string ruta = folderBrowserDialog1.SelectedPath;
            PDF(Propiedades_BE.SingletonLogIn.GlobalIdUsuario, DateTime.Now.ToShortDateString(), ruta);
        }


        #endregion

        #region combos

        private void CmbCodProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            CmbNombreArticulo.Text = GestorArticulo.SeleccionarNombreArt(int.Parse(CmbCodProducto.SelectedItem.ToString()));
        }

        private void CmbNombreArticulo_SelectedValueChanged(object sender, EventArgs e)
        {
            CmbCodProducto.Text = GestorArticulo.SeleccionarCodArticulo(CmbNombreArticulo.SelectedItem.ToString()).ToString();
        }

        private void dataGridViewPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CmbCodProducto.Text = Convert.ToString(dataGridViewPedido.Rows[e.RowIndex].Cells["CodProd"].Value.ToString());
                TxtCantidad.Text = int.Parse(Convert.ToString(dataGridViewPedido.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString())).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(CambiarIdioma.TraducirGlobal("Error") ?? "Error");
            }
        }

        #endregion

        #region traduccion
        void IObserver.Update(ISubject Subject)
        {
            
            LblArticulo.Text = Subject.TraducirObserver(LblArticulo.Tag.ToString()) ?? LblArticulo.Tag.ToString();            
            LblCantidad.Text = Subject.TraducirObserver(LblCantidad.Tag.ToString()) ?? LblCantidad.Tag.ToString();
            BtnAlta.Text = Subject.TraducirObserver(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnModificar.Text = Subject.TraducirObserver(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            BtnBaja.Text = Subject.TraducirObserver(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnCerrarPedido.Text = Subject.TraducirObserver(BtnCerrarPedido.Tag.ToString()) ?? BtnCerrarPedido.Tag.ToString();
            btnPedidosViejos.Text = Subject.TraducirObserver(btnPedidosViejos.Tag.ToString()) ?? btnPedidosViejos.Tag.ToString();
            BtnImprimir.Text = Subject.TraducirObserver(BtnImprimir.Tag.ToString()) ?? BtnImprimir.Tag.ToString();
            this.Text = Subject.TraducirObserver(this.Tag.ToString()) ?? this.Tag.ToString();
        }

        public void Traducir()
        {
            LblArticulo.Text = CambiarIdioma.TraducirGlobal(LblArticulo.Tag.ToString()) ?? LblArticulo.Tag.ToString();
            LblCantidad.Text = CambiarIdioma.TraducirGlobal(LblCantidad.Tag.ToString()) ?? LblCantidad.Tag.ToString();
            BtnAlta.Text = CambiarIdioma.TraducirGlobal(BtnAlta.Tag.ToString()) ?? BtnAlta.Tag.ToString();
            BtnModificar.Text = CambiarIdioma.TraducirGlobal(BtnModificar.Tag.ToString()) ?? BtnModificar.Tag.ToString();
            BtnBaja.Text = CambiarIdioma.TraducirGlobal(BtnBaja.Tag.ToString()) ?? BtnBaja.Tag.ToString();
            BtnCerrarPedido.Text = CambiarIdioma.TraducirGlobal(BtnCerrarPedido.Tag.ToString()) ?? BtnCerrarPedido.Tag.ToString();
            btnPedidosViejos.Text = CambiarIdioma.TraducirGlobal(btnPedidosViejos.Tag.ToString()) ?? btnPedidosViejos.Tag.ToString();
            BtnImprimir.Text = CambiarIdioma.TraducirGlobal(BtnImprimir.Tag.ToString()) ?? BtnImprimir.Tag.ToString();
            this.Text = CambiarIdioma.TraducirGlobal(this.Tag.ToString()) ?? this.Tag.ToString();
        }
        #endregion
    }
}
