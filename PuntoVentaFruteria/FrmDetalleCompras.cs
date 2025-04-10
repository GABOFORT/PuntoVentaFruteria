using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Entidades;
using Negocios;

namespace PuntoVentaFruteria
{
    public partial class FrmDetalleCompras : Form
    {
        public FrmDetalleCompras()
        {
            InitializeComponent();
        }
        private void FrmDetalleCompras_Load(object sender, EventArgs e)
        {
            CargarComprasPorDia();
            TextBusquedas.KeyDown += TextBusquedas_KeyDown;
        }
        private void CargarComprasPorDia()
        {
            Dictionary<int, Tuple<decimal, string>> ComprasConHora = new N_Compras().ObtenerComprasPorDia();
            DgvDataComprasDia.Rows.Clear();
            foreach (var item in ComprasConHora)
            {
                DgvDataComprasDia.Rows.Add(item.Key.ToString("D5"), item.Value.Item1.ToString("C2"), item.Value.Item2); 
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCompra(); 
        }
        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            TextFecha.Text = "";
            TextUsuario.Text = "";
            TextClaveProveedor.Text = "";
            TextNombreProveedor.Text = "";
            DgvDataDetallesCompras.Rows.Clear();
            textMontoTotal.Text = "0.00";
            TextBusquedas.Focus();
        }
        private void TextBusquedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCompra();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnLimpiarBuscador.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void BuscarCompra()
        {
            Compras oCompra = new N_Compras().ObtenerCompra(TextBusquedas.Text);
            if (oCompra.comprasID != 0)
            {
                TextProveedor.Text = oCompra.numerosCompras;
                TextFecha.Text = oCompra.fechaRegistros;
                TextUsuario.Text = oCompra.oUsuarios.nombresUsuarios;
                TextClaveProveedor.Text = oCompra.oProveedores.clavesProveedores;
                TextNombreProveedor.Text = oCompra.oProveedores.nombresProveedores;
                DgvDataDetallesCompras.Rows.Clear();
                foreach (DetallesCompras dc in oCompra.oDetallesCompras)
                {
                    string precioCompra = dc.preciosCompras.ToString("C2");
                    string precioVenta = dc.preciosVentas.ToString("C2");
                    string montoTotal = dc.montosTotales.ToString("C2");
                    DgvDataDetallesCompras.Rows.Add(new object[]{
                    dc.oProductos.nombresProductos,
                    dc.oProductos.descripciones,
                    precioCompra,  
                    precioVenta,   
                    dc.oProductos.esPorPeso ? "N/A" : $"{dc.cantidades} un",
                    dc.oProductos.esPorPeso ? (dc.peso == 0 ? "N/A" : $"{dc.peso:0.00} kg") : "N/A",
                    dc.oProductos.unidadMedida,
                    dc.oProductos.esPorPeso ? "Sí" : "No",
                    montoTotal     
                        });
                }
                textMontoTotal.Text = oCompra.montosTotales.ToString("C2");
            }
        }
        }
}
