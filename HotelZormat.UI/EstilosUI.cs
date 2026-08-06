using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HotelZormat.UI
{
    internal static class EstilosUI
    {
        private const int RadioPorDefecto = 14;

        /// <summary>
        /// Enganchado al evento Resize de un Panel para que sus esquinas se mantengan
        /// redondeadas incluso cuando el panel cambia de tamaño (Dock=Fill, Anchor, etc.).
        /// </summary>
        public static void RedondearEsquinas(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            AplicarEsquinasRedondeadas(control, RadioPorDefecto);
        }

        /// <summary>
        /// Enganchado al evento CellFormatting de un DataGridView: subraya el texto de la
        /// fila seleccionada para que se note claramente cuál está elegida (además del color
        /// de fondo de selección).
        /// </summary>
        public static void SubrayarFilaSeleccionada(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            if (e.RowIndex < 0) return;

            if (grid.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(grid.Font, FontStyle.Underline);
            }
        }

        /// <summary>
        /// Enganchado al evento SelectionChanged de un DataGridView para forzar el repintado
        /// inmediato (y así el subrayado de SubrayarFilaSeleccionada se vea al instante).
        /// </summary>
        public static void RefrescarSeleccion(object sender, EventArgs e)
        {
            ((DataGridView)sender).Invalidate();
        }

        public static void AplicarEsquinasRedondeadas(Control control, int radio)
        {
            if (control.Width <= 0 || control.Height <= 0)
            {
                return;
            }

            int diametro = radio * 2;
            Rectangle area = new Rectangle(0, 0, control.Width, control.Height);

            GraphicsPath ruta = new GraphicsPath();
            ruta.AddArc(area.X, area.Y, diametro, diametro, 180, 90);
            ruta.AddArc(area.Right - diametro, area.Y, diametro, diametro, 270, 90);
            ruta.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90);
            ruta.AddArc(area.X, area.Bottom - diametro, diametro, diametro, 90, 90);
            ruta.CloseFigure();

            control.Region = new Region(ruta);
        }
    }
}
