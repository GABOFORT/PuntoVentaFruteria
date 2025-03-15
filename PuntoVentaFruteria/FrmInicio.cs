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
using FontAwesome.Sharp;
using PuntoVentaFruteria.Modales;

namespace PuntoVentaFruteria
{
    public partial class FrmInicio : Form
    {
        private static Usuarios usuariosActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public FrmInicio(Usuarios objusuarios)
        {
            usuariosActual = objusuarios;
            InitializeComponent();
        }
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            List<Permisos> ListaPermisos = new N_Permisos().Listar(usuariosActual.usuariosID);
            foreach (ToolStripMenuItem icommenu in menuIconos.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.nombresPermisos == icommenu.Name);
                if (encontrado == false)
                {
                    icommenu.Visible = false;
                }
            }
            Lblusuario.Text = usuariosActual.nombresUsuarios;
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.SteelBlue;
            MenuActivo = menu;
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());
        }
        private void RegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new FrmVentas(usuariosActual));
        }
        private void DetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new FrmDetalleVentas());
        }
        private void MenuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProductos());
        }
        private void RegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new FrmCompras(usuariosActual));
        }
        private void DetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new FrmDetalleCompras());
        }
        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());
        }
        private void MenuCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmCategorias());
        }
        private void MenuAcercaDe_Click(object sender, EventArgs e)
        {
            mdAcercaDe md = new mdAcercaDe();
            md.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void submenureportecompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new FrmReportesCompras());
        }
        private void submenureporteventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuReportes, new FrmReportesVentas());
        }
    }
}
