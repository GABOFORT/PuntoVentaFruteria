using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        public int usuariosID { get; set; }
        public string nombresUsuarios { get; set; }
        public string contraseñas { get; set; }
        public Roles oRoles { get; set; }
        public bool estados { get; set; }
        public string fechaRegistros { get; set; }
    }
}
