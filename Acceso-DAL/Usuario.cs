using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Acceso_DAL
{
    public class Usuario
    {
        Acceso_BD Acceso = new Acceso_BD();
        Seguridad Seguridad = new Seguridad();

        #region Seguridad

        long Dv;

        public void RestaurarClave(string Contraseña, string Nick, string Mail)
        {
            Seguridad Seguridad = new Acceso_DAL.Seguridad();
            string query = "Update Usuario set Contraseña = '" + Contraseña + "' where Nick = '" + Nick + "' and Mail = '" + Mail + "'";
            EjecutarConsulta(query);
            long dv;
            dv = Seguridad.CalcularDVH("Select * from Usuario where Nick = '" + Nick + "' and Mail = '" + Mail + "'", "Usuario");
            EjecutarConsulta("Update Usuario set DVH = " + dv + "  where Nick = '" + Nick + "' and Mail = '" + Mail + "'");
            Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));
        }


        //NO USO
        public List<string> NombreUsuariosSistema()
        {
            List<string> NomUs = new List<string>();
            SqlConnection Conexion = new SqlConnection();
            using (Conexion)
            {
                Conexion.ConnectionString = @"Data Source=.;Integrated Security=True";
                Conexion.Open();

                string query = "select suser_sname(owner_sid) as 'Owner' from sys.databases";
                using (SqlCommand cmd = new SqlCommand(query, Conexion))
                {
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            NomUs.Add(lector.GetString(0).ToString());
                        }
                    }
                }
                Conexion.Close();
            }
            NomUs = NomUs.Distinct().ToList();
            return NomUs;
        }

        public string GetConexion()
        {
            return Acceso.GlobalConexion;
        }

        public void GenerarConexion(string Conexion)
        {
            Acceso.GenerarConexion(Conexion);
        }

        public List<string> NickUsuario()
        {
            List<string> NickUs = new List<string>();
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string QueryPatentes = "select Nick from Usuario";

                using (SqlCommand Cmd = new SqlCommand(QueryPatentes, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            NickUs.Add(Seguridad.Desencriptar(Lector.GetString(0).ToString()));
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return NickUs;
        }

        public int SeleccionarIDNick(string Nick)
        {
            int Id = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string QueryID = "select IdUsuario from Usuario where Nick = '" + Seguridad.EncriptarAES(Nick) + "'";

                using (SqlCommand Cmd = new SqlCommand(QueryID, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        if (Lector.Read())
                        {
                            Id = Lector.GetInt32(0);
                        }
                        else
                        {
                            Id = -1;
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Id;
        }

        public bool VerificarEstados(string Nick)
        {
            bool i = false;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string QueryEstado = "select * from Usuario where (Nick = '" + Seguridad.EncriptarAES(Nick) + "' and Estado = 1) or (Nick = '" + Seguridad.EncriptarAES(Nick) + "' and BajaLogica = 1)";

                using (SqlCommand Cmd = new SqlCommand(QueryEstado, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        if (Lector.Read())
                        {
                            i = true;
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return i;
        }

        public int VerificarContador(string Nick)
        {
            int i = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string QueryContador = "select Contador from Usuario where Nick = '" + Seguridad.EncriptarAES(Nick) + "'";

                using (SqlCommand Cmd = new SqlCommand(QueryContador, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        if (Lector.Read())
                        {
                            i = Lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return i;
        }

        public void EjecutarConsulta(string Consulta)
        {
            Acceso.EjecutarConsulta(Consulta);
        }

        public int VerificarUsuarioContraseña(string Nick, string Contraseña, int Integridad)
        {
            int i = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string QueryUsCon = "select * from Usuario where Nick = '" + Seguridad.EncriptarAES(Nick) + "' and Contraseña = '" + Seguridad.EncriptarMD5(Contraseña.ToString()) + "'";

                using (SqlCommand Cmd = new SqlCommand(QueryUsCon, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        if (Lector.Read())
                        {
                            i = 1;
                        }
                        else
                        {
                            if (Integridad == 0)
                            {
                                EjecutarConsulta("Update Usuario set Contador = ((select Contador from Usuario where Nick = '" + Seguridad.EncriptarAES(Nick) + "' ) + 1) where Nick = '" + Seguridad.EncriptarAES(Nick) + "' and Contador < 3");
                                string QueryDv = "select * from Usuario where Nick = '" + Seguridad.EncriptarAES(Nick) + "'";
                                Dv = Seguridad.CalcularDVH(QueryDv, "Usuario");
                                EjecutarConsulta("Update Usuario set DVH = " + Dv + " where Nick = '" + Seguridad.EncriptarAES(Nick) + "'");
                                Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));
                            }
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return i;
        }

        public void BloquearUsuario(string Nick)
        {
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string QueryBloquear = "Update Usuario set Estado = 1 where Nick = '" + Seguridad.EncriptarAES(Nick) + "'";

                using (SqlCommand Cmd = new SqlCommand(QueryBloquear, Acceso.Conexion))
                {
                    Cmd.ExecuteNonQuery();
                    string QueryDv = "select * from Usuario where Nick = '" + Seguridad.EncriptarAES(Nick) + "'";
                    Dv = Seguridad.CalcularDVH(QueryDv, "Usuario");
                    EjecutarConsulta("Update Usuario set DVH = " + Dv + " where Nick = '" + Seguridad.EncriptarAES(Nick) + "'");
                    Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));
                }
                Acceso.CerrarConexion();
            }
        }

        public void ReiniciarIntentos(string Nick)
        {
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string QueryReiniciar = "Update Usuario set Contador = 0 where Nick = '" + Seguridad.EncriptarAES(Nick) + "'";

                using (SqlCommand Cmd = new SqlCommand(QueryReiniciar, Acceso.Conexion))
                {
                    Cmd.ExecuteNonQuery();
                    string QueryDv = "select * from Usuario where Nick = '" + Seguridad.EncriptarAES(Nick) + "'";
                    Dv = Seguridad.CalcularDVH(QueryDv, "Usuario");
                    EjecutarConsulta("Update Usuario set DVH = " + Dv + " where Nick = '" + Seguridad.EncriptarAES(Nick) + "'");
                    Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));
                }
                Acceso.CerrarConexion();
            }
        }

        public string VerificarIntegridadUsuario(int GlobalIdUsuario)
        {
            long Suma = 0;
            long DVH = 0;
            string msj = "";
            string msj2 = "";

            List<int> CamposFallidos = new List<int>();
            List<Propiedades_BE.Usuario> Us = Listar();

            foreach (Propiedades_BE.Usuario Usu in Us.ToList())
            {
                string Id = Usu.IdUsuario.ToString();
                string Nick = Seguridad.EncriptarAES(Usu.Nick);
                string Contraseña = Usu.Contraseña;
                string Nombre = Usu.Nombre;
                string Mail = Usu.Mail;
                string Estado = Usu.Estado.ToString();
                string Contador = Usu.Contador.ToString();
                //string Idioma = Usu.Idioma;
                string IdIdioma = Usu.IdIdioma.ToString();
                string BajaLogica = Usu.BajaLogica.ToString();
                string dvh = Usu.DVH.ToString();

                long IdU = Seguridad.ObtenerAscii(Id);
                long NickU = Seguridad.ObtenerAscii(Nick);
                long ContraseñaU = Seguridad.ObtenerAscii(Contraseña);
                long NombreU = Seguridad.ObtenerAscii(Nombre);
                long MailU = Seguridad.ObtenerAscii(Mail);
                long EstadoU = Seguridad.ObtenerAscii(Estado);
                long ContadorU = Seguridad.ObtenerAscii(Contador);
                long IdiomaU = Seguridad.ObtenerAscii(IdIdioma);
                long BajaLogicaU = Seguridad.ObtenerAscii(BajaLogica);
                long DVHU = long.Parse(dvh);

                Suma = IdU + NickU + ContraseñaU + NombreU + MailU + EstadoU + ContadorU + IdiomaU + BajaLogicaU;
                DVH += Suma;

                if (DVHU == Suma)
                {
                    Us.Remove(Usu);
                }
            }
            if (DVH != Seguridad.VerificacionDVV("Usuario"))
            {
                msj += "Se encontro un error en la tabla USUARIO \n";
                Seguridad.CargarBitacora(GlobalIdUsuario, DateTime.Now, "Error en la tabla Usuario", "Alta");

                if (DVH < Seguridad.VerificacionDVV("Usuario"))
                {
                    msj += "Posibilidad de eliminacion de 1 o mas registros Usuario \n";
                    Seguridad.CargarBitacora(GlobalIdUsuario, DateTime.Now, "Eliminacion registros Usuarios", "Alta");
                }
            }
            foreach (Propiedades_BE.Usuario MalCampo in Us)
            {
                CamposFallidos.Add(MalCampo.IdUsuario);
            }
            foreach (var item in CamposFallidos)
            {
                msj += "Se encontro un fallo en la fila con ID: " + item + " \n";
                msj2 = "Error usuario en fila " + item + " ";
                Seguridad.CargarBitacora(GlobalIdUsuario, DateTime.Now, msj2, "Alta");
                msj2 = "";
            }
            return msj;
        }

        public void Desbloquear(string Nick)
        {
            try
            {
                string Query = "Update Usuario set Estado = 0 where Nick = '" + Nick + "'";
                EjecutarConsulta(Query);
                ReiniciarIntentos(Seguridad.Desencriptar(Nick));
                string QueryDv = "Select * from Usuario where Nick = '" + Nick + "'";
                Dv = Seguridad.CalcularDVH(Query, "Usuario");
                EjecutarConsulta("Update Usuario set DVH = " + Dv + " where Nick = '" + Nick + "'");
                Seguridad.ActualizarDVV("Usuario", Seguridad.SumaDVV("Usuario"));
            }
            catch (Exception)
            {

            }
        }

        public bool VerificarNickMail(string Nick, string Mail)
        {
            bool i = false;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "Select * from Usuario where Nick = '" + Nick + "' and Mail = '" + Mail + "'";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        if (Lector.Read())
                        {
                            i = true;
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return i;
        }

        public void RecalcularDVH()
        {
            long suma = 0;

            List<Propiedades_BE.Usuario> Us = Listar();
            foreach (Propiedades_BE.Usuario Usu in Us.ToList())
            {
                suma = 0;

                string id = Usu.IdUsuario.ToString();
                string nombre = Usu.Nombre;
                string nick = Seguridad.EncriptarAES(Usu.Nick);
                string contraseña = Usu.Contraseña;
                string mail = Usu.Mail;
                string estado = Usu.Estado.ToString();
                string contador = Usu.Contador.ToString();
                string bajalogica = Usu.BajaLogica.ToString();
                string ididioma = Usu.IdIdioma.ToString();
                //string idioma = Usu.Idioma;
                string dvh = Usu.DVH.ToString();

                long idU = Seguridad.ObtenerAscii(id);
                long nombreU = Seguridad.ObtenerAscii(nombre);
                long nickU = Seguridad.ObtenerAscii(nick);
                long contraseñaU = Seguridad.ObtenerAscii(contraseña);
                long mailU = Seguridad.ObtenerAscii(mail);
                long estadoU = Seguridad.ObtenerAscii(estado);
                long contadorU = Seguridad.ObtenerAscii(contador);
                long bajalogicaU = Seguridad.ObtenerAscii(bajalogica);
                long idiomaU = Seguridad.ObtenerAscii(ididioma);
                long digito = long.Parse(dvh);

                suma = idU + nombreU + nickU + contraseñaU + mailU + estadoU + contadorU + bajalogicaU + idiomaU;
                EjecutarConsulta("Update Usuario set DVH = " + suma + " where IdUsuario = " + id + "");
            }
        }
        #endregion

        #region ABML

        public List<Propiedades_BE.Usuario> Listar()
        {
            List<Propiedades_BE.Usuario> ListarUsuario = new List<Propiedades_BE.Usuario>();
            DataTable Tabla = Acceso.Leer("ListarUsuario", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Usuario U = new Propiedades_BE.Usuario();
                U.IdUsuario = int.Parse(R["IdUsuario"].ToString());
                U.Nick = Seguridad.Desencriptar(R["Nick"].ToString());
                U.Contraseña = R["Contraseña"].ToString();
                U.Nombre = R["Nombre"].ToString();
                U.Mail = R["Mail"].ToString();
                U.Estado = bool.Parse(R["Estado"].ToString());
                U.Contador = int.Parse(R["Contador"].ToString());
                U.IdIdioma = int.Parse(R["IdIdioma"].ToString());
                U.Idioma = R["NombreIdioma"].ToString(); //Traigo nombre para mostrar
                U.BajaLogica = bool.Parse(R["BajaLogica"].ToString());
                U.DVH = int.Parse(R["DVH"].ToString());

                ListarUsuario.Add(U);
            }
            return ListarUsuario;
        }

        public int Alta(Propiedades_BE.Usuario U)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[9];
            P[0] = new SqlParameter("@IdUsuario", U.IdUsuario);
            P[1] = new SqlParameter("@Nick", U.Nick);
            P[2] = new SqlParameter("@Contraseña", U.Contraseña);
            P[3] = new SqlParameter("@Nombre", U.Nombre);
            P[4] = new SqlParameter("@Mail", U.Mail);
            P[5] = new SqlParameter("@Estado", U.Estado);
            P[6] = new SqlParameter("@Contador", U.Contador);
            P[7] = new SqlParameter("@Idioma", U.Idioma);
            P[8] = new SqlParameter("@DVH", U.DVH);
            fa = Acceso.Escribir("AltaUsuario", P);
            return fa;
        }

        public int Modificar(Propiedades_BE.Usuario U)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[8];
            P[0] = new SqlParameter("@IdUsuario", U.IdUsuario);
            P[1] = new SqlParameter("@Nick", U.Nick);
            P[2] = new SqlParameter("@Nombre", U.Nombre);
            P[3] = new SqlParameter("@Mail", U.Mail);
            P[4] = new SqlParameter("@Estado", U.Estado);
            P[5] = new SqlParameter("@Contador", U.Contador);
            P[6] = new SqlParameter("@Idioma", U.Idioma);
            P[7] = new SqlParameter("@DVH", U.DVH);
            fa = Acceso.Escribir("ModificarUsuario", P);
            return fa;
        }

        public int Baja(Propiedades_BE.Usuario U)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[2];
            P[0] = new SqlParameter("@IdUsuario", U.IdUsuario);
            P[1] = new SqlParameter("@DVH", U.DVH);
            fa = Acceso.Escribir("BajaUsuario", P);
            return fa;
        }

        #endregion

        #region Permisos

        public List<Propiedades_BE.Usuario> GetAll()
        {
            var cnn = new SqlConnection(Acceso.GlobalConexion);
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;
            var sql = "select * from Usuario  where BajaLogica != 1 and Estado != 1";
            cmd.CommandText = sql;
            var reader = cmd.ExecuteReader();

            var lista = new List<Propiedades_BE.Usuario>();
            while (reader.Read())
            {
                Propiedades_BE.Usuario c = new Propiedades_BE.Usuario();
                c.IdUsuario = reader.GetInt32(reader.GetOrdinal("IdUsuario"));
                c.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                lista.Add(c);
            }
            reader.Close();
            cnn.Close();
            return lista;
        }

        public IList<Propiedades_BE.Usuario> GetAllPermisosUsuario()
        {
            var cnn = new SqlConnection(Acceso.GlobalConexion);
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = "select (select nombre from Usuario where IdUsuario = up.id_usuario) as 'NomUs',p.nombre as 'NomPermiso' from usuarios_permisos up inner join Permiso p on up.id_permiso = p.id";
            cmd.CommandText = sql;
            var reader = cmd.ExecuteReader();
            var lista = new List<Propiedades_BE.Usuario>();

            while (reader.Read())
            {
                var nombre_usuario = reader.GetString(reader.GetOrdinal("NomUs"));
                var nombre_permiso = reader.GetString(reader.GetOrdinal("NomPermiso"));

                Propiedades_BE.Usuario u = new Propiedades_BE.Usuario();

                u.Nombre = nombre_usuario;
                u.NombrePermiso = nombre_permiso;

                lista.Add(u);
            }
            reader.Close();
            cnn.Close();
            return lista;
        }

        public void GuardarPermiso(Propiedades_BE.Usuario U)
        {
            try
            {
                var cnn = new SqlConnection(Acceso.GlobalConexion);
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var sql = $@"delete from usuarios_permisos where id_usuario=@id;";

                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("id", U.IdUsuario));
                cmd.ExecuteNonQuery();

                foreach (var item in U.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    sql = $@"insert into usuarios_permisos (id_usuario,id_permiso) values (@id_usuario,@id_permiso) ";
                    
                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqlParameter("id_usuario", U.IdUsuario));
                    cmd.Parameters.Add(new SqlParameter("id_permiso", item.Id));

                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarPermisos(int IdUsuario, int IdPermiso)
        {
            try
            {
                var cnn = new SqlConnection(Acceso.GlobalConexion);
                cnn.Open();

                var cmd = new SqlCommand();

                cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = "delete from usuarios_permisos where id_usuario = @id_usuario and id_permiso = @id_permiso";
                cmd.Parameters.Add(new SqlParameter("id_usuario", IdUsuario));
                cmd.Parameters.Add(new SqlParameter("id_permiso", IdPermiso));

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region VerificacionBorrar

        public List<int> PatentesUsuario(Propiedades_BE.Usuario Usuario)
        {
            List<int> ListaPatentes = new List<int>();
            var Connection = new SqlConnection(Acceso.GlobalConexion);
            Connection.Open();

            var Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandText = "select p.* from usuarios_permisos up inner join Permiso p on up.id_permiso=p.id where id_usuario=@id;";
            Command.Parameters.AddWithValue("id", Usuario.IdUsuario);

            var reader = Command.ExecuteReader();
            while (reader.Read())
            {
                var IdPat = reader.GetInt32(reader.GetOrdinal("id"));
                var NombrePat = reader.GetString(reader.GetOrdinal("nombre"));

                var PermisoP = String.Empty;
                if (reader["permiso"] != DBNull.Value)
                {
                    PermisoP = reader.GetString(reader.GetOrdinal("permiso"));
                }

                Propiedades_BE.Componente c1;
                if (!String.IsNullOrEmpty(PermisoP))
                {
                    c1 = new Propiedades_BE.Patente();
                    c1.Id = IdPat;
                    c1.Nombre = NombrePat;
                    c1.Permiso = (Propiedades_BE.TipoPermiso)Enum.Parse(typeof(Propiedades_BE.TipoPermiso), PermisoP);
                    ListaPatentes.Add(c1.Id);
                }
                else
                {
                    c1 = new Propiedades_BE.Familia();
                    c1.Id = IdPat;
                    c1.Nombre = NombrePat;
                    Acceso_DAL.Permisos Permisos = new Acceso_DAL.Permisos();
                    var f = Permisos.GetAll("=" + IdPat);

                    foreach (var familia in f)
                    {
                        foreach (var pat in familia.Hijos)
                        {
                            ListaPatentes.Add(pat.Id);
                        }
                    }
                }
            }
            reader.Close();
            return ListaPatentes;
        }

        public int VerificarBorradoUsuario(int IdUsuario)
        {
            int i = 0;
            SqlConnection Connection = new SqlConnection(Acceso.GlobalConexion);
            Connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;

            Propiedades_BE.Usuario Us = new Propiedades_BE.Usuario();
            Us.IdUsuario = IdUsuario;

            foreach (int Patente in PatentesUsuario(Us).Distinct().ToList())
            {
                cmd.CommandText = "select * from usuarios_permisos where (id_usuario in (select IdUsuario from Usuario where BajaLogica != 1 and Estado != 1 and IdUsuario != " + IdUsuario + ") and id_permiso = " + Patente + ") OR (id_permiso in (select id_permiso_padre from permiso_permiso where id_permiso_hijo = " + Patente + ") and id_usuario in (select IdUsuario from Usuario where BajaLogica != 1 and Estado != 1 and IdUsuario != " + IdUsuario + "))";
                var QueryPatentes = cmd.ExecuteReader();
                if (QueryPatentes.Read())
                {
                    i += 0;
                }
                else
                {
                    i += 1;
                }
                QueryPatentes.Close();
            }
            Connection.Close();
            return i;
        }

        public int VerificarBorrarPatUs(int IdUsuario, int IdPatente)
        {
            int i = 0;
            SqlConnection Connection = new SqlConnection(Acceso.GlobalConexion);
            Connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = "select * from usuarios_permisos where (id_usuario in (select IdUsuario from Usuario where BajaLogica != 1 and Estado != 1 and id_usuario != " + IdUsuario + ") and id_permiso = " + IdPatente + ") OR (id_permiso in (select id_permiso_padre from permiso_permiso where id_permiso_hijo = " + IdPatente + ") and id_usuario in (select IdUsuario from Usuario where BajaLogica != 1 and Estado != 1))";
            var QueryChequeo = cmd.ExecuteReader();
            if (QueryChequeo.Read())
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }

        public int VerificarBorrarFamUs(int IdUsuario, int IdFamilia)
        {
            int i = 0;
            SqlConnection Connection = new SqlConnection(Acceso.GlobalConexion);
            Connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = "select id_permiso_hijo from permiso_permiso where id_permiso_padre = " + IdFamilia + " and id_permiso_hijo not in (select id from Permiso where permiso is null) union select id_permiso_hijo from permiso_permiso where id_permiso_padre in (select id_permiso_hijo from permiso_permiso where id_permiso_padre = " + IdFamilia + " and id_permiso_hijo in (select id from Permiso where permiso is null))";
            List<int> ListaPatentesFamilia = new List<int>();
            var QueryPatentes = cmd.ExecuteReader();
            while (QueryPatentes.Read())
            {
                ListaPatentesFamilia.Add(QueryPatentes.GetInt32(0));
            }
            QueryPatentes.Close();
            foreach (int Patente in ListaPatentesFamilia)
            {
                cmd.CommandText = "select * from usuarios_permisos where (id_usuario in (select IdUsuario from Usuario where BajaLogica != 1 and Estado != 1 and id_usuario != " + IdUsuario + ") and id_permiso = " + Patente + ") OR (id_permiso in (select id_permiso_padre from permiso_permiso where id_permiso_hijo = " + Patente + ") and id_usuario in (select IdUsuario from Usuario where BajaLogica != 1 and Estado != 1 and IdUsuario != " + IdUsuario + "))";
                var QueryVerificar = cmd.ExecuteReader();
                if (QueryVerificar.Read())
                {
                    i += 0;
                }
                else
                {
                    i += 1;
                }
                QueryVerificar.Close();
            }
            Connection.Close();
            return i;
        }

        #endregion
    }
}
