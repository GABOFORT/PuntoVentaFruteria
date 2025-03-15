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
    public partial class mdProductos : Form
    {
        public Productos _Productos { get; set; }
        public mdProductos()
        {
            InitializeComponent();
        }
        private void mdProductos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DgvDataMDProductos.Columns)
            {
                if (columna.Visible == true)
                {
                    CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valor";
            CboBuscar.SelectedIndex = 0;
            List<Productos> listaProducto = new N_Productos().Listar();
            foreach (Productos item in listaProducto)
            {
                DgvDataMDProductos.Rows.Add(new object[] {
                        item.productosID,
                        item.codigos,
                        item.nombresProductos,
                        item.descripciones,
                        item.ocategorias.nombresCategorias,
                        item.preciosCompras,
                        item.preciosVentas,
            });
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CboBuscar.SelectedItem).Valor.ToString();
            if (DgvDataMDProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataMDProductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToUpper().Contains(TextBusquedas.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TextBusquedas.Text = "";
            foreach (DataGridViewRow row in DgvDataMDProductos.Rows)
            {
                row.Visible = true;
            }
        }
        private void DgvDataMDProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if (iRow >= 0 && iColum > 0)
            {
                _Productos = new Productos()
                {
                    productosID = Convert.ToInt32(DgvDataMDProductos.Rows[iRow].Cells["ID"].Value.ToString()),
                    codigos = DgvDataMDProductos.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    nombresProductos = DgvDataMDProductos.Rows[iRow].Cells["Nombre_Producto"].Value.ToString(),
                    descripciones = DgvDataMDProductos.Rows[iRow].Cells["descripcion"].Value.ToString(),
                    preciosCompras = Convert.ToDecimal(DgvDataMDProductos.Rows[iRow].Cells["Precio_Compra"].Value.ToString()),
                    preciosVentas = Convert.ToDecimal(DgvDataMDProductos.Rows[iRow].Cells["Precio_Venta"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
