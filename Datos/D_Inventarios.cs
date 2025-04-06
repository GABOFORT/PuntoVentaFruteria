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
                    query.AppendLine("SELECT p.productosID, p.nombresProductos, p.descripciones, p.esPorPeso, p.unidadMedida,");
                    query.AppendLine("i.inventariosID, i.stockActual, i.stockMinimo, i.fechaActualizacion");
                    query.AppendLine("FROM Productos p");
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
                                    descripciones = dr["descripciones"].ToString(),
                                    esPorPeso = Convert.ToBoolean(dr["esPorPeso"]),
                                    unidadMedida = dr["unidadMedida"].ToString()
                                },
                                stockActual = Convert.ToDecimal(dr["stockActual"]),
                                stockMinimo = Convert.ToDecimal(dr["stockMinimo"]),
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
        public bool Insertar(Inventarios inventario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string queryVerificar = "SELECT COUNT(1) FROM Inventarios WHERE productosID = @productosID";
                    SqlCommand cmdVerificar = new SqlCommand(queryVerificar, oconexion);
                    cmdVerificar.Parameters.AddWithValue("@productosID", inventario.oProductosID.productosID);
                    oconexion.Open();
                    int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                    if (existe > 0)
                    {
                        mensaje = "Este producto ya está registrado en el inventario";
                        return false;
                    }
                    string queryInsert = @"INSERT INTO Inventarios (productosID, stockActual, stockMinimo, fechaActualizacion) 
                                           VALUES (@productosID, @stockActual, @stockMinimo, @fechaActualizacion)";
                    SqlCommand cmdInsert = new SqlCommand(queryInsert, oconexion);
                    cmdInsert.Parameters.AddWithValue("@productosID", inventario.oProductosID.productosID);
                    cmdInsert.Parameters.AddWithValue("@stockActual", inventario.stockActual);
                    cmdInsert.Parameters.AddWithValue("@stockMinimo", inventario.stockMinimo);
                    cmdInsert.Parameters.AddWithValue("@fechaActualizacion", inventario.fechaActualizacion);
                    int filasAfectadas = cmdInsert.ExecuteNonQuery();
                    respuesta = filasAfectadas > 0;

                    if (respuesta)
                        mensaje = "Producto agregado al inventario correctamente";
                    else
                        mensaje = "No se pudo agregar el producto al inventario";
                }
                catch (Exception ex)
                {
                    mensaje = "Error al insertar en Inventarios: " + ex.Message;
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
