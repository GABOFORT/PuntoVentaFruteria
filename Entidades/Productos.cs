using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        public int productosID { get; set; }
        public string codigos { get; set; }
        public string nombresProductos { get; set; }
        public string descripciones { get; set; }
        public Categorias ocategorias { get; set; }
        public decimal preciosCompras { get; set; }
        public decimal preciosVentas { get; set; }
        public bool estados { get; set; }
        public string fechaRegistros { get; set; }
    }
}
