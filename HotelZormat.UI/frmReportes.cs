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
    public partial class frmReportes : Form
    {
        private readonly EstadiaService _estadiaService;
        private readonly ReservaService _reservaService;
        private readonly HuespedService _huespedService;
        private readonly HabitacionService _habitacionService;
        private readonly FacturaService _facturaService;

        public frmReportes()
        {
            InitializeComponent();
            _estadiaService = new EstadiaService();
            _reservaService = new ReservaService();
            _huespedService = new HuespedService();
            _habitacionService = new HabitacionService();
            _facturaService = new FacturaService();

            pnlFiltros.Resize += EstilosUI.RedondearEsquinas;
            pnlGridCard.Resize += EstilosUI.RedondearEsquinas;
            EstilosUI.AplicarEsquinasRedondeadas(pnlFiltros, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlGridCard, 14);
            EstilosUI.AplicarEsquinasRedondeadas(tarjetaOcupadas, 10);
            EstilosUI.AplicarEsquinasRedondeadas(tarjetaFacturas, 10);
            EstilosUI.AplicarEsquinasRedondeadas(tarjetaIngresos, 10);
        }

        // TODO: frmReportes_Load - Sin parámetros, arma columnas de dgvOcupacion, fija las fechas de hoy y llama CargarOcupacion
        private void frmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                dgvOcupacion.Columns.Add("colHabitacion", "Habitación");
                dgvOcupacion.Columns.Add("colTipo", "Tipo");
                dgvOcupacion.Columns.Add("colHuesped", "Huésped");
                dgvOcupacion.Columns.Add("colFechaEntrada", "Fecha de entrada");

                dtpDesde.Value = DateTime.Today;
                dtpHasta.Value = DateTime.Today;

                CargarOcupacion();
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
        // TODO: CargarOcupacion - Sin parámetros, recorre EstadiaService.ObtenerActivas con foreach, arma el grid y el conteo (reporte 1: ocupación del día)
        private void CargarOcupacion()
        {
            dgvOcupacion.Rows.Clear();
            List<Estadia> activas = _estadiaService.ObtenerActivas();

            foreach (Estadia estadia in activas)
            {
                Reserva reserva = _reservaService.BuscarPorId(estadia.ReservaId);
                if (reserva == null) continue;

                Habitacion hab = _habitacionService.BuscarPorNumero(reserva.HabitacionNumero);
                Huesped huesped = _huespedService.BuscarPorId(reserva.HuespedId);

                string tipo = hab != null ? hab.Tipo : "-";
                string nombreHuesped = huesped != null ? huesped.NombreCompleto() : "(eliminado)";

                dgvOcupacion.Rows.Add(reserva.HabitacionNumero, tipo, nombreHuesped,
                    estadia.FechaCheckInReal.ToString("dd/MM/yyyy HH:mm"));
            }

            lblTotalOcupadas.Text = activas.Count.ToString();
        }

        // TODO: btnConsultar_Click - Valida el rango de fechas y llama FacturaService.ContarFacturasPorRango/ObtenerIngresosPorRango (reporte 2: ingresos por rango); catch FormatException, ArgumentException, SqlException, Exception, con finally
        private void btnConsultar_Click(object sender, EventArgs e)
        {

            btnConsultar.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (dtpHasta.Value.Date < dtpDesde.Value.Date)
                {
                    MessageBox.Show("La fecha 'Hasta' debe ser mayor o igual a 'Desde'", "Datos inválidos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

                int cantidad = _facturaService.ContarFacturasPorRango(desde, hasta);
                decimal ingresos = _facturaService.ObtenerIngresosPorRango(desde, hasta);

                lblCantidadFacturas.Text = cantidad.ToString();
                lblIngresosTotales.Text = ingresos.ToString("N2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique los datos ingresados", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                btnConsultar.Enabled = true;
            }
        }
    }
}
