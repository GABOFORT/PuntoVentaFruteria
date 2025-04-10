using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Reportes
    {
        private D_Reportes objcd_reportes = new D_Reportes();
        public List<ReportesCompras> Compras(string fechainicio, string fechafin, int proveedoresID)
        {
            return objcd_reportes.Compras(fechainicio, fechafin, proveedoresID);
        }
        public List<ReportesVentas> Ventas(string fechainicio, string fechafin)
        {
            return objcd_reportes.Ventas(fechainicio, fechafin);
        }
        public List<ProductosDesplazados> ProductosMasVendidosPorFechas(string fechaInicio, string fechaFin)
        {
            return objcd_reportes.ProductosMasVendidosPorFechas(fechaInicio, fechaFin);
        }
        public List<ProductosDesplazados> ObtenerProductosMasVendidos()
        {
            return objcd_reportes.ObtenerProductosMasVendidos();
        }
        public List<ProductosComprados> ObtenerProductosMasComprados()
        {
            return objcd_reportes.ObtenerProductosMasComprados();
        }
        public List<ProductosComprados> ProductosMasCompradosPorFechas(string fechaInicio, string fechaFin)
        {
            return objcd_reportes.ProductosMasCompradosPorFechas(fechaInicio, fechaFin);
        }
        public decimal ObtenerTotalVentasHoy(out string mensajeError)
        {
            return objcd_reportes.ObtenerTotalVentasHoy(out mensajeError);
        }
    }
}
