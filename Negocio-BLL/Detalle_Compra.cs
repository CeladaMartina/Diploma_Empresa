using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class Detalle_Compra
    {
        Acceso_DAL.Detalle_Compra Mapper = new Acceso_DAL.Detalle_Compra();
        Propiedades_BE.Detalle_Compra DCTemp = new Propiedades_BE.Detalle_Compra();
        Acceso_DAL.Seguridad Seguridad = new Acceso_DAL.Seguridad();
        Acceso_DAL.Articulo Articulo = new Acceso_DAL.Articulo();

        long DV = 0;

        public int AltaDC(int Cantidad, int DVH, int IdArticulo, decimal PUnit, int IdCompra)
        {
            DCTemp.Cant = Cantidad;
            DCTemp.DVH = DVH;
            DCTemp.IdArticulo = IdArticulo;
            DCTemp.PUnit = PUnit;
            DCTemp.IdCompra = IdCompra;
            int i = Mapper.AltaDC(DCTemp);
            DV = Seguridad.CalcularDVH("select top 1* from Detalle_Compra order by IdDetalle Desc", "Detalle_Compra");
            Articulo.EjecutarConsulta("Update Detalle_Compra set DVH = " + DV + " where IdDetalle = (SELECT TOP 1 IdDetalle from Detalle_Compra order by IdDetalle desc)");
            Seguridad.ActualizarDVV("Detalle_Compra", Seguridad.SumaDVV("Detalle_Compra"));

            return i;
        }

        public int BajaDC(int IdDetalle, int IdArticulo)
        {
            DCTemp.IdDetalle = IdDetalle;
            DCTemp.IdArticulo = IdArticulo;
            int i = Mapper.BajaDC(DCTemp);
            Seguridad.ActualizarDVV("Detalle_Compra", Seguridad.SumaDVV("Detalle_Compra"));

            return i;
        }

        public int ModificarDC(int IdDetalle, int IdArticulo, decimal PUnit, int Cantidad, int DVH)
        {
            DCTemp.IdDetalle = IdDetalle;
            DCTemp.IdArticulo = IdArticulo;
            DCTemp.PUnit = PUnit;
            DCTemp.Cant = Cantidad;
            DCTemp.DVH = DVH;
            int i = Mapper.ModificarDC(DCTemp);
            DV = Seguridad.CalcularDVH("Select * from Detalle_Compra where IdDetalle = " + DCTemp.IdDetalle + "", "Detalle_Compra");
            Articulo.EjecutarConsulta("Update Detalle_Compra set DVH = " + DV + " where IdDetalle = " + DCTemp.IdDetalle + "");
            Seguridad.ActualizarDVV("Detalle_Compra", Seguridad.SumaDVV("Detalle_Compra"));

            return i;
        }

        public List<Propiedades_BE.Detalle_Compra> ListarDC(int IdCompra)
        {
            DCTemp.IdCompra = IdCompra;
            List<Propiedades_BE.Detalle_Compra> Lista = Mapper.ListarDC(DCTemp);
            return Lista;
        }
        public List<Propiedades_BE.Detalle_Compra> ListaVerificacion()
        {
            return Mapper.ListaVerificacion();
        }

        public decimal SubTotal(int IdCompra)
        {
            return Mapper.SubTotal(IdCompra);
        }

        public bool ExisteProducto(int IdCompra, int IdArticulo)
        {
            return Mapper.ExisteProducto(IdCompra, IdArticulo);
        }

        public void UnificarArticulos(int IdCompra, int IdArticulo, int Cantidad)
        {
            Mapper.UnificarArticulos(IdCompra, IdArticulo, Cantidad);
            DV = Seguridad.CalcularDVH("Select * from Detalle_Compra where IdArticulo = " + IdArticulo + " and IdCompra = " + IdCompra + "", "Detalle_Compra");
            Articulo.EjecutarConsulta("Update Detalle_Compra set DVH = " + DV + " where IdArticulo = " + IdArticulo + " and IdCompra = " + IdCompra + "");
            Seguridad.ActualizarDVV("Detalle_Compra", Seguridad.SumaDVV("Detalle_Compra"));
        }

        public string VerificarIntegridadDC(int GlobalIdUsuario)
        {
            return Mapper.VerificarIntegridadDC(GlobalIdUsuario);
        }

        public void RecalcularDVH()
        {
            Mapper.RecalcularDVH();
        }

    }
}
