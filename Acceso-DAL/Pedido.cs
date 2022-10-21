using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class Pedido
    {
        Acceso_BD Acceso = new Acceso_BD();

        public List<Propiedades_BE.Pedido> Listar()
        {
            List<Propiedades_BE.Pedido> ListarPedido = new List<Propiedades_BE.Pedido>();
            DataTable Tabla = Acceso.Leer("ListarPedido", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Pedido P = new Propiedades_BE.Pedido();
                P.IdPedido = int.Parse(R["IdPedido"].ToString());
                P.CodProd = int.Parse(R["CodProd"].ToString());
                P.NombreProd = R["Descripcion"].ToString();
                P.Cantidad = int.Parse(R["Cantidad"].ToString());
                ListarPedido.Add(P);
            }
            return ListarPedido;
        }

        public int Alta(Propiedades_BE.Pedido P)
        {
            int fa = 0;
            SqlParameter[] Pa = new SqlParameter[2];
            Pa[0] = new SqlParameter("@IdArticulo", P.IdArticulo);
            Pa[1] = new SqlParameter("@Cantidad", P.Cantidad);
            fa = Acceso.Escribir("AltaPedido", Pa);
            return fa;
        }

        public int Modificar(Propiedades_BE.Pedido P)
        {
            int fa = 0;
            SqlParameter[] Pa = new SqlParameter[2];
            Pa[0] = new SqlParameter("@IdArticulo", P.IdArticulo);
            Pa[1] = new SqlParameter("@Cantidad", P.Cantidad);
            fa = Acceso.Escribir("ModificarPedido", Pa);
            return fa;
        }

        public int Baja(Propiedades_BE.Pedido P)
        {
            int fa = 0;
            SqlParameter[] Pa = new SqlParameter[1];
            Pa[0] = new SqlParameter("@IdArticulo", P.IdArticulo);
            fa = Acceso.Escribir("BajaPedido", Pa);
            return fa;
        }

        public void ReduccionPedido(int IdCompra)
        {
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                Dictionary<int, int> ListaProd = new Dictionary<int, int>();
                string Query = "select IdArticulo,Cant from Detalle_Compra where IdCompra = " + IdCompra + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            ListaProd.Add(Lector.GetInt32(0), Lector.GetInt32(1));
                        }
                    }
                }
                Acceso.CerrarConexion();

                foreach (var CodProd in ListaProd)
                {
                    Acceso.AbrirConexion();
                    string QueryCant = "if (" + CodProd.Value + " >= (select Cantidad from Pedido WHERE IdArticulo = " + CodProd.Key + ")) begin UPDATE Pedido set Cantidad = 0 where IdArticulo = " + CodProd.Key + " end else if (" + CodProd.Value + " <= (select Cantidad from Pedido WHERE IdArticulo = " + CodProd.Key + ")) begin update Pedido set Cantidad = Cantidad - " + CodProd.Value + " where IdArticulo = " + CodProd.Key + " end;";
                    using (SqlCommand Command = new SqlCommand(QueryCant, Acceso.Conexion))
                    {
                        Command.ExecuteNonQuery();
                    }
                    Acceso.CerrarConexion();
                }

                Acceso.EjecutarConsulta("Delete from Pedido where Cantidad = 0");
            }
        }
    }
}
