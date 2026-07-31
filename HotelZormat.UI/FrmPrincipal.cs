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
            
            AbrirPantallas(new frmGestionHuespedes());
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
            AbrirPantallas(new frmDashboard());
        }

        private void menuHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirPantallas(new frmGestionHabitaciones());
        }

        private void menuReservas_Click(object sender, EventArgs e)
        {
            AbrirPantallas(new frmGestionReservas());
        }

        private void menuCheckInOut_Click(object sender, EventArgs e)
        {
           AbrirPantallas(new frmCheckInOut());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirPantallas(new frmReportes());
        }

        private void menuBitacora_Click(object sender, EventArgs e)
        {
            AbrirPantallas(new frmBitacora());
        }
        private void AbrirPantallas(Form hijo)
        {
            foreach (Form abierto in this.MdiChildren)
            {
                abierto.Close();
            }

            hijo.MdiParent = this;
            hijo.Show();
        }

        private void menuCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar sesión?",
       "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                SesionActual.UsuarioLogueado = null;
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }

        }
    }
}
