using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelZormat.UI
{
    public partial class frmDashboard : Form
    {
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
                case "Disponible": return Color.Green;
                case "Ocupada": return Color.Red;
                case "Reservada": return Color.Orange;
                case "Limpieza": return Color.RoyalBlue;
                default: return Color.Gray;
            }
        }

        public void CargarTablero()
        {
            flpHabitaciones.Controls.Clear();                          

            foreach (Habitacion h in _habitacionService.ObtenerTodas())  
            {
                Panel tarjeta = new Panel();
                tarjeta.Size = new Size(92, 62);
                tarjeta.BorderStyle = BorderStyle.FixedSingle;
                tarjeta.BackColor = ObtenerColorPorEstado(h.Estado);

                Label lblInfo = new Label();
                lblInfo.Text = h.Numero + "\n" + h.Tipo + "\n" + h.Estado;
                lblInfo.Dock = DockStyle.Fill;
                lblInfo.TextAlign = ContentAlignment.MiddleCenter;
                lblInfo.ForeColor = Color.White;

                tarjeta.Controls.Add(lblInfo);
                flpHabitaciones.Controls.Add(tarjeta);                
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablero();
        }
    }
}
