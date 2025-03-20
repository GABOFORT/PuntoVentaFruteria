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
        private int menuIndex = 0;
        private int subMenuIndex = -1;
        public FrmInicio(Usuarios objusuarios)
        {
            usuariosActual = objusuarios;
            InitializeComponent();
            this.KeyPreview = true; 
            this.KeyDown += FrmInicio_KeyDown;
            menuIconos.KeyDown += MenuIconos_KeyDown;
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
            menuIconos.Focus();
        }
        private void MenuIconos_KeyDown(object sender, KeyEventArgs e)
        {
            ToolStripItemCollection items = menuIconos.Items;
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                if (e.KeyCode == Keys.Left)
                {
                    menuIndex = (menuIndex - 1 + items.Count) % items.Count;
                }
                else if (e.KeyCode == Keys.Right)
                {
                    menuIndex = (menuIndex + 1) % items.Count;
                }
                items[menuIndex].Select();
                subMenuIndex = -1; 
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                if (items[menuIndex] is ToolStripMenuItem menuItem && menuItem.DropDownItems.Count > 0)
                {
                    ToolStripItemCollection subItems = menuItem.DropDownItems;
                    if (e.KeyCode == Keys.Up)
                    {
                        subMenuIndex = (subMenuIndex - 1 + subItems.Count) % subItems.Count;
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        subMenuIndex = (subMenuIndex + 1) % subItems.Count;
                    }
                    subItems[subMenuIndex].Select();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (subMenuIndex != -1 && items[menuIndex] is ToolStripMenuItem menuItem && menuItem.DropDownItems.Count > 0)
                {
                    menuItem.DropDownItems[subMenuIndex].PerformClick();
                }
                else
                {
                    items[menuIndex].PerformClick();
                }
            }
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
        private void FrmInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
             }
            }
        }
}
