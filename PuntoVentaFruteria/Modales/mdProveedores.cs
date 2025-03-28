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
    public partial class mdProveedores : Form
    {
        public Proveedores _Proveedores { get; set; }
        public mdProveedores()
        {
            InitializeComponent();
        }
        private void mdProveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DgvDataMDProveedores.Columns)
            {
                if (columna.Visible == true)
                {
                    CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valor";
            CboBuscar.SelectedIndex = 0;
            List<Proveedores> listaProveedor = new N_Proveedores().Listar();
            foreach (Proveedores item in listaProveedor)
            {
                DgvDataMDProveedores.Rows.Add(new object[] {
                    item.proveedoresID,
                    item.clavesProveedores,
                    item.nombresProveedores

            });
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CboBuscar.SelectedItem).Valor.ToString();

            if (DgvDataMDProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataMDProveedores.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToUpper().Contains(TextBusquedas.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            TextBusquedas.Text = "";
            foreach (DataGridViewRow row in DgvDataMDProveedores.Rows)
            {
                row.Visible = true;
            }
        }

        private void DgvDataMDProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum >= 0)
            {
                _Proveedores = new Proveedores()
                {
                    proveedoresID = Convert.ToInt32(DgvDataMDProveedores.Rows[iRow].Cells["ID"].Value.ToString()),
                    clavesProveedores = DgvDataMDProveedores.Rows[iRow].Cells["Clave_Proveedor"].Value.ToString(),
                    nombresProveedores = DgvDataMDProveedores.Rows[iRow].Cells["Nombre_Proveedor"].Value.ToString()


                };
                this.DialogResult = DialogResult.OK;
                this.Close();
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
                BtnLimpiarBuscador.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
