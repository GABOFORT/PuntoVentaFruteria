using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Ventas
    {
        private D_Ventas objcd_ventas = new D_Ventas();
        public int ObtenerCorrelativo()
        {
            return objcd_ventas.ObtenerCorrelativo();
        }
        public bool Registrar(Ventas obj, DataTable DetallesVentas, out string Mensaje)
        {
            return objcd_ventas.Registrar(obj, DetallesVentas, out Mensaje);
        }
        public Ventas ObtenerVenta(string numeros)
        {
            Ventas oVentas = objcd_ventas.ObtenerVenta(numeros);
            if (oVentas.ventasID != 0)
            {
                List<DetallesVentas> oDetallesVentas= objcd_ventas.ObtenerDetalleVenta(oVentas.ventasID);
                oVentas.oDetallesVentas = oDetallesVentas;
            }
            return oVentas;
        }
        public Dictionary<int, Tuple<decimal, string>> ObtenerVentasPorDia()
        {
            return objcd_ventas.ObtenerVentasPorDia();
        }
    }
}
