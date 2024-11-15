using Proyecto.Clases.Usuario;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Formularios.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Proyecto.Clases.Labs;
using Proyecto.Formularios.UsuariosForm;

namespace Proyecto.Formularios.Labs
{
    public partial class Laboratorios : Form
    {
        private Usuario usuario;
        public Laboratorios(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblUsuario.Text += " " + usuario.Nombre;
            LlenarTabla();
        }

        private void Laboratorios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSes_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void LlenarTabla()
        {
            dtLabs.Columns.Clear();

            dtLabs.Columns.Add("Id", "Id");
            dtLabs.Columns.Add("Nombre", "Nombre");
            dtLabs.Columns.Add("Ubicacion", "Ubicación");
            dtLabs.Columns.Add("Capacidad", "Capacidad");
            dtLabs.Columns.Add("Responsable", "Responsable");
            dtLabs.Columns.Add("FechaApertura", "Fecha Apertura");
            dtLabs.Columns.Add("FechaCierre", "Fecha Cierre");

            CargarDatos();
        }

        private void CargarDatos()
        {
            dtLabs.Rows.Clear();
            LaboratorioRepo laboratorioRepo = new LaboratorioRepo();
            List<Laboratorio> listaLaboratorios = laboratorioRepo.LeerLaboratorios();

            if (listaLaboratorios != null && listaLaboratorios.Count > 0)
            {
                foreach (Laboratorio lab in listaLaboratorios)
                {
                    dtLabs.Rows.Add(lab.Id, lab.Nombre, lab.Ubicacion, lab.Capacidad, lab.Responsable, lab.FechaApertura.ToShortDateString(),
                                    lab.FechaCierre?.ToShortDateString() ?? "N/A");
                }
            }
            else
            {
                MessageBox.Show("No se encontraron laboratorios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtLabs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtLabs.Rows[e.RowIndex];

                txtID.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtUbicación.Text = row.Cells["Ubicacion"].Value.ToString();
                txtCapacidad.Text = row.Cells["Capacidad"].Value.ToString();
                txtResponsable.Text = row.Cells["Responsable"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtUbicación.Clear();
            txtCapacidad.Clear();
            txtResponsable.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void toolUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarioForm = new Usuarios(usuario);
            usuarioForm.Show();
        }

        private void toolLabs_Click(object sender, EventArgs e)
        {
            return;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
