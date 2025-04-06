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


namespace PuntoVentaFruteria.Modales
{
    public partial class mdGastosPersonales : Form
    {
        private Usuarios _Usuarios;
        public mdGastosPersonales(Usuarios ousuarios)
        {
            _Usuarios = ousuarios;
            InitializeComponent();
        }
        private void GastosPersonales_Load(object sender, EventArgs e)
        {
            TextNombreUsuario.Text = _Usuarios.nombresUsuarios;
            TextNombreUsuario.ReadOnly = true;
            TextFecha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            TextBusquedas.KeyDown += TextBusquedas_KeyDown;

            foreach (DataGridViewColumn columna in DgvDataGastosPersonales.Columns)
            {
                if (columna.Visible == true && columna.Name != "Seleccionar")
                {
                    CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valor";
            CboBuscar.SelectedIndex = 0;
            cargarGastos();
        }
        private void cargarGastos()
        {
            DgvDataGastosPersonales.Rows.Clear();
            List<Gastos> listaGastos = new N_Gastos().Listar();
            foreach (Gastos item in listaGastos)
            {
                DgvDataGastosPersonales.Rows.Add(new object[] {"",
                item.gastosID,
                item.oUsuarios.usuariosID,
                item.oUsuarios.nombresUsuarios,
                item.concepto,
                item.montosTotales,
                item.fechaRegistros.ToString("yyyy-MM-dd HH:mm:ss"),
            });
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }
        private void RealizarBusqueda()
        {
            string columnaFiltro = ((OpcionCombo)CboBuscar.SelectedItem).Valor.ToString();
            if (DgvDataGastosPersonales.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataGastosPersonales.Rows)
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
            foreach (DataGridViewRow row in DgvDataGastosPersonales.Rows)
            {
                row.Visible = true;
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Gastos objgastos = new Gastos()
            {
                oUsuarios = new Usuarios()
                {
                    usuariosID = _Usuarios.usuariosID
                },
                concepto = TextConcepto.Text,
                montosTotales = Convert.ToDecimal(TextMontoTotal.Text),
                fechaRegistros = DateTime.Now
            };
            if (Convert.ToInt32(TextID.Text) > 0)
            {
                objgastos.gastosID = Convert.ToInt32(TextID.Text);
            }

            if (objgastos.gastosID == 0)
            {
                int gastosIDGenerado = new N_Gastos().GuardarGastos(objgastos, out Mensaje);
                if (gastosIDGenerado != 0)
                {
                    cargarGastos(); 
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de actualizar este gasto?", "Confirmar actualización",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool resultado = new N_Gastos().EditarGastos(objgastos, out Mensaje);
                    if (resultado)
                    {
                        cargarGastos();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Limpiar()
        {
            TextIndice.Text = "-1";
            TextID.Text = "0";
            TextConcepto.Text = "";
            TextMontoTotal.Text = "";
            TextConcepto.Select();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextID.Text) != 0)
            {
                if (MessageBox.Show("¿Deseas eliminar el gasto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string Mensaje = string.Empty;
                    Gastos objGasto = new Gastos()
                    {
                        gastosID = Convert.ToInt32(TextID.Text)
                    };
                    bool Respuesta = new N_Gastos().EliminarGastos(objGasto, out Mensaje);
                    if (Respuesta)
                    {
                        DgvDataGastosPersonales.Rows.RemoveAt(Convert.ToInt32(TextIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void DgvDataGastosPersonales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDataGastosPersonales.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    TextIndice.Text = indice.ToString();
                    TextID.Text = DgvDataGastosPersonales.Rows[indice].Cells["gastosID"].Value.ToString();
                    TextNombreUsuario.Text = DgvDataGastosPersonales.Rows[indice].Cells["nombresUsuarios"].Value.ToString();
                    TextConcepto.Text = DgvDataGastosPersonales.Rows[indice].Cells["concepto"].Value.ToString();
                    TextMontoTotal.Text = DgvDataGastosPersonales.Rows[indice].Cells["montosTotales"].Value.ToString();
                    TextFecha.Text = DgvDataGastosPersonales.Rows[indice].Cells["fechaRegistros"].Value.ToString();
                }
            }
        }
        private void DgvDataGastosPersonales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void BtnBuscarFechas_Click(object sender, EventArgs e)
        {
            string fechaInicio = DateTimePicker1.Value.ToString("yyyy/MM/dd");
            string fechaFin = DateTimePicker2.Value.ToString("yyyy/MM/dd");
            List<Gastos> listaGastos = new N_Gastos().ReporteGastos(fechaInicio, fechaFin);
            DgvDataGastosPersonales.Rows.Clear();
            decimal totalGastado = 0;
            foreach (Gastos item in listaGastos)
            {
                DgvDataGastosPersonales.Rows.Add(new object[] {
                "", 
                item.gastosID,
                item.oUsuarios.usuariosID,
                item.oUsuarios.nombresUsuarios,
                item.concepto,
                item.montosTotales,
                item.fechaRegistros.ToString("yyyy-MM-dd HH:mm:ss")
            });

                totalGastado += item.montosTotales;
            }
            TextMontoGasto.Text = totalGastado.ToString("F2");
        }
    }
}

