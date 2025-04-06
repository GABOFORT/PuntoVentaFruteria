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
    public class D_Ventas
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Ventas");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }
        public bool Registrar(Ventas obj, DataTable DetallesVentas, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("REGISTRARVENTAS", oconexion);
                    cmd.Parameters.AddWithValue("usuariosID", obj.oUsuarios.usuariosID);
                    cmd.Parameters.AddWithValue("numerosVentas", obj.numerosVentas);
                    cmd.Parameters.AddWithValue("montosPagos", obj.montosPagos);
                    cmd.Parameters.AddWithValue("montosCambios", obj.montosCambios);
                    cmd.Parameters.AddWithValue("montosTotales ", obj.montosTotales);
                    cmd.Parameters.AddWithValue("DetallesVentas", DetallesVentas);
                    cmd.Parameters.Add("Resultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultados"].Value);
                    Mensaje = cmd.Parameters["mensajes"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }
        public Ventas ObtenerVenta(string numeros)
        {
            Ventas obj = new Ventas();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select v.ventasID,u.nombresUsuarios,");
                    query.AppendLine("v.numerosVentas,");
                    query.AppendLine("v.montosPagos, v.montosCambios, v.montosTotales,");
                    query.AppendLine("convert(char(10),v.fechaRegistros,103)[FechaRegistros]");
                    query.AppendLine("from Ventas v");
                    query.AppendLine("inner join Usuarios u on u.usuariosID = v.usuariosID");
                    query.AppendLine("where v.numerosVentas = @numeros");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numeros", numeros);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Ventas()
                            {
                                ventasID = int.Parse(dr["ventasID"].ToString()),
                                oUsuarios = new Usuarios() { nombresUsuarios = dr["nombresUsuarios"].ToString() },
                                numerosVentas = dr["numerosVentas"].ToString(),
                                montosPagos = Convert.ToDecimal(dr["montosPagos"].ToString()),
                                montosCambios = Convert.ToDecimal(dr["montosCambios"].ToString()),
                                montosTotales = Convert.ToDecimal(dr["montosTotales"].ToString()),
                                fechaRegistros = dr["fechaRegistros"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj = new Ventas();
                }
            }
            return obj;
        }
        public List<DetallesVentas> ObtenerDetalleVenta(int ventasID)
        {
            List<DetallesVentas> oLista = new List<DetallesVentas>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.nombresProductos, p.descripciones, dv.preciosVentas, dv.cantidades,");
                    query.AppendLine("dv.peso, dv.precioReal, p.esPorPeso, p.unidadMedida, dv.subTotales");
                    query.AppendLine("FROM DetallesVentas dv");
                    query.AppendLine("INNER JOIN Productos p ON p.productosID = dv.productosID");
                    query.AppendLine("WHERE dv.ventasID = @ventasID");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@ventasID", ventasID);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetallesVentas()
                            {
                                oProductos = new Productos()
                                {
                                    nombresProductos = dr["nombresProductos"].ToString(),
                                    descripciones = dr["descripciones"].ToString(),
                                    esPorPeso = Convert.ToBoolean(dr["esPorPeso"]),
                                    unidadMedida = dr["unidadMedida"].ToString()
                                    
                                },
                                preciosVentas = Convert.ToDecimal(dr["preciosVentas"].ToString()),
                                cantidades = Convert.ToInt32(dr["cantidades"].ToString()),
                                peso = dr["peso"] != DBNull.Value ? Convert.ToDecimal(dr["peso"]) : 0,
                                precioReal = dr["precioReal"] != DBNull.Value ? Convert.ToDecimal(dr["precioReal"]) : 0,
                                subTotales = Convert.ToDecimal(dr["subTotales"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<DetallesVentas>();
            }
            return oLista;
        }
        public Dictionary<int, Tuple<decimal, string>> ObtenerVentasPorDia()
        {
            Dictionary<int, Tuple<decimal, string>> ventasConHora = new Dictionary<int, Tuple<decimal, string>>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT numerosVentas, montosTotales, fechaRegistros FROM Ventas ORDER BY fechaRegistros DESC";  
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string numeroVenta = Convert.ToInt32(dr["numerosVentas"]).ToString("D5"); 
                            decimal montoTotal = Convert.ToDecimal(dr["montosTotales"]);  
                            string fechaHora = Convert.ToDateTime(dr["fechaRegistros"]).ToString("yyyy-MM-dd HH:mm:ss"); 
                            ventasConHora.Add(Convert.ToInt32(numeroVenta), new Tuple<decimal, string>(montoTotal, fechaHora)); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    ventasConHora = new Dictionary<int, Tuple<decimal, string>>();
                }
            }
            return ventasConHora;
        }
    }
}
