using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductosDesplazados
    {
        public int ProductosID { get; set; }
        public string nombresProductos { get; set; }
        public string descripciones { get; set; }
        public decimal totalVendido { get; set; }
        public bool esPorPeso {  get; set; }
        public decimal totalDinero { get; set; }
    }
}
