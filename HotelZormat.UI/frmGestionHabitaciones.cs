//Cedula: 402-1937000-0
using HotelZormat.Modelo;
using HotelZormat.Negocio;
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
    public partial class frmGestionHabitaciones : Form
    {
        private readonly HabitacionService _habitacionService;
        public frmGestionHabitaciones()
        {
            InitializeComponent();
            _habitacionService = new HabitacionService();
            txtNumero.KeyPress += ValidacionesTexto.SoloDigitos_KeyPress;
            txtPiso.KeyPress += ValidacionesTexto.SoloDigitos_KeyPress;
            txtCapacidad.KeyPress += ValidacionesTexto.SoloDigitos_KeyPress;
            txtTarifa.KeyPress += ValidacionesTexto.SoloDecimal_KeyPress;

            pnlFiltros.Resize += EstilosUI.RedondearEsquinas;
            pnlGridCard.Resize += EstilosUI.RedondearEsquinas;
            pnlCaptura.Resize += EstilosUI.RedondearEsquinas;
            EstilosUI.AplicarEsquinasRedondeadas(pnlFiltros, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlGridCard, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlCaptura, 14);

            dgvHabitaciones.CellFormatting += EstilosUI.SubrayarFilaSeleccionada;
            dgvHabitaciones.SelectionChanged += EstilosUI.RefrescarSeleccion;
        }
        // TODO: ObtenerColorPorEstado - Recibe estado (string), switch que retorna el Color para pintar según Disponible/Ocupada/Reservada/Limpieza
        private Color ObtenerColorPorEstado(string estado)
        {
            switch (estado)
            {
                case "Disponible": return Color.FromArgb(47, 143, 99);
                case "Ocupada": return Color.FromArgb(193, 68, 60);
                case "Reservada": return Color.FromArgb(201, 146, 47);
                case "Limpieza": return Color.FromArgb(79, 126, 168);
                default: return Color.FromArgb(121, 112, 93);
            }
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // TODO: frmGestionHabitaciones_Load - Sin parámetros, arma columnas del grid y llena cboTipo/cboEstado/cboFiltroEstado con foreach, luego carga el grid
        private void frmGestionHabitaciones_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHabitaciones.Columns.Add("colNumero", "Número");
                dgvHabitaciones.Columns.Add("colTipo", "Tipo");
                dgvHabitaciones.Columns.Add("colPiso", "Piso");
                dgvHabitaciones.Columns.Add("colEstado", "Estado");
                dgvHabitaciones.Columns.Add("colCapacidad", "Capacidad");
                dgvHabitaciones.Columns.Add("colTarifa", "Tarifa");

                List<string> tipos = new List<string> { "Sencilla", "Doble", "Suite" };
                foreach (string tipo in tipos)
                {
                    cboTipo.Items.Add(tipo);
                }

                List<string> estados = new List<string> { "Disponible", "Ocupada", "Reservada", "Limpieza" };
                foreach (string estado in estados)
                {
                    cboEstado.Items.Add(estado);
                    cboFiltroEstado.Items.Add(estado);
                }
                cboFiltroEstado.Items.Insert(0, "Todos");
                cboFiltroEstado.SelectedIndex = 0;

                RecargarFiltroPiso();

                CargarGrid(_habitacionService.ObtenerTodas());
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

        // TODO: CargarGrid - Recibe List<Habitacion>, limpia el grid y lo llena con foreach (una fila por habitación)
        private void CargarGrid(List<Habitacion> lista)
        {
            dgvHabitaciones.Rows.Clear();                                 
            foreach (Habitacion h in lista)
            {
                dgvHabitaciones.Rows.Add(h.Numero, h.Tipo, h.Piso, h.Estado, h.Capacidad, h.TarifaBase);
            }
        }

        // TODO: btnFiltrar_Click - Lee cboFiltroPiso/cboFiltroEstado, llama HabitacionService.ObtenerPorFiltro y recarga el grid; catch de SqlException y Exception
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                int? piso = null;
                if (cboFiltroPiso.SelectedItem.ToString() != "Todos")
                {
                    piso = int.Parse(cboFiltroPiso.SelectedItem.ToString());
                }

                string estado = cboFiltroEstado.SelectedItem.ToString() == "Todos" ? null : cboFiltroEstado.SelectedItem.ToString();

                CargarGrid(_habitacionService.ObtenerPorFiltro(piso, estado));
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

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipo.SelectedItem?.ToString())
            {
                case "Sencilla": lblIcono.Text = "🛏️"; break;
                case "Doble": lblIcono.Text = "🛏️🛏️"; break;
                case "Suite": lblIcono.Text = "🏨"; break;
                default: lblIcono.Text = "❓"; break;
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cboEstado.SelectedItem?.ToString();
            lblEstado.Text = estado;
            lblEstado.ForeColor = ObtenerColorPorEstado(estado);
        }

        // TODO: btnBuscar_Click - Recibe el número desde txtNumero, busca con HabitacionService.BuscarPorNumero y llena los campos; catch FormatException, SqlException, Exception
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);                  // dentro del try, a propósito
                Habitacion h = _habitacionService.BuscarPorNumero(numero);

                if (h == null)
                {
                    MessageBox.Show("No existe la habitación #" + numero, "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtPiso.Text = h.Piso.ToString();
                txtCapacidad.Text = h.Capacidad.ToString();
                txtTarifa.Text = h.TarifaBase.ToString();
                cboTipo.SelectedItem = h.Tipo;
                cboEstado.SelectedItem = h.Estado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un número de habitación válido", "Aviso",
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

        // TODO: btnGuardar_Click - Arma una Habitacion desde los campos y llama HabitacionService.Guardar; catch en orden HabitacionOcupadaException, SqlException, FormatException, Exception, con finally
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool tipoValido = ValidacionesTexto.ValidarComboRequerido(cboTipo, errorProvider1, "Selecciona un tipo de habitación");
            bool estadoValido = ValidacionesTexto.ValidarComboRequerido(cboEstado, errorProvider1, "Selecciona un estado");

            if (!tipoValido || !estadoValido)
            {
                return;
            }
            btnGuardar.Enabled = false;
            try
            {
                Habitacion h = new Habitacion();
                h.Numero = int.Parse(txtNumero.Text);
                h.Tipo = cboTipo.SelectedItem.ToString();
                h.Estado = cboEstado.SelectedItem.ToString();
                h.Piso = int.Parse(txtPiso.Text);
                h.Capacidad = int.Parse(txtCapacidad.Text);
                h.TarifaBase = decimal.Parse(txtTarifa.Text);

                _habitacionService.Guardar(h);

                MessageBox.Show("Habitación guardada correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrid(_habitacionService.ObtenerTodas());
                RecargarFiltroPiso();
            }
            catch (HabitacionOcupadaException ex)
            {
                MessageBox.Show("La habitación " + ex.NumeroHabitacion + " está ocupada: " + ex.Message,
                    "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Verifique que SQL Server esté corriendo.",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que Número, Piso, Capacidad y Tarifa sean numéricos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        // TODO: btnEliminar_Click - Pide confirmación (YesNo) y llama HabitacionService.Eliminar(numero, EsAdministrador); catch UnauthorizedAccessException, HabitacionOcupadaException, SqlException, FormatException, Exception
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);

                DialogResult resultado = MessageBox.Show(
                    "¿Eliminar la habitación " + numero + "? Esta acción no se puede deshacer",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado != DialogResult.Yes)
                {
                    return;
                }

                _habitacionService.Eliminar(numero, SesionActual.EsAdministrador);

                MessageBox.Show("Habitación eliminada", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrid(_habitacionService.ObtenerTodas());
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Solo el Administrador puede eliminar habitaciones", "Permiso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (HabitacionOcupadaException ex)
            {
                MessageBox.Show(ex.Message, "Operación no permitida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Verifique que SQL Server esté corriendo.",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa un número de habitación válido", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtNumero.Clear();
            txtPiso.Clear();
            txtCapacidad.Clear();
            txtTarifa.Clear();
            cboTipo.SelectedIndex = -1;
            cboEstado.SelectedIndex = -1;
            lblIcono.Text = "icono";
            lblEstado.Text = "estado";
        }

        // TODO: RecargarFiltroPiso - Sin parámetros, recorre las habitaciones con foreach y arma la lista de pisos únicos para cboFiltroPiso
        private void RecargarFiltroPiso()
        {
            cboFiltroPiso.Items.Clear();
            cboFiltroPiso.Items.Add("Todos");

            List<int> pisosVistos = new List<int>();
            foreach (Habitacion h in _habitacionService.ObtenerTodas())
            {
                if (!pisosVistos.Contains(h.Piso))
                {
                    pisosVistos.Add(h.Piso);
                    cboFiltroPiso.Items.Add(h.Piso.ToString());
                }
            }
            cboFiltroPiso.SelectedIndex = 0;
        }
    }
}
