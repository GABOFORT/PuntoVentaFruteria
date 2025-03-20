using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallesGastos
    {
        public int detallesGastosID { get; set; }
        public Gastos oGastos { get; set; }
        public string concepto { get; set; }
        public decimal montosTotales { get; set; }
        public string fechaRegistros { get; set; }
    }
}
