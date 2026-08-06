using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelZormat.UI
{
    public partial class frmGestionUsuarios : Form
    {
        private readonly UsuarioService _usuarioService;
        private int _idSeleccionado = 0;

        public frmGestionUsuarios()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            txtContrasena.UseSystemPasswordChar = true;

            pnlGridCard.Resize += EstilosUI.RedondearEsquinas;
            pnlCaptura.Resize += EstilosUI.RedondearEsquinas;
            EstilosUI.AplicarEsquinasRedondeadas(pnlGridCard, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlCaptura, 14);

            dgvUsuarios.CellFormatting += EstilosUI.SubrayarFilaSeleccionada;
            dgvUsuarios.SelectionChanged += EstilosUI.RefrescarSeleccion;
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.Columns.Add("colId", "Id");
                dgvUsuarios.Columns.Add("colNombreUsuario", "Usuario");
                dgvUsuarios.Columns.Add("colNombreCompleto", "Nombre completo");
                dgvUsuarios.Columns.Add("colRol", "Rol");
                dgvUsuarios.Columns.Add("colActivo", "Activo");

                List<string> roles = new List<string> { "Administrador", "Recepcionista" };
                foreach (string rol in roles)
                {
                    cboRol.Items.Add(rol);
                }

                CargarGrid(_usuarioService.ObtenerTodos());
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Verifique que SQL Server esté corriendo.",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrid(List<Usuario> lista)
        {
            dgvUsuarios.Rows.Clear();
            foreach (Usuario u in lista)
            {
                dgvUsuarios.Rows.Add(u.Id, u.NombreUsuario, u.NombreCompleto, u.Rol, u.Activo ? "Sí" : "No");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            _idSeleccionado = Convert.ToInt32(fila.Cells["colId"].Value);
            txtNombreUsuario.Text = fila.Cells["colNombreUsuario"].Value.ToString();
            txtNombreCompleto.Text = fila.Cells["colNombreCompleto"].Value.ToString();
            cboRol.SelectedItem = fila.Cells["colRol"].Value.ToString();
            txtContrasena.Clear();
            lblAyudaContrasena.Text = "Dejar vacío para no cambiar la contraseña";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionesTexto.ValidarComboRequerido(cboRol, errorProvider1, "Selecciona un rol"))
            {
                return;
            }

            btnGuardar.Enabled = false;
            try
            {
                Usuario u = new Usuario();
                u.Id = _idSeleccionado;
                u.NombreUsuario = txtNombreUsuario.Text;
                u.NombreCompleto = txtNombreCompleto.Text;
                u.Rol = cboRol.SelectedItem?.ToString();

                _usuarioService.Guardar(u, txtContrasena.Text);

                MessageBox.Show("Usuario guardado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrid(_usuarioService.ObtenerTodos());
                btnLimpiar_Click(sender, e);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Verifique que SQL Server esté corriendo.",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un usuario del listado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Desactivar al usuario " + txtNombreUsuario.Text + "? No podrá volver a iniciar sesión",
                "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            try
            {
                _usuarioService.Eliminar(_idSeleccionado);
                MessageBox.Show("Usuario desactivado", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid(_usuarioService.ObtenerTodos());
                btnLimpiar_Click(sender, e);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Operación no permitida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Verifique que SQL Server esté corriendo.",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _idSeleccionado = 0;
            txtNombreUsuario.Clear();
            txtNombreCompleto.Clear();
            txtContrasena.Clear();
            cboRol.SelectedIndex = -1;
            lblAyudaContrasena.Text = "";
        }
    }
}
