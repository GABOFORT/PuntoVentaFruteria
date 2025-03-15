using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Negocios;
using PuntoVentaFruteria.Modales;
using PuntoVentaFruteria.Utilidades;

namespace PuntoVentaFruteria
{
    public partial class FrmVentas : Form
    {
        private Usuarios _Usuarios;
        public FrmVentas(Usuarios ousuarios)
        {
            _Usuarios = ousuarios;
            InitializeComponent();
        }
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            TextFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TextIDProductos.Text = "0";
            TextPagaCon.Text = "";
            TextCambio.Text = "";
            TextTotalPagar.Text = "0";
        }
        private void DgvDataVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDataVentas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    DgvDataVentas.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }
        private void iconBtnAgregarProductos_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;
            if (int.Parse(TextIDProductos.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(TextPrecioVenta.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextPrecioVenta.Select();
                return;
            }
            foreach (DataGridViewRow fila in DgvDataVentas.Rows)
            {
                if (fila.Cells["productoID"].Value.ToString() == TextIDProductos.Text)
                {
                    int cantidadActual = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                    int nuevaCantidad = cantidadActual + (int)TextCantidad.Value;
                    fila.Cells["Cantidad"].Value = nuevaCantidad.ToString();
                    fila.Cells["Sub_Total"].Value = (nuevaCantidad * precio).ToString("0.00");
                    calcularTotal();
                    LimpiarProducto();
                    return;
                }
            }
            DgvDataVentas.Rows.Add(new object[] {
             TextIDProductos.Text,
             TextNombreProductos.Text,
             TextDescripcion.Text,
             precio.ToString("0.00"),
             TextCantidad.Value.ToString(),
             (TextCantidad.Value * precio).ToString("0.00")
         });
            calcularTotal();
            LimpiarProducto();
            TextCodigoProductos.Select();
        }
        private void LimpiarProducto()
        {
            TextIDProductos.Text = "0";
            TextCodigoProductos.Text = "";
            TextNombreProductos.Text = "";
            TextDescripcion.Text = "";
            TextPrecioVenta.Text = "";
            TextCantidad.Value = 1;
        }
        private void calcularTotal()
        {
            decimal total = 0;
            if (DgvDataVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataVentas.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Sub_Total"].Value.ToString());
                }
                TextTotalPagar.Text = total.ToString("0.00");
            }
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TextIDProductos.Text = modal._Productos.productosID.ToString();
                    TextCodigoProductos.Text = modal._Productos.codigos;
                    TextNombreProductos.Text = modal._Productos.nombresProductos;
                    TextDescripcion.Text = modal._Productos.descripciones;
                    TextPrecioVenta.Text = modal._Productos.preciosVentas.ToString("0.00");
                    TextCantidad.Select();
                }
                else
                {
                    TextCodigoProductos.Select();
                }
            }
        }
        private void TextCodigoProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Productos oProducto = new N_Productos().Listar().Where(p => p.codigos == TextCodigoProductos.Text && p.estados == true).FirstOrDefault();
                if (oProducto != null)
                {
                    TextCodigoProductos.BackColor = System.Drawing.Color.Honeydew;
                    TextIDProductos.Text = oProducto.productosID.ToString();
                    TextNombreProductos.Text = oProducto.nombresProductos;
                    TextPrecioVenta.Text = oProducto.preciosVentas.ToString("0.00");
                    TextCantidad.Select();
                }
                else
                {
                    TextCodigoProductos.BackColor = System.Drawing.Color.MistyRose;
                    TextIDProductos.Text = "0";
                    TextNombreProductos.Text = "";
                    TextPrecioVenta.Text = "";
                    TextCantidad.Value = 1;
                }
            }
        }
        private void DgvDataVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.select.Width;
                var h = Properties.Resources.select.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.select, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void TextPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TextPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = false;
                }
                else
                {
                    if (!char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void TextPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !TextPagaCon.Text.Contains("."))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void calcularcambio()
        {
            if (TextTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existe productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal pagacon;
            decimal total = Convert.ToDecimal(TextTotalPagar.Text);
            if (decimal.TryParse(TextPagaCon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    TextCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    TextCambio.Text = cambio.ToString("0.00");
                }
            }
        }
        private void TextPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }
        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (DgvDataVentas.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable detalle_venta = new DataTable();
            detalle_venta.Columns.Add("productosID", typeof(int));
            detalle_venta.Columns.Add("preciosVentas", typeof(decimal));
            detalle_venta.Columns.Add("cantidades", typeof(int));
            detalle_venta.Columns.Add("subTotales", typeof(decimal));
            foreach (DataGridViewRow row in DgvDataVentas.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                row.Cells["productoID"].Value.ToString(),
                row.Cells["Precio_Compra"].Value.ToString(),
                row.Cells["Cantidad"].Value.ToString(),
                row.Cells["Sub_Total"].Value.ToString(),
            });
            }

            int idcorrelativo = new N_Ventas().ObtenerCorrelativo();
            string numerosVentas = string.Format("{0:00000}", idcorrelativo);
            calcularcambio();
            Ventas oVentas = new Ventas()
            {
                oUsuarios = new Usuarios() { usuariosID = _Usuarios.usuariosID },
                numerosVentas = numerosVentas,
                montosPagos = Convert.ToDecimal(TextPagaCon.Text),
                montosCambios = Convert.ToDecimal(TextCambio.Text),
                montosTotales = Convert.ToDecimal(TextTotalPagar.Text),
            };
            string mensaje = string.Empty;
            bool respuesta = new N_Ventas().Registrar(oVentas, detalle_venta, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numerosVentas + "\n\n¿Desea copiar al portapapeles?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numerosVentas);
                }
                var generarTicket = MessageBox.Show("¿Desea generar el ticket de venta?",
                 "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (generarTicket == DialogResult.Yes)
                {
                    GenerarTicketDigital(numerosVentas, detalle_venta);
                }
                DgvDataVentas.Rows.Clear();
                calcularTotal();
                TextPagaCon.Text = "";
                TextCambio.Text = "";
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GenerarTicketDigital(string numeroVenta, DataTable detalleVenta)
        {
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine("********** TICKET DE VENTA **********");
            ticket.AppendLine($"Venta No: {numeroVenta}");
            ticket.AppendLine($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
            ticket.AppendLine("====================================");
            ticket.AppendLine($"{"Producto",-15} {"Descripción",-12} {"Cantidad",-10} {"Precio",-10} {"SubTotal",-10}");
            ticket.AppendLine("====================================");

            foreach (DataGridViewRow row in DgvDataVentas.Rows)
            {
                string producto = row.Cells["producto"].Value?.ToString() ?? "Producto sin nombre";
                string descripcion = row.Cells["Descripciones"].Value?.ToString() ?? "Sin descripción";
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["Precio_Compra"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["Sub_Total"].Value);
                ticket.AppendLine($"{producto,-15} {descripcion,-12} {cantidad,-10} {precio,10:C} {subtotal,10:C}");
            }
            decimal totalPagar = Convert.ToDecimal(TextTotalPagar.Text);
            decimal montoPagado = Convert.ToDecimal(TextPagaCon.Text);
            decimal cambio = Convert.ToDecimal(TextCambio.Text);
            ticket.AppendLine("====================================");
            ticket.AppendLine($"Total a Pagar: {totalPagar,10:C}");
            ticket.AppendLine($"Monto Pagado: {montoPagado,10:C}");
            ticket.AppendLine($"Cambio: {cambio,10:C}");
            ticket.AppendLine("====================================");
            ticket.AppendLine("Gracias por su compra!");
            MessageBox.Show(ticket.ToString(), "Ticket Digital", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }
}
