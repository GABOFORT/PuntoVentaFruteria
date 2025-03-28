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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CboEstados.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstados.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CboEstados.DisplayMember = "Texto";
            CboEstados.ValueMember = "Valor";
            CboEstados.SelectedIndex = 0;
            foreach (DataGridViewColumn columna in DgvDataCategorias.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valor";
            CboBuscar.SelectedIndex = 0;
            List<Categorias> listaCategoria = new N_Categorias().Listar();
            foreach (Categorias item in listaCategoria)
            {
                DgvDataCategorias.Rows.Add(new object[] {"",item.categoriasID,
                item.nombresCategorias,
                item.estados == true ? 1 : 0,
                item.estados == true ? "Activo" : "No Activo"
            });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Categorias objCategoria = new Categorias()
            {
                categoriasID = Convert.ToInt32(TextID.Text),
                nombresCategorias = TextNombreCategorias.Text,
                estados = Convert.ToInt32(((OpcionCombo)CboEstados.SelectedItem).Valor) == 1 ? true : false
            };
            if (objCategoria.categoriasID == 0)
            {
                int categoriaidgenerado = new N_Categorias().Registrar(objCategoria, out Mensaje);
                if (categoriaidgenerado != 0)
                {
                DgvDataCategorias.Rows.Add(new object[] {"",categoriaidgenerado,TextNombreCategorias.Text,
                ((OpcionCombo)CboEstados.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CboEstados.SelectedItem).Texto.ToString(),
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
                bool resultado = new N_Categorias().Editar(objCategoria, out Mensaje);
                if (resultado)
                {
                    DataGridViewRow row = DgvDataCategorias.Rows[Convert.ToInt32(TextIndices.Text)];
                    row.Cells["ID"].Value = TextID.Text;
                    row.Cells["Descripcion"].Value = TextNombreCategorias.Text;
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
            TextIndices.Text = "-1";
            TextID.Text = "0";
            TextNombreCategorias.Text = "";
            CboEstados.SelectedIndex = 0;

            TextNombreCategorias.Select();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextID.Text) != 0)
            {
                if (MessageBox.Show("¿Deseas eliminar el nombre de la categoria", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categorias objCategoria = new Categorias()
                    {
                        categoriasID = Convert.ToInt32(TextID.Text)
                    };
                    bool Respuesta = new N_Categorias().Eliminar(objCategoria, out string Mensaje);
                    if (Respuesta)
                    {
                        DgvDataCategorias.Rows.RemoveAt(Convert.ToInt32(TextIndices.Text));
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
            if (DgvDataCategorias.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataCategorias.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToUpper().Contains(TextBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            TextBusqueda.Text = "";
            foreach (DataGridViewRow row in DgvDataCategorias.Rows)
            {
                row.Visible = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DgvDataCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDataCategorias.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int Indices = e.RowIndex;
                if (Indices >= 0)
                {
                    TextIndices.Text = Indices.ToString();
                    TextID.Text = DgvDataCategorias.Rows[Indices].Cells["ID"].Value.ToString();
                    TextNombreCategorias.Text = DgvDataCategorias.Rows[Indices].Cells["Descripcion"].Value.ToString();
                    foreach (OpcionCombo oc in CboEstados.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvDataCategorias.Rows[Indices].Cells["Estado_Valor"].Value))
                        {
                            int Indices_combo = CboEstados.Items.IndexOf(oc);
                            CboEstados.SelectedIndex = Indices_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void DgvDataCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void TextBusqueda_KeyDown(object sender, KeyEventArgs e)
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
