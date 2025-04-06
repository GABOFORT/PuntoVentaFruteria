using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Inventarios
    {
        private D_Inventarios objcd_inventarios = new D_Inventarios();
        public List<Inventarios> Listar()
        {
            return objcd_inventarios.Listar();
        }
        public bool Insertar(Inventarios inventario, out string mensaje)
        {
            return objcd_inventarios.Insertar(inventario, out mensaje);
        }
        public bool Eliminar(int inventarioID)
        {
            return objcd_inventarios.Eliminar(inventarioID);
        }
    }
}
