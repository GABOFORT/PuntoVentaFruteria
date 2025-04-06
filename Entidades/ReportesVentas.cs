using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReportesVentas
    {
        public string FechaRegistros { get; set; }
        public string numerosVentas { get; set; }
        public int montosTotales { get; set; }
        public string UsuariosRegistros { get; set; }
        public string CodigosProductos { get; set; }
        public string NombresProductos { get; set; }
        public string Descripciones { get; set; }
        public string NombresCategorias { get; set; }
        public int preciosVentas { get; set; }
        public int cantidades { get; set; }
        public decimal peso { get; set; }
        public decimal precioPorUnidadMedida { get; set; }
        public bool esPorPeso { get; set; }
        public string unidadMedida { get; set; }
        public decimal SubTotales { get; set; }
    }
}
