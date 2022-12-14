using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
    public class Compra
    {
        Acceso_DAL.Compra Mapper = new Acceso_DAL.Compra();
        Propiedades_BE.Compra CompraTemp = new Propiedades_BE.Compra();

        #region list 
        public List<Propiedades_BE.Compra> Listar()
        {
            return Mapper.Listar();
        }

        //public List<Propiedades_BE.Compra> FiltradoCompleto(decimal _MontoDesde, decimal _MontoHasta, DateTime _FechaDesde, DateTime _FechaHasta, string _CUIT)
        //{
        //    return Mapper.FiltradoCompleto(_MontoDesde, _MontoHasta, _FechaDesde, _FechaHasta, _CUIT);
        //}

        public List<Propiedades_BE.Compra> ConsultaCompra(DateTime _FechaDesde, DateTime _FechaHasta, string consultaProveedor, string consultaMonto)
        {
            return Mapper.ConsultaCompra(_FechaDesde, _FechaHasta, consultaProveedor, consultaMonto);
        }
        #endregion

        public int TraerIdCompra()
        {
            return Mapper.TraerIdCompra();
        }

        public int Alta(int IdProveedor, DateTime Fecha)
        {
            CompraTemp.IdProveedor = IdProveedor;
            CompraTemp.Fecha = Fecha;

            return Mapper.Alta(CompraTemp);
        }

        public void Comprar(int IdCompra)
        {
            Mapper.Comprar(IdCompra);
        }
        public string CancelarCompra(int IdCompra)
        {
            return Mapper.CancelarCompra(IdCompra);
        }
        public bool VerificarExistenciaMonto(int IdCompra)
        {
            return Mapper.VerificarExistenciaMonto(IdCompra);
        }
    }
}
