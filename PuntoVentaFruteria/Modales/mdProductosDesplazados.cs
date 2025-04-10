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
    public partial class mdProductosDesplazados : Form
    {
        public ProductosDesplazados _ProductosDesplazados { get; set; }
        public mdProductosDesplazados()
        {
            InitializeComponent();
        }
        private void mdProductosDesplazados_Load(object sender, EventArgs e)
        {
            List<ProductosDesplazados> listaProducto = new N_Reportes().ObtenerProductosMasVendidos();

            foreach (ProductosDesplazados item in listaProducto)
            {
                string totalFormateado = item.esPorPeso
                ? $"{item.totalVendido:0.00} kg"  
                : $"{item.totalVendido:0} un";
                string totalDineroFormateado = item.totalDinero.ToString("C2");
                DgvDataMDMasVendidos.Rows.Add(new object[] {
                    item.ProductosID,
                    item.nombresProductos,
                    item.descripciones,
                    totalFormateado,
                    totalDineroFormateado
                });
             }
        }
        private void BtnBuscarFechas_Click(object sender, EventArgs e)
        {
            string fechaInicio = DateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fechaFin = DateTimePicker2.Value.ToString("yyyy-MM-dd");
            List<ProductosDesplazados> listaProducto = new N_Reportes().ProductosMasVendidosPorFechas(fechaInicio, fechaFin);
            DgvDataMDMasVendidos.Rows.Clear();
            foreach (ProductosDesplazados item in listaProducto)
            {
                string totalFormateado = item.totalVendido == 0 ? "N/A"
                : (item.esPorPeso ? $"{item.totalVendido:0.00} kg" : $"{item.totalVendido:0} un");
                string totalDineroFormateado = item.totalDinero.ToString("C2");
                DgvDataMDMasVendidos.Rows.Add(new object[] {
                item.ProductosID,
                item.nombresProductos,
                item.descripciones,
                totalFormateado,
                totalDineroFormateado
             });
            }
        }
    }
}