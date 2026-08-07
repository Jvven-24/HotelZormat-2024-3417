// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HotelZormat.Datos.Conexion
{
    public static class ConfiguracionBD
    {
        // TODO: ObtenerConnectionString - Sin parámetros, lee el connection string desde App.config y lo retorna como string
        public static string ObtenerConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HotelZormatDB"].ConnectionString;
        }
    }
}