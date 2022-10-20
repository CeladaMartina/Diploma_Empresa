using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class Detalle_Compra
    {
        Acceso_BD Acceso = new Acceso_BD();
        Seguridad Seguridad = new Seguridad();

        public List<Propiedades_BE.Detalle_Compra> ListarDC(Propiedades_BE.Detalle_Compra DetalleCompra)
        {
            List<Propiedades_BE.Detalle_Compra> ListarDetalle = new List<Propiedades_BE.Detalle_Compra>();
            SqlParameter[] P = new SqlParameter[1];
            P[0] = new SqlParameter("@IdCompra", DetalleCompra.IdCompra);

            DataTable Tabla = Acceso.Leer("ListarDCParametros", P);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Detalle_Compra DC = new Propiedades_BE.Detalle_Compra();
                DC.IdDetalle = int.Parse(R["IdDetalle"].ToString());
                DC.CodProd = int.Parse(R["CodProd"].ToString());
                DC.Descripcion = R["Descripcion"].ToString();
                DC.PUnit = decimal.Parse(R["PUnit"].ToString());
                DC.Cant = int.Parse(R["Cant"].ToString());
                ListarDetalle.Add(DC);
            }
            return ListarDetalle;
        }

        public int AltaDC(Propiedades_BE.Detalle_Compra DC)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[5];
            P[0] = new SqlParameter("@IdCompra", DC.IdCompra);
            P[1] = new SqlParameter("@IdArticulo", DC.IdArticulo);
            P[2] = new SqlParameter("@Cant", DC.Cant);
            P[3] = new SqlParameter("@PUnit", DC.PUnit);
            P[4] = new SqlParameter("@DVH", DC.DVH);
            fa = Acceso.Escribir("AltaDetalleCompra", P);
            return fa;
        }

        public int BajaDC(Propiedades_BE.Detalle_Compra DC)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[1];
            P[0] = new SqlParameter("@IdDetalle", DC.IdDetalle);
            fa = Acceso.Escribir("BajaDetalleCompra", P);
            return fa;
        }

        public int ModificarDC(Propiedades_BE.Detalle_Compra DC)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[5];
            P[0] = new SqlParameter("@IdDetalle", DC.IdDetalle);
            P[1] = new SqlParameter("@IdArticulo", DC.IdArticulo);
            P[2] = new SqlParameter("@Cant", DC.Cant);
            P[3] = new SqlParameter("@PUnit", DC.PUnit);
            P[4] = new SqlParameter("@DVH", DC.DVH);
            fa = Acceso.Escribir("ModificarDetalleCompra", P);
            return fa;
        }

        public decimal SubTotal(int IdCompra)
        {
            decimal SubTOT = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = " + IdCompra + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            SubTOT = Lector.GetDecimal(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return SubTOT;
        }

        public bool ExisteProducto(int IdCompra, int IdArticulo)
        {
            bool a = false;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select * from Detalle_Compra where IdCompra = " + IdCompra + " and IdArticulo = " + IdArticulo + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        if (Lector.Read())
                        {
                            a = true;
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return a;
        }

        public void UnificarArticulos(int IdCompra, int IdArticulo, int Cantidad)
        {
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "update Detalle_Compra set Cant = " + Cantidad + " + Cant where IdCompra = " + IdCompra + " and IdArticulo = " + IdArticulo + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    Cmd.ExecuteNonQuery();
                }
                Acceso.CerrarConexion();
            }
        }

        public string VerificarIntegridadDC(int GlobalIdUsuario)
        {
            long Suma = 0;
            long DVH = 0;
            string msj = "";
            string msj2 = "";

            List<int> CamposFallidos = new List<int>();
            List<Propiedades_BE.Detalle_Compra> DetalleC = ListaVerificacion();

            foreach (Propiedades_BE.Detalle_Compra DC in DetalleC.ToList())
            {
                string IdCompra = DC.IdCompra.ToString();
                string IdDetalle = DC.IdDetalle.ToString();
                string IdArticulo = DC.IdArticulo.ToString();
                string Cant = DC.Cant.ToString();
                string punit = DC.PUnit.ToString();
                string dvh = DC.DVH.ToString();

                long IdCompraDC = Seguridad.ObtenerAscii(IdCompra);
                long IdDetalleDC = Seguridad.ObtenerAscii(IdDetalle);
                long IdArticuloDC = Seguridad.ObtenerAscii(IdArticulo);
                long CantDC = Seguridad.ObtenerAscii(Cant);
                long pu = Seguridad.ObtenerAscii(punit);
                long dvhDC = long.Parse(dvh);

                Suma = IdCompraDC + IdDetalleDC + IdArticuloDC + CantDC + pu;
                DVH += Suma;

                if (dvhDC == Suma)
                {
                    DetalleC.Remove(DC);
                }
            }
            if (DVH != Seguridad.VerificacionDVV("Detalle_Compra"))
            {
                msj += "Se encontro un error en la tabla Detalle Compra \n";
                Seguridad.CargarBitacora(GlobalIdUsuario, DateTime.Now, "Error en la tabla Det_Com", "Alta", 0);

                if (DVH < Seguridad.VerificacionDVV("Detalle_Compra"))
                {
                    msj += "Posibilidad de eliminacion de 1 o mas registros de Detalle de Compra \n";
                    Seguridad.CargarBitacora(GlobalIdUsuario, DateTime.Now, "Eliminacion registros Det_Com", "Alta", 0);
                }
            }
            foreach (Propiedades_BE.Detalle_Compra MalCampo in DetalleC)
            {
                CamposFallidos.Add(MalCampo.IdDetalle);
            }
            foreach (var item in CamposFallidos)
            {

                msj += "Se encontro un fallo en la fila con Id Detalle: " + item + " \n";
                msj2 = "Error Det_Com IdDet:" + item + "";
                Seguridad.CargarBitacora(GlobalIdUsuario, DateTime.Now, msj2, "Alta", 0);
                msj2 = "";
            }
            return msj;
        }

        public void RecalcularDVH()
        {
            long suma = 0;

            List<Propiedades_BE.Detalle_Compra> DC = ListaVerificacion();
            foreach (Propiedades_BE.Detalle_Compra Det_Com in DC.ToList())
            {
                suma = 0;

                string IdCompra = Det_Com.IdCompra.ToString();
                string IdDetalle = Det_Com.IdDetalle.ToString();
                string IdArticulo = Det_Com.IdArticulo.ToString();
                string Cant = Det_Com.Cant.ToString();
                string punit = Det_Com.PUnit.ToString();
                string dvh = Det_Com.DVH.ToString();

                long IdCompraDC = Seguridad.ObtenerAscii(IdCompra);
                long IdDetalleDC = Seguridad.ObtenerAscii(IdDetalle);
                long IdArticuloDC = Seguridad.ObtenerAscii(IdArticulo);
                long CantDC = Seguridad.ObtenerAscii(Cant);
                long pu = Seguridad.ObtenerAscii(punit);
                long dvhDC = long.Parse(dvh);

                suma = IdCompraDC + IdDetalleDC + IdArticuloDC + CantDC + pu;
                Acceso.EjecutarConsulta("Update Detalle_Compra set DVH = " + suma + " where IdDetalle = " + IdDetalle + "");
            }
        }

        public List<Propiedades_BE.Detalle_Compra> ListaVerificacion()
        {
            List<Propiedades_BE.Detalle_Compra> Lista = new List<Propiedades_BE.Detalle_Compra>();
            DataTable Tabla = Acceso.Leer("ListarCompraVerificacion", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Detalle_Compra DC = new Propiedades_BE.Detalle_Compra();
                DC.IdCompra = int.Parse(R["IdCompra"].ToString());
                DC.IdDetalle = int.Parse(R["IdDetalle"].ToString());
                DC.IdArticulo = int.Parse(R["IdArticulo"].ToString());
                DC.PUnit = decimal.Parse(R["PUnit"].ToString());
                DC.Cant = int.Parse(R["Cant"].ToString());
                DC.DVH = int.Parse(R["DVH"].ToString());
                Lista.Add(DC);
            }
            return Lista;
        }

    }
}
