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
using Negocio;
using Negocios;
using PuntoVentaFruteria.Utilidades;
using static System.Net.Mime.MediaTypeNames;

namespace PuntoVentaFruteria
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CboEstado.DisplayMember = "Texto";
            CboEstado.ValueMember = "Valor";
            CboEstado.SelectedIndex = 0;
            foreach (DataGridViewColumn columna in DgvDataProveedores.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valor";
            CboBuscar.SelectedIndex = 0;
            List<Proveedores> listaProveedores = new N_Proveedores().Listar();
            foreach (Proveedores item in listaProveedores)
            {
                DgvDataProveedores.Rows.Add(new object[] {
                    "",
                    item.proveedoresID,
                    item.clavesProveedores,
                    item.nombresProveedores,
                    item.telefonos,
                    item.estados == true ? 1 : 0,
                    item.estados == true ? "Activo" : "No Activo"
            });
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Proveedores objProveedores = new Proveedores()
            {
                proveedoresID = Convert.ToInt32(TextID.Text),
                clavesProveedores = TextClaveProveedores.Text,
                nombresProveedores = TextNombreProveedores.Text,
                telefonos = TextTelefono.Text,
                estados = Convert.ToInt32(((OpcionCombo)CboEstado.SelectedItem).Valor) == 1 ? true : false
            };
            if (objProveedores.proveedoresID == 0)
            {
                int Proveedoresidgenerado = new N_Proveedores().Registrar(objProveedores, out Mensaje);
                if (Proveedoresidgenerado != 0)
                {
                    DgvDataProveedores.Rows.Add(new object[] {"",Proveedoresidgenerado,TextClaveProveedores.Text,TextNombreProveedores.Text,TextTelefono.Text,
                ((OpcionCombo)CboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CboEstado.SelectedItem).Texto.ToString(),
                });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            }
            else
            {
                bool resultado = new N_Proveedores().Editar(objProveedores, out Mensaje);
                if (resultado)
                {
                    DataGridViewRow row = DgvDataProveedores.Rows[Convert.ToInt32(TextIndices.Text)];
                    row.Cells["ID"].Value = TextID.Text;
                    row.Cells["Clave_Proveedor"].Value = TextClaveProveedores.Text;
                    row.Cells["Nombre_Proveedor"].Value = TextNombreProveedores.Text;
                    row.Cells["Telefono"].Value = TextTelefono.Text;
                    row.Cells["Estado_Valor"].Value = ((OpcionCombo)CboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)CboEstado.SelectedItem).Texto.ToString();
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
            TextIndices.Text = "-1";
            TextID.Text = "0";
            TextClaveProveedores.Text = "";
            TextNombreProveedores.Text = "";
            TextTelefono.Text = "";
            CboEstado.SelectedIndex = 0;
            TextClaveProveedores.Select();
    }
        private void DgvDataProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void DgvDataProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDataProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    TextIndices.Text = indice.ToString();
                    TextID.Text = DgvDataProveedores.Rows[indice].Cells["ID"].Value.ToString();
                    TextClaveProveedores.Text = DgvDataProveedores.Rows[indice].Cells["Clave_Proveedor"].Value.ToString();
                    TextNombreProveedores.Text = DgvDataProveedores.Rows[indice].Cells["Nombre_Proveedor"].Value.ToString();
                    TextTelefono.Text = DgvDataProveedores.Rows[indice].Cells["Telefono"].Value.ToString();
                    foreach (OpcionCombo oc in CboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvDataProveedores.Rows[indice].Cells["Estado_Valor"].Value))
                        {
                            int indice_combo = CboEstado.Items.IndexOf(oc);
                            CboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextID.Text) != 0)
            {
                if (MessageBox.Show("¿Deseas eliminar el Proveedores", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedores objProveedores = new Proveedores()
                    {
                        proveedoresID = Convert.ToInt32(TextID.Text)
                    };
                    bool Respuesta = new N_Proveedores().Eliminar(objProveedores, out string Mensaje);
                    if (Respuesta)
                    {
                        DgvDataProveedores.Rows.RemoveAt(Convert.ToInt32(TextIndices.Text));
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
            string columnaFiltro = ((OpcionCombo)CboBuscar.SelectedItem).Valor.ToString();
            if (DgvDataProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataProveedores.Rows)
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
            foreach (DataGridViewRow row in DgvDataProveedores.Rows)
            {
                row.Visible = true;
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
