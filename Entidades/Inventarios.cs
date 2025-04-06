using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventarios
    {
        public int inventariosID { get; set; } 
        public Productos oProductosID { get; set; }
        public decimal stockActual { get; set; } 
        public decimal stockMinimo { get; set; } 
        public DateTime fechaActualizacion { get; set; }
    }
}
