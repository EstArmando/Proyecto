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
            LlenarTabla();
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

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
        }

        private void LlenarTabla()
        {
            dtUsuarios.Columns.Clear();

            dtUsuarios.Columns.Add("Id", "Id");
            dtUsuarios.Columns.Add("Nombre", "Nombre");
            dtUsuarios.Columns.Add("Correo", "Correo");
            dtUsuarios.Columns.Add("Fecha", "Fecha de registro");

            dtUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            CargarDatos();
            dtUsuarios.Width = dtUsuarios.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + dtUsuarios.RowHeadersWidth;
        }
        
        private void CargarDatos()
        {
            UsuarioRepo usuarioRepo = new UsuarioRepo();
            List<Usuario> listaUsuarios = usuarioRepo.LeerUsuarios();
            dtUsuarios.Rows.Clear();

            if (listaUsuarios != null && listaUsuarios.Count > 0)
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    dtUsuarios.Rows.Add(usuario.UsuarioId, usuario.Nombre, usuario.Correo, usuario.FechaRegistro);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron usuarios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
