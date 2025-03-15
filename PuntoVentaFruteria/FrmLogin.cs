using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;
namespace PuntoVentaFruteria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Usuarios ousario = new N_Usuarios().Listar().Where(u => u.nombresUsuarios == Textusuario.Text && u.contraseñas == Textclave.Text).FirstOrDefault();
            if (ousario != null)
            {
                FrmInicio form = new FrmInicio(ousario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            Textusuario.Text = "";
            Textclave.Text = "";
            this.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
