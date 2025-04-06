using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Entidades;

namespace Datos
{
    public class D_Gastos
    {
        public List<Gastos> Listar()
        {
            List<Gastos> lista = new List<Gastos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT g.gastosID, g.usuariosID, u.nombresUsuarios, g.concepto, g.montosTotales, g.fechaRegistros");
                    query.AppendLine("FROM Gastos g");
                    query.AppendLine("INNER JOIN Usuarios u ON g.usuariosID = u.usuariosID"); 
                    query.AppendLine("ORDER BY g.fechaRegistros DESC");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Gastos()
                            {
                                gastosID = Convert.ToInt32(dr["gastosID"]),
                                oUsuarios = new Usuarios()
                                {
                                    usuariosID = Convert.ToInt32(dr["usuariosID"]),
                                    nombresUsuarios = dr["nombresUsuarios"].ToString(),
                                },
                                concepto = dr["concepto"].ToString(),
                                montosTotales = Convert.ToDecimal(dr["montosTotales"].ToString()),
                                fechaRegistros = Convert.ToDateTime(dr["fechaRegistros"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Gastos>();
                }
            }
            return lista;
        }
        public int GuardarGastos(Gastos obj, out string Mensaje)
        {
            int gastosIDGenerados = 0; 
            Mensaje = string.Empty;    
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("GUARDARGASTOS", oconexion);
                    cmd.Parameters.AddWithValue("@usuariosID", obj.oUsuarios.usuariosID);
                    cmd.Parameters.AddWithValue("@concepto", obj.concepto);
                    cmd.Parameters.AddWithValue("@montosTotales", obj.montosTotales);
                    cmd.Parameters.AddWithValue("@fechaRegistros", obj.fechaRegistros);
                    cmd.Parameters.Add("@gastosIDResultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensajes", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output; cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    gastosIDGenerados = Convert.ToInt32(cmd.Parameters["@gastosIDResultados"].Value);
                    Mensaje = cmd.Parameters["@mensajes"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                gastosIDGenerados = 0;
                Mensaje = "Error al guardar el gasto: " + ex.Message;
            }
            return gastosIDGenerados; 
        }
        public bool EditarGastos(Gastos obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("EDITARGASTOS", oconexion);
                    cmd.Parameters.AddWithValue("@gastosID", obj.gastosID);
                    cmd.Parameters.AddWithValue("@usuariosID", obj.oUsuarios.usuariosID);
                    cmd.Parameters.AddWithValue("@concepto", obj.concepto);
                    cmd.Parameters.AddWithValue("@montosTotales", obj.montosTotales);
                    cmd.Parameters.AddWithValue("@fechaRegistros", obj.fechaRegistros);
                    cmd.Parameters.Add("@Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output; cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Respuesta"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Mensaje = "Error al editar el gasto: " + ex.Message;
                Respuesta = false;
            }
            return Respuesta;
        }
        public bool EliminarGastos(Gastos obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            bool resultado = false;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("ELIMINARGASTOS", oconexion);
                    cmd.Parameters.AddWithValue("@gastosID", obj.gastosID);
                    cmd.Parameters.Add("@Resultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensajes", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output; cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultados"].Value);
                    Mensaje = cmd.Parameters["@Mensajes"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Mensaje = "Error al eliminar el gasto: " + ex.Message;
                resultado = false;
            }
            return resultado;
        }
        public List<Gastos> ReporteGastos(string fechaInicio, string fechaFin)
        {
            List<Gastos> lista = new List<Gastos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("REPORTESGASTOS", oconexion);
                    cmd.Parameters.AddWithValue("FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechaFin);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Gastos()
                            {
                                gastosID = Convert.ToInt32(dr["gastosID"]),
                                oUsuarios = new Usuarios()
                                {
                                    usuariosID = Convert.ToInt32(dr["usuariosID"]),
                                    nombresUsuarios = dr["nombresUsuarios"].ToString(),
                                },
                                concepto = dr["concepto"].ToString(),
                                montosTotales = Convert.ToDecimal(dr["montosTotales"].ToString()),
                                fechaRegistros = Convert.ToDateTime(dr["fechaRegistros"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Gastos>();
                    Console.WriteLine("Error en ReporteGastos: " + ex.Message);
                }
            }
            return lista;
        }
    }
}
         