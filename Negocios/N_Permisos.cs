using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class N_Permisos
    {
        private D_Permisos objcd_permisos = new D_Permisos();
        public List<Permisos> Listar(int usuariosID)
        {
            return objcd_permisos.Listar(usuariosID);
        }
    }
}
