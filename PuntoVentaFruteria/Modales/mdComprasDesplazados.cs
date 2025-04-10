using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVentaFruteria.Modales
{
    public partial class mdComprasDesplazados : Form
    {
        public ProductosComprados _ProductosComprados { get; set; }
        public mdComprasDesplazados()
        {
            InitializeComponent();
        }
        private void mdComprasDesplazados_Load(object sender, EventArgs e)
        {
            List<ProductosComprados> listaProducto = new N_Reportes().ObtenerProductosMasComprados();
            foreach (ProductosComprados item in listaProducto)
            {
                string cantidadConUnidad = item.totalComprado > 0
                ? $"{item.totalComprado:0.00} {(item.esPorPeso ? "kg" : "un")}" : "N/A";
                DgvDataMDMasComprados.Rows.Add(new object[] {
                    item.ProductosID,
                    item.nombresProductos,
                    item.descripciones,
                    cantidadConUnidad,
                    item.totalCosto.ToString("C2")
                });
            }
        }
        private void BtnBuscarFechas_Click(object sender, EventArgs e)
        {
            string fechaInicio = DateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fechaFin = DateTimePicker2.Value.ToString("yyyy-MM-dd");
            List<ProductosComprados> listaProducto = new N_Reportes().ProductosMasCompradosPorFechas(fechaInicio, fechaFin);
            DgvDataMDMasComprados.Rows.Clear();
            foreach (ProductosComprados item in listaProducto)
            {
                string cantidadFormateada = item.totalComprado > 0
                ? $"{(item.esPorPeso ? item.totalComprado.ToString("0.00") : item.totalComprado.ToString("0"))} {(item.esPorPeso ? "kg" : "un")}" : "N/A";
                string costoFormateado = item.totalCosto > 0 ? $"${item.totalCosto:0.00}" : "N/A";
                DgvDataMDMasComprados.Rows.Add(new object[] {
                item.ProductosID,
                item.nombresProductos,
                item.descripciones,
                cantidadFormateada,
                costoFormateado
             });
            }
        }
    }
}
