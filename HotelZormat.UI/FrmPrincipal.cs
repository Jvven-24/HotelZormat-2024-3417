// Cedula : 402-1937000-0
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
        private static readonly Color ColorSidebar = Color.FromArgb(16, 48, 46);
        private static readonly Color ColorSidebarMuted = Color.FromArgb(143, 179, 170);
        private static readonly Color ColorAccent = Color.FromArgb(200, 90, 52);
        private static readonly Color ColorAccentInk = Color.FromArgb(255, 247, 241);
        private static readonly Color ColorCanvas = Color.FromArgb(22, 58, 55);

        private Button _botonActivo;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (!SesionActual.EsAdministrador)
            {
                btnNavBitacora.Visible = false;
                btnNavUsuarios.Visible = false;
            }

            lblUsuario.Text = SesionActual.UsuarioLogueado.NombreCompleto + " (" + SesionActual.UsuarioLogueado.Rol + ")";

            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = ColorCanvas;
                }
            }
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnNavDashboard);
            AbrirPantallas(new frmDashboard());
        }

        private void btnNavHabitaciones_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnNavHabitaciones);
            AbrirPantallas(new frmGestionHabitaciones());
        }

        private void btnNavHuespedes_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnNavHuespedes);
            AbrirPantallas(new frmGestionHuespedes());
        }

        private void btnNavReservas_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnNavReservas);
            AbrirPantallas(new frmGestionReservas());
        }

        private void btnNavCheckInOut_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnNavCheckInOut);
            AbrirPantallas(new frmCheckInOut());
        }

        private void btnNavReportes_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnNavReportes);
            AbrirPantallas(new frmReportes());
        }

        private void btnNavBitacora_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnNavBitacora);
            AbrirPantallas(new frmBitacora());
        }

        private void btnNavUsuarios_Click(object sender, EventArgs e)
        {
            MarcarBotonActivo(btnNavUsuarios);
            AbrirPantallas(new frmGestionUsuarios());
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
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

        private void MarcarBotonActivo(Button boton)
        {
            if (_botonActivo != null)
            {
                _botonActivo.BackColor = ColorSidebar;
                _botonActivo.ForeColor = ColorSidebarMuted;
            }

            boton.BackColor = ColorAccent;
            boton.ForeColor = ColorAccentInk;
            _botonActivo = boton;
        }
    }
}
