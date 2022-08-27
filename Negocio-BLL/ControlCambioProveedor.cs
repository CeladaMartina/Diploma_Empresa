using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class ControlCambioProveedor
    {
        Acceso_DAL.ControlCambioProveedor Mapper = new Acceso_DAL.ControlCambioProveedor();
        Propiedades_BE.ControlCambioProveedor ControlCambioTemp = new Propiedades_BE.ControlCambioProveedor();

        public List<Propiedades_BE.ControlCambioProveedor> ListarControlCambioProveedor()
        {
            List<Propiedades_BE.ControlCambioProveedor> Lista = Mapper.ListarControlCambiosProveedor();
            return Lista;
        }

        public int InsertarCambios(string CUIT, string Nombre, string Apellido, DateTime FechaNac, int Tel, string Mail, int IdUsuario, DateTime FechaModificacion)
        {
            ControlCambioTemp.CUIT = CUIT;
            ControlCambioTemp.Nombre = Nombre;
            ControlCambioTemp.Apellido = Apellido;
            ControlCambioTemp.FechaNac = FechaNac;
            ControlCambioTemp.Tel = Tel;
            ControlCambioTemp.Mail = Mail;
            ControlCambioTemp.IdUsuario = IdUsuario;
            ControlCambioTemp.FechaModificacion = FechaModificacion;

            return Mapper.InsertarCambios(ControlCambioTemp);
        }

        public int VolverEstadoProveedor(Propiedades_BE.Proveedor P)
        {
            return Mapper.VolverEstadoProveedor(P);
        }

        public List<Propiedades_BE.ControlCambioProveedor> FiltrarCambio(string CUIT)
        {
            List<Propiedades_BE.ControlCambioProveedor> ListarFiltro = Mapper.FiltrarControlCambio(CUIT);
            return ListarFiltro;
        }
    }
}
