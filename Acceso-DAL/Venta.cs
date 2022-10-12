using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class Venta
    {
        Acceso_BD Acceso = new Acceso_BD();
        Seguridad Seguridad = new Seguridad();

        #region list
        public List<Propiedades_BE.Venta> Listar()
        {
            List<Propiedades_BE.Venta> ListaVenta = new List<Propiedades_BE.Venta>();
            DataTable Tabla = Acceso.Leer("ListarVenta", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Venta V = new Propiedades_BE.Venta();
                V.NumVenta = int.Parse(R["NumVenta"].ToString());
                V.DNICliente = Seguridad.Desencriptar(R["DNIcliente"].ToString());
                V.Fecha = DateTime.Parse(R["Fecha"].ToString());
                V.Monto = decimal.Parse(R["Monto"].ToString());
                ListaVenta.Add(V);
            }
            return ListaVenta;
        }

        public List<Propiedades_BE.Venta> FiltrarMontoVenta(decimal _MontoDesde, decimal _MontoHasta)
        {
            List<Propiedades_BE.Venta> ListaVenta = new List<Propiedades_BE.Venta>();

            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select V.IdVenta as 'NumVenta', C.DNI as 'DNICliente', V.Fecha, (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Venta where IdVenta = V.IdVenta) as 'Monto' from Venta V inner join Cliente C on V.IdCliente = C.IdCliente where (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Venta where IdVenta = V.IdVenta) >= " + _MontoDesde + " and (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Venta where IdVenta = V.IdVenta) <= " + _MontoHasta + "";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Venta V = new Propiedades_BE.Venta();
                V.NumVenta = int.Parse(lector["NumVenta"].ToString());
                V.DNICliente = Seguridad.Desencriptar(lector["DNICliente"].ToString());
                V.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                V.Monto = decimal.Parse(lector["Monto"].ToString());
                ListaVenta.Add(V);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return ListaVenta;
        }

        public List<Propiedades_BE.Venta> FiltrarRangoFechaVenta(DateTime _FechaDesde, DateTime _FechaHasta)
        {
            List<Propiedades_BE.Venta> ListaVenta = new List<Propiedades_BE.Venta>();

            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select V.IdVenta as 'NumVenta', C.DNI as 'DNICliente', V.Fecha, (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Venta where IdVenta = V.IdVenta) as 'Monto' from Venta V inner join Cliente C on V.IdCliente = C.IdCliente where convert(date,Fecha) >= '" + _FechaDesde + "' and convert(date,Fecha) <= '" + _FechaHasta + "'";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Venta V = new Propiedades_BE.Venta();
                V.NumVenta = int.Parse(lector["NumVenta"].ToString());
                V.DNICliente = Seguridad.Desencriptar(lector["DNICliente"].ToString());
                V.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                V.Monto = decimal.Parse(lector["Monto"].ToString());
                ListaVenta.Add(V);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return ListaVenta;
        }

        public List<Propiedades_BE.Venta> FiltrarDNIVenta(string _DNI)
        {
            List<Propiedades_BE.Venta> ListaVenta = new List<Propiedades_BE.Venta>();
            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select V.IdVenta as 'NumVenta', C.DNI as 'DNICliente', V.Fecha, (select ISNULL(SUM(Cant * PUnit),0) from Detalle_Venta where IdVenta = V.IdVenta) as 'Monto' from Venta V inner join Cliente C on V.IdCliente = C.IdCliente where DNI = '" + Seguridad.EncriptarAES(_DNI) + "'";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Venta V = new Propiedades_BE.Venta();
                V.NumVenta = int.Parse(lector["NumVenta"].ToString());
                V.DNICliente = Seguridad.Desencriptar(lector["DNICliente"].ToString());
                V.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                V.Monto = decimal.Parse(lector["Monto"].ToString());
                ListaVenta.Add(V);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return ListaVenta;
        }
        #endregion

        public bool VerificarExistenciaMonto(int IdVenta)
        {
            bool i = false;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select * from Detalle_Venta where IdVenta = " + IdVenta + "";
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

        public int TraerIdVenta()
        {
            int Id = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string QueryIdLast = "select TOP 1 IdVenta from Venta ORDER BY IdVenta DESC";
                using (SqlCommand Cmd = new SqlCommand(QueryIdLast, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Id = Lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Id;
        }

        public int Alta(Propiedades_BE.Venta Venta)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[2];
            P[0] = new SqlParameter("@IdCliente", Venta.IdCliente);
            P[1] = new SqlParameter("@Fecha", Venta.Fecha);
            fa = Acceso.Escribir("AltaVenta", P);
            return fa;
        }
        public string CancelarVenta(int IdVenta)
        {
            string Mensaje = "";
            try
            {
                Acceso.EjecutarConsulta("Delete from Detalle_Venta where IdVenta= " + IdVenta + "");
                Acceso.EjecutarConsulta("Delete from Venta where IdVenta= " + IdVenta + "");
                Seguridad.ActualizarDVV("Detalle_Venta", Seguridad.SumaDVV("Detalle_Venta"));
                Mensaje = "Se ha cancelado la venta";
            }

            catch (Exception)
            {
                Mensaje = "La venta no se cancelo";
            }
            return Mensaje;
        }

        public void Vender(int IdVenta)
        {
            List<Propiedades_BE.Detalle_Venta> ListaDV = new List<Propiedades_BE.Detalle_Venta>();
            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select IdArticulo,Cant from Detalle_Venta where IdVenta = " + IdVenta + " ";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Detalle_Venta DV = new Propiedades_BE.Detalle_Venta();
                DV.IdArticulo = int.Parse(lector["IdArticulo"].ToString());
                DV.Cant = int.Parse(lector["Cant"].ToString());
                ListaDV.Add(DV);
            }
            lector.Close();
            Acceso.CerrarConexion();
            foreach (var item in ListaDV)
            {
                Acceso.EjecutarConsulta("update Articulo set Stock = (Stock - " + item.Cant + ") where IdArticulo = " + item.IdArticulo + "");
            }
        }
    }
}
