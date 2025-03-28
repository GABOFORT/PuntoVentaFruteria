﻿using System;
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
    public partial class FrmReportesVentas : Form
    {
        public FrmReportesVentas()
        {
            InitializeComponent();
        }
        private void FrmReportesVentas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in DgvDataReportesVentas.Columns)
            {
                CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valior";
            CboBuscar.SelectedIndex = 0;
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CboBuscar.SelectedItem).Valor.ToString();
            if (DgvDataReportesVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataReportesVentas.Rows)
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
            foreach (DataGridViewRow row in DgvDataReportesVentas.Rows)
            {
                row.Visible = true;
            }
        }
        private void BtnBtnBuscarFechas_Click(object sender, EventArgs e)
        {
            List<ReportesVentas> lista = new List<ReportesVentas>();
            lista = new N_Reportes().Ventas(
                DateTimePicker1.Value.ToString("yyyy/MM/dd"),
                DateTimePicker2.Value.ToString("yyyy/MM/dd"));
            DgvDataReportesVentas.Rows.Clear();
            decimal totalVentas = 0;  
            foreach (ReportesVentas rc in lista)
            {
                DgvDataReportesVentas.Rows.Add(new object[]
                {
                        rc.FechaRegistros,
                        rc.numerosVentas,
                        rc.montosTotales,
                        rc.UsuariosRegistros,
                        rc.CodigosProductos,
                        rc.NombresProductos,
                        rc.Descripciones,
                        rc.NombresCategorias,
                        rc.preciosVentas,
                        rc.cantidades,
                        rc.SubTotales,
                });
                if (decimal.TryParse(rc.SubTotales, out decimal monto))
                {
                    totalVentas += monto;
                }
            }
            TextMontoVenta.Text = totalVentas.ToString("F2");
        }
        private void BtnVerMasVendidos_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductosDesplazados())
            {
                var result = modal.ShowDialog();
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
