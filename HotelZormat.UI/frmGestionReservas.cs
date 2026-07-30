using HotelZormat.Modelo;
using HotelZormat.Negocio.Excepciones;
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
    public partial class frmGestionReservas : Form
    {
        private readonly ReservaService _reservaService;
        private readonly HuespedService _huespedService;
        private readonly HabitacionService _habitacionService;

        private List<Huesped> _huespedes = new List<Huesped>();
        private List<Habitacion> _habitacionesDisponibles = new List<Habitacion>();
        private int _idReservaSeleccionada = 0;

        public frmGestionReservas()
        {
            InitializeComponent();
            _reservaService = new ReservaService();
            _huespedService = new HuespedService();
            _habitacionService = new HabitacionService();

        }

        private void frmGestionReservas_Load(object sender, EventArgs e)
        {
            dgvReservas.Columns.Add("colId", "Id");
            dgvReservas.Columns.Add("colHuesped", "Huésped");
            dgvReservas.Columns.Add("colHabitacion", "Habitación");
            dgvReservas.Columns.Add("colCheckIn", "Check-in");
            dgvReservas.Columns.Add("colCheckOut", "Check-out");
            dgvReservas.Columns.Add("colTemporada", "Temporada");
            dgvReservas.Columns.Add("colEstado", "Estado");
            dgvReservas.Columns.Add("colMonto", "Monto");

            List<string> temporadas = new List<string> { "Alta", "Media", "Baja" };
            foreach (string temporada in temporadas)
            {
                cboTemporada.Items.Add(temporada);
            }

            CargarCombosYGrid();

        }
        private void CargarCombosYGrid()
        {
            cboHuesped.Items.Clear();
            _huespedes = _huespedService.ObtenerTodos();
            foreach (Huesped h in _huespedes)
            {
                cboHuesped.Items.Add(h.Id + " - " + h.NombreCompleto());
            }

            cboHabitacion.Items.Clear();
            _habitacionesDisponibles = new List<Habitacion>();
            foreach (Habitacion hab in _habitacionService.ObtenerTodas())
            {
                if (hab.EstaDisponible())
                {
                    _habitacionesDisponibles.Add(hab);
                    cboHabitacion.Items.Add(hab.Numero + " - " + hab.Tipo);
                }
            }

            CargarGrid(_reservaService.ObtenerTodas());
        }

        private void CargarGrid(List<Reserva> lista)
        {
            dgvReservas.Rows.Clear();
            foreach (Reserva r in lista)
            {
                Huesped h = _huespedService.BuscarPorId(r.HuespedId);
                Habitacion hab = _habitacionService.BuscarPorNumero(r.HabitacionNumero);

                string nombreHuesped = h != null ? h.NombreCompleto() : "(eliminado)";
                string descHabitacion = hab != null ? hab.Numero + " - " + hab.Tipo : r.HabitacionNumero.ToString();

                dgvReservas.Rows.Add(r.Id, nombreHuesped, descHabitacion, r.FechaCheckIn.ToString("dd/MM/yyyy"),
                    r.FechaCheckOut.ToString("dd/MM/yyyy"), r.Temporada, r.Estado, r.MontoEstimado.ToString("N2"));
            }
        }

        private void RecalcularNochesYMonto()
        {
            try
            {
                if (cboHabitacion.SelectedIndex < 0 || cboTemporada.SelectedItem == null)
                {
                    lblNoches.Text = "0";
                    lblMonto.Text = "0.00";
                    return;
                }

                int noches = _reservaService.CalcularNoches(dtpCheckIn.Value, dtpCheckOut.Value);
                Habitacion hab = _habitacionesDisponibles[cboHabitacion.SelectedIndex];
                decimal monto = noches * _reservaService.CalcularTarifaConTemporada(hab.TarifaBase, cboTemporada.SelectedItem.ToString());

                lblNoches.Text = noches.ToString();
                lblMonto.Text = monto.ToString("N2");
            }
            catch (ArgumentException)
            {
                lblNoches.Text = "0";
                lblMonto.Text = "0.00";
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e) { RecalcularNochesYMonto(); }
        private void dtpCheckOut_ValueChanged(object sender, EventArgs e) { RecalcularNochesYMonto(); }
        private void cboTemporada_SelectedIndexChanged(object sender, EventArgs e) { RecalcularNochesYMonto(); }
        private void cboHabitacion_SelectedIndexChanged(object sender, EventArgs e) { RecalcularNochesYMonto(); }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            btnCrear.Enabled = false;
            try
            {
                if (cboHuesped.SelectedIndex < 0 || cboHabitacion.SelectedIndex < 0 || cboTemporada.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona huésped, habitación y temporada", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Reserva r = new Reserva();
                r.HuespedId = _huespedes[cboHuesped.SelectedIndex].Id;
                r.HabitacionNumero = _habitacionesDisponibles[cboHabitacion.SelectedIndex].Numero;
                r.FechaCheckIn = dtpCheckIn.Value;
                r.FechaCheckOut = dtpCheckOut.Value;
                r.Temporada = cboTemporada.SelectedItem.ToString();

                _reservaService.CrearReserva(r);

                MessageBox.Show("Reserva creada correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombosYGrid();
            }
            catch (HabitacionOcupadaException ex)
            {
                MessageBox.Show(ex.Message, "Operación no permitida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique los datos ingresados", "Error",
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
                btnCrear.Enabled = true;
            }
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _idReservaSeleccionada = Convert.ToInt32(dgvReservas.Rows[e.RowIndex].Cells["colId"].Value);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (_idReservaSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una reserva del listado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Confirmar la reserva #" + _idReservaSeleccionada + "? La habitación pasará a estado Reservada",
                "Confirmar reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            try
            {
                _reservaService.ConfirmarReserva(_idReservaSeleccionada);
                MessageBox.Show("Reserva confirmada", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCombosYGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_idReservaSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una reserva del listado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Cancelar la reserva #" + _idReservaSeleccionada + "?",
                "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            try
            {
                _reservaService.CancelarReserva(_idReservaSeleccionada);
                MessageBox.Show("Reserva cancelada", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCombosYGrid();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnProximas_Click(object sender, EventArgs e)
        {
            CargarGrid(_reservaService.ObtenerProximas(7));
        }
    }


}

