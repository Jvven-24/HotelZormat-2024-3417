// Cedula : 402-1937000-0
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelZormat.UI
{
    public partial class frmGestionHuespedes : Form
    {
        private readonly HuespedService _huespedService;
        private int _idSeleccionado = 0;

        public frmGestionHuespedes()
        {
            InitializeComponent();
            _huespedService = new HuespedService();
            txtTelefono.KeyPress += ValidacionesTexto.SoloDigitos_KeyPress;
            txtNumeroDocumento.KeyPress += txtNumeroDocumento_KeyPress;

            pnlFiltros.Resize += EstilosUI.RedondearEsquinas;
            pnlGridCard.Resize += EstilosUI.RedondearEsquinas;
            pnlCaptura.Resize += EstilosUI.RedondearEsquinas;
            EstilosUI.AplicarEsquinasRedondeadas(pnlFiltros, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlGridCard, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlCaptura, 14);

            dgvHuespedes.CellFormatting += EstilosUI.SubrayarFilaSeleccionada;
            dgvHuespedes.SelectionChanged += EstilosUI.RefrescarSeleccion;
        }

        private void frmGestionHuespedes_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHuespedes.Columns.Add("colId", "Id");
                dgvHuespedes.Columns.Add("colNombre", "Nombre");
                dgvHuespedes.Columns.Add("colApellido", "Apellido");
                dgvHuespedes.Columns.Add("colTipoDoc", "Tipo Doc.");
                dgvHuespedes.Columns.Add("colNumDoc", "Número Doc.");
                dgvHuespedes.Columns.Add("colNacionalidad", "Nacionalidad");
                dgvHuespedes.Columns.Add("colTelefono", "Teléfono");
                dgvHuespedes.Columns.Add("colEmail", "Email");

                List<string> tiposDocumento = new List<string> { "Cedula", "Pasaporte" };
                foreach (string tipo in tiposDocumento)
                {
                    cboTipoDocumento.Items.Add(tipo);
                }

                CargarGrid(_huespedService.ObtenerTodos());
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
        private void CargarGrid(List<Huesped> lista)
        {
            dgvHuespedes.Rows.Clear();
            foreach (Huesped h in lista)
            {
                dgvHuespedes.Rows.Add(h.Id, h.Nombre, h.Apellido, h.TipoDocumento, h.NumeroDocumento, h.Nacionalidad, h.Telefono, h.Email);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    CargarGrid(_huespedService.ObtenerTodos());
                    return;
                }
                CargarGrid(_huespedService.Buscar(txtBuscar.Text));
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

        private void dgvHuespedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvHuespedes.Rows[e.RowIndex];
            _idSeleccionado = Convert.ToInt32(fila.Cells["colId"].Value);
            txtNombre.Text = fila.Cells["colNombre"].Value.ToString();
            txtApellido.Text = fila.Cells["colApellido"].Value.ToString();
            cboTipoDocumento.SelectedItem = fila.Cells["colTipoDoc"].Value.ToString();
            txtNumeroDocumento.Text = fila.Cells["colNumDoc"].Value.ToString();
            txtNacionalidad.Text = fila.Cells["colNacionalidad"].Value.ToString();
            txtTelefono.Text = fila.Cells["colTelefono"].Value?.ToString();
            txtEmail.Text = fila.Cells["colEmail"].Value?.ToString();
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoDocumento.SelectedItem?.ToString())
            {
                case "Cedula":
                    txtNumeroDocumento.MaxLength = 11;
                    lblAyuda.Text = "11 dígitos sin guiones";
                    break;
                case "Pasaporte":
                    txtNumeroDocumento.MaxLength = 20;
                    lblAyuda.Text = "Alfanumérico";
                    break;
                default:
                    txtNumeroDocumento.MaxLength = 32767;
                    lblAyuda.Text = "";
                    break;
            }
        }
        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboTipoDocumento.SelectedItem?.ToString() == "Cedula" &&
                !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidacionesTexto.ValidarComboRequerido(cboTipoDocumento, errorProvider1, "Selecciona el tipo de documento"))
            {
                return;
            }
            btnGuardar.Enabled = false;
            try
            {
                Huesped h = new Huesped();
                h.Id = _idSeleccionado;
                h.Nombre = txtNombre.Text;
                h.Apellido = txtApellido.Text;
                h.TipoDocumento = cboTipoDocumento.SelectedItem?.ToString();
                h.NumeroDocumento = txtNumeroDocumento.Text;
                h.Nacionalidad = txtNacionalidad.Text;
                h.Telefono = txtTelefono.Text;
                h.Email = txtEmail.Text;

                _huespedService.Guardar(h);

                MessageBox.Show("Huésped guardado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrid(_huespedService.ObtenerTodos());
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
                MessageBox.Show("Selecciona un huésped del listado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Eliminar al huésped " + txtNombre.Text + " " + txtApellido.Text + "? Esta acción no se puede deshacer",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            try
            {
                _huespedService.Eliminar(_idSeleccionado);
                MessageBox.Show("Huésped eliminado", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid(_huespedService.ObtenerTodos());
                btnLimpiar_Click(sender, e);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("No se puede eliminar: el huésped tiene reservas asociadas",
                    "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumeroDocumento.Clear();
            txtNacionalidad.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cboTipoDocumento.SelectedIndex = -1;
            lblAyuda.Text = "";
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un huésped del listado", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Estadia> historial = new EstadiaService().ObtenerHistorialPorHuesped(_idSeleccionado);

                if (historial.Count == 0)
                {
                    MessageBox.Show("Este huésped todavía no tiene estadías registradas", "Historial",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                StringBuilder texto = new StringBuilder();
                foreach (Estadia est in historial)
                {
                    string salida = est.FechaCheckOutReal.HasValue ? est.FechaCheckOutReal.Value.ToString("dd/MM/yyyy") : "En curso";
                    texto.AppendLine("Reserva #" + est.ReservaId + " — Entrada: " + est.FechaCheckInReal.ToString("dd/MM/yyyy") +
                                      " — Salida: " + salida + " — Estado: " + est.Estado);
                }

                MessageBox.Show(texto.ToString(), "Historial de estadías",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }  
}
