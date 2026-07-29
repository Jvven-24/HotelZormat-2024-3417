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
    public partial class frmLogin : Form
    {
        private readonly UsuarioService _usuarioService;
       
        public frmLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService(); 
            txtPassword.UseSystemPasswordChar = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Usuario usuario = _usuarioService.IniciarSesion(txtUsuario.Text, txtPassword.Text);

                    if (usuario == null)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        FrmPrincipal principal = new FrmPrincipal();
                        principal.Show();
                        this.Hide();
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
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
