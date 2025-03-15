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
using PuntoVentaFruteria.Modales;
using PuntoVentaFruteria.Utilidades;

namespace PuntoVentaFruteria
{
    public partial class FrmReportesCompras : Form
    {
        public FrmReportesCompras()
        {
            InitializeComponent();
        }
        private void FrmReportesCompras_Load(object sender, EventArgs e)
        {
            List<Proveedores> lista = new N_Proveedores().Listar();
            CboBuscarProveedores.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });
            foreach (Proveedores item in lista)
            {
                CboBuscarProveedores.Items.Add(new OpcionCombo() { Valor = item.proveedoresID, Texto = item.nombresProveedores });
            }
            CboBuscarProveedores.DisplayMember = "Texto";
            CboBuscarProveedores.ValueMember = "Valor";
            CboBuscarProveedores.SelectedIndex = 0;
            foreach (DataGridViewColumn columna in DgvDataReportesCompra.Columns)
            {
                CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valior";
            CboBuscar.SelectedIndex = 0;
        }
        private void BtnBuscarProveedores_Click(object sender, EventArgs e)
        {
            int proveedoresID = Convert.ToInt32(((OpcionCombo)CboBuscarProveedores.SelectedItem).Valor.ToString());

            List<ReportesCompras> lista = new List<ReportesCompras>();

            lista = new N_Reportes().Compras(
                DateTimePicker1.Value.ToString("yyyy/MM/dd"),
                DateTimePicker2.Value.ToString("yyyy/MM/dd"),
                proveedoresID
                );
            DgvDataReportesCompra.Rows.Clear();
            decimal totalCompras = 0;
            foreach (ReportesCompras rc in lista)
            {
                DgvDataReportesCompra.Rows.Add(new object[]
                {
                    rc.FechaRegistros,
                    rc.numerosCompras,
                    rc.montosTotales,
                    rc.UsuariosRegistros,
                    rc.clavesProveedores,
                    rc.nombresProveedores,
                    rc.CodigosProductos,
                    rc.NombresProductos,
                    rc.Descripciones,
                    rc.NombresCategorias,
                    rc.preciosCompras,
                    rc.preciosVentas,
                    rc.cantidades,
                    rc.SubTotales,
                });
                if (decimal.TryParse(rc.SubTotales, out decimal monto))
                {
                    totalCompras += monto;
                }
            }
            TextMontoCompra.Text = totalCompras.ToString("F2");
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CboBuscar.SelectedItem).Valor.ToString();
            if (DgvDataReportesCompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataReportesCompra.Rows)
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
            foreach (DataGridViewRow row in DgvDataReportesCompra.Rows)
            {
                row.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBusquedas_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerMasVendidos_Click(object sender, EventArgs e)
        {
            using (var modal = new mdComprasDesplazados())
            {
                var result = modal.ShowDialog();
            }
        }
    }
}
