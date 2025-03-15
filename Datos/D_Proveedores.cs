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
    public class D_Proveedores
    {
        public List<Proveedores> Listar()
        {
            List<Proveedores> lista = new List<Proveedores>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select proveedoresID,clavesProveedores,nombresProveedores,telefonos,estados from Proveedores");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedores()
                            {
                                proveedoresID = Convert.ToInt32(dr["proveedoresID"]),
                                clavesProveedores = dr["clavesProveedores"].ToString(),
                                nombresProveedores = dr["nombresProveedores"].ToString(),
                                telefonos = dr["telefonos"].ToString(),
                                estados = Convert.ToBoolean(dr["estados"]),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Proveedores>();
                }
            }
            return lista;
        }
        public int Registrar(Proveedores obj, out string Mensaje)
        {
            int proveedoresIDGenerados = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("REGISTRARPROVEEDORES", oconexion);
                    cmd.Parameters.AddWithValue("clavesProveedores ", obj.clavesProveedores);
                    cmd.Parameters.AddWithValue("nombresProveedores ", obj.nombresProveedores);
                    cmd.Parameters.AddWithValue("telefonos", obj.telefonos);
                    cmd.Parameters.AddWithValue("estados", obj.estados);
                    cmd.Parameters.Add("Resultados", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensajes", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    proveedoresIDGenerados = Convert.ToInt32(cmd.Parameters["Resultados"].Value);
                    Mensaje = cmd.Parameters["mensajes"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                proveedoresIDGenerados = 0;
                Mensaje = ex.Message;
            }
            return proveedoresIDGenerados;
        }
        public bool Editar(Proveedores obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("EDITARPROVEEDORES", oconexion);
                    cmd.Parameters.AddWithValue("proveedoresID", obj.proveedoresID);
                    cmd.Parameters.AddWithValue("clavesProveedores  ", obj.clavesProveedores);
                    cmd.Parameters.AddWithValue("nombresProveedores", obj.nombresProveedores);
                    cmd.Parameters.AddWithValue("telefonos", obj.telefonos);
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
        public bool Eliminar(Proveedores obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("ELIMINARPROVEEDORES", oconexion);
                    cmd.Parameters.AddWithValue("proveedoresID", obj.proveedoresID);
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
    }
}
