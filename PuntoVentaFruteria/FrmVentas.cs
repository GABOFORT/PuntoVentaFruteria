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
            TextPagaCon.Text = "$0.00";
            TextCambio.Text = "$0.00";
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
            bool producto_existe = false;
            foreach (DataGridViewRow fila in DgvDataVentas.Rows)
            {
                if (fila.Cells["productoID"].Value.ToString() == TextIDProductos.Text)
                {
                    producto_existe = true;
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
                    decimal subtotalActual = Convert.ToDecimal(fila.Cells["Sub_Total"].Value.ToString().Replace("$", ""));
                    fila.Cells["Sub_Total"].Value = "$" + (subtotalActual + subtotal).ToString("0.00");

                    calcularTotal();
                    LimpiarProducto();
                    return;
                }
            }
            if (!producto_existe)
            {
                string cantidadDisplay = esPorPeso ? "N/A" : cantidad.ToString("0") + " un";
                string pesoDisplay = esPorPeso ? cantidad.ToString("0.00") + " kg" : "N/A";
                string precioVentaDisplay = precioUnitario == 0 ? "N/A" : "$" + precioUnitario.ToString("0.00");
                string precioRealDisplay = precioReal == 0 ? "N/A" : "$" + precioReal.ToString("0.00");
                string subtotalDisplay = "$" + subtotal.ToString("0.00");
                DgvDataVentas.Rows.Add(new object[] {
                    TextIDProductos.Text,
                    TextNombreProductos.Text,
                    TextDescripcion.Text,
                    precioVentaDisplay,    
                    cantidadDisplay,     
                    pesoDisplay,          
                    precioRealDisplay,    
                    subtotalDisplay,     
                    esPorPeso ? "Sí" : "No"
                });
                calcularTotal();
                LimpiarProducto();
                TextCodigoProductos.Select();
            }
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
                    string subtotalStr = row.Cells["Sub_Total"].Value.ToString().Replace("$", "");
                    total += Convert.ToDecimal(subtotalStr);
                }
                TextTotalPagar.Text = "$" + total.ToString("0.00");
            }
            else
            {
                TextTotalPagar.Text = "$0.00";
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void calcularcambio()
        {

            if (string.IsNullOrWhiteSpace(TextTotalPagar.Text))
            {
                MessageBox.Show("No existe productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string totalPagarStr = TextTotalPagar.Text.Replace("$", "").Trim();
            string pagaConStr = TextPagaCon.Text.Replace("$", "").Trim();
            if (decimal.TryParse(totalPagarStr, out decimal total) &&
                decimal.TryParse(pagaConStr, out decimal pagacon))
            {
                if (pagacon < total)
                {
                    TextCambio.Text = "$0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    TextCambio.Text = "$" + cambio.ToString("0.00");
                }
            }
            else
            {
                TextCambio.Text = "$0.00";
                MessageBox.Show("Ingrese valores numéricos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TextPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(TextPagaCon.Text))
                {
                    MessageBox.Show("Ingrese el monto con el que paga el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
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
            string pagaConStr = TextPagaCon.Text.Replace("$", "").Trim();
            string totalPagarStr = TextTotalPagar.Text.Replace("$", "").Trim();
            if (!decimal.TryParse(pagaConStr, out decimal montoPagado) ||
                !decimal.TryParse(totalPagarStr, out decimal totalPagar))
            {
                MessageBox.Show("Ingrese montos válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (montoPagado < totalPagar)
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
                    string cantidadStr = row.Cells["Cantidad"].Value.ToString().Replace(" un", "").Replace("N/A", "0").Trim();
                    if (!int.TryParse(cantidadStr, out cantidad))
                    {
                        MessageBox.Show($"Cantidad inválida para el producto: {row.Cells["Nombre"].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    string pesoStr = row.Cells["pesos"].Value.ToString().Replace(" kg", "").Replace("N/A", "0").Trim();
                    if (!decimal.TryParse(pesoStr, out peso))
                    {
                        MessageBox.Show($"Peso inválido para el producto: {row.Cells["Nombre"].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                string precioVentaStr = row.Cells["Precio_Compra"].Value.ToString().Replace("$", "").Replace("N/A", "0").Trim();
                string precioRealStr = row.Cells["precioReal"].Value.ToString().Replace("$", "").Replace("N/A", "0").Trim();
                string subtotalStr = row.Cells["Sub_Total"].Value.ToString().Replace("$", "").Trim();
                if (!decimal.TryParse(precioVentaStr, out decimal precioVenta) ||
                    !decimal.TryParse(precioRealStr, out decimal precioReal) ||
                    !decimal.TryParse(subtotalStr, out decimal subtotal))
                {
                    MessageBox.Show($"Valores monetarios inválidos para el producto: {row.Cells["Nombre"].Value}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                detalle_venta.Rows.Add(
                    Convert.ToInt32(row.Cells["productoID"].Value),
                    precioVenta,
                    esPorPeso ? 0 : cantidad,
                    esPorPeso ? peso : 0,
                    precioReal,
                    subtotal
                );
            }
            int idcorrelativo = new N_Ventas().ObtenerCorrelativo();
            string numerosVentas = string.Format("{0:00000}", idcorrelativo);
            string cambioStr = TextCambio.Text.Replace("$", "").Trim();
            decimal.TryParse(cambioStr, out decimal cambio);
            Ventas oVentas = new Ventas()
            {
                oUsuarios = new Usuarios() { usuariosID = _Usuarios.usuariosID },
                numerosVentas = numerosVentas,
                montosPagos = montoPagado,
                montosCambios = cambio,
                montosTotales = totalPagar,
            };
            string mensaje = string.Empty;
            bool respuesta = new N_Ventas().Registrar(oVentas, detalle_venta, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show("Número de venta generada:\n" + numerosVentas + "\n\n¿Desea copiar al portapapeles?", "Mensaje",
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
                TextPagaCon.Text = "$0.00";
                TextCambio.Text = "$0.00";
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GenerarTicketDigital(string numeroVenta, DataTable detalleVenta)
        {
            StringBuilder ticket = new StringBuilder();
            int anchoTotal = 90;
            int colProducto = 18;
            int colDescripcion = 18;
            int colUM = 5;
            int colCantPeso = 15;
            int colPrecio = 15;
            int colSubtotal = 15;
            ticket.AppendLine("+" + new string('-', anchoTotal - 2) + "+");
            ticket.AppendLine("|" + " TICKET DE VENTA ".PadLeft((anchoTotal + 14) / 2).PadRight(anchoTotal - 2) + "|");
            ticket.AppendLine("+" + new string('-', anchoTotal - 2) + "+");
            ticket.AppendLine($"| N° Venta: {numeroVenta.PadRight(anchoTotal - 13)}|");
            ticket.AppendLine($"| Fecha:   {DateTime.Now:dd/MM/yyyy HH:mm:ss}".PadRight(anchoTotal - 1) + "|");
            ticket.AppendLine("+" + new string('-', anchoTotal - 2) + "+");
            ticket.AppendLine(
                "| " +
                Truncar("Producto", colProducto) +
                Truncar("Descripción", colDescripcion) +
                "UM".PadRight(colUM) +
                "Cant/Peso".PadLeft(colCantPeso) +
                "P.Unit".PadLeft(colPrecio) +
                "Subtotal".PadLeft(colSubtotal) +
                " |"
            );
            ticket.AppendLine("+" + new string('-', anchoTotal - 2) + "+");
            foreach (DataGridViewRow row in DgvDataVentas.Rows)
            {
                bool esPorPeso = row.Cells["EsPorPeso"].Value.ToString() == "Sí";
                string unidadMedida = esPorPeso ? "kg" : "un";
                decimal precioUnitario = esPorPeso
                    ? Convert.ToDecimal(row.Cells["precioReal"].Value.ToString().Replace("$", ""))
                    : Convert.ToDecimal(row.Cells["Precio_Compra"].Value.ToString().Replace("$", ""));
                string cantidadPeso = esPorPeso
                    ? $"{row.Cells["pesos"].Value.ToString().Replace(" kg", "").Trim()} kg"
                    : $"{row.Cells["Cantidad"].Value.ToString().Replace(" un", "").Trim()} un";
                string producto = Truncar(row.Cells["Producto"].Value?.ToString(), colProducto);
                string descripcion = Truncar(row.Cells["Descripciones"].Value?.ToString(), colDescripcion);
                decimal subtotal = Convert.ToDecimal(row.Cells["Sub_Total"].Value.ToString().Replace("$", ""));
                ticket.AppendLine(
                    "| " +
                    producto +
                    descripcion +
                    unidadMedida.PadRight(colUM) +
                    cantidadPeso.PadLeft(colCantPeso) +
                    precioUnitario.ToString("$#,##0.00").PadLeft(colPrecio) +
                    subtotal.ToString("$#,##0.00").PadLeft(colSubtotal) +
                    " |" 
                );
            }
            decimal totalPagar = Convert.ToDecimal(TextTotalPagar.Text.Replace("$", ""));
            decimal montoPagado = Convert.ToDecimal(TextPagaCon.Text.Replace("$", ""));
            decimal cambio = Convert.ToDecimal(TextCambio.Text.Replace("$", ""));
            ticket.AppendLine("+" + new string('-', anchoTotal - 2) + "+");
            ticket.AppendLine($"| {"TOTAL A PAGAR:",-58}{totalPagar.ToString("$#,##0.00").PadLeft(28)} |");
            ticket.AppendLine($"| {"MONTO PAGADO:",-58}{montoPagado.ToString("$#,##0.00").PadLeft(28)} |");
            ticket.AppendLine($"| {"CAMBIO:",-58}{cambio.ToString("$#,##0.00").PadLeft(28)} |");
            ticket.AppendLine("+" + new string('-', anchoTotal - 2) + "+");
            ticket.AppendLine("|" + "¡Gracias por su compra!".PadLeft(anchoTotal - 3) + " |");
            ticket.AppendLine("+" + new string('-', anchoTotal - 2) + "+");
            using (var form = new Form())
            using (var textBox = new TextBox()
            {
                Multiline = true,
                Font = new Font("Consolas", 10),
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Text = ticket.ToString(),
                Dock = DockStyle.Fill,
                BackColor = Color.White
            })
            {
                form.Text = "Ticket Digital";
                form.Size = new Size(680, 400);
                form.BackColor = Color.White;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Controls.Add(textBox);
                form.ShowDialog();
            }
            string Truncar(string texto, int maxLength)
            {
                if (string.IsNullOrEmpty(texto)) return new string(' ', maxLength);
                texto = texto.Trim();
                return texto.Length <= maxLength
                    ? texto.PadRight(maxLength)
                    : texto.Substring(0, maxLength - 3) + "...";
            }
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
