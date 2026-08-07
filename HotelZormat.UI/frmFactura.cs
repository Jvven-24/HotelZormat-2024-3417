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
    public partial class frmFactura : Form
    {
        private Factura _factura;
        private readonly EstadiaService _estadiaService;
        private readonly ReservaService _reservaService;
        private readonly HuespedService _huespedService;
        private readonly HabitacionService _habitacionService;

        public frmFactura()
        {
            InitializeComponent();
            _estadiaService = new EstadiaService();
            _reservaService = new ReservaService();
            _huespedService = new HuespedService();
            _habitacionService = new HabitacionService();

            EstilosUI.AplicarEsquinasRedondeadas(pnlReceipt, 18);
        }
        public void CargarFactura(Factura factura)
        {
            _factura = factura;
        }


        private void frmFactura_Load(object sender, EventArgs e)
        {
            try
            {

                if (_factura == null) return;

                Estadia estadia = _estadiaService.BuscarPorId(_factura.EstadiaId);
                Reserva reserva = estadia != null ? _reservaService.BuscarPorId(estadia.ReservaId) : null;
                Huesped huesped = reserva != null ? _huespedService.BuscarPorId(reserva.HuespedId) : null;
                Habitacion habitacion = reserva != null ? _habitacionService.BuscarPorNumero(reserva.HabitacionNumero) : null;

                lblEncabezado.Text = "NCF: " + _factura.NCF + " · Fecha: " + _factura.FechaEmision.ToString("dd/MM/yyyy");
                lblHuesped.Text = "Huésped: " + (huesped != null ? huesped.NombreCompleto() : "-");
                lblHabitacion.Text = "Habitación: " + (habitacion != null ? habitacion.Numero + " — " + habitacion.Tipo : "-");

                lstLineas.Items.Clear();
                if (habitacion != null && estadia != null && reserva != null)
                {
                    DateTime fin = estadia.FechaCheckOutReal ?? DateTime.Now;
                    int noches = Math.Max(1, (fin.Date - estadia.FechaCheckInReal.Date).Days);
                    decimal tarifaNoche = _reservaService.CalcularTarifaConTemporada(habitacion.TarifaBase, reserva.Temporada);

                    foreach (string linea in _reservaService.GenerarLineasFactura(noches, tarifaNoche))
                    {
                        lstLineas.Items.Add(linea);
                    }
                }

                lblSubtotal.Text = "Subtotal: " + _factura.Subtotal.ToString("N2");
                lblItbis.Text = "ITBIS (18%): " + _factura.Itbis.ToString("N2");
                lblPropina.Text = "Propina (10%): " + _factura.Propina.ToString("N2");
                lblTotal.Text = "TOTAL: " + _factura.Total.ToString("N2");
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
