using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class Proveedor
    {
        Acceso_BD Acceso = new Acceso_BD();
        Seguridad Seguridad = new Seguridad();

        public List<Propiedades_BE.Proveedor> Listar()
        {
            List<Propiedades_BE.Proveedor> ListarProveedor = new List<Propiedades_BE.Proveedor>();
            DataTable Tabla = Acceso.Leer("ListarProveedor", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Proveedor P = new Propiedades_BE.Proveedor();
                P.IdProveedor = int.Parse(R["IdProveedor"].ToString());
                P.CUIT = Seguridad.Desencriptar(R["CUIT"].ToString());
                P.Nombre = R["Nombre"].ToString();
                P.Apellido = R["Apellido"].ToString();
                P.FechaNac = DateTime.Parse(R["FechaNac"].ToString());
                P.Tel = int.Parse(R["Tel"].ToString());
                P.Mail = R["Mail"].ToString();
                P.BajaLogica = bool.Parse(R["BajaLogica"].ToString());
                ListarProveedor.Add(P);
            }
            return ListarProveedor;
        }

        public int Alta(Propiedades_BE.Proveedor Pr)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[7];
            P[0] = new SqlParameter("@IdProveedor", Pr.IdProveedor);
            P[1] = new SqlParameter("@CUIT", Pr.CUIT);
            P[2] = new SqlParameter("@Nombre", Pr.Nombre);
            P[3] = new SqlParameter("@Apellido", Pr.Apellido);
            P[4] = new SqlParameter("@FechaNac", Pr.FechaNac);
            P[5] = new SqlParameter("@Tel", Pr.Tel);
            P[6] = new SqlParameter("@Mail", Pr.Mail);
            fa = Acceso.Escribir("AltaProveedor", P);
            return fa;
        }

        public int Baja(Propiedades_BE.Proveedor Pr)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[1];
            P[0] = new SqlParameter("@IdProveedor", Pr.IdProveedor);
            fa = Acceso.Escribir("BajaProveedor", P);
            return fa;
        }

        public int Modificar(Propiedades_BE.Proveedor Pr)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[7];
            P[0] = new SqlParameter("@IdProveedor", Pr.IdProveedor);
            P[1] = new SqlParameter("@CUIT", Pr.CUIT);
            P[2] = new SqlParameter("@Nombre", Pr.Nombre);
            P[3] = new SqlParameter("@Apellido", Pr.Apellido);
            P[4] = new SqlParameter("@FechaNac", Pr.FechaNac);
            P[5] = new SqlParameter("@Tel", Pr.Tel);
            P[6] = new SqlParameter("@Mail", Pr.Mail);
            fa = Acceso.Escribir("ModificarProveedor", P);
            return fa;
        }

        public List<string> CUITProveedor()
        {
            List<string> CUITP = new List<string>();
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "Select CUIT from Proveedor";
                using (SqlCommand command = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader lector = command.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            CUITP.Add(Seguridad.Desencriptar(lector.GetString(0).ToString()));
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return CUITP;
        }

        public List<string> NombreProveedores()
        {
            List<string> Nombres = new List<string>();
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "Select Nombre from Proveedor";
                using (SqlCommand command = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader lector = command.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Nombres.Add(lector.GetString(0));
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Nombres;
        }

        public Int64 SeleccionarCUITProveedor(string NombreProveedor)
        {
            Int64 CUIT = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string query = "select CUIT from Proveedor where Nombre = '" + NombreProveedor + "'";
                using (SqlCommand command = new SqlCommand(query, Acceso.Conexion))
                {
                    using (SqlDataReader lector = command.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            CUIT = Int64.Parse(Seguridad.Desencriptar(lector.GetString(0).ToString()));
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return CUIT;
        }

        public int SeleccionarIdProveedor(Int64 CUIT)
        {
            int ID = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string query = "select IdProveedor from Proveedor where CUIT = '" + Seguridad.EncriptarAES(CUIT.ToString()) + "'";
                using (SqlCommand command = new SqlCommand(query, Acceso.Conexion))
                {
                    using (SqlDataReader lector = command.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            ID = lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return ID;
        }

        public string SeleccionarNombreProveedor(Int64 CUIT)
        {
            string Nombre = "";
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string query = "select Nombre from Proveedor where CUIT = '" + Seguridad.EncriptarAES(CUIT.ToString()) + "'";
                using (SqlCommand command = new SqlCommand(query, Acceso.Conexion))
                {
                    using (SqlDataReader lector = command.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Nombre = lector.GetString(0).ToString();
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Nombre;
        }
    }
}

