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
    public class D_Reportes
    {
        public List<ReportesCompras> Compras(string fechainicio, string fechafin, int proveedoresID)
        {
            List<ReportesCompras> lista = new List<ReportesCompras>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("REPORTESCOMPRAS", oconexion);
                    cmd.Parameters.AddWithValue("FechaIncio", fechainicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechafin);
                    cmd.Parameters.AddWithValue("proveedoresID", proveedoresID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReportesCompras()
                            {
                                FechaRegistros = dr["FechaRegistros"].ToString(),
                                numerosCompras = dr["numerosCompras"].ToString(),
                                montosTotales = Convert.ToInt32(dr["montosTotales"]),
                                UsuariosRegistros = dr["UsuariosRegistros"].ToString(),
                                clavesProveedores = dr["clavesProveedores"].ToString(),
                                nombresProveedores = dr["nombresProveedores"].ToString(),
                                CodigosProductos = dr["CodigosProductos"].ToString(),
                                NombresProductos = dr["NombresProductos"].ToString(),
                                Descripciones = dr["Descripciones"].ToString(),
                                NombresCategorias = dr["NombresCategorias"].ToString(),
                                preciosCompras = Convert.ToInt32(dr["preciosCompras"]),
                                preciosVentas = Convert.ToInt32(dr["preciosVentas"]),
                                cantidades = Convert.ToInt32(dr["cantidades"]),
                                peso = Convert.ToDecimal(dr["peso"]),
                                esPorPeso = Convert.ToBoolean(dr["esPorPeso"]),
                                unidadMedida = dr["unidadMedida"].ToString(),
                                SubTotales = Convert.ToDecimal(dr["SubTotales"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReportesCompras>();
                }
            }
            return lista;
        }
        public List<ReportesVentas> Ventas(string fechainicio, string fechafin)
        {
            List<ReportesVentas> lista = new List<ReportesVentas>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cmd = new SqlCommand("REPORTESVENTAS", oconexion);
                    cmd.Parameters.AddWithValue("FechaIncio", fechainicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReportesVentas()
                            {
                                FechaRegistros = dr["FechaRegistros"].ToString(),
                                numerosVentas = dr["numerosVentas"].ToString(),
                                montosTotales = Convert.ToInt32(dr["montosTotales"]),
                                UsuariosRegistros = dr["UsuariosRegistros"].ToString(),
                                CodigosProductos = dr["CodigosProductos"].ToString(),
                                NombresProductos = dr["NombresProductos"].ToString(),
                                Descripciones = dr["Descripciones"].ToString(),
                                NombresCategorias = dr["NombresCategorias"].ToString(),
                                preciosVentas = Convert.ToInt32(dr["preciosVentas"]),
                                cantidades = Convert.ToInt32(dr["cantidades"]),
                                peso = Convert.ToDecimal(dr["peso"]),
                                precioPorUnidadMedida = Convert.ToDecimal(dr["precioPorUnidadMedida"]),
                                esPorPeso = Convert.ToBoolean(dr["esPorPeso"]),
                                unidadMedida = dr["unidadMedida"].ToString(),
                                SubTotales = Convert.ToDecimal(dr["subTotales"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ReportesVentas>();
                }
            }
            return lista;
        }
        public List<ProductosDesplazados> ProductosMasVendidosPorFechas(string fechaInicio, string fechaFin)
        {
            List<ProductosDesplazados> lista = new List<ProductosDesplazados>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PRODUCTOSMASVENDIDOSPORFECHAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechaFin);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ProductosDesplazados()
                            {
                                ProductosID = Convert.ToInt32(dr["productosID"]),
                                nombresProductos = dr["nombresProductos"].ToString(),
                                descripciones = dr["descripciones"].ToString(),
                                totalVendido = Convert.ToInt32(dr["totalVendido"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ProductosDesplazados>();
                }
            }
            return lista;
        }
        public List<ProductosDesplazados> ObtenerProductosMasVendidos()
        {
            List<ProductosDesplazados> listaProductosDesplazados = new List<ProductosDesplazados>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string consulta = @" SELECT dv.productosID, p.nombresProductos, p.descripciones, SUM(dv.cantidades) AS totalVendido FROM DetallesVentas dv INNER JOIN Ventas v ON dv.ventasID = v.ventasID
                INNER JOIN Productos p ON dv.productosID = p.productosID GROUP BY dv.productosID, p.nombresProductos, p.descripciones ORDER BY totalVendido DESC;";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaProductosDesplazados.Add(new ProductosDesplazados
                    {
                        ProductosID = Convert.ToInt32(reader["productosID"]),
                        nombresProductos = reader["nombresProductos"].ToString(),
                        descripciones = reader["descripciones"].ToString(),
                        totalVendido = Convert.ToInt32(reader["totalVendido"])
                    });
                }
            }
            return listaProductosDesplazados;
        }
        public List<ProductosComprados> ObtenerProductosMasComprados()
        {
            List<ProductosComprados> listaProductosDesplazados = new List<ProductosComprados>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string consulta = @" SELECT dc.productosID, p.nombresProductos, p.descripciones, SUM(dc.cantidades) AS totalComprado, SUM(dc.cantidades * dc.preciosCompras) AS totalCosto FROM DetallesCompras dc 
                INNER JOIN Compras c ON dc.comprasID = c.comprasID INNER JOIN Productos p ON dc.productosID = p.productosID GROUP BY dc.productosID, p.nombresProductos, p.descripciones ORDER BY totalComprado DESC;";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaProductosDesplazados.Add(new ProductosComprados
                    {
                        ProductosID = Convert.ToInt32(reader["productosID"]),
                        nombresProductos = reader["nombresProductos"].ToString(),
                        descripciones = reader["descripciones"].ToString(),
                        totalComprado = Convert.ToInt32(reader["totalComprado"]), 
                        totalCosto = Convert.ToDecimal(reader["totalCosto"])    
                    });
                }
            }
            return listaProductosDesplazados;
        }
        public List<ProductosComprados> ProductosMasCompradosPorFechas(string fechaInicio, string fechaFin)
        {
            List<ProductosComprados> lista = new List<ProductosComprados>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PRODUCTOSMASCOMPRADOSPORFECHAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("FechaFin", fechaFin);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ProductosComprados()
                            {
                                ProductosID = Convert.ToInt32(dr["productosID"]),
                                nombresProductos = dr["nombresProductos"].ToString(),
                                descripciones = dr["descripciones"].ToString(),
                                totalComprado = Convert.ToInt32(dr["totalComprado"]),
                                totalCosto = Convert.ToDecimal(dr["totalCosto"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ProductosComprados>();
                }
            }
            return lista;
        }
        }
}
