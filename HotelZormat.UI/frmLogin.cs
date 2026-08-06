// Cedula : 402-1937000-0
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            this.Paint += frmLogin_Paint;
            pnlCard.Resize += EstilosUI.RedondearEsquinas;
            EstilosUI.AplicarEsquinasRedondeadas(pnlCard, 18);

            lblMarca.Left = (this.ClientSize.Width - lblMarca.Width) / 2;
            lblTagline.Left = (this.ClientSize.Width - lblTagline.Width) / 2;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Dibuja el fondo del login: cielo de atardecer, palmeras y silueta de hotel.
        /// Todo con GDI+ (Graphics), sin imágenes externas.
        /// </summary>
        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int ancho = this.ClientSize.Width;
            int alto = this.ClientSize.Height;

            // Cielo con degradado
            Rectangle rectCielo = new Rectangle(0, 0, ancho, alto);
            using (LinearGradientBrush pincelCielo = new LinearGradientBrush(rectCielo, Color.Black, Color.Black, LinearGradientMode.Vertical))
            {
                ColorBlend degradado = new ColorBlend();
                degradado.Colors = new Color[] {
                    Color.FromArgb(12, 42, 41),
                    Color.FromArgb(31, 79, 71),
                    Color.FromArgb(196, 106, 63),
                    Color.FromArgb(232, 163, 92)
                };
                degradado.Positions = new float[] { 0f, 0.45f, 0.78f, 1f };
                pincelCielo.InterpolationColors = degradado;
                g.FillRectangle(pincelCielo, rectCielo);
            }

            // Sol / resplandor
            int solX = (int)(ancho * 0.74);
            int solY = (int)(alto * 0.30);
            using (SolidBrush brilloDebil = new SolidBrush(Color.FromArgb(60, 240, 190, 130)))
            {
                g.FillEllipse(brilloDebil, solX - 130, solY - 130, 260, 260);
            }
            using (SolidBrush brilloMedio = new SolidBrush(Color.FromArgb(110, 240, 190, 130)))
            {
                g.FillEllipse(brilloMedio, solX - 80, solY - 80, 160, 160);
            }
            using (SolidBrush sol = new SolidBrush(Color.FromArgb(255, 230, 186)))
            {
                g.FillEllipse(sol, solX - 42, solY - 42, 84, 84);
            }

            // Agua (parte inferior)
            int aguaY = (int)(alto * 0.74);
            Rectangle rectAgua = new Rectangle(0, aguaY, ancho, alto - aguaY);
            using (LinearGradientBrush pincelAgua = new LinearGradientBrush(rectAgua,
                Color.FromArgb(12, 36, 34), Color.FromArgb(7, 22, 21), LinearGradientMode.Vertical))
            {
                g.FillRectangle(pincelAgua, rectAgua);
            }
            using (Pen lucecita = new Pen(Color.FromArgb(55, 232, 163, 92), 3))
            {
                g.DrawLine(lucecita, ancho * 0.40f, aguaY + 22, ancho * 0.62f, aguaY + 22);
                g.DrawLine(lucecita, ancho * 0.44f, aguaY + 42, ancho * 0.70f, aguaY + 42);
                g.DrawLine(lucecita, ancho * 0.38f, aguaY + 64, ancho * 0.60f, aguaY + 64);
            }

            // Silueta del hotel
            using (SolidBrush negroVerdoso = new SolidBrush(Color.FromArgb(10, 24, 22)))
            {
                Rectangle cuerpoHotel = new Rectangle((int)(ancho * 0.08), (int)(alto * 0.60), (int)(ancho * 0.26), (int)(alto * 0.20));
                g.FillRectangle(negroVerdoso, cuerpoHotel);

                Rectangle letrero = new Rectangle((int)(ancho * 0.10), (int)(alto * 0.555), (int)(ancho * 0.09), (int)(alto * 0.04));
                g.FillRectangle(negroVerdoso, letrero);

                Rectangle torre = new Rectangle((int)(ancho * 0.30), (int)(alto * 0.50), (int)(ancho * 0.018), (int)(alto * 0.10));
                g.FillRectangle(negroVerdoso, torre);
            }

            using (SolidBrush ventanas = new SolidBrush(Color.FromArgb(200, 232, 163, 92)))
            {
                int baseX = (int)(ancho * 0.10);
                int baseY = (int)(alto * 0.64);
                int lado = 12;
                int espacioX = 26;
                int espacioY = 26;
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int col = 0; col < 6; col++)
                    {
                        if ((fila + col) % 3 == 2) continue;
                        g.FillRectangle(ventanas, baseX + col * espacioX, baseY + fila * espacioY, lado, lado);
                    }
                }
            }

            // Palmeras
            DibujarPalmera(g, ancho * 0.07f, alto * 0.60f, 1.0f, Color.FromArgb(8, 22, 21));
            DibujarPalmera(g, ancho * 0.905f, alto * 0.64f, 0.85f, Color.FromArgb(10, 24, 22));
            DibujarPalmera(g, ancho * 0.70f, alto * 0.80f, 0.7f, Color.FromArgb(6, 17, 16));

            // Velo oscuro hacia abajo para que el panel de login siempre tenga suficiente contraste
            using (LinearGradientBrush velo = new LinearGradientBrush(rectCielo,
                Color.FromArgb(0, 9, 20, 19), Color.FromArgb(150, 9, 20, 19), LinearGradientMode.Vertical))
            {
                g.FillRectangle(velo, rectCielo);
            }
        }

        /// <summary>
        /// Dibuja una palmera sencilla: un tronco curvo y 5 hojas curvas, con Pen y curvas Bezier.
        /// </summary>
        private void DibujarPalmera(Graphics g, float baseX, float baseY, float escala, Color color)
        {
            float altoTronco = 170 * escala;
            PointF pieTronco = new PointF(baseX, baseY);
            PointF copaTronco = new PointF(baseX + 14 * escala, baseY - altoTronco);

            using (Pen tronco = new Pen(color, 11 * escala))
            {
                tronco.StartCap = LineCap.Round;
                tronco.EndCap = LineCap.Round;
                g.DrawBezier(tronco,
                    pieTronco,
                    new PointF(baseX - 4 * escala, baseY - altoTronco * 0.6f),
                    new PointF(baseX + 20 * escala, baseY - altoTronco * 0.35f),
                    copaTronco);
            }

            using (Pen hoja = new Pen(color, 8 * escala))
            {
                hoja.StartCap = LineCap.Round;
                hoja.EndCap = LineCap.Round;

                float[][] curvas = new float[][]
                {
                    new float[] { -70, -20, -110, 0 },
                    new float[] { -60, -60, -95, -70 },
                    new float[] { -8, -70, 15, -110 },
                    new float[] { 55, -35, 95, -50 },
                    new float[] { 60, 5, 95, 30 },
                };

                foreach (float[] c in curvas)
                {
                    g.DrawBezier(hoja,
                        copaTronco,
                        new PointF(copaTronco.X + c[0] * 0.5f * escala, copaTronco.Y + c[1] * 0.5f * escala),
                        new PointF(copaTronco.X + c[0] * 0.85f * escala, copaTronco.Y + c[1] * 0.85f * escala),
                        new PointF(copaTronco.X + c[2] * escala, copaTronco.Y + c[3] * escala));
                }
            }
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
