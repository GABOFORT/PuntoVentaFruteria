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
        public bool esPorPeso {  get; set; } = false;
        public string unidadMedida { get; set; } = "un";
        public decimal preciosCompras { get; set; }
        public decimal preciosVentas { get; set; }
        public decimal precioPorUnidadMedida { get; set; }
        public bool estados { get; set; }
        public string fechaRegistros { get; set; }
    }
}
