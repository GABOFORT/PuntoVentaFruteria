using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        public int ventasID { get; set; }
        public Usuarios oUsuarios { get; set; }
        public string numerosVentas { get; set; }
        public decimal montosPagos { get; set; }
        public decimal montosCambios { get; set; }
        public decimal montosTotales { get; set; }
        public List<DetallesVentas> oDetallesVentas { get; set; }
        public string fechaRegistros { get; set; }
    }
}
