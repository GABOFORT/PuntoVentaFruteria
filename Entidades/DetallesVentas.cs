using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallesVentas
    {
        public int detallesVentasID { get; set; }
        public Productos oProductos { get; set; }
        public decimal preciosVentas { get; set; }
        public int cantidades { get; set; }
        public decimal subTotales { get; set; }
        public string fechaRegistros { get; set; }
    }
}
