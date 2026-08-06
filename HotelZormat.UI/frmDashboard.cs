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
    public partial class frmDashboard : Form
    {
        private static readonly Color ColorSurface = Color.FromArgb(255, 250, 241);
        private static readonly Color ColorInk = Color.FromArgb(28, 38, 36);
        private static readonly Color ColorMuted = Color.FromArgb(121, 112, 93);

        private static readonly Color ColorDisponible = Color.FromArgb(47, 143, 99);
        private static readonly Color ColorOcupada = Color.FromArgb(193, 68, 60);
        private static readonly Color ColorReservada = Color.FromArgb(201, 146, 47);
        private static readonly Color ColorLimpieza = Color.FromArgb(79, 126, 168);
        private static readonly Color ColorDesconocido = Color.FromArgb(121, 112, 93);

        private readonly HabitacionService _habitacionService;
        public frmDashboard()
        {
            InitializeComponent();
            _habitacionService = new HabitacionService();
        }


        private void frmDashboard_Load(object sender, EventArgs e)
        {
            CargarTablero();
        }

        private Color ObtenerColorPorEstado(string estado)
        {
            switch (estado)
            {
                case "Disponible": return ColorDisponible;
                case "Ocupada": return ColorOcupada;
                case "Reservada": return ColorReservada;
                case "Limpieza": return ColorLimpieza;
                default: return ColorDesconocido;
            }
        }

        public void CargarTablero()
        {
            try
            {
                List<Habitacion> habitaciones = _habitacionService.ObtenerTodas();

                int disponibles = 0;
                int ocupadas = 0;
                int reservadas = 0;
                int limpieza = 0;

                foreach (Habitacion h in habitaciones)
                {
                    switch (h.Estado)
                    {
                        case "Disponible": disponibles++; break;
                        case "Ocupada": ocupadas++; break;
                        case "Reservada": reservadas++; break;
                        case "Limpieza": limpieza++; break;
                    }
                }

                flpKpis.Controls.Clear();
                flpKpis.Controls.Add(ConstruirTarjetaKpi("Disponibles", disponibles, ColorDisponible));
                flpKpis.Controls.Add(ConstruirTarjetaKpi("Ocupadas", ocupadas, ColorOcupada));
                flpKpis.Controls.Add(ConstruirTarjetaKpi("Reservadas", reservadas, ColorReservada));
                flpKpis.Controls.Add(ConstruirTarjetaKpi("En limpieza", limpieza, ColorLimpieza));

                flpHabitaciones.Controls.Clear();
                foreach (Habitacion h in habitaciones)
                {
                    flpHabitaciones.Controls.Add(ConstruirTarjetaHabitacion(h));
                }
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

        private Panel ConstruirTarjetaHabitacion(Habitacion h)
        {
            Color color = ObtenerColorPorEstado(h.Estado);

            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(150, 94);
            tarjeta.Margin = new Padding(0, 0, 12, 12);
            tarjeta.BackColor = ColorSurface;

            Panel franjaEstado = new Panel();
            franjaEstado.Dock = DockStyle.Left;
            franjaEstado.Width = 5;
            franjaEstado.BackColor = color;
            tarjeta.Controls.Add(franjaEstado);

            Label lblNumero = new Label();
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Cambria", 15F, FontStyle.Bold);
            lblNumero.ForeColor = ColorInk;
            lblNumero.Location = new Point(17, 10);
            lblNumero.Text = h.Numero.ToString();
            tarjeta.Controls.Add(lblNumero);

            Label lblTipoPiso = new Label();
            lblTipoPiso.AutoSize = true;
            lblTipoPiso.Font = new Font("Segoe UI", 8F);
            lblTipoPiso.ForeColor = ColorMuted;
            lblTipoPiso.Location = new Point(18, 38);
            lblTipoPiso.Text = h.Tipo + " · Piso " + h.Piso;
            tarjeta.Controls.Add(lblTipoPiso);

            Label lblEstado = new Label();
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblEstado.ForeColor = color;
            lblEstado.Location = new Point(18, 62);
            lblEstado.Text = h.Estado;
            tarjeta.Controls.Add(lblEstado);

            EstilosUI.AplicarEsquinasRedondeadas(tarjeta, 10);
            return tarjeta;
        }

        private Panel ConstruirTarjetaKpi(string etiqueta, int valor, Color color)
        {
            Panel tarjeta = new Panel();
            tarjeta.Size = new Size(200, 88);
            tarjeta.Margin = new Padding(0, 0, 14, 0);
            tarjeta.BackColor = ColorSurface;

            Panel franja = new Panel();
            franja.Dock = DockStyle.Left;
            franja.Width = 4;
            franja.BackColor = color;
            tarjeta.Controls.Add(franja);

            Label lblEtiqueta = new Label();
            lblEtiqueta.AutoSize = true;
            lblEtiqueta.Font = new Font("Segoe UI", 8.5F);
            lblEtiqueta.ForeColor = ColorMuted;
            lblEtiqueta.Location = new Point(16, 14);
            lblEtiqueta.Text = etiqueta;
            tarjeta.Controls.Add(lblEtiqueta);

            Label lblValor = new Label();
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Cambria", 22F, FontStyle.Bold);
            lblValor.ForeColor = ColorInk;
            lblValor.Location = new Point(14, 32);
            lblValor.Text = valor.ToString();
            tarjeta.Controls.Add(lblValor);

            EstilosUI.AplicarEsquinasRedondeadas(tarjeta, 10);
            return tarjeta;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablero();
        }
    }
}
