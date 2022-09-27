using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class Localidad
    {
        Acceso_DAL.Localidad Mapper = new Acceso_DAL.Localidad();
        Propiedades_BE.Localidad LocalidadTemp = new Propiedades_BE.Localidad();

        public List<Propiedades_BE.Localidad> Listar()
        {
            List<Propiedades_BE.Localidad> Lista = Mapper.Listar();
            return Lista;
        }

        public int Alta(int IdLocalidad, string Nombre, string Descripcion, int CodPostal, string Partido)
        {
            LocalidadTemp.IdLocalidad = IdLocalidad;
            LocalidadTemp.Nombre = Nombre;
            LocalidadTemp.Descripcion = Descripcion;
            LocalidadTemp.CodPostal = CodPostal;
            LocalidadTemp.Partido = Partido;

            return Mapper.Alta(LocalidadTemp);
        }

        public int Baja(int IdLocalidad)
        {
            LocalidadTemp.IdLocalidad = IdLocalidad;

            return Mapper.Baja(LocalidadTemp);
        }

        public int Modificar(int IdLocalidad, string Nombre, string Descripcion, int CodPostal, string Partido)
        {
            LocalidadTemp.IdLocalidad = IdLocalidad;
            LocalidadTemp.Nombre = Nombre;
            LocalidadTemp.Descripcion = Descripcion;
            LocalidadTemp.CodPostal = CodPostal;
            LocalidadTemp.Partido = Partido;

            return Mapper.Modificar(LocalidadTemp);
        }

        public List<string> TraerNomLoc()
        {
            return Mapper.TraerNomLoc();
        }

        public int TraerIdLoc(string NomLoc)
        {
            return Mapper.TraerIdLoc(NomLoc);
        }
    }
}
