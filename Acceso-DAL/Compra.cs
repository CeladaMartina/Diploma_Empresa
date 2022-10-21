using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class Compra
    {
        Acceso_BD Acceso = new Acceso_BD();
        Seguridad Seguridad = new Seguridad();

        #region list 
        public List<Propiedades_BE.Compra> Listar()
        {
            List<Propiedades_BE.Compra> ListaCompra = new List<Propiedades_BE.Compra>();
            DataTable Tabla = Acceso.Leer("ListarCompra", null);
            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Compra C = new Propiedades_BE.Compra();
                C.NumCompra = int.Parse(R["NumCompra"].ToString());
                C.CUIT = Seguridad.Desencriptar(R["CUIT"].ToString());
                C.Fecha = DateTime.Parse(R["Fecha"].ToString());
                C.Monto = decimal.Parse(R["Monto"].ToString());
                ListaCompra.Add(C);
            }
            return ListaCompra;
        }

        //public List<Propiedades_BE.Compra> FiltrarMontoCompra(decimal _MontoDesde, decimal _MontoHasta)
        //{
        //    List<Propiedades_BE.Compra> ListaCompra = new List<Propiedades_BE.Compra>();

        //    Acceso.AbrirConexion();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select C.IdCompra as 'NumCompra', P.CUIT, C.Fecha, (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) as 'Monto' from Compra C inner join Proveedor P on C.IdProveedor = P.IdProveedor where (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) >= " + _MontoDesde + " and (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) <= " + _MontoHasta + "";
        //    cmd.Connection = Acceso.Conexion;

        //    SqlDataReader lector = cmd.ExecuteReader();

        //    while (lector.Read())
        //    {
        //        Propiedades_BE.Compra C = new Propiedades_BE.Compra();
        //        C.NumCompra = int.Parse(lector["NumCompra"].ToString());
        //        C.CUIT = Seguridad.Desencriptar(lector["CUIT"].ToString());
        //        C.Fecha = DateTime.Parse(lector["Fecha"].ToString());
        //        C.Monto = decimal.Parse(lector["Monto"].ToString());
        //        ListaCompra.Add(C);
        //    }
        //    lector.Close();
        //    Acceso.CerrarConexion();
        //    return ListaCompra;
        //}

        //public List<Propiedades_BE.Compra> FiltrarRangoFechaCompra(DateTime _FechaDesde, DateTime _FechaHasta)
        //{
        //    List<Propiedades_BE.Compra> ListaCompra = new List<Propiedades_BE.Compra>();

        //    Acceso.AbrirConexion();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select C.IdCompra as 'NumCompra', P.CUIT, C.Fecha, (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) as 'Monto' from Compra C inner join Proveedor P on C.IdProveedor = P.IdProveedor where convert(date,Fecha) >= '" + _FechaDesde + "' and convert(date,Fecha) <= '" + _FechaHasta + "'";
        //    cmd.Connection = Acceso.Conexion;

        //    SqlDataReader lector = cmd.ExecuteReader();

        //    while (lector.Read())
        //    {
        //        Propiedades_BE.Compra C = new Propiedades_BE.Compra();
        //        C.NumCompra = int.Parse(lector["NumCompra"].ToString());
        //        C.CUIT = Seguridad.Desencriptar(lector["CUIT"].ToString());
        //        C.Fecha = DateTime.Parse(lector["Fecha"].ToString());
        //        C.Monto = decimal.Parse(lector["Monto"].ToString());
        //        ListaCompra.Add(C);
        //    }
        //    lector.Close();
        //    Acceso.CerrarConexion();
        //    return ListaCompra;
        //}

        //public List<Propiedades_BE.Compra> FiltrarCUITCompra(string _CUIT)
        //{
        //    List<Propiedades_BE.Compra> ListaCompra = new List<Propiedades_BE.Compra>();
        //    Acceso.AbrirConexion();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select C.IdCompra as 'NumCompra', P.CUIT, C.Fecha, (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) as 'Monto' from Compra C inner join Proveedor P on C.IdProveedor = P.IdProveedor where CUIT = '" + Seguridad.EncriptarAES(_CUIT) + "'";
        //    cmd.Connection = Acceso.Conexion;

        //    SqlDataReader lector = cmd.ExecuteReader();

        //    while (lector.Read())
        //    {
        //        Propiedades_BE.Compra C = new Propiedades_BE.Compra();
        //        C.NumCompra = int.Parse(lector["NumCompra"].ToString());
        //        C.CUIT = Seguridad.Desencriptar(lector["CUIT"].ToString());
        //        C.Fecha = DateTime.Parse(lector["Fecha"].ToString());
        //        C.Monto = decimal.Parse(lector["Monto"].ToString());
        //        ListaCompra.Add(C);
        //    }
        //    lector.Close();
        //    Acceso.CerrarConexion();
        //    return ListaCompra;
        //}

        public List<Propiedades_BE.Compra> FiltradoCompleto(decimal _MontoDesde, decimal _MontoHasta, DateTime _FechaDesde, DateTime _FechaHasta, string _CUIT)
        {
            List<Propiedades_BE.Compra> ListaCompra = new List<Propiedades_BE.Compra>();
            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select C.IdCompra as 'NumCompra', P.CUIT, C.Fecha, (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) as 'Monto' from Compra C inner join Proveedor P on C.IdProveedor = P.IdProveedor where (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) >= " + _MontoDesde + " and (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Compra where IdCompra = C.IdCompra) <= " + _MontoHasta + " and convert(date,Fecha) >= '" + _FechaDesde + "' and convert(date,Fecha) <= '" + _FechaHasta + "' and CUIT = '" + Seguridad.EncriptarAES(_CUIT) + "'";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Compra C = new Propiedades_BE.Compra();
                C.NumCompra = int.Parse(lector["NumCompra"].ToString());
                C.CUIT = Seguridad.Desencriptar(lector["CUIT"].ToString());
                C.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                C.Monto = decimal.Parse(lector["Monto"].ToString());
                ListaCompra.Add(C);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return ListaCompra;
        }
        #endregion


        public int Alta(Propiedades_BE.Compra Compra)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[2];
            P[0] = new SqlParameter("@IdProveedor", Compra.IdProveedor);
            P[1] = new SqlParameter("@Fecha", Compra.Fecha);
            fa = Acceso.Escribir("AltaCompra", P);
            return fa;
        }

        public void Comprar(int IdCompra)
        {
            List<Propiedades_BE.Detalle_Compra> ListaDC = new List<Propiedades_BE.Detalle_Compra>();
            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select IdArticulo,Cant from Detalle_Compra where IdCompra = " + IdCompra + " ";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Detalle_Compra DC = new Propiedades_BE.Detalle_Compra();
                DC.IdArticulo = int.Parse(lector["IdArticulo"].ToString());
                DC.Cant = int.Parse(lector["Cant"].ToString());
                ListaDC.Add(DC);
            }
            lector.Close();
            Acceso.CerrarConexion();
            foreach (var item in ListaDC)
            {
                Acceso.EjecutarConsulta("update Articulo set Stock = (Stock + " + item.Cant + ") where IdArticulo = " + item.IdArticulo + "");
            }
        }

        public string CancelarCompra(int IdCompra)
        {
            string Mensaje = "";
            try
            {
                Acceso.EjecutarConsulta("Delete from Detalle_Compra where IdCompra= " + IdCompra + "");
                Acceso.EjecutarConsulta("Delete from Compra where IdCompra= " + IdCompra + "");
                Seguridad.ActualizarDVV("Detalle_Compra", Seguridad.SumaDVV("Detalle_Compra"));
                Mensaje = "Se ha cancelado la Compra";
            }

            catch (Exception)
            {
                Mensaje = "La Compra no se cancelo";
            }
            return Mensaje;
        }

        public int TraerIdCompra()
        {
            int ID = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select TOP 1 IdCompra from Compra ORDER BY IdCompra DESC";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            ID = Lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return ID;
        }

        public bool VerificarExistenciaMonto(int IdCompra)
        {
            bool i = false;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select * from Detalle_Compra where IdCompra = " + IdCompra + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        if (Lector.Read())
                        {
                            i = true;
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return i;
        }
    }
}
