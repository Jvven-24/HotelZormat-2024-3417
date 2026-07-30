// Cedula : 402-1937000-0
using HotelZormat.Datos.Conexion;
using HotelZormat.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HotelZormat.Datos.Repositorio
{
    public interface IHabitacionRepository
    {
        List<Habitacion> ObtenerTodas();
        List<Habitacion> ObtenerPorFiltro(int? piso, string estado);
        Habitacion BuscarPorNumero(int numero);
        void Insertar(Habitacion habitacion);
        void Actualizar(Habitacion habitacion);
        void Eliminar(int numero);
        void CambiarEstado(int numero, string nuevoEstado);
    }

    public class HabitacionRepository : IHabitacionRepository
    {
        public List<Habitacion> ObtenerTodas()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Numero, Tipo, Piso, Estado, Capacidad, TarifaBase FROM Habitaciones";
                SqlCommand cmd = new SqlCommand(sql, conexion);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Habitacion h = new Habitacion();
                    h.Numero = (int)reader["Numero"];
                    h.Tipo = (string)reader["Tipo"];
                    h.Piso = (int)reader["Piso"];
                    h.Estado = (string)reader["Estado"];
                    h.Capacidad = (int)reader["Capacidad"];
                    h.TarifaBase = (decimal)reader["TarifaBase"];
                    habitaciones.Add(h);
                }
            }
            return habitaciones;
        }

        public List<Habitacion> ObtenerPorFiltro(int? piso, string estado)
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Numero, Tipo, Piso, Estado, Capacidad, TarifaBase FROM Habitaciones " +
                             "WHERE (@piso IS NULL OR Piso = @piso) AND (@estado IS NULL OR Estado = @estado)";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@piso", (object)piso ?? DBNull.Value);            // 1. null-check manual
                cmd.Parameters.AddWithValue("@estado", string.IsNullOrEmpty(estado) ? (object)DBNull.Value : estado);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Habitacion h = new Habitacion();
                    h.Numero = (int)reader["Numero"];
                    h.Tipo = (string)reader["Tipo"];
                    h.Piso = (int)reader["Piso"];
                    h.Estado = (string)reader["Estado"];
                    h.Capacidad = (int)reader["Capacidad"];
                    h.TarifaBase = (decimal)reader["TarifaBase"];
                    habitaciones.Add(h);
                }
            }
            return habitaciones;
        }

        public Habitacion BuscarPorNumero(int numero)
        {
            Habitacion h = null;
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Numero, Tipo, Piso, Estado, Capacidad, TarifaBase FROM Habitaciones WHERE Numero = @numero";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@numero", numero);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    h = new Habitacion();
                    h.Numero = (int)reader["Numero"];
                    h.Tipo = (string)reader["Tipo"];
                    h.Piso = (int)reader["Piso"];
                    h.Estado = (string)reader["Estado"];
                    h.Capacidad = (int)reader["Capacidad"];
                    h.TarifaBase = (decimal)reader["TarifaBase"];
                }
            }
            return h;
        }

        public void Insertar(Habitacion habitacion)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "INSERT INTO Habitaciones (Numero, Tipo, Piso, Estado, Capacidad, TarifaBase) " +
                             "VALUES (@n, @t, @p, @e, @c, @tarifa)";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@n", habitacion.Numero);
                cmd.Parameters.AddWithValue("@t", habitacion.Tipo);
                cmd.Parameters.AddWithValue("@p", habitacion.Piso);
                cmd.Parameters.AddWithValue("@e", habitacion.Estado);
                cmd.Parameters.AddWithValue("@c", habitacion.Capacidad);
                cmd.Parameters.AddWithValue("@tarifa", habitacion.TarifaBase);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Habitacion habitacion)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "UPDATE Habitaciones SET Tipo=@t, Piso=@p, Estado=@e, Capacidad=@c, TarifaBase=@tarifa WHERE Numero=@n";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@n", habitacion.Numero);
                cmd.Parameters.AddWithValue("@t", habitacion.Tipo);
                cmd.Parameters.AddWithValue("@p", habitacion.Piso);          // ← la línea que faltaba
                cmd.Parameters.AddWithValue("@e", habitacion.Estado);
                cmd.Parameters.AddWithValue("@c", habitacion.Capacidad);
                cmd.Parameters.AddWithValue("@tarifa", habitacion.TarifaBase);

                conexion.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    throw new Exception("No existe la habitación #" + habitacion.Numero + " para actualizar");
                }
            }
        }

        public void Eliminar(int numero)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "DELETE FROM Habitaciones WHERE Numero = @numero";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@numero", numero);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CambiarEstado(int numero, string nuevoEstado)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "UPDATE Habitaciones SET Estado = @estado WHERE Numero = @numero";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@numero", numero);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
