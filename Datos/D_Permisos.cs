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
    public class D_Permisos
    {
        public List<Permisos> Listar(int usuariosID)
        {
            List<Permisos> lista = new List<Permisos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.rolesID,p.nombresPermisos from permisos p");
                    query.AppendLine("inner join Roles r on r.rolesID = p.rolesID");
                    query.AppendLine("inner join Usuarios u on u.rolesID = r.rolesID");
                    query.AppendLine("where u.usuariosID = @usuariosID");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@usuariosID", usuariosID);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permisos()
                            {
                                oRoles = new Roles() { rolesID = Convert.ToInt32(dr["rolesID"]) },
                                nombresPermisos = dr["nombresPermisos"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permisos>();
                }
            }
            return lista;
        }
    }
}
