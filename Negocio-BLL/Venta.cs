using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class Venta
    {
        Acceso_DAL.Venta Mapper = new Acceso_DAL.Venta();
        Propiedades_BE.Venta VentaTemp = new Propiedades_BE.Venta();

        #region list
        public List<Propiedades_BE.Venta> Listar()
        {
            return Mapper.Listar();
        }
        
        public List<Propiedades_BE.Venta> FiltradoCompleto(string _DNI, DateTime _FechaDesde, DateTime _FechaHasta, decimal _MontoDesde, decimal _MontoHasta)
        {
            return Mapper.FiltradoCompleto(_DNI, _MontoDesde, _MontoHasta, _FechaDesde, _FechaHasta);
        }


        #endregion
        public string CancelarVenta(int IdVenta)
        {
            return Mapper.CancelarVenta(IdVenta);
        }

        public int TraerIdVenta()
        {
            return Mapper.TraerIdVenta();
        }

        public int Alta(int IdCliente, DateTime Fecha)
        {
            VentaTemp.IdCliente = IdCliente;
            VentaTemp.Fecha = Fecha;

            return Mapper.Alta(VentaTemp);
        }
        public bool VerificarExistenciaMonto(int IdVenta)
        {
            return Mapper.VerificarExistenciaMonto(IdVenta);
        }
        public void Vender(int IdVenta)
        {
            Mapper.Vender(IdVenta);
        }
    }
}
