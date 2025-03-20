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
                    TextPrecioCompra.Select();
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
            bool producto_existe = false;
            if (int.Parse(TextIDProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(TextPrecioCompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra  - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextPrecioCompra.Select();
                return;
            }
            if (!decimal.TryParse(TextPrecioVenta.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta  - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextPrecioVenta.Select();
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
                DgvDataCompras.Rows.Add(new object[] {
                    TextIDProducto.Text,
                    TextNombreProductos.Text,
                    TextDescripcion.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    TextCantidad.Value.ToString(),
                    (TextCantidad.Value * preciocompra).ToString("0.00")
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
            TextCantidad.Value = 1;
        }
            private void calcularTotal()
        {
            decimal total = 0;
            if (DgvDataCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataCompras.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["Sub_Total"].Value.ToString());
                }
                TextTotalPagar.Text = total.ToString("0.00");
            
        }
    }
        private void DgvDataCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 7)
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
            detalle_compra.Columns.Add("montoTotales", typeof(decimal));
            foreach (DataGridViewRow row in DgvDataCompras.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[] {
                        Convert.ToUInt32(row.Cells["productoID"].Value.ToString()),
                        row.Cells["Precio_Compra"].Value.ToString(),
                        row.Cells["Precio_Venta"].Value.ToString(),
                        row.Cells["Cantidad"].Value.ToString(),
                        row.Cells["Sub_Total"].Value.ToString()
                    });
            }
            int idcorrelativo = new N_Compras().ObtenerCorrelativo();
            string numerocompras = string.Format("{0:00000}", idcorrelativo);
            Compras oCompra = new Compras()
            {
                oUsuarios = new Usuarios() { usuariosID = _Usuario.usuariosID },
                oProveedores = new Proveedores() { proveedoresID = Convert.ToInt32(TextIDProveedor.Text) },
                numerosCompras = numerocompras,
                montosTotales = Convert.ToDecimal(TextTotalPagar.Text)
            };
            string mensaje = string.Empty;
            bool respuesta = new N_Compras().Registrar(oCompra, detalle_compra, out mensaje);
            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numerocompras + "\n\nDesea copiar al portapapeles?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numerocompras);
                    TextIDProveedor.Text = "0";
                    TextClaveProveedor.Text = "";
                    TextNombreProveedor.Text = "";
                    DgvDataCompras.Rows.Clear();
                    calcularTotal();
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
