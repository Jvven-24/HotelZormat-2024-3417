using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HotelZormat.Datos.Conexion
{
    /// <summary>
    /// Punto único de conexión a la base de datos del hotel.
    /// El día 5 (semana 02) lo conectaremos a SQL Server.
    /// /// </summary>
    public static class ConexionBD
    {
        private static readonly string _cadena =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=HotelZormatDB;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadena);
        }
    }
}
