using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;
using PuntoVentaFruteria.Utilidades;

namespace PuntoVentaFruteria.Modales
{
    public partial class mdInventario : Form
    {
        public Inventarios _Inventarios { get; set; }
        public mdInventario()
        {
            InitializeComponent();
        }
        private void mdInventario_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DgvDataMDInventarios.Columns)
            {
                if (columna.Visible == true)
                {
                    CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valor";
            CboBuscar.SelectedIndex = 0;
            CargarInventarios();
        }
        private void CargarInventarios()
        {
            DgvDataMDInventarios.Rows.Clear();
            List<Inventarios> listaInventarios = new N_Inventarios().Listar();
            foreach (Inventarios item in listaInventarios)
            {
                DgvDataMDInventarios.Rows.Add(new object[] {
                    item.inventariosID,
                    item.oProductosID.nombresProductos,
                    item.oProductosID.descripciones,
                    item.stockActual,
                    item.stockMinimo,
                    item.fechaActualizacion.ToString("yyyy-MM-dd HH:mm:ss")
                });
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TextBusquedas.Text = "";
            foreach (DataGridViewRow row in DgvDataMDInventarios.Rows)
            {
                row.Visible = true;
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CboBuscar.SelectedItem).Valor.ToString();
            if (DgvDataMDInventarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataMDInventarios.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToUpper().Contains(TextBusquedas.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void iconBtnAgregarProductos_Click(object sender, EventArgs e)
        {
            using (var modalProductos = new mdProductos())
            {
                if (modalProductos.ShowDialog() == DialogResult.OK)
                {
                    Productos productoSeleccionado = modalProductos._Productos;
                    if (productoSeleccionado != null)
                    {
                        int stockActual = 0; 
                        int stockMinimo = 1;  
                        Inventarios nuevoInventario = new Inventarios()
                        {
                            oProductosID = productoSeleccionado,
                            stockActual = stockActual,
                            stockMinimo = stockMinimo,
                            fechaActualizacion = DateTime.Now
                        };
                        bool insertado = new N_Inventarios().Insertar(nuevoInventario);
                        if (insertado)
                        {
                            MessageBox.Show("Producto agregado al inventario correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarInventarios();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el producto al inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void iconBtnEliminarProductos_Click(object sender, EventArgs e)
        {
            if (DgvDataMDInventarios.CurrentRow != null)
            {
                int inventarioID = Convert.ToInt32(DgvDataMDInventarios.CurrentRow.Cells["inventariosID"].Value);
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de eliminar este producto del inventario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool eliminado = new N_Inventarios().Eliminar(inventarioID);
                    if (eliminado)
                    {
                        MessageBox.Show("Producto eliminado del inventario correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarInventarios();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto del inventario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto del inventario para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBusquedas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnBuscar.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                BtnLimpiar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}