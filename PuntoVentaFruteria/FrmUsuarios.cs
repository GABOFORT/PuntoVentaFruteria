using Entidades;
using PuntoVentaFruteria.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoVentaFruteria.Utilidades;
using Entidades;
using Negocios;
using Negocio;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using PuntoVentaFruteria.Modales;

namespace PuntoVentaFruteria
{
    public partial class FrmUsuarios : Form
    {
        private Usuarios _Usuarios;
        public FrmUsuarios(Usuarios ousuarios)
        {
            _Usuarios = ousuarios;
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CboEstado.DisplayMember = "Texto";
            CboEstado.ValueMember = "Valor";
            CboEstado.SelectedIndex = 0;
            List<Roles> listaRol = new N_Roles().Listar();
            foreach (Roles item in listaRol)
            {
                CboRol.Items.Add(new OpcionCombo() { Valor = item.rolesID, Texto = item.nombresRoles });
            }
            CboRol.DisplayMember = "Texto";
            CboRol.ValueMember = "Valor";
            CboRol.SelectedIndex = 0;
            foreach (DataGridViewColumn columna in DgvDataUsuario.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    CboBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            CboBuscar.DisplayMember = "Texto";
            CboBuscar.ValueMember = "Valor";
            CboBuscar.SelectedIndex = 0;
            List<Usuarios> listaUsuario = new N_Usuarios().Listar();
            foreach (Usuarios item in listaUsuario)
            {
                DgvDataUsuario.Rows.Add(new object[] {"",item.usuariosID,item.nombresUsuarios,item.contraseñas,
                item.oRoles.rolesID,
                item.oRoles.nombresRoles,
                item.estados == true ? 1 : 0,
                item.estados == true ? "Activo" : "No Activo",
            });

            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Mensaje = string.Empty;
            Usuarios objusuarios = new Usuarios()
            {
                usuariosID = Convert.ToInt32(TextID.Text),
                nombresUsuarios = TextNombreCompleto.Text,
                contraseñas = TextClave.Text,
                oRoles = new Roles() { rolesID = Convert.ToInt32(((OpcionCombo)CboRol.SelectedItem).Valor) },
                estados = Convert.ToInt32(((OpcionCombo)CboEstado.SelectedItem).Valor) == 1 ? true : false
            };
            if (objusuarios.usuariosID == 0)
            {
                int usuarioidgenerado = new N_Usuarios().Registrar(objusuarios, out Mensaje);
                if (usuarioidgenerado != 0)
                {
                    DgvDataUsuario.Rows.Add(new object[] {"",usuarioidgenerado,TextNombreCompleto.Text,TextClave.Text,
                ((OpcionCombo)CboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CboRol.SelectedItem).Texto.ToString(),
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
                bool resultado = new N_Usuarios().Editar(objusuarios, out Mensaje);
                if (resultado)
                {
                    DataGridViewRow row = DgvDataUsuario.Rows[Convert.ToInt32(TextIndice.Text)];
                    row.Cells["ID"].Value = TextID.Text;
                    row.Cells["Nombre_Usuario"].Value = TextNombreCompleto.Text;
                    row.Cells["Clave"].Value = TextClave.Text;
                    row.Cells["rolID"].Value = ((OpcionCombo)CboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)CboRol.SelectedItem).Texto.ToString();
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
            TextIndice.Text = "-1";
            TextID.Text = "0";
            TextNombreCompleto.Text = "";
            TextClave.Text = "";
            CboRol.SelectedIndex = 0;
            CboEstado.SelectedIndex = 0;
            TextNombreCompleto.Select();
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void BtnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            TextBusquedas.Text = "";
            foreach (DataGridViewRow row in DgvDataUsuario.Rows)
            {
                row.Visible = true;
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)CboBuscar.SelectedItem).Valor.ToString();
            if (DgvDataUsuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DgvDataUsuario.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().ToUpper().Contains(TextBusquedas.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextID.Text) != 0)
            {
                if (MessageBox.Show("¿Deseas eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuarios objusuario = new Usuarios()
                    {
                        usuariosID = Convert.ToInt32(TextID.Text)
                    };
                    bool Respuesta = new N_Usuarios().Eliminar(objusuario, out string Mensaje);
                    if (Respuesta)
                    {
                        DgvDataUsuario.Rows.RemoveAt(Convert.ToInt32(TextIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void DgvDataUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
        private void DgvDataUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDataUsuario.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    TextIndice.Text = indice.ToString();
                    TextID.Text = DgvDataUsuario.Rows[indice].Cells["ID"].Value.ToString();
                    TextNombreCompleto.Text = DgvDataUsuario.Rows[indice].Cells["Nombre_Usuario"].Value.ToString();
                    TextClave.Text = DgvDataUsuario.Rows[indice].Cells["Clave"].Value.ToString();
                    foreach (OpcionCombo oc in CboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvDataUsuario.Rows[indice].Cells["rolID"].Value))
                        {
                            int indice_combo = CboRol.Items.IndexOf(oc);
                            CboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionCombo oc in CboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvDataUsuario.Rows[indice].Cells["Estado_Valor"].Value))
                        {
                            int indice_combo = CboEstado.Items.IndexOf(oc);
                            CboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }
        private void BtnVerContraseña_Click(object sender, EventArgs e)
        {
            if (TextClave.PasswordChar == '*')
            {
                TextClave.PasswordChar = '\0'; 
            }
            else
            {
                TextClave.PasswordChar = '*'; 
            }
        }
        private void BtnGastos_Click(object sender, EventArgs e)
        {
            using (var modal = new mdGastosPersonales(_Usuarios))
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCierre())
            {
                var result = modal.ShowDialog();
            }
        }
    }
}
