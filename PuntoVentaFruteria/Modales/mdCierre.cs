using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVentaFruteria.Modales
{
    public partial class mdCierre : Form
    {
        public mdCierre()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(mdCierre_KeyDown);
            TextCierreCaja.ReadOnly = true;
            TextCierreCaja.TabStop = false;
            TextCierreCaja.Enter += TextCierreCaja_Enter;
        }
        private void TextCierreCaja_Enter(object sender, EventArgs e)
        {
            BtnCierre.Focus(); 
        }
        private void mdCierre_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                    if (BtnCierre.Focused) BtnTicket.Focus();
                    else if (BtnTicket.Focused) BtnCierre.Focus();
                    e.Handled = true; 
                    break;
                case Keys.Escape:
                    this.Close(); 
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    if (BtnCierre.Focused) BtnCierre.PerformClick();
                    else if (BtnTicket.Focused) BtnTicket.PerformClick();
                    e.Handled = true;
                    break;
            }
        }
        private void mdCierre_Load(object sender, EventArgs e)
        {
            BtnCierre.Focus();
            BtnCierre.TabIndex = 0;  
            BtnTicket.TabIndex = 1;
        }
        private void BtnCierre_Click(object sender, EventArgs e)
        {
            N_Reportes reportes = new N_Reportes();
            string mensajeError;
            decimal totalVentas = reportes.ObtenerTotalVentasHoy(out mensajeError);
            if (string.IsNullOrEmpty(mensajeError))
            {
                TextCierreCaja.Text = totalVentas.ToString("C2");
            }
            else
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnCierre.Focus();
            }
        }
        private void BtnTicket_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TextCierreCaja.Text, System.Globalization.NumberStyles.Currency, null, out decimal totalVentas))
            {
                GenerarTicketCierreCaja(totalVentas);
            }
            else
            {
                MessageBox.Show("Primero realiza el cierre para calcular el total de ventas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BtnCierre.Focus();
            }
        }
        private void GenerarTicketCierreCaja(decimal totalVentas)
        {
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine("********** TICKET DE CIERRE DE CAJA **********");
            ticket.AppendLine($"Fecha: {fechaHora}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine($"{"Descripción",-30} {"Monto",10}");
            ticket.AppendLine("----------------------------------------------");
            ticket.AppendLine($"{"Total de Venta:",-30} {totalVentas,10:C}");
            ticket.AppendLine("==============================================");
            ticket.AppendLine("Turno cerrado correctamente");
            ticket.AppendLine("¡Éxito Siempre!");
            ticket.AppendLine();
            MessageBox.Show(ticket.ToString(), "Ticket Digital", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnTicket.Focus();
        }
    }
}
