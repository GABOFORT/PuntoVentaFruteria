using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Permisos
    {
        public int permisosID { get; set; }
        public Roles oRoles { get; set; }
        public string nombresPermisos { get; set; }
        public string fechaRegistros { get; set; }
    }
}
