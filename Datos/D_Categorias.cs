using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Categorias
    {
            public List<Categorias> Listar()
            {
                List<Categorias> lista = new List<Categorias>();
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    {
                        StringBuilder query = new StringBuilder();
                        query.AppendLine("select categoriasID,nombresCategorias,estados from Categorias");
                        SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                        cmd.CommandType = CommandType.Text;
                        oconexion.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Categorias()
                                {
                                    categoriasID = Convert.ToInt32(dr["categoriasID"]),
                                    nombresCategorias = dr["nombresCategorias"].ToString(),
                                    estados = Convert.ToBoolean(dr["estados"])
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        lista = new List<Categorias>();
                    }
                }
                return lista;
            }
            public int Registrar(Categorias obj, out string Mensaje)
            {
                int CategoriasIDGenerados = 0;
                Mensaje = string.Empty;
                try
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        SqlCommand cmd = new SqlCommand("REGISTRARCATEGORIAS", oconexion);
                        cmd.Parameters.AddWithValue("descripciones", obj.nombresCategorias);
                        cmd.Parameters.AddWithValue("estados", obj.estados);
                        cmd.Parameters.Add("Resultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;
                        oconexion.Open();
                        cmd.ExecuteNonQuery();
                        CategoriasIDGenerados = Convert.ToInt32(cmd.Parameters["Resultados"].Value);
                        Mensaje = cmd.Parameters["mensajes"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    CategoriasIDGenerados = 0;
                    Mensaje = ex.Message;
                }
                return CategoriasIDGenerados;
            }
            public bool Editar(Categorias obj, out string Mensaje)
            {
                bool Respuesta = false;
                Mensaje = string.Empty;
                try
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        SqlCommand cmd = new SqlCommand("EDITARCATEGORIAS", oconexion);
                        cmd.Parameters.AddWithValue("categoriasID", obj.categoriasID);
                        cmd.Parameters.AddWithValue("descripciones", obj.nombresCategorias);
                        cmd.Parameters.AddWithValue("estados", obj.estados);
                        cmd.Parameters.Add("Resultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;
                        oconexion.Open();
                        cmd.ExecuteNonQuery();
                        Respuesta = Convert.ToBoolean(cmd.Parameters["Resultados"].Value);
                        Mensaje = cmd.Parameters["mensajes"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
                return Respuesta;
            }
            public bool Eliminar(Categorias obj, out string Mensaje)
            {
                bool Respuesta = false;
                Mensaje = string.Empty;
                try
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {
                        SqlCommand cmd = new SqlCommand("ELIMINARCATEGORIAS", oconexion);
                        cmd.Parameters.AddWithValue("CategoriasID", obj.categoriasID);
                        cmd.Parameters.Add("Resultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;
                        oconexion.Open();
                        cmd.ExecuteNonQuery();
                        Respuesta = Convert.ToBoolean(cmd.Parameters["Resultados"].Value);
                        Mensaje = cmd.Parameters["mensajes"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
                return Respuesta;
            }
     }
}
//hola