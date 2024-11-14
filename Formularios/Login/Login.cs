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

namespace Proyecto.Formularios.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            UsuarioRepo usuarioRepo = new UsuarioRepo();

            Usuario usuario = usuarioRepo.ObtenerUsuario(txtUsuario.Text, txtContra.Text);

            if (usuario != null)
            {
                this.Hide();
                Laboratorios labs = new Laboratorios();
                labs.Show();
            } else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
