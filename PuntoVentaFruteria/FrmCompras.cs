using Entidades;
using Negocios;
using PuntoVentaFruteria.Modales;
using PuntoVentaFruteria.Utilidades;
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

namespace PuntoVentaFruteria
{
    public partial class FrmCompras : Form
    {
        private Usuarios _Usuario;
        public FrmCompras(Usuarios ousuario)
        {
            _Usuario = ousuario;
            InitializeComponent();
        }
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            TextFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TextIDProveedor.Text = "0";
            TextIDProducto.Text = "0";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedores())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TextIDProveedor.Text = modal._Proveedores.proveedoresID.ToString();
                    TextClaveProveedor.Text = modal._Proveedores.clavesProveedores.ToString();
                    TextNombreProveedor.Text = modal._Proveedores.nombresProveedores.ToString();
                }
                else
                {
                    TextClaveProveedor.Select();
                }
            }
        }
        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TextIDProducto.Text = modal._Productos.productosID.ToString();
                    TextCodigoProductos.Text = modal._Productos.codigos;
                    TextNombreProductos.Text = modal._Productos.nombresProductos;
                    TextDescripcion.Text = modal._Productos.descripciones;
                    TextPeso.Text = modal._Productos.esPorPeso ? "Sí" : "No";
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
                    TextIDProducto.Text = oProducto.productosID.ToString();
                    TextNombreProductos.Text = oProducto.nombresProductos;
                    TextPrecioCompra.Select();
                }
                else
                {
                    TextCodigoProductos.BackColor = System.Drawing.Color.MistyRose;
                    TextIDProducto.Text = "0";
                    TextNombreProductos.Text = "";

                }
            }
        }
        private void IconBtnAgregarProductos_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            decimal cantidadPeso = 0;
            bool producto_existe = false;
            bool esPorPeso = TextPeso.Text == "Sí";
            if (int.Parse(TextIDProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(TextPrecioCompra.Text, out preciocompra) || preciocompra <= 0)
            {
                MessageBox.Show("Precio Compra - Debe ser un valor mayor a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextPrecioCompra.Select();
                return;
            }
            if (!decimal.TryParse(TextPrecioVenta.Text, out precioventa) || precioventa <= 0)
            {
                MessageBox.Show("Precio Venta - Debe ser un valor mayor a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextPrecioVenta.Select();
                return;
            }
            if (!decimal.TryParse(TextCantidadyPeso.Text, out cantidadPeso))
            {
                MessageBox.Show(esPorPeso ? "Ingrese un peso válido" : "Ingrese una cantidad válida",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextCantidadyPeso.Select();
                return;
            }
            if ((esPorPeso && cantidadPeso <= 0) || (!esPorPeso && cantidadPeso < 1))
            {
                MessageBox.Show(esPorPeso ? "El peso debe ser mayor a 0" : "La cantidad debe ser al menos 1",
                                "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextCantidadyPeso.Select();
                return;
            }
            foreach (DataGridViewRow fila in DgvDataCompras.Rows)
            {
                if (fila.Cells["productoID"].Value.ToString() == TextIDProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }
            if (!producto_existe)
            {
                decimal subtotal = preciocompra * cantidadPeso;
                DgvDataCompras.Rows.Add(new object[] {
                TextIDProducto.Text,
                TextNombreProductos.Text,
                TextDescripcion.Text,
                "$" + preciocompra.ToString("0.00"),  
                "$" + precioventa.ToString("0.00"),  
                esPorPeso ? "N/A" : $"{cantidadPeso.ToString("0")} un",
                esPorPeso ? $"{cantidadPeso.ToString("0.00")} kg" : "N/A",
                esPorPeso ? "Sí" : "No",
                "$" + subtotal.ToString("0.00")      
            });
                calcularTotal();
                LimpiarProducto();
                TextCodigoProductos.Select();
            }
        }
        private void LimpiarProducto()
        {
            TextIDProducto.Text = "0";
            TextCodigoProductos.Text = "";
            TextCodigoProductos.BackColor = System.Drawing.Color.White;
            TextNombreProductos.Text = "";
            TextDescripcion.Text = "";
            TextPrecioCompra.Text = "";
            TextPrecioVenta.Text = "";
            TextCantidadyPeso.Text = "";
            TextPeso.Text = "";
        }        
            private void calcularTotal()
            {
            decimal total = 0;
            if (DgvDataCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataCompras.Rows)
                {
                    string subtotalStr = row.Cells["Sub_Total"].Value.ToString().Replace("$", "");
                    total += Convert.ToDecimal(subtotalStr);
                }
                TextTotalPagar.Text = "$" + total.ToString("0.00");
            }
        }
        private void DgvDataCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void DgvDataCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDataCompras.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    DgvDataCompras.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }
        private void TextPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.' && TextPrecioCompra.Text.Contains("."))
                    e.Handled = true;
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
        private void TextPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.' && TextPrecioVenta.Text.Contains("."))
                    e.Handled = true;
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
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextIDProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DgvDataCompras.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable detalle_compra = new DataTable();
            detalle_compra.Columns.Add("productosID", typeof(int));
            detalle_compra.Columns.Add("preciosCompras", typeof(decimal));
            detalle_compra.Columns.Add("preciosVentas", typeof(decimal));
            detalle_compra.Columns.Add("cantidades", typeof(int));
            detalle_compra.Columns.Add("peso", typeof(decimal));  
            detalle_compra.Columns.Add("montoTotales", typeof(decimal));
            foreach (DataGridViewRow row in DgvDataCompras.Rows)
            {
                bool esPorPeso = row.Cells["esPorPeso"].Value.ToString() == "Sí";
                decimal cantidad = 0;
                decimal peso = 0;
                if (esPorPeso)
                {
                    string pesoTexto = row.Cells["Peso"].Value.ToString().Replace(" kg", "");
                    decimal.TryParse(pesoTexto, out peso);
                }
                else
                {
                    string cantidadTexto = row.Cells["Cantidad"].Value.ToString().Replace(" un", "");
                    decimal.TryParse(cantidadTexto, out cantidad);
                }
                string precioCompraStr = row.Cells["Precio_Compra"].Value.ToString().Replace("$", "").Trim();
                string precioVentaStr = row.Cells["Precio_Venta"].Value.ToString().Replace("$", "").Trim();
                string subTotalStr = row.Cells["Sub_Total"].Value.ToString().Replace("$", "").Trim();
                detalle_compra.Rows.Add(
                    new object[] {
                    Convert.ToInt32(row.Cells["productoID"].Value.ToString()),
                    Convert.ToDecimal(precioCompraStr),  
                    Convert.ToDecimal(precioVentaStr),   
                    esPorPeso ? 0 : cantidad,
                    esPorPeso ? peso : 0,
                    Convert.ToDecimal(subTotalStr)       
                    });
            }
            string totalPagarStr = TextTotalPagar.Text.Replace("$", "").Trim();
            Compras oCompra = new Compras()
            {
                oUsuarios = new Usuarios() { usuariosID = _Usuario.usuariosID },
                oProveedores = new Proveedores() { proveedoresID = Convert.ToInt32(TextIDProveedor.Text) },
                numerosCompras = string.Format("{0:00000}", new N_Compras().ObtenerCorrelativo()),
                montosTotales = Convert.ToDecimal(totalPagarStr)
            };
            string mensaje = string.Empty;
            bool respuesta = new N_Compras().Registrar(oCompra, detalle_compra, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show($"Compra registrada exitosamente!\nNúmero: {oCompra.numerosCompras}\nTotal: {TextTotalPagar.Text}\n\n¿Desea copiar el número al portapapeles?",
                                            "Compra Registrada",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(oCompra.numerosCompras);
                    TextIDProveedor.Text = "0";
                    TextClaveProveedor.Text = "";
                    TextNombreProveedor.Text = "";
                    DgvDataCompras.Rows.Clear();
                    TextTotalPagar.Text = "$0.00";
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
