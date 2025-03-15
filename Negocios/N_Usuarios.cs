using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Usuarios
    {
        private D_Usuarios objcd_usuarios = new D_Usuarios();
        public List<Usuarios> Listar()
        {
            return objcd_usuarios.Listar();  
        }
        public int Registrar(Usuarios obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (obj.nombresUsuarios == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }
            if (obj.contraseñas == "")
            {
                Mensaje += "Es necesario la contraseña del usuario\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuarios.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Usuarios obj, out string Mensaje)
        {
                return objcd_usuarios.Editar(obj, out Mensaje);
        }
        public bool Eliminar(Usuarios obj, out string Mensaje)
        {
            return objcd_usuarios.Eliminar(obj, out Mensaje);
        }
    }
}
