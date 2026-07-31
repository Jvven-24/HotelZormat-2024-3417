// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelZormat.UI
{
    internal static class ValidacionesTexto
    {
        public static void SoloDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void SoloDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        public static bool ValidarComboRequerido(ComboBox combo, ErrorProvider provider, string mensaje)
        {
            if (combo.SelectedIndex < 0)
            {
                provider.SetError(combo, mensaje);
                return false;
            }

            provider.SetError(combo, "");
            return true;
        }
    }
}