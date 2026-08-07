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
    public partial class frmBitacora : Form
    {
        private readonly BitacoraService _bitacoraService;
        private readonly UsuarioService _usuarioService;

        public frmBitacora()
        {
            InitializeComponent();
            _bitacoraService = new BitacoraService();
            _usuarioService = new UsuarioService();

            pnlFiltros.Resize += EstilosUI.RedondearEsquinas;
            pnlGridCard.Resize += EstilosUI.RedondearEsquinas;
            EstilosUI.AplicarEsquinasRedondeadas(pnlFiltros, 14);
            EstilosUI.AplicarEsquinasRedondeadas(pnlGridCard, 14);

            dgvBitacora.CellFormatting += EstilosUI.SubrayarFilaSeleccionada;
            dgvBitacora.SelectionChanged += EstilosUI.RefrescarSeleccion;
        }

        // TODO: frmBitacora_Load - Sin parámetros, arma columnas del grid, llena cboFiltroAccion con foreach y carga todos los registros (solo Administrador entra aquí, ver FrmPrincipal_Load)
        private void frmBitacora_Load(object sender, EventArgs e)
        {
            try
            {


                dgvBitacora.Columns.Add("colFecha", "Fecha/Hora");
                dgvBitacora.Columns.Add("colUsuario", "Usuario");
                dgvBitacora.Columns.Add("colAccion", "Acción");
                dgvBitacora.Columns.Add("colDetalle", "Detalle");

                List<string> acciones = new List<string> { "Login", "CheckIn", "CheckOut", "Facturacion" };
                foreach (string accion in acciones)
                {
                    cboFiltroAccion.Items.Add(accion);
                }

                CargarGrid(_bitacoraService.ObtenerTodas());
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
        // TODO: CargarGrid - Recibe List<RegistroBitacora>, limpia el grid y lo llena con foreach (busca el usuario por cada registro)
        private void CargarGrid(List<RegistroBitacora> registros)
        {
            dgvBitacora.Rows.Clear();
            foreach (RegistroBitacora r in registros)
            {
                Usuario u = _usuarioService.BuscarPorId(r.UsuarioId);
                string nombreUsuario = u != null ? u.NombreCompleto : "(desconocido)";

                dgvBitacora.Rows.Add(r.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"), nombreUsuario, r.Accion, r.Detalle);
            }
        }

        // TODO: btnFiltrar_Click - Llama BitacoraService.ObtenerPorAccion con lo elegido en cboFiltroAccion; catch FormatException, SqlException, Exception
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cboFiltroAccion.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una acción para filtrar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CargarGrid(_bitacoraService.ObtenerPorAccion(cboFiltroAccion.SelectedItem.ToString()));
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

        // TODO: btnVerTodas_Click - Limpia el filtro y llama BitacoraService.ObtenerTodas; catch FormatException, SqlException, Exception
        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            cboFiltroAccion.SelectedIndex = -1;
            try
            {
                CargarGrid(_bitacoraService.ObtenerTodas());
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
    }
}
