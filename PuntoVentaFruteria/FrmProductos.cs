using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Negocios;
using PuntoVentaFruteria.Modales;
using PuntoVentaFruteria.Utilidades;
using static System.Net.Mime.MediaTypeNames;

namespace PuntoVentaFruteria
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CboCategorias.Items.Clear();
            CboEstados.Items.Clear();
            CboEstados.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstados.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CboEstados.DisplayMember = "Texto";
            CboEstados.ValueMember = "Valor";
            CboEstados.SelectedIndex = 0;
            List<Categorias> listaCategoria = new N_Categorias().Listar();
            foreach (Categorias item in listaCategoria)
            {
                CboCategorias.Items.Add(new OpcionCombo() { Valor = item.categoriasID, Texto = item.nombresCategorias });
            }
            CboCategorias.DisplayMember = "Texto";
            CboCategorias.ValueMember = "Valor";
            CboCategorias.SelectedIndex = 0;
            foreach (DataGridViewColumn columna in DgvDataProductos.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cboBuscar.DisplayMember = "Texto";
            cboBuscar.ValueMember = "Valor";
            cboBuscar.SelectedIndex = 0;
            List<Productos> listaProducto = new N_Productos().Listar();
            foreach (Productos item in listaProducto)
            {
                DgvDataProductos.Rows.Add(new object[] {
                    "",
                        item.productosID,
                        item.codigos,
                        item.nombresProductos,
                        item.descripciones,
                        item.ocategorias.categoriasID,
                        item.ocategorias.nombresCategorias,
                        item.preciosCompras,
                        item.preciosVentas,
                        item.estados == true ? 1 : 0,
                        item.estados == true ? "Activo" : "No Activo"
            });
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Productos objproducto = new Productos()
            {
                productosID = Convert.ToInt32(TextID.Text),
                codigos = TextCodigos.Text,
                nombresProductos = TextNombreProducto.Text,
                descripciones = TextDescripciones.Text,
                ocategorias = new Categorias() { categoriasID = Convert.ToInt32(((OpcionCombo)CboCategorias.SelectedItem).Valor) },
                preciosCompras = Convert.ToDecimal(TextPrecioCompra.Text),
                preciosVentas = Convert.ToDecimal(TextPrecioVenta.Text),
                estados = Convert.ToInt32(((OpcionCombo)CboEstados.SelectedItem).Valor) == 1 ? true : false
            };
            if (objproducto.productosID == 0)
            {
                int productoidgenerado = new N_Productos().Registrar(objproducto, out Mensaje);
                if (productoidgenerado != 0)
                {
                    DgvDataProductos.Rows.Clear();  
                    FrmProductos_Load(null, EventArgs.Empty); 
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
            else
            {
                bool resultado = new N_Productos().Editar(objproducto, out Mensaje);
                if (resultado)
                {
                    DataGridViewRow row = DgvDataProductos.Rows[Convert.ToInt32(TextIndice.Text)];
                    row.Cells["ID"].Value = TextID.Text;
                    row.Cells["Codigo"].Value = TextCodigos.Text;
                    row.Cells["Nombre_Producto"].Value = TextNombreProducto.Text;
                    row.Cells["Descripcion"].Value = TextDescripciones.Text;
                    row.Cells["categoriasID"].Value = ((OpcionCombo)CboCategorias.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)CboCategorias.SelectedItem).Texto.ToString();
                    row.Cells["PrecioCompra"].Value = objproducto.preciosCompras.ToString("F2");  
                    row.Cells["PrecioVenta"].Value = objproducto.preciosVentas.ToString("F2");    
                    row.Cells["Estado_Valor"].Value = ((OpcionCombo)CboEstados.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)CboEstados.SelectedItem).Texto.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
        }
        private void Limpiar()
        {
            TextIndice.Text = "-1";
            TextID.Text = "0";
            TextCodigos.Text = "";
            TextNombreProducto.Text = "";
            TextDescripciones.Text = "";
            CboCategorias.SelectedIndex = 0;
            TextPrecioCompra.Text = "";
            TextPrecioVenta.Text = "";
            CboEstados.SelectedIndex = 0;
            TextCodigos.Select();
        }
        private void DgvDataProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDataProductos.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    TextIndice.Text = indice.ToString();
                    TextID.Text = DgvDataProductos.Rows[indice].Cells["ID"].Value.ToString();
                    TextCodigos.Text = DgvDataProductos.Rows[indice].Cells["Codigo"].Value.ToString();
                    TextNombreProducto.Text = DgvDataProductos.Rows[indice].Cells["Nombre_Producto"].Value.ToString();
                    TextDescripciones.Text = DgvDataProductos.Rows[indice].Cells["Descripcion"].Value.ToString();
                    foreach (OpcionCombo oc in CboCategorias.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvDataProductos.Rows[indice].Cells["categoriasID"].Value))
                        {
                            int indice_combo = CboCategorias.Items.IndexOf(oc);
                            CboCategorias.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    TextPrecioCompra.Text = DgvDataProductos.Rows[indice].Cells["PrecioCompra"].Value.ToString();
                    TextPrecioVenta.Text = DgvDataProductos.Rows[indice].Cells["PrecioVenta"].Value.ToString();
                    foreach (OpcionCombo oc in CboEstados.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvDataProductos.Rows[indice].Cells["Estado_Valor"].Value))
                        {
                            int indice_combo = CboEstados.Items.IndexOf(oc);
                            CboEstados.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }
        private void DgvDataProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
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
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextID.Text) != 0)
            {
                if (MessageBox.Show("¿Deseas eliminar el Prodcuto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Productos objproducto = new Productos()
                    {
                        productosID = Convert.ToInt32(TextID.Text)
                    };
                    bool Respuesta = new N_Productos().Eliminar(objproducto, out string Mensaje);
                    if (Respuesta)
                    {
                        DgvDataProductos.Rows.RemoveAt(Convert.ToInt32(TextIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).Valor.ToString();
            if (DgvDataProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataProductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToUpper().Contains(textBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            textBusqueda.Text = "";
            foreach (DataGridViewRow row in DgvDataProductos.Rows)
            {
                row.Visible = true;
            }
        }
        private void BtnInventario_Click(object sender, EventArgs e)
        {
            using (var modal = new mdInventario())
            {
                var result = modal.ShowDialog();
            }
        }
        private void textBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnBuscar.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnLimpiarBuscador.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
