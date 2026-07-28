using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelZormat.Datos.Conexion
{
    public static class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(ConfiguracionBD.ObtenerConnectionString());
        }
    }
}
