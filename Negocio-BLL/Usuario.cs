using System;
using System.Collections.Generic;

namespace Negocio_BLL
{
    public class Usuario
    {
        Acceso_DAL.Usuario Mapper = new Acceso_DAL.Usuario();
        Propiedades_BE.Usuario UsuarioTemp = new Propiedades_BE.Usuario();
        Seguridad Seguridad = new Seguridad();

        #region Seguridad

        public string VerificarIntegridadUsuario(int GlobalIdUsuario)
        {
            return Mapper.VerificarIntegridadUsuario(GlobalIdUsuario);
        }

        public bool VerificarEstado(string Nick)
        {
            return Mapper.VerificarEstados(Nick);
        }

        public int VerificarContador(string Nick)
        {
            return Mapper.VerificarContador(Nick);
        }

        public void EjecutarConsulta(string Consulta)
        {
            Mapper.EjecutarConsulta(Consulta);
        }

        public void BloquearUsuario(string Nick)
        {
            Mapper.BloquearUsuario(Nick);
        }

        public void ReiniciarIntentos(string Nick)
        {
            Mapper.ReiniciarIntentos(Nick);
        }

        public int VerificarUsuarioContraseña(string Nick, string Contraseña, int Integridad)
        {
            return Mapper.VerificarUsuarioContraseña(Nick, Contraseña, Integridad);
        }

        public List<string> NickUsuario()
        {
            return Mapper.NickUsuario();
        }

        public int SeleccionarIDNick(string Nick)
        {
            return Mapper.SeleccionarIDNick(Nick);
        }

        public void Desbloquear(string Nick)
        {
            Mapper.Desbloquear(Nick);
        }

        public bool VerificarNickMail(string Nick, string Mail)
        {
            return Mapper.VerificarNickMail(Nick, Mail);
        }

        public void RecalcularDVH()
        {
            Mapper.RecalcularDVH();
        }

        public void GenerarConexion(string usuario, string basedatos)
        {
            string Conexion = "";
            string DataSourceRaw = "";
            string DataSourceRaw2 = "";
            DataSourceRaw = usuario;
            DataSourceRaw2 = basedatos;
            //string[] DataSourceFinal = DataSourceRaw.Split('\\');
            Conexion = @"Data Source=" + DataSourceRaw + ";Initial Catalog=" + DataSourceRaw2 + ";Integrated Security=True";
            //Conexion = @"Data Source=" + DataSourceFinal[0] + ";Initial Catalog=Diploma_Trabajo_Final;Integrated Security=True";
            Mapper.GenerarConexion(Conexion);
        }

        public void ConfirmarCambioContraseña(string Nick, string Contraseña, string Mail)
        {
            string Query = "Update Usuario set Contraseña= '" + Seguridad.EncriptarMD5(Contraseña) + "' where Nick = '" + Seguridad.EncriptarAES(Nick) + "' and Mail= '" + Mail + "'";
            Mapper.EjecutarConsulta(Query);
            long Dv;
            Dv = Seguridad.CalcularDVH("Select * from Usuario where Nick = '" + Seguridad.EncriptarAES(Nick) + "' and Mail = '" + Mail + "'", "Usuario");
            Mapper.EjecutarConsulta("Update Usuario set DVH = " + Dv + " where Nick = '" + Seguridad.EncriptarAES(Nick) + "' and Mail= '" + Mail + "'");
            Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));
        }

        public void CancelarConexion()
        {
            Mapper.GenerarConexion("");
        }

        public string GetConexion()
        {
            return Mapper.GetConexion();
        }

        public void RestaurarClave(string Contraseña, string Nick, string Mail) { }

        public List<string> NombreUsuariosSistema()
        {
            return Mapper.NombreUsuariosSistema();
        }

        #endregion

        #region ABML

        public List<Propiedades_BE.Usuario> Listar()
        {
            List<Propiedades_BE.Usuario> Lista = Mapper.Listar();
            return Lista;
        }

        public int Alta(string Nick, string Contraseña, string Nombre, string Mail, bool Estado, int Contador, string Idioma, int DVH)
        {
            UsuarioTemp.IdUsuario = SeleccionarIDNick(Nick);
            UsuarioTemp.Nick = Seguridad.EncriptarAES(Nick);
            UsuarioTemp.Contraseña = Seguridad.EncriptarMD5(Contraseña);
            UsuarioTemp.Nombre = Nombre;
            UsuarioTemp.Mail = Mail;
            UsuarioTemp.Estado = Estado;
            UsuarioTemp.Contador = 0;
            UsuarioTemp.Idioma = Idioma;
            UsuarioTemp.DVH = DVH;

            int i = Mapper.Alta(UsuarioTemp);
            long Dv = Seguridad.CalcularDVH("select * From Usuario where Nick = '" + UsuarioTemp.Nick + "'", "Usuario");
            EjecutarConsulta("Update Usuario set DVH = " + Dv + " where Nick = '" + UsuarioTemp.Nick + "'");
            Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));

            return i;
        }

        public int Baja(int IdUsuario, int DVH)
        {
            UsuarioTemp.IdUsuario = IdUsuario;
            UsuarioTemp.DVH = DVH;

            int i = Mapper.Baja(UsuarioTemp);
            long Dv = Seguridad.CalcularDVH("select * From Usuario where IdUsuario = '" + UsuarioTemp.IdUsuario + "'", "Usuario");
            EjecutarConsulta("Update Usuario set DVH = " + Dv + " where IdUsuario = '" + UsuarioTemp.IdUsuario + "'");
            Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));

            return i;
        }

        public int Modificar(int IdUsuario, string Nick, string Nombre, string Mail, bool Estado, int Contador, string Idioma, int DVH)
        {
            UsuarioTemp.IdUsuario = IdUsuario;
            UsuarioTemp.Nick = Seguridad.EncriptarAES(Nick);
            UsuarioTemp.Nombre = Nombre;
            UsuarioTemp.Mail = Mail;
            UsuarioTemp.Estado = Estado;
            UsuarioTemp.Contador = Contador;
            UsuarioTemp.Idioma = Idioma;
            UsuarioTemp.DVH = DVH;

            int i = Mapper.Modificar(UsuarioTemp);
            long Dv = Seguridad.CalcularDVH("select * From Usuario where Nick = '" + UsuarioTemp.Nick + "'", "Usuario");
            EjecutarConsulta("Update Usuario set DVH = " + Dv + " where Nick = '" + UsuarioTemp.Nick + "'");
            Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));

            return i;
        }

        #endregion

        #region Permisos

        public List<Propiedades_BE.Usuario> GetAll()
        {
            return Mapper.GetAll();
        }

        public IList<Propiedades_BE.Usuario> GetAllUsuarioPermisos()
        {
            return Mapper.GetAllPermisosUsuario();
        }

        public void GuardarPermisos(Propiedades_BE.Usuario u)
        {
            Mapper.GuardarPermiso(u);
        }

        public void EliminarPermisos(int IdUsuario, int IdPermiso)
        {
            Mapper.EliminarPermisos(IdUsuario, IdPermiso);
        }

        public void LogIn(Propiedades_BE.Usuario U)
        {
            (new Acceso_DAL.Permisos()).FillUserComponents(U);
            Propiedades_BE.SingletonLogIn.GetInstance.LogIn(U);
        }

        public void LogOut()
        {
            Propiedades_BE.SingletonLogIn.GetInstance.LogOut();
        }

        #endregion

        #region VerificarBorrado

        public int VerificarBorradoUsuario(int IdUsuario)
        {
            return Mapper.VerificarBorradoUsuario(IdUsuario);
        }

        public int VerificarBorrarPatUs(int IdUsuario, int IdPatente)
        {
            return Mapper.VerificarBorrarPatUs(IdUsuario, IdPatente);
        }

        public int VerificarBorrarFamUs(int IdUsuario, int IdFamilia)
        {
            return Mapper.VerificarBorrarFamUs(IdUsuario, IdFamilia);
        }

        #endregion
    }
}
