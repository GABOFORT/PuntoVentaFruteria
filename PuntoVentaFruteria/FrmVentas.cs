using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (int.Parse(TextIDProductos.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(TextCantidadyPeso.Text) || decimal.Parse(TextCantidadyPeso.Text) <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad/peso válido mayor a cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextCantidadyPeso.Focus();
                return;
            }
            bool esPorPeso = TextPeso.Text == "Sí";
            decimal precioUnitario = Convert.ToDecimal(TextPrecioVenta.Text);
            decimal cantidad = decimal.Parse(TextCantidadyPeso.Text);
            decimal precioReal = esPorPeso ? Convert.ToDecimal(TextPrecioReal.Text) : precioUnitario;
            decimal subtotal = esPorPeso ? cantidad * precioReal : cantidad * precioUnitario;
            foreach (DataGridViewRow fila in DgvDataVentas.Rows)
            {
                if (fila.Cells["productoID"].Value.ToString() == TextIDProductos.Text)
                {
                    if (esPorPeso)
                    {
                        string pesoStr = fila.Cells["pesos"].Value.ToString().Replace(" kg", "").Replace("N/A", "0");
                        decimal pesoActual = decimal.Parse(pesoStr);
                        string nuevoPeso = (pesoActual + cantidad) == 0 ? "N/A" : (pesoActual + cantidad).ToString("0.00") + " kg";
                        fila.Cells["pesos"].Value = nuevoPeso;
                    }
                    else
                    {
                        string cantStr = fila.Cells["Cantidad"].Value.ToString().Replace(" un", "").Replace("N/A", "0");
                        int cantidadActual = int.Parse(cantStr);
                        string nuevaCantidad = (cantidadActual + (int)cantidad) == 0 ? "N/A" : (cantidadActual + (int)cantidad).ToString() + " un";
                        fila.Cells["Cantidad"].Value = nuevaCantidad;
                    }
                    fila.Cells["Sub_Total"].Value = (Convert.ToDecimal(fila.Cells["Sub_Total"].Value) + subtotal).ToString("0.00");
                    calcularTotal();
                    LimpiarProducto();
                    return;
                }
            }
                string cantidadDisplay = esPorPeso ? "N/A" : (cantidad == 0 ? "N/A" : cantidad.ToString("0") + " un");
                string pesoDisplay = esPorPeso ? (cantidad == 0 ? "N/A" : cantidad.ToString("0.00") + " kg") : "N/A";
                 DgvDataVentas.Rows.Add(new object[] {
                 TextIDProductos.Text,
                 TextNombreProductos.Text,
                 TextDescripcion.Text,
                 precioUnitario.ToString("0.00"),
                 cantidadDisplay,
                 pesoDisplay,
                 precioReal.ToString("0.00"),
                 subtotal.ToString("0.00"),
                 esPorPeso ? "Sí" : "No"
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
            TextCantidadyPeso.Text = "";
            TextPeso.Text = "";
            TextPrecioReal.Text = "";
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
                    TextPeso.Text = modal._Productos.esPorPeso ? "Sí" : "No";
                    TextPrecioReal.Text = modal._Productos.precioPorUnidadMedida.ToString("0.00");
                    TextPrecioVenta.Text = modal._Productos.preciosVentas.ToString("0.00");
                    TextCantidadyPeso.Select();
                    if (modal._Productos.esPorPeso)
                        TextCantidadyPeso.Select(); 
                    else
                        TextCantidadyPeso.Select(); 
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
                    TextCantidadyPeso.Select();
                }
                else
                {
                    TextCodigoProductos.BackColor = System.Drawing.Color.MistyRose;
                    TextIDProductos.Text = "0";
                    TextNombreProductos.Text = "";
                    TextPrecioVenta.Text = "";
                    TextCantidadyPeso.Text = "";
                }
            }
        }
        private void DgvDataVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 9)
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
            if (string.IsNullOrEmpty(TextPagaCon.Text) || Convert.ToDecimal(TextPagaCon.Text) < Convert.ToDecimal(TextTotalPagar.Text))
            {
                MessageBox.Show("El monto pagado es insuficiente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextPagaCon.Focus();
                return;
            }
            DataTable detalle_venta = new DataTable();
            detalle_venta.Columns.Add("productosID", typeof(int));
            detalle_venta.Columns.Add("preciosVentas", typeof(decimal));
            detalle_venta.Columns.Add("cantidades", typeof(int));
            detalle_venta.Columns.Add("pesos", typeof(decimal)); 
            detalle_venta.Columns.Add("precioReal", typeof(decimal));
            detalle_venta.Columns.Add("subTotales", typeof(decimal));
            foreach (DataGridViewRow row in DgvDataVentas.Rows)
            {
                bool esPorPeso = row.Cells["EsPorPeso"].Value.ToString() == "Sí";
                int cantidad = 0;
                decimal peso = 0;
                if (!esPorPeso)
                {
                    string cantidadStr = row.Cells["Cantidad"].Value.ToString().Replace(" un", "").Trim();
                    if (!int.TryParse(cantidadStr, out cantidad))
                    {
                        MessageBox.Show($"Cantidad inválida para el producto: {row.Cells["Nombre"].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    string pesoStr = row.Cells["pesos"].Value.ToString().Replace(" kg", "").Trim();
                    if (!decimal.TryParse(pesoStr, out peso))
                    {
                        MessageBox.Show($"Peso inválido para el producto: {row.Cells["Nombre"].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                detalle_venta.Rows.Add(
                    Convert.ToInt32(row.Cells["productoID"].Value),
                    Convert.ToDecimal(row.Cells["Precio_Compra"].Value),
                    esPorPeso ? 0 : cantidad,
                    esPorPeso ? peso : 0,
                    Convert.ToDecimal(row.Cells["precioReal"].Value),
                    Convert.ToDecimal(row.Cells["Sub_Total"].Value)
                );
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
        private void TextCantidadyPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
