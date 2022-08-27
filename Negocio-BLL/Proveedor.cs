using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class Proveedor
    {
        Acceso_DAL.Proveedor Mapper = new Acceso_DAL.Proveedor();
        Propiedades_BE.Proveedor ProveedorTemp = new Propiedades_BE.Proveedor();

        public List<Propiedades_BE.Proveedor> Listar()
        {
            List<Propiedades_BE.Proveedor> Lista = Mapper.Listar();
            return Lista;
        }

        public int Alta(int IdProveedor, string CUIT, string Nombre, string Apellido, DateTime FechaNac, int Tel, string Mail)
        {
            ProveedorTemp.IdProveedor = IdProveedor;
            ProveedorTemp.CUIT = CUIT;
            ProveedorTemp.Nombre = Nombre;
            ProveedorTemp.Apellido = Apellido;
            ProveedorTemp.FechaNac = FechaNac;
            ProveedorTemp.Tel = Tel;
            ProveedorTemp.Mail = Mail;

            return Mapper.Alta(ProveedorTemp);
        }

        public int Baja(int IdProveedor)
        {
            ProveedorTemp.IdProveedor = IdProveedor;

            return Mapper.Baja(ProveedorTemp);
        }

        public int Modificar(int IdProveedor, string CUIT, string Nombre, string Apellido, DateTime FechaNac, int Tel, string Mail)
        {
            ProveedorTemp.IdProveedor = IdProveedor;
            ProveedorTemp.CUIT = CUIT;
            ProveedorTemp.Nombre = Nombre;
            ProveedorTemp.Apellido = Apellido;
            ProveedorTemp.FechaNac = FechaNac;
            ProveedorTemp.Tel = Tel;
            ProveedorTemp.Mail = Mail;

            return Mapper.Modificar(ProveedorTemp);
        }

        public int SeleccionarIdProveedor(Int64 CUIT)
        {
            return Mapper.SeleccionarIdProveedor(CUIT);
        }

        public List<string> CUITProveedor()
        {
            return Mapper.CUITProveedor();
        }

        public string SeleccionarNombreProveedor(Int64 CUIT)
        {
            return Mapper.SeleccionarNombreProveedor(CUIT);
        }

        public List<string> NombreProveedores()
        {
            return Mapper.NombreProveedores();
        }

        public Int64 SeleccionarCUITProveedor(string NombreProveedor)
        {
            return Mapper.SeleccionarCUITProveedor(NombreProveedor);
        }
    }
}
