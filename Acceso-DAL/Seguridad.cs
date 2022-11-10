﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Acceso_DAL
{
    public class Seguridad
    {

        Acceso_BD Acceso = new Acceso_BD();
        public static Random Random = new Random();

        public void EjecutarConsulta(string Consulta)
        {
            Acceso.EjecutarConsulta(Consulta);
        }

        #region Bitacora

        public List<Propiedades_BE.Bitacora> Listar()
        {
            List<Propiedades_BE.Bitacora> ListarBitacora = new List<Propiedades_BE.Bitacora>();
            DataTable Tabla = Acceso.Leer("ListarBitacora", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Bitacora B = new Propiedades_BE.Bitacora();
                B.NickUs = Desencriptar(R["Nick"].ToString());
                B.Fecha = DateTime.Parse(R["Fecha"].ToString());
                B.Descripcion = Desencriptar(R["Descripcion"].ToString());
                B.Criticidad = R["Criticidad"].ToString();
                ListarBitacora.Add(B);
            }
            return ListarBitacora;
        }

        public void CargarBitacora(int IdUsuario, DateTime Fecha, string Descripcion, string Criticidad, int DVH)
        {
            int o = 0;

            try
            {
                SqlParameter[] P = new SqlParameter[5];
                P[0] = new SqlParameter("@IdUsuario", IdUsuario);
                P[1] = new SqlParameter("@Fecha", Fecha);
                P[2] = new SqlParameter("@Descripcion", EncriptarAES(Descripcion));
                P[3] = new SqlParameter("@Criticidad", Criticidad);
                P[4] = new SqlParameter("@DVH", DVH);
                Acceso.Escribir("CargarBitacora", P);
                long DV = CalcularDVH("select * from Bitacora where Fecha = '" + Fecha + "'", "Bitacora");
                EjecutarConsulta("Update Bitacora set DVH = " + DV + "where Fecha = '" + Fecha + "'");
                ActualizarDVV("Bitacora", SumaDVV("Bitacora"));

                o = 1;
            }
            catch (Exception)
            {
                o = -1;
                throw;
            }
        }

        //public List<Propiedades_BE.Bitacora> FiltrarCriticidadBitacora(string _Criticidad)
        //{
        //    List<Propiedades_BE.Bitacora> ListaBitacora = new List<Propiedades_BE.Bitacora>();

        //    Acceso.AbrirConexion();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select Us.Nick, Bita.Fecha, Bita.Descripcion, Bita.Criticidad from Usuario Us inner join Bitacora Bita on Us.IdUsuario = Bita.IdUsuario where Criticidad = '" + _Criticidad + "'";
        //    cmd.Connection = Acceso.Conexion;

        //    SqlDataReader lector = cmd.ExecuteReader();

        //    while (lector.Read())
        //    {
        //        Propiedades_BE.Bitacora B = new Propiedades_BE.Bitacora();
        //        B.NickUs = Desencriptar(lector["Nick"].ToString());
        //        B.Fecha = DateTime.Parse(lector["Fecha"].ToString());
        //        B.Descripcion = Desencriptar(lector["Descripcion"].ToString());
        //        B.Criticidad = lector["Criticidad"].ToString();
        //        ListaBitacora.Add(B);
        //    }
        //    lector.Close();
        //    Acceso.CerrarConexion();
        //    return ListaBitacora;
        //}
        //public List<Propiedades_BE.Bitacora> FiltrarUsuarioBitacora(string _NickUs)
        //{
        //    List<Propiedades_BE.Bitacora> ListaBitacora = new List<Propiedades_BE.Bitacora>();
        //    Acceso.AbrirConexion();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select Us.Nick,B.Fecha,B.Descripcion,B.Criticidad from Usuario Us inner join Bitacora B on Us.IdUsuario = B.IdUsuario where Us.Nick = '" + EncriptarAES(_NickUs) + "'";
        //    cmd.Connection = Acceso.Conexion;

        //    SqlDataReader lector = cmd.ExecuteReader();

        //    while (lector.Read())
        //    {
        //        Propiedades_BE.Bitacora B = new Propiedades_BE.Bitacora();
        //        B.NickUs = Desencriptar(lector["Nick"].ToString());
        //        B.Fecha = DateTime.Parse(lector["Fecha"].ToString());
        //        B.Criticidad = lector["Criticidad"].ToString();
        //        B.Descripcion = Desencriptar(lector["Descripcion"].ToString());
        //        ListaBitacora.Add(B);
        //    }
        //    lector.Close();
        //    Acceso.CerrarConexion();
        //    return ListaBitacora;
        //}

        public List<Propiedades_BE.Bitacora> FiltrarFechaRangoBitacora(DateTime _FechaDesde, DateTime _FechaHasta)
        {
            List<Propiedades_BE.Bitacora> ListaBitacora = new List<Propiedades_BE.Bitacora>();

            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Us.Nick,B.Fecha,B.Descripcion,B.Criticidad from Usuario Us inner join Bitacora B on Us.IdUsuario = B.IdUsuario where convert(date,Fecha) >= '" + _FechaDesde + "' and convert(date,Fecha) <= '" + _FechaHasta + "'";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Bitacora B = new Propiedades_BE.Bitacora();
                B.NickUs = Desencriptar(lector["Nick"].ToString());
                B.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                B.Descripcion = Desencriptar(lector["Descripcion"].ToString());
                B.Criticidad = lector["Criticidad"].ToString();
                ListaBitacora.Add(B);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return ListaBitacora;
        }

        //filtrado fecha - usuario
        public List<Propiedades_BE.Bitacora> FiltrarFechaRangoUsuario(DateTime _FechaDesde, DateTime _FechaHasta, string _NickUs)
        {
            List<Propiedades_BE.Bitacora> ListaBitacora = new List<Propiedades_BE.Bitacora>();

            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Us.Nick,B.Fecha,B.Descripcion,B.Criticidad from Usuario Us inner join Bitacora B on Us.IdUsuario = B.IdUsuario where convert(date,Fecha) >= '" + _FechaDesde + "' and convert(date,Fecha) <= '" + _FechaHasta + "' and Us.Nick = '" + EncriptarAES(_NickUs) + "' ";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Bitacora B = new Propiedades_BE.Bitacora();
                B.NickUs = Desencriptar(lector["Nick"].ToString());
                B.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                B.Descripcion = Desencriptar(lector["Descripcion"].ToString());
                B.Criticidad = lector["Criticidad"].ToString();
                ListaBitacora.Add(B);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return ListaBitacora;
        }

        //filtrado fecha - criticidad
        public List<Propiedades_BE.Bitacora> FiltrarFechaRangoCriticidad(DateTime _FechaDesde, DateTime _FechaHasta, string _Criticidad)
        {
            List<Propiedades_BE.Bitacora> ListaBitacora = new List<Propiedades_BE.Bitacora>();

            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Us.Nick,B.Fecha,B.Descripcion,B.Criticidad from Usuario Us inner join Bitacora B on Us.IdUsuario = B.IdUsuario where convert(date,Fecha) >= '" + _FechaDesde + "' and convert(date,Fecha) <= '" + _FechaHasta + "' and Criticidad = '" + _Criticidad + "' ";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Bitacora B = new Propiedades_BE.Bitacora();
                B.NickUs = Desencriptar(lector["Nick"].ToString());
                B.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                B.Descripcion = Desencriptar(lector["Descripcion"].ToString());
                B.Criticidad = lector["Criticidad"].ToString();
                ListaBitacora.Add(B);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return ListaBitacora;
        }

        public List<Propiedades_BE.Bitacora> FiltradoCompleto(string _NickUs, DateTime _FechaDesde, DateTime _FechaHasta, string _Criticidad)
        {
            List<Propiedades_BE.Bitacora> ListaBitacora = new List<Propiedades_BE.Bitacora>();
            Acceso.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Us.Nick, Bita.Fecha, Bita.Descripcion, Bita.Criticidad from Usuario Us inner join Bitacora Bita on Us.IdUsuario = Bita.IdUsuario where Criticidad = '" + _Criticidad + "' and convert(date,Fecha) >= '" + _FechaDesde + "' and convert(date,Fecha) <= '" + _FechaHasta + "' and Us.Nick = '" + EncriptarAES(_NickUs) + "'";
            cmd.Connection = Acceso.Conexion;

            SqlDataReader lector = cmd.ExecuteReader();

            while (lector.Read())
            {
                Propiedades_BE.Bitacora B = new Propiedades_BE.Bitacora();
                B.NickUs = Desencriptar(lector["Nick"].ToString());
                B.Fecha = DateTime.Parse(lector["Fecha"].ToString());
                B.Criticidad = lector["Criticidad"].ToString();
                B.Descripcion = Desencriptar(lector["Descripcion"].ToString());
                ListaBitacora.Add(B);
            }
            lector.Close();
            Acceso.CerrarConexion();
            return ListaBitacora;
        }

        public void RecalcularDVH()
        {
            long suma = 0;

            List<Propiedades_BE.Bitacora> DV = ListaVerificacion();
            foreach (Propiedades_BE.Bitacora bitacora in DV.ToList())
            {
                suma = 0;
                string IdBitacora = bitacora.IdBitacora.ToString();
                string IdUsuario = bitacora.IdUsuario.ToString();
                string Fecha = bitacora.Fecha.ToString();
                string Descripcion = bitacora.Descripcion.ToString();
                string Criticidad = bitacora.Criticidad.ToString();
                string dvh = bitacora.DVH.ToString();

                long IdBitacoraB = ObtenerAscii(IdBitacora);
                long IdUsuarioB = ObtenerAscii(IdUsuario);
                long FechaB = ObtenerAscii(Fecha);
                long DescripcionB = ObtenerAscii(Descripcion);
                long CriticidadB = ObtenerAscii(Criticidad);
                long dvhDv = long.Parse(dvh);

                suma = IdBitacoraB + IdUsuarioB + FechaB + DescripcionB + CriticidadB;
                Acceso.EjecutarConsulta("Update Bitacora set DVH = " + suma + " where IdBitacora = " + IdBitacora + "");
            }
        }

        public List<Propiedades_BE.Bitacora> ListaVerificacion()
        {
            List<Propiedades_BE.Bitacora> Lista = new List<Propiedades_BE.Bitacora>();           
            DataTable Tabla = Acceso.Leer("ListarBitacoraVerificacion", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Bitacora DV = new Propiedades_BE.Bitacora();
                DV.IdBitacora = int.Parse(R["IdBitacora"].ToString());
                DV.IdUsuario = int.Parse(R["IdUsuario"].ToString());
                DV.Fecha = DateTime.Parse(R["Fecha"].ToString()); 
                DV.Descripcion = R["Descripcion"].ToString();
                DV.Criticidad = R["Criticidad"].ToString();
                DV.DVH = int.Parse(R["DVH"].ToString());
                Lista.Add(DV);
            }
            return Lista;
        }

        public string VerificarIntegridadBitacora(int GlobalIdUsuario)
        {
            long Suma = 0;
            long DVH = 0;
            string msj = "";
            string msj2 = "";

            List<int> CamposFallidos = new List<int>();
            List<Propiedades_BE.Bitacora> BitacoraB = ListaVerificacion();

            foreach (Propiedades_BE.Bitacora Dv in BitacoraB.ToList())
            {
                string IdBitacora = Dv.IdBitacora.ToString();
                string IdUsuario = Dv.IdUsuario.ToString();
                string Fecha = Dv.Fecha.ToString();
                string Descripcion = Dv.Descripcion.ToString();
                string Criticidad = Dv.Criticidad.ToString();
                string dvh = Dv.DVH.ToString();

                long IdBitacoraB = ObtenerAscii(IdBitacora);
                long IdUsuarioB = ObtenerAscii(IdUsuario);
                long FechaB = ObtenerAscii(Fecha);
                long DescripcionB = ObtenerAscii(Descripcion);
                long CriticidadB = ObtenerAscii(Criticidad);
                long dvhDv = long.Parse(dvh);

                Suma = IdBitacoraB + IdUsuarioB + FechaB + DescripcionB + CriticidadB;
                DVH += Suma;

                if (dvhDv == Suma)
                {
                    BitacoraB.Remove(Dv);
                }
            }
            if (DVH != VerificacionDVV("Bitacora"))
            {
                msj += "Se encontro un error en la tabla Bitacora \n";
                CargarBitacora(GlobalIdUsuario, DateTime.Now, "Error en la tabla Bitacora", "Alta", 0);

                if (DVH < VerificacionDVV("Bitacora"))
                {
                    msj += "Posibilidad de eliminacion de 1 o mas registros de Bitacora \n";
                    CargarBitacora(GlobalIdUsuario, DateTime.Now, "Eliminacion registros Bitacora", "Alta", 0);
                }
            }
            foreach (Propiedades_BE.Bitacora MalCampo in BitacoraB)
            {
                CamposFallidos.Add(MalCampo.IdBitacora);
            }
            foreach (var item in CamposFallidos)
            {

                msj += "Se encontro un fallo en la fila con Id Detalle: " + item + " \n";
                msj2 = "Error Bitacora IdBitacora:" + item + "";
                CargarBitacora(GlobalIdUsuario, DateTime.Now, msj2, "Alta", 0);
                msj2 = "";
            }
            return msj;
        }

        #endregion

        #region DigitoVerificador

        long AsciiHorizontal;

        public DataSet EjecutarConsultaDSTabla(string Consulta, string Tabla)
        {
            DataSet Ds = new DataSet();
            Acceso.AbrirConexion();
            SqlDataAdapter DA = new SqlDataAdapter(Consulta, Acceso.Conexion);
            DA.Fill(Ds, Tabla);
            Acceso.CerrarConexion();
            return Ds;
        }

        public long ObtenerAscii(string Texto)
        {
            long SumAscii = 0;

            if (Texto != null)
            {
                int i;
                for (i = 0; i <= Texto.Length - 1; i++)
                {
                    SumAscii += Convert.ToInt64((Strings.Asc(Texto[i]).ToString()));
                }
            }
            return SumAscii;
        }

        public long CalcularDVH(string Consulta, string Tabla)
        {
            AsciiHorizontal = default(long);
            DataSet ds = new DataSet();
            ds = EjecutarConsultaDSTabla(Consulta, Tabla);

            for (int i = 0; i <= Information.UBound(ds.Tables[0].Rows[0].ItemArray, 1) - 1; i++)
            {
                try
                {
                    AsciiHorizontal += ObtenerAscii((ds.Tables[0].Rows[0].ItemArray[i]).ToString());
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return AsciiHorizontal;
        }

        public int VerificacionDVV(string Tabla)
        {
            int i = 0;
            Acceso.AbrirConexion();
            string Consulta = "select DVV from DVV where NombreTabla = '" + Tabla + "'";
            SqlCommand Cmd = new SqlCommand(Consulta, Acceso.Conexion);
            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.HasRows)
            {
                try
                {
                    Dr.Read();
                    i = Dr.GetInt32(0);
                }
                catch (Exception)
                {
                    i = 0;
                }
            }
            Acceso.CerrarConexion();
            return i;
        }

        public int SumaDVV(string Tabla)
        {
            int i = 0;
            Acceso.AbrirConexion();
            string Consulta = " SELECT SUM(DVH) FROM " + Tabla + "";
            SqlCommand Cmd = new SqlCommand(Consulta, Acceso.Conexion);
            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.HasRows)
            {
                try
                {
                    Dr.Read();
                    i = Dr.GetInt32(0);
                }
                catch (Exception)
                {
                    i = 0;
                }
            }
            Acceso.CerrarConexion();
            return i;
        }

        public void ActualizarDVV(string NombreTabla, int Suma)
        {
            Acceso.AbrirConexion();
            string Consulta = "Update DVV set DVV.DVV = " + Suma + " WHERE DVV.NombreTabla = '" + NombreTabla + "'";
            SqlCommand Cmd = new SqlCommand(Consulta, Acceso.Conexion);
            Cmd.ExecuteNonQuery();
            Acceso.CerrarConexion();
        }

        public long ObtenerDVV(string NombreTabla)
        {
            long i = 0;
            Acceso.AbrirConexion();
            string Consulta = "select DVV from DVV where NombreTabla = '" + NombreTabla + "'";
            SqlCommand Cmd = new SqlCommand(Consulta, Acceso.Conexion);
            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.HasRows)
            {
                Dr.Read();
                i = Dr.GetInt32(0);
            }

            Acceso.CerrarConexion();
            return i;
        }

        #endregion

        #region Encriptacion

        private static string Key = "asdfqwertuniolnmajeolikoajskidjq";
        private static string IV = "asdfghjklopqwert";

        public string EncriptarMD5(string Texto)
        {
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Texto));
            byte[] Resultado = MD5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < Resultado.Length; i++)
            {
                str.Append(Resultado[i].ToString("X2"));
            }
            return str.ToString();
        }

        public string EncriptarAES(string Texto)
        {
            byte[] TextoPlano = System.Text.ASCIIEncoding.ASCII.GetBytes(Texto);
            AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
            AES.BlockSize = 128;
            AES.KeySize = 256;
            AES.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            AES.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CBC;
            ICryptoTransform Crypto = AES.CreateEncryptor(AES.Key, AES.IV);
            byte[] Encriptar = Crypto.TransformFinalBlock(TextoPlano, 0, TextoPlano.Length);
            Crypto.Dispose();
            return Convert.ToBase64String(Encriptar);
        }

        public string Desencriptar(string Texto)
        {
            byte[] Encriptado = Convert.FromBase64String(Texto);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform Crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] des = Crypto.TransformFinalBlock(Encriptado, 0, Encriptado.Length);
            Crypto.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(des);
        }
        #endregion

        #region BackUpRestore

        public SqlConnection ConexionBack = new SqlConnection();

        public string Ejecutar(string query, SqlParameter[] parameter = null)
        {
            ConexionBack.ConnectionString = Acceso.GlobalConexion;
            string vConn = Acceso.GlobalConexion;
            //if (conn == "M")
            //{
            //    vConn = Conexion.ConnectionString;
            //}
            Acceso.Conexion = new SqlConnection(vConn);

            //Conexion = new SqlConnection(vConn);
            SqlCommand cmd = new SqlCommand();
            if (parameter != null)
            {
                for (int i = 0; i < parameter.Length; i++)
                {
                    cmd.Parameters.Add(parameter[i]);
                }
            }
            try
            {
                Acceso.AbrirConexion();
                cmd.Connection = Acceso.Conexion;
                cmd.CommandText = query;
                int res = Convert.ToInt16(cmd.ExecuteScalar());
                Acceso.CerrarConexion();
                Acceso.Conexion.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            return "ok";

        }

        public string GenerarBackup(string Nombre, string ruta)
        {            
            string query = "USE MASTER; BACKUP DATABASE [Diploma_Empresa] TO DISK = N'" + ruta + "\\" + Nombre  + ".bak' WITH NOFORMAT,NOINIT,NAME = N'" + Nombre + "', SKIP,NOREWIND,NOUNLOAD,STATS = 10 "; 
            return Ejecutar(query, null);
        }

        public string Restaurar(string ruta)
        {      
            string query = "USE MASTER; ALTER DATABASE [Diploma_Empresa] SET Single_User WITH Rollback Immediate; RESTORE DATABASE [Diploma_Empresa] FROM  DISK = '" + ruta + "' WITH REPLACE; ALTER DATABASE [Diploma_Empresa] SET Multi_User";          
            return Ejecutar(query, null);
        }


        #endregion

        #region Contraseña

        public string GenerarClave()
        {
            const string Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(Chars, 7).Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public bool ValidarClave(string clave)
        {
            int a = 0;
            if (clave.Length >= 8 || clave.Length <= 16)
            {
                a += 1;
            }
            if (Regex.IsMatch(clave, @"[1234567890]"))
            {
                a += 1;
            }
            if (Regex.IsMatch(clave, @"[A-Z]"))
            {
                a += 1;
            }
            if (Regex.IsMatch(clave, @"[a-z]"))
            {
                a += 1;
            }
            bool i = false;
            if (a == 4)
            {
                i = true;
            }
            return i;
        }

        #endregion
    }
}
