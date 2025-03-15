using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compras
    {
        public int comprasID { get; set; }
        public Usuarios oUsuarios { get; set; }
        public Proveedores oProveedores { get; set; }
        public string numerosCompras { get; set; }
        public decimal montosTotales { get; set; }
        public List<DetallesCompras> oDetallesCompras { get; set; }
        public string fechaRegistros { get; set; }
    }
}
