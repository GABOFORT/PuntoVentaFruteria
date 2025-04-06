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
    public class D_Productos
    {
        public List<Productos> Listar()
        {
            List<Productos> lista = new List<Productos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.productosID, p.codigos, p.nombresProductos, p.descripciones, p.categoriasID,");
                    query.AppendLine("c.nombresCategorias, p.esPorPeso, p.unidadMedida, p.preciosCompras, p.preciosVentas,");
                    query.AppendLine("p.precioPorUnidadMedida, p.estados");
                    query.AppendLine("FROM Productos p");
                    query.AppendLine("INNER JOIN Categorias c ON c.categoriasID = p.categoriasID");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Productos()
                            {
                                productosID = Convert.ToInt32(dr["productosID"]),
                                codigos = dr["codigos"].ToString(),
                                nombresProductos = dr["nombresProductos"].ToString(),
                                descripciones = dr["descripciones"].ToString(),
                                ocategorias = new Categorias() { categoriasID = Convert.ToInt32(dr["categoriasID"]), nombresCategorias = dr["nombresCategorias"].ToString() },
                                esPorPeso = Convert.ToBoolean(dr["esPorPeso"]),
                                unidadMedida = dr["unidadMedida"].ToString(),
                                preciosCompras = Convert.ToDecimal(dr["preciosCompras"].ToString()),
                                preciosVentas = Convert.ToDecimal(dr["preciosVentas"].ToString()),
                                precioPorUnidadMedida = Convert.ToDecimal(dr["precioPorUnidadMedida"].ToString()),
                                estados = Convert.ToBoolean(dr["estados"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Productos>();
                }
            }
            return lista;
        }
        public int Registrar(Productos obj, out string Mensaje)
        {
            int CategoriaIDGenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("REGISTRARPRODUCTOS", oconexion);
                    cmd.Parameters.AddWithValue("codigos", obj.codigos);
                    cmd.Parameters.AddWithValue("nombresProductos ", obj.nombresProductos);
                    cmd.Parameters.AddWithValue("descripciones", obj.descripciones);
                    cmd.Parameters.AddWithValue("categoriasID", obj.ocategorias.categoriasID);
                    cmd.Parameters.AddWithValue("esPorPeso", obj.esPorPeso);
                    cmd.Parameters.AddWithValue("unidadMedida", obj.unidadMedida);
                    cmd.Parameters.AddWithValue("preciosCompras", obj.preciosCompras);
                    cmd.Parameters.AddWithValue("preciosVentas", obj.preciosVentas);
                    cmd.Parameters.AddWithValue("precioPorUnidadMedida", obj.precioPorUnidadMedida);
                    cmd.Parameters.AddWithValue("estados", obj.estados);
                    cmd.Parameters.Add("Resultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    CategoriaIDGenerado = Convert.ToInt32(cmd.Parameters["Resultados"].Value);
                    Mensaje = cmd.Parameters["mensajes"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                CategoriaIDGenerado = 0;
                Mensaje = ex.Message;
            }
            return CategoriaIDGenerado;
        }
        public bool Editar(Productos obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("EDITARPRODUCTOS", oconexion);
                    cmd.Parameters.AddWithValue("productosID", obj.productosID);
                    cmd.Parameters.AddWithValue("codigos", obj.codigos);
                    cmd.Parameters.AddWithValue("nombresProductos", obj.nombresProductos);
                    cmd.Parameters.AddWithValue("descripciones", obj.descripciones);
                    cmd.Parameters.AddWithValue("categoriasID", obj.ocategorias.categoriasID);
                    cmd.Parameters.AddWithValue("esPorPeso", obj.esPorPeso);
                    cmd.Parameters.AddWithValue("unidadMedida", obj.unidadMedida);
                    cmd.Parameters.AddWithValue("preciosCompras", obj.preciosCompras);
                    cmd.Parameters.AddWithValue("preciosVentas", obj.preciosVentas);
                    cmd.Parameters.AddWithValue("precioPorUnidadMedida", obj.precioPorUnidadMedida);
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
        public bool Eliminar(Productos obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("ELIMINARPRODUCTOS", oconexion);
                    cmd.Parameters.AddWithValue("productosID", obj.productosID);
                    cmd.Parameters.Add("Respuestas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuestas"].Value);
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
