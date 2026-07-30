using HotelZormat.Negocio;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void huespedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionHuespedes gestion = new frmGestionHuespedes();
            gestion.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (!SesionActual.EsAdministrador)
            {
                menuBitacora.Visible = false;
            }

            lblUsuario.Text = SesionActual.UsuarioLogueado.NombreCompleto + " (" + SesionActual.UsuarioLogueado.Rol + ")";
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            dashboard.Show();
        }

        private void menuHabitaciones_Click(object sender, EventArgs e)
        {
            frmGestionHabitaciones gestion = new frmGestionHabitaciones();
            gestion.Show();
        }

        private void menuReservas_Click(object sender, EventArgs e)
        {
            frmGestionReservas gestion = new frmGestionReservas();
            gestion.Show();
        }
    }
}
