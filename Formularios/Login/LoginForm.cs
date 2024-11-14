using Proyecto.Clases.Usuario;
using Proyecto.Formularios.Labs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioRepo usuarioRepo = new UsuarioRepo();
            Usuario usuario = usuarioRepo.IniciarSesion(txtUsuario.Text, txtContra.Text);

            if (usuario != null)
            {
                AbrirLaboratorios(usuario);
            } else
            {
                MostrarMensajeError();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AbrirLaboratorios(Usuario usuario)
        {
            this.Hide();
            Laboratorios labs = new Laboratorios(usuario);
            labs.Show();
        }

        private void MostrarMensajeError()
        {
            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
