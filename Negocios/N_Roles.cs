using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class N_Roles
    {
        private D_Roles objcd_roles = new D_Roles();
        public List<Roles> Listar()
        {
            return objcd_roles.Listar();
        }
    }
}
