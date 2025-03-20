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
                    query.AppendLine("SELECT ");
                    query.AppendLine("u.nombresUsuarios AS Usuario,");
                    query.AppendLine("CAST(g.fechaRegistros AS DATE) AS Fecha,");
                    query.AppendLine("dg.concepto AS Concepto,");
                    query.AppendLine("SUM(dg.montosTotales) AS TotalPorConcepto,");
                    query.AppendLine("(SELECT SUM(dg2.montosTotales) ");
                    query.AppendLine("FROM DetallesGastos dg2 ");
                    query.AppendLine("INNER JOIN Gastos g2 ON dg2.gastosID = g2.gastosID");
                    query.AppendLine("WHERE CAST(g2.fechaRegistros AS DATE) = CAST(g.fechaRegistros AS DATE) ");
                    query.AppendLine("AND g2.usuariosID = g.usuariosID) AS TotalDia");
                    query.AppendLine("FROM DetallesGastos dg");
                    query.AppendLine("INNER JOIN Gastos g ON dg.gastosID = g.gastosID");
                    query.AppendLine("INNER JOIN Usuarios u ON g.usuariosID = u.usuariosID");
                    query.AppendLine("GROUP BY u.nombresUsuarios, CAST(g.fechaRegistros AS DATE), dg.concepto, g.usuariosID");
                    query.AppendLine("ORDER BY Fecha, Usuario, Concepto;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Gastos()
                            {
                                Usuario = dr["Usuario"].ToString(),
                                Fecha = Convert.ToDateTime(dr["Fecha"]),
                                Concepto = dr["Concepto"].ToString(),
                                TotalPorConcepto = Convert.ToDecimal(dr["TotalPorConcepto"]),
                                TotalDia = Convert.ToDecimal(dr["TotalDia"])
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
    }
}
