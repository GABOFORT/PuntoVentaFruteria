using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class D_Inventarios
    {
        public List<Inventarios> Listar()
        {
            List<Inventarios> lista = new List<Inventarios>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.productosID, p.nombresProductos, p.descripciones, i.inventariosID, i.stockActual, i.stockMinimo, i.fechaActualizacion FROM Productos p");
                    query.AppendLine("JOIN Inventarios i ON p.productosID = i.productosID");
                    query.AppendLine("ORDER BY i.stockActual ASC");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Inventarios()
                            {
                                inventariosID = Convert.ToInt32(dr["inventariosID"]),
                                oProductosID = new Productos()
                                {
                                    productosID = Convert.ToInt32(dr["productosID"]),
                                    nombresProductos = dr["nombresProductos"].ToString(),
                                    descripciones = dr["descripciones"].ToString()
                                },
                                stockActual = Convert.ToInt32(dr["stockActual"]),
                                stockMinimo = Convert.ToInt32(dr["stockMinimo"]),
                                fechaActualizacion = Convert.ToDateTime(dr["fechaActualizacion"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Inventarios>();
                }
            }
            return lista;
        }
        public bool Insertar(Inventarios inventario)
        {
            bool respuesta = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO Inventarios (productosID, stockActual, stockMinimo, fechaActualizacion) " + "VALUES (@productosID, @stockActual, @stockMinimo, @fechaActualizacion)";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@productosID", inventario.oProductosID.productosID);
                    cmd.Parameters.AddWithValue("@stockActual", inventario.stockActual);
                    cmd.Parameters.AddWithValue("@stockMinimo", inventario.stockMinimo);
                    cmd.Parameters.AddWithValue("@fechaActualizacion", inventario.fechaActualizacion);
                    oconexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        respuesta = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar en Inventarios: " + ex.Message);
                }
            }
            return respuesta;
        }
        public bool Eliminar(int inventarioID)
        {
            bool respuesta = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM Inventarios WHERE inventariosID = @inventariosID";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@inventariosID", inventarioID);
                    oconexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                        respuesta = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el inventario: " + ex.Message);
                }
            }
            return respuesta;
        }
    }
}
