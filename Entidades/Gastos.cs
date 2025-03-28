using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gastos
    {
        public int gastosID { get; set; }
        public Usuarios oUsuarios { get; set; }
        public string concepto { get; set; }
        public decimal montosTotales { get; set; }
        public DateTime fechaRegistros { get; set; }
    }
}
