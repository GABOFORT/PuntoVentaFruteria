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
    public class D_Compras
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Compras");
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
        public bool Registrar(Compras obj, DataTable DetallesCompras, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("REGISTRARCOMPRAS", oconexion);
                    cmd.Parameters.AddWithValue("usuariosID", obj.oUsuarios.usuariosID);
                    cmd.Parameters.AddWithValue("proveedoresID", obj.oProveedores.proveedoresID);
                    cmd.Parameters.AddWithValue("numerosCompras", obj.numerosCompras);
                    cmd.Parameters.AddWithValue("montosTotales", obj.montosTotales);
                    cmd.Parameters.AddWithValue("DetallesCompras", DetallesCompras);
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
        public Compras ObtenerCompra(string numeros)
        {
            Compras obj = new Compras();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.comprasID,");
                    query.AppendLine("u.nombresUsuarios,");
                    query.AppendLine("pr.clavesProveedores, pr.nombresProveedores,");
                    query.AppendLine("c.numerosCompras,c.montosTotales,convert(char(10),c.fechaRegistros,103)[FechaRegistros]");
                    query.AppendLine("from Compras c");
                    query.AppendLine("inner join Usuarios u on u.usuariosID = c.usuariosID");
                    query.AppendLine("inner join Proveedores pr on pr.proveedoresID = c.proveedoresID");
                    query.AppendLine("where c.numerosCompras = @numeros");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numeros", numeros);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    { 
                        while (dr.Read())
                        {
                            obj = new Compras()
                            {
                                comprasID = Convert.ToInt32(dr["comprasID"]),
                                oUsuarios = new Usuarios() { nombresUsuarios = dr["nombresUsuarios"].ToString() },
                                oProveedores = new Proveedores() { clavesProveedores = dr["clavesProveedores"].ToString(), nombresProveedores = dr["nombresProveedores"].ToString() },
                                numerosCompras = dr["numerosCompras"].ToString(),
                                montosTotales = Convert.ToDecimal(dr["montosTotales"].ToString()),
                                fechaRegistros = dr["FechaRegistros"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    obj = new Compras();
                }
            }
            return obj;
        }
        public List<DetallesCompras> ObtenerDetalleCompra(int comprasID)
        {
            List<DetallesCompras> oLista = new List<DetallesCompras>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.nombresProductos, p.descripciones, p.unidadMedida, p.esPorPeso,");
                    query.AppendLine("dc.preciosCompras, dc.preciosVentas, dc.cantidades, dc.peso, dc.montosTotales");
                    query.AppendLine("FROM DetallesCompras dc");
                    query.AppendLine("INNER JOIN Productos p ON p.productosID = dc.productosID");
                    query.AppendLine("WHERE dc.comprasID = @comprasID");
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@comprasID", comprasID);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetallesCompras()
                            {
                                oProductos = new Productos()
                                {
                                    nombresProductos = dr["nombresProductos"].ToString(),
                                    descripciones = dr["descripciones"].ToString(),
                                    unidadMedida = dr["unidadMedida"].ToString(),
                                    esPorPeso = Convert.ToBoolean(dr["esPorPeso"])
                                },
                                preciosCompras = Convert.ToDecimal(dr["preciosCompras"].ToString()),
                                preciosVentas = Convert.ToDecimal(dr["preciosVentas"].ToString()),
                                cantidades = Convert.ToInt32(dr["cantidades"].ToString()),
                                peso = Convert.ToDecimal(dr["peso"]),
                                montosTotales = Convert.ToDecimal(dr["montosTotales"].ToString()),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<DetallesCompras>();
            }
            return oLista;
        }
        public Dictionary<int, Tuple<decimal, string>> ObtenerComprasPorDia()
        {
            Dictionary<int, Tuple<decimal, string>> ComprasConHora = new Dictionary<int, Tuple<decimal, string>>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"SELECT numerosCompras, montosTotales, fechaRegistros FROM Compras ORDER BY fechaRegistros DESC";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int numeroCompra = Convert.ToInt32(dr["numerosCompras"]);
                            decimal montoTotal = Convert.ToDecimal(dr["montosTotales"]);
                            string fechaHora = Convert.ToDateTime(dr["fechaRegistros"]).ToString("yyyy-MM-dd HH:mm:ss");
                            ComprasConHora.Add(numeroCompra, new Tuple<decimal, string>(montoTotal, fechaHora));
                        }
                    }
                }
                catch (Exception ex)
                {
                    ComprasConHora = new Dictionary<int, Tuple<decimal, string>>();
                }
            }
            return ComprasConHora;
        }
    }
}
