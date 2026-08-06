// Cedula : 402-1937000-0
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
    public partial class frmCheckInOut : Form
    {
        private readonly EstadiaService _estadiaService;
        private readonly ReservaService _reservaService;
        private readonly HuespedService _huespedService;

        private int _idReservaSeleccionada = 0;
        private int _idEstadiaSeleccionada = 0;
        public frmCheckInOut()
        {
            InitializeComponent();
            _estadiaService = new EstadiaService();
            _reservaService = new ReservaService();
            _huespedService = new HuespedService();

            pnlFiltros.Resize += EstilosUI.RedondearEsquinas;
            pnlReservas.Resize += EstilosUI.RedondearEsquinas;
            pnlEstadias.Resize += EstilosUI.RedondearEsquinas;
            EstilosUI.AplicarEsquinasRedondeadas(pnlFiltros, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlReservas, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlEstadias, 14);

            dgvReservasConfirmadas.CellFormatting += EstilosUI.SubrayarFilaSeleccionada;
            dgvReservasConfirmadas.SelectionChanged += EstilosUI.RefrescarSeleccion;
            dgvEstadiasActivas.CellFormatting += EstilosUI.SubrayarFilaSeleccionada;
            dgvEstadiasActivas.SelectionChanged += EstilosUI.RefrescarSeleccion;
        }

        private void frmCheckInOut_Load(object sender, EventArgs e)
        {
            try
            {
                dgvReservasConfirmadas.Columns.Add("colId", "Id");
                dgvReservasConfirmadas.Columns.Add("colHuesped", "Huésped");
                dgvReservasConfirmadas.Columns.Add("colHabitacion", "Habitación");
                dgvReservasConfirmadas.Columns.Add("colCheckIn", "Check-in");
                dgvReservasConfirmadas.Columns.Add("colTemporada", "Temporada");

                dgvEstadiasActivas.Columns.Add("colId", "Id");
                dgvEstadiasActivas.Columns.Add("colHuesped", "Huésped");
                dgvEstadiasActivas.Columns.Add("colHabitacion", "Habitación");
                dgvEstadiasActivas.Columns.Add("colEntrada", "Entrada real");
                dgvEstadiasActivas.Columns.Add("colNoches", "Noches");

                CargarGrids();

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
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarGrids()
        {
            CargarGridReservas();
            CargarGridEstadias();
        }

        private void CargarGridReservas()
        {
            dgvReservasConfirmadas.Rows.Clear();
            foreach (Reserva r in _reservaService.ObtenerTodas())
            {
                if (r.Estado != "Confirmada") continue;

                Huesped h = _huespedService.BuscarPorId(r.HuespedId);
                string nombreHuesped = h != null ? h.NombreCompleto() : "(eliminado)";

                dgvReservasConfirmadas.Rows.Add(r.Id, nombreHuesped, r.HabitacionNumero,
                    r.FechaCheckIn.ToString("dd/MM/yyyy"), r.Temporada);
            }

        }
        private void CargarGridEstadias()
        {
            dgvEstadiasActivas.Rows.Clear();
            foreach (Estadia e in _estadiaService.ObtenerActivas())
            {
                Reserva r = _reservaService.BuscarPorId(e.ReservaId);
                string nombreHuesped = "(desconocido)";
                object habitacion = "-";

                if (r != null)
                {
                    habitacion = r.HabitacionNumero;
                    Huesped h = _huespedService.BuscarPorId(r.HuespedId);
                    nombreHuesped = h != null ? h.NombreCompleto() : "(eliminado)";
                }

                int noches = Math.Max(1, (DateTime.Now.Date - e.FechaCheckInReal.Date).Days);
                dgvEstadiasActivas.Rows.Add(e.Id, nombreHuesped, habitacion,
                    e.FechaCheckInReal.ToString("dd/MM/yyyy HH:mm"), noches);
            }
        }

        private void dgvReservasConfirmadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _idReservaSeleccionada = Convert.ToInt32(dgvReservasConfirmadas.Rows[e.RowIndex].Cells["colId"].Value);

        }

        private void dgvEstadiasActivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _idEstadiaSeleccionada = Convert.ToInt32(dgvEstadiasActivas.Rows[e.RowIndex].Cells["colId"].Value);

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (_idReservaSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una reserva confirmada del listado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Registrar el check-in de la reserva #" + _idReservaSeleccionada + "?",
                "Confirmar check-in", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;
            
            btnCheckIn.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                _estadiaService.HacerCheckIn(_idReservaSeleccionada);
                MessageBox.Show("Check-in registrado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _idReservaSeleccionada = 0;
                CargarGrids();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique los datos ingresados", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HabitacionOcupadaException ex)
            {
                MessageBox.Show(ex.Message, "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            finally
            {
                Cursor.Current = Cursors.Default;
                btnCheckIn.Enabled = true;
            }

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (_idEstadiaSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una estadía activa del listado", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Registrar el check-out de la estadía #" + _idEstadiaSeleccionada + "?",
                "Confirmar check-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes) return;

            btnCheckOut.Enabled = false;
            try
            {
                Factura factura = _estadiaService.HacerCheckOut(_idEstadiaSeleccionada);
                _idEstadiaSeleccionada = 0;
                CargarGrids();

                frmFactura factView = new frmFactura();
                factView.CargarFactura(factura);
                factView.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique los datos ingresados", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            finally
            {
                btnCheckOut.Enabled = true;
            }
        }
    }
}
