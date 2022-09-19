﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio_BLL
{
    public class Seguridad
    {
        Acceso_DAL.Seguridad Mapper = new Acceso_DAL.Seguridad();
        Acceso_DAL.Acceso_BD Acceso = new Acceso_DAL.Acceso_BD();

        #region Bitacora

        public List<Propiedades_BE.Bitacora> Listar()
        {
            return Mapper.Listar();
        }

        public void CargarBitacora(int IdUsuario, DateTime Fecha, string Descripcion, string Criticidad, int DVH)
        {
            Mapper.CargarBitacora(IdUsuario, Fecha, Descripcion, Criticidad, DVH);
        }

        public List<Propiedades_BE.Bitacora> FiltrarCriticidadBitacora(string _Criticidad)
        {
            return Mapper.FiltrarCriticidadBitacora(_Criticidad);
        }

        public List<Propiedades_BE.Bitacora> FiltrarUsuarioBitacora(string _Nick)
        {
            return Mapper.FiltrarUsuarioBitacora(_Nick);
        }

        public List<Propiedades_BE.Bitacora> FiltrarFechaRangoBitacora(DateTime _FechaDesde, DateTime _FechaHasta)
        {
            return Mapper.FiltrarFechaRangoBitacora(_FechaDesde, _FechaHasta);
        }

        #endregion

        #region DigitoVerificador

        public long ObtenerAscii(string Texto)
        {
            return Mapper.ObtenerAscii(Texto);
        }

        public long CalcularDVH(string Consulta, string Tabla)
        {
            return Mapper.CalcularDVH(Consulta, Tabla);
        }

        public int VerificacionDVV(string Tabla)
        {
            return Mapper.VerificacionDVV(Tabla);
        }

        public int SumaDVV(string Tabla)
        {
            return Mapper.SumaDVV(Tabla);
        }

        public void ActualizarDVV(string NombreTabla, int Suma)
        {
            Mapper.ActualizarDVV(NombreTabla, Suma);
        }

        public void RecalcularDVV()
        {
            Mapper.EjecutarConsulta("Update DVV set DVV.DVV = (select ISNULL(SUM(DVH), 0) from Usuario) where NombreTabla = 'Usuario'");
            Mapper.EjecutarConsulta("Update DVV set DVV.DVV = (select ISNULL(SUM(DVH), 0) from Detalle_Compra) where NombreTabla = 'Detalle_Compra'");
            Mapper.EjecutarConsulta("Update DVV set DVV.DVV = (select ISNULL(SUM(DVH), 0) from Detalle_Venta) where NombreTabla = 'Detalle_Venta'");
        }

        public long ObtenerDVV(string NombreTabla)
        {
            return Mapper.ObtenerDVV(NombreTabla);
        }

        public void EjecutarConsulta(string Consulta)
        {
            Acceso.EjecutarConsulta(Consulta);
        }


        #endregion

        #region Encriptacion

        public string EncriptarMD5(string Texto)
        {
            return Mapper.EncriptarMD5(Texto);
        }

        public string EncriptarAES(string Texto)
        {
            return Mapper.EncriptarAES(Texto);
        }

        public string Desencriptar(string Texto)
        {
            return Mapper.Desencriptar(Texto);
        }
        #endregion

        #region BackUpRestore

        public string GenerarBackUp(string Nombre, string Ruta, int CantVol)
        {
            return Mapper.GenerarBackup(Nombre, Ruta, CantVol);
        }

        public string Restaurar(List<string> archivos)
        {
            return Mapper.Restaurar(archivos);
        }

        #endregion

        #region Contraseña

        public string GenerarClave()
        {
            return Mapper.GenerarClave();
        }

        public bool ValidarClave(string clave)
        {
            return Mapper.ValidarClave(clave);
        }

        public void RecalcularDVH()
        {
            Mapper.RecalcularDVH();
        }

        #endregion
    }
}
