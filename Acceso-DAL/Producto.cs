﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_DAL
{
    public class Producto
    {
        Acceso_BD Acceso = new Acceso_BD();

        public void EjecutarConsulta(string Consulta)
        {
            Acceso.AbrirConexion();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Acceso.Conexion;
            Cmd.CommandText = Consulta;
            Cmd.ExecuteNonQuery();
            Acceso.CerrarConexion();
        }

        public int SeleccionarIdArticulo(int CodProd)
        {
            int ID = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select IdArticulo from Articulo where CodProd = " + CodProd + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            ID = Lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return ID;
        }

        public int SeleccionarCodArticulo(string DescripcionProducto)
        {
            int Cod = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select CodProd from Articulo where Descripcion = '" + DescripcionProducto + "'";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Cod = Lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Cod;
        }

        public string SeleccionarNombreArt(int CodProd)
        {
            string Descripcion = "";
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select Descripcion from Articulo where CodProd = " + CodProd + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Descripcion = Lector.GetString(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Descripcion;
        }

        public int VerificarCantStock(int CodProd)
        {
            int Cant = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select Stock from Articulo where CodProd = " + CodProd + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Cant = Lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Cant;
        }

        public decimal SeleccionPUnit(int CodProd)
        {
            decimal PUnit = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select PUnit from Articulo where CodProd = " + CodProd + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            PUnit = decimal.Parse(Lector.GetValue(0).ToString());
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return PUnit;
        }

        public List<string> CodProdArticulo()
        {
            List<string> CodProd = new List<string>();
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select CodProd from Articulo";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            CodProd.Add(Lector.GetInt32(0).ToString());
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return CodProd;
        }

        public List<string> DescripcionProd()
        {
            List<string> DescProd = new List<string>();
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string query = "Select Descripcion From Articulo";
                using (SqlCommand cmd = new SqlCommand(query, Acceso.Conexion))
                {
                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            DescProd.Add(lector.GetString(0));
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return DescProd;
        }

        public int SeleccionarStock(int CodProd)
        {
            int Stock = 0;
            using (Acceso.Conexion)
            {
                Acceso.AbrirConexion();
                string Query = "select Stock from Articulo where CodProd = " + CodProd + "";
                using (SqlCommand Cmd = new SqlCommand(Query, Acceso.Conexion))
                {
                    using (SqlDataReader Lector = Cmd.ExecuteReader())
                    {
                        while (Lector.Read())
                        {
                            Stock = Lector.GetInt32(0);
                        }
                    }
                }
                Acceso.CerrarConexion();
            }
            return Stock;
        }

        public List<Propiedades_BE.Articulo> Listar()
        {
            List<Propiedades_BE.Articulo> ListarArticulo = new List<Propiedades_BE.Articulo>();
            DataTable Tabla = Acceso.Leer("ListarArticulo", null);

            foreach (DataRow R in Tabla.Rows)
            {
                Propiedades_BE.Articulo A = new Propiedades_BE.Articulo();
                A.IdArticulo = int.Parse(R["IdArticulo"].ToString());
                A.CodProd = int.Parse(R["CodProd"].ToString());
                A.Nombre = (R["Nombre"].ToString());
                A.Descripcion = (R["Descripcion"].ToString());
                A.Material = (R["Material"].ToString());
                A.Talle = int.Parse(R["Talle"].ToString());
                A.NombreLocalidad = (R["NombreLocalidad"].ToString());
                A.Stock = int.Parse(R["Stock"].ToString());
                A.PUnit = decimal.Parse(R["PUnit"].ToString());
                A.BajaLogica = bool.Parse(R["BajaLogica"].ToString());
                ListarArticulo.Add(A);
            }
            return ListarArticulo;
        }

        public int Alta(Propiedades_BE.Articulo A)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[9];
            P[0] = new SqlParameter("@IdArticulo", A.IdArticulo);
            P[1] = new SqlParameter("@IdLocalidad", A.IdLocalidad);
            P[2] = new SqlParameter("@CodProd", A.CodProd);
            P[3] = new SqlParameter("@Nombre", A.Nombre);
            P[4] = new SqlParameter("@Descripcion", A.Descripcion);
            P[5] = new SqlParameter("@Material", A.Material);
            P[6] = new SqlParameter("@Talle", A.Talle);
            P[7] = new SqlParameter("@Stock", A.Stock);
            P[8] = new SqlParameter("@PUnit", A.PUnit);
            fa = Acceso.Escribir("AltaArticulo", P);
            return fa;
        }

        public int Modificar(Propiedades_BE.Articulo A)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[8];
            P[0] = new SqlParameter("@IdArticulo", A.IdArticulo);
            P[1] = new SqlParameter("@IdLocalidad", A.IdLocalidad);
            P[2] = new SqlParameter("@CodProd", A.CodProd);
            P[3] = new SqlParameter("@Nombre", A.Nombre);
            P[4] = new SqlParameter("@Descripcion", A.Descripcion);
            P[5] = new SqlParameter("@Material", A.Material);
            P[6] = new SqlParameter("@Talle", A.Talle);
            P[7] = new SqlParameter("@PUnit", A.PUnit);
            fa = Acceso.Escribir("ModificarArticulo", P);
            return fa;
        }

        public int Baja(Propiedades_BE.Articulo A)
        {
            int fa = 0;
            SqlParameter[] P = new SqlParameter[1];
            P[0] = new SqlParameter("@IdArticulo", A.IdArticulo);
            fa = Acceso.Escribir("BajaArticulo", P);
            return fa;
        }

    }
}
