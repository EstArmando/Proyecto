using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Clases.Usuario;
using Proyecto.Formularios.Labs;
using Proyecto.Formularios.Login;

namespace Proyecto.Formularios.UsuariosForm
{
    public partial class Usuarios : Form
    {
        private Usuario usuario;

        public Usuarios(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            lblUsuario.Text += " " + usuario.Nombre;
        }

        private void toolLabs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laboratorios labs = new Laboratorios(usuario);
            labs.Show();
        }

        private void toolUsuarios_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnCerrarSes_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
