using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class D_Usuarios
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.usuariosID,u.nombresUsuarios,u.contraseñas,u.estados,r.rolesID,r.nombresRoles from Usuarios u");
                    query.AppendLine("inner join roles r on r.rolesID = u.rolesID");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuarios()
                            {
                                usuariosID = Convert.ToInt32(dr["usuariosID"]),
                                nombresUsuarios = dr["nombresUsuarios"].ToString(),
                                contraseñas = dr["contraseñas"].ToString(),
                                estados = Convert.ToBoolean(dr["Estados"]),
                                oRoles = new Roles() { rolesID = Convert.ToInt32(dr["rolesID"]), nombresRoles = dr["nombresRoles"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuarios>();
                }
            }
            return lista;
        }
        public int Registrar(Usuarios obj, out string Mensaje)
        {
            int usuariosIDGenerados = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("REGISTRARUSUARIOS", oconexion);
                    cmd.Parameters.AddWithValue("nombresUsuarios ", obj.nombresUsuarios);
                    cmd.Parameters.AddWithValue("contraseñas", obj.contraseñas);
                    cmd.Parameters.AddWithValue("rolesID", obj.oRoles.rolesID);
                    cmd.Parameters.AddWithValue("estados", obj.estados);
                    cmd.Parameters.Add("usuariosIDResultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    usuariosIDGenerados = Convert.ToInt32(cmd.Parameters["usuariosIDResultados"].Value);
                    Mensaje = cmd.Parameters["mensajes"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                usuariosIDGenerados = 0;
                Mensaje = ex.Message;
            }
            return usuariosIDGenerados;
        }
        public bool Editar(Usuarios obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("EDITARUSUARIOS", oconexion);
                    cmd.Parameters.AddWithValue("usuariosID", obj.usuariosID);
                    cmd.Parameters.AddWithValue("nombresUsuarios", obj.nombresUsuarios);
                    cmd.Parameters.AddWithValue("contraseñas", obj.contraseñas);
                    cmd.Parameters.AddWithValue("rolesId", obj.oRoles.rolesID);
                    cmd.Parameters.AddWithValue("estados", obj.estados);
                    cmd.Parameters.Add("Respuestas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
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
        public bool Eliminar(Usuarios obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("ELIMINARUSUARIOS", oconexion);
                    cmd.Parameters.AddWithValue("usuariosID", obj.usuariosID);
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
