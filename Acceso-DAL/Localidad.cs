using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class Localidad
    {
        Acceso_BD Acceso = new Acceso_BD();

        public List<Propiedades_BE.Localidad> Listar()
        {
            List<Propiedades_BE.Localidad> ListarLocalidad = new List<Propiedades_BE.Localidad>();
            DataTable Tabla = Acceso.Leer("ListarLocalidad", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Localidad L = new Propiedades_BE.Localidad();
                L.IdLocalidad = int.Parse(R["IdLocalidad"].ToString());
                L.Nombre = R["Nombre"].ToString();
                L.Descripcion = R["Descripcion"].ToString();
                L.CodPostal = int.Parse(R["CodPostal"].ToString());
                L.Partido = R["Partido"].ToString();
                L.BajaLogica = bool.Parse(R["BajaLogica"].ToString());
                ListarLocalidad.Add(L);
            }
            return ListarLocalidad;
        }

        public int Alta(Propiedades_BE.Localidad L)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[5];
            P[0] = new SqlParameter("@IdLocalidad", L.IdLocalidad);
            P[1] = new SqlParameter("@Nombre", L.Nombre);
            P[2] = new SqlParameter("@Descripcion", L.Descripcion);
            P[3] = new SqlParameter("@CodPostal", L.CodPostal);
            P[4] = new SqlParameter("@Partido", L.Partido);
            fa = Acceso.Escribir("AltaLocalidad", P);
            return fa;
        }

        public int Modificar(Propiedades_BE.Localidad L)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[5];
            P[0] = new SqlParameter("@IdLocalidad", L.IdLocalidad);
            P[1] = new SqlParameter("@Nombre", L.Nombre);
            P[2] = new SqlParameter("@Descripcion", L.Descripcion);
            P[3] = new SqlParameter("@CodPostal", L.CodPostal);
            P[4] = new SqlParameter("@Partido", L.Partido);
            fa = Acceso.Escribir("ModificarLocalidad", P);
            return fa;
        }

        public int Baja(Propiedades_BE.Localidad L)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[1];
            P[0] = new SqlParameter("@IdLocalidad", L.IdLocalidad);
            fa = Acceso.Escribir("BajaLocalidad", P);
            return fa;
        }

        public List<string> TraerNomLoc()
        {
            List<string> Nom = new List<string>();
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string query = "Select Nombre From Localidad";
                using (SqlCommand cmd = new SqlCommand(query, Acceso.Conexion))
                {
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Nom.Add(lector.GetString(0));
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Nom;
        }

        public int TraerIdLoc(string NomLoc)
        {
            int ID = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string query = "select IdLocalidad from Localidad where Nombre = '" + NomLoc + "'";
                using (SqlCommand cmd = new SqlCommand(query, Acceso.Conexion))
                {
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            ID = lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return ID;
        }
    }
}
