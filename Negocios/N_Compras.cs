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
    public class N_Compras
    {
        private D_Compras objcd_compras = new D_Compras();

        public int ObtenerCorrelativo()
        {
            return objcd_compras.ObtenerCorrelativo();
        }
        public bool Registrar(Compras obj, DataTable DetallesCompras, out string Mensaje)
        {

            return objcd_compras.Registrar(obj, DetallesCompras, out Mensaje);
        }
        public Compras ObtenerCompra(string numero)
        {
            Compras oCompras = objcd_compras.ObtenerCompra(numero);

            if (oCompras.comprasID != 0)
            {
                List<DetallesCompras> oDetallesCompras = objcd_compras.ObtenerDetalleCompra(oCompras.comprasID);

                oCompras.oDetallesCompras = oDetallesCompras;
            }
            return oCompras;
        }
        public Dictionary<int, Tuple<decimal, string>> ObtenerComprasPorDia()
        {
            return objcd_compras.ObtenerComprasPorDia();
        }
    }
}
