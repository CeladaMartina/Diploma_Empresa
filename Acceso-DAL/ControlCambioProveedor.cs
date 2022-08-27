using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class ControlCambioProveedor
    {
        Acceso_BD Acceso = new Acceso_BD();
        Seguridad Seguridad = new Seguridad();

        public int VolverEstadoProveedor(Propiedades_BE.Proveedor P)
        {
            int fa = 0;
            SqlParameter[] Pa = new SqlParameter[8];
            Pa[0] = new SqlParameter("@IdProveedor", P.IdProveedor);
            Pa[1] = new SqlParameter("@CUIT", P.CUIT);
            Pa[2] = new SqlParameter("@Nombre", P.Nombre);
            Pa[3] = new SqlParameter("@Apellido", P.Apellido);
            Pa[4] = new SqlParameter("@FechaNac", P.FechaNac);
            Pa[5] = new SqlParameter("@Tel", P.Tel);
            Pa[6] = new SqlParameter("@Mail", P.Mail);
            Pa[7] = new SqlParameter("@BajaLogica", P.BajaLogica);
            fa = Acceso.Escribir("VolverEstadoProveedor", Pa);
            return fa;
        }

        public List<Propiedades_BE.ControlCambioProveedor> ListarControlCambiosProveedor()
        {
            List<Propiedades_BE.ControlCambioProveedor> ListaControl = new List<Propiedades_BE.ControlCambioProveedor>();
            DataTable Tabla = Acceso.Leer("ListarControlCambiosProveedor", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.ControlCambioProveedor CC = new Propiedades_BE.ControlCambioProveedor();
                CC.IdProveedor = int.Parse(R["IdProveedor"].ToString());
                CC.CUIT = Seguridad.Desencriptar(R["CUIT"].ToString());
                CC.Nombre = R["Nombre"].ToString();
                CC.Apellido = R["Apellido"].ToString();
                CC.FechaNac = DateTime.Parse(R["FechaNac"].ToString());
                CC.Tel = int.Parse(R["Tel"].ToString());
                CC.Mail = R["Mail"].ToString();
                CC.BajaLogica = bool.Parse(R["BajaLogica"].ToString());
                CC.Nick = Seguridad.Desencriptar(R["Nick"].ToString());
                CC.FechaModificacion = DateTime.Parse(R["FechaModificacion"].ToString());
                ListaControl.Add(CC);
            }
            return ListaControl;
        }

        public int InsertarCambios(Propiedades_BE.ControlCambioProveedor CC)
        {
            int fa = 0;
            SqlParameter[] Pa = new SqlParameter[8];
            Pa[0] = new SqlParameter("@CUIT", CC.CUIT);
            Pa[1] = new SqlParameter("@Nombre", CC.Nombre);
            Pa[2] = new SqlParameter("@Apellido", CC.Apellido);
            Pa[3] = new SqlParameter("@FechaN", CC.FechaNac);
            Pa[4] = new SqlParameter("@Tel", CC.Tel);
            Pa[5] = new SqlParameter("@Mail", CC.Mail);
            Pa[6] = new SqlParameter("@IdUsuario", CC.IdUsuario);
            Pa[7] = new SqlParameter("@FechaModificacion", CC.FechaModificacion);
            fa = Acceso.Escribir("InsertarControlCambioProveedor", Pa);
            return fa;
        }

        public List<Propiedades_BE.ControlCambioProveedor> FiltrarControlCambio(string CUIT)
        {
            List<Propiedades_BE.ControlCambioProveedor> Listar = new List<Propiedades_BE.ControlCambioProveedor>();
            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select CP.IdProveedor,CP.CUIT,CP.Nombre,CP.Apellido,CP.FechaNac,CP.Tel,CP.Mail,CP.BajaLogica,U.Nick,CP.FechaModificacion from Control_Cambios_Proveedor CP, Usuario U where CP.IdUsuario = U.IdUsuario AND CP.CUIT = '" + Seguridad.EncriptarAES(CUIT) + "'";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.ControlCambioProveedor CCP = new Propiedades_BE.ControlCambioProveedor();
                CCP.IdProveedor = int.Parse(lector["IdProveedor"].ToString());
                CCP.CUIT = Seguridad.Desencriptar(lector["CUIT"].ToString());
                CCP.Nombre = lector["Nombre"].ToString();
                CCP.Apellido = lector["Apellido"].ToString();
                CCP.FechaNac = DateTime.Parse(lector["FechaNac"].ToString());
                CCP.Tel = int.Parse(lector["Tel"].ToString());
                CCP.Mail = lector["Mail"].ToString();
                CCP.BajaLogica = bool.Parse(lector["BajaLogica"].ToString());
                CCP.Nick = Seguridad.Desencriptar(lector["Nick"].ToString());
                CCP.FechaModificacion = DateTime.Parse(lector["FechaModificacion"].ToString());
                Listar.Add(CCP);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return Listar;
        }
    }
}
