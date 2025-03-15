using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
using Negocios;
using PuntoVentaFruteria.Utilidades;

namespace PuntoVentaFruteria
{
    public partial class FrmDetalleVentas : Form
    {
        public FrmDetalleVentas()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarVenta();
        }
        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            TextFecha.Text = "";
            TextUsuario.Text = "";
            DgvDataDetallesVentas.Rows.Clear();
            TextMontosPagos.Text = "0.00";
            TextMontosCambios.Text = "0.00";
            TextMontosTotales.Text = "0.00";
            TextBusquedas.Focus();
        }

        private void FrmDetalleVentas_Load(object sender, EventArgs e)
        {
            CargarVentasPorDia();
            TextBusquedas.KeyDown += TextBusquedas_KeyDown;
        }
        private void CargarVentasPorDia()
        {
            Dictionary<int, Tuple<decimal, string>> ventasConHora = new N_Ventas().ObtenerVentasPorDia();
            DgvDataVentasDia.Rows.Clear();
            foreach (var item in ventasConHora)
            {
                DgvDataVentasDia.Rows.Add(item.Key.ToString("D5"), item.Value.Item1.ToString("C2"), item.Value.Item2); 
            }
        }

        private void TextBusquedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                BuscarVenta();  
                e.SuppressKeyPress = true; 
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnLimpiarBuscador.PerformClick(); 
                e.SuppressKeyPress = true;
            }
        }
        private void BuscarVenta()
        {
            Ventas oVenta = new N_Ventas().ObtenerVenta(TextBusquedas.Text);
            if (oVenta.ventasID != 0)
            {
                TextFecha.Text = oVenta.fechaRegistros;
                TextUsuario.Text = oVenta.oUsuarios.nombresUsuarios;
                DgvDataDetallesVentas.Rows.Clear();
                foreach (DetallesVentas dv in oVenta.oDetallesVentas)
                {
                    DgvDataDetallesVentas.Rows.Add(new object[] { dv.oProductos.nombresProductos, dv.oProductos.descripciones, dv.preciosVentas, dv.cantidades, dv.subTotales });
                }
                TextMontosPagos.Text = oVenta.montosPagos.ToString("0.00");
                TextMontosCambios.Text = oVenta.montosCambios.ToString("0.00");
                TextMontosTotales.Text = oVenta.montosTotales.ToString("0.00");
            }
        }
        }
}

