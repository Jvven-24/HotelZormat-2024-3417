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
    public interface IReservaRepository
    {
        List<Reserva> ObtenerTodas();
        Reserva BuscarPorId(int id);
        List<Reserva> ObtenerProximas(int dias);
        void Insertar(Reserva reserva);
        void Actualizar(Reserva reserva);
        void CambiarEstado(int id, string nuevoEstado);
    }
    public class ReservaRepository : IReservaRepository
    {
        // TODO: ObtenerTodas - Sin parámetros, ejecuta SELECT ordenado por FechaCheckIn con SqlDataReader, retorna List<Reserva>
        public List<Reserva> ObtenerTodas()
        {
            List<Reserva> reservas = new List<Reserva>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, HuespedId, HabitacionNumero, FechaCheckIn, FechaCheckOut, " +
                             "Temporada, Estado, TotalNoches, MontoEstimado, FechaCreacion " +
                             "FROM Reservas ORDER BY FechaCheckIn DESC";
                SqlCommand cmd = new SqlCommand(sql, conexion);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reservas.Add(MapearReserva(reader));
                }
            }
            return reservas;
        }

        // TODO: BuscarPorId - Recibe id (int), busca parametrizado y retorna la Reserva o null
        public Reserva BuscarPorId(int id)
        {
            Reserva r = null;
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, HuespedId, HabitacionNumero, FechaCheckIn, FechaCheckOut, " +
                             "Temporada, Estado, TotalNoches, MontoEstimado, FechaCreacion " +
                             "FROM Reservas WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    r = MapearReserva(reader);
                }
            }
            return r;
        }

        // TODO: ObtenerProximas - Recibe dias (int), filtra Estado='Confirmada' y FechaCheckIn entre hoy y hoy+dias (parametrizado), retorna List<Reserva>
        public List<Reserva> ObtenerProximas(int dias)
        {
            List<Reserva> reservas = new List<Reserva>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, HuespedId, HabitacionNumero, FechaCheckIn, FechaCheckOut, " +
                             "Temporada, Estado, TotalNoches, MontoEstimado, FechaCreacion " +
                             "FROM Reservas WHERE Estado = 'Confirmada' AND FechaCheckIn BETWEEN @hoy AND @limite " +
                             "ORDER BY FechaCheckIn";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@hoy", DateTime.Today);
                cmd.Parameters.AddWithValue("@limite", DateTime.Today.AddDays(dias));

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reservas.Add(MapearReserva(reader));
                }
            }
            return reservas;
        }

        // TODO: Insertar - Recibe una Reserva, ejecuta INSERT parametrizado contra la tabla Reservas
        public void Insertar(Reserva reserva)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "INSERT INTO Reservas (HuespedId, HabitacionNumero, FechaCheckIn, FechaCheckOut, " +
                             "Temporada, Estado, TotalNoches, MontoEstimado) " +
                             "VALUES (@huespedId, @habNumero, @checkIn, @checkOut, @temporada, @estado, @noches, @monto)";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@huespedId", reserva.HuespedId);
                cmd.Parameters.AddWithValue("@habNumero", reserva.HabitacionNumero);
                cmd.Parameters.AddWithValue("@checkIn", reserva.FechaCheckIn);
                cmd.Parameters.AddWithValue("@checkOut", reserva.FechaCheckOut);
                cmd.Parameters.AddWithValue("@temporada", reserva.Temporada);
                cmd.Parameters.AddWithValue("@estado", reserva.Estado);
                cmd.Parameters.AddWithValue("@noches", reserva.TotalNoches);
                cmd.Parameters.AddWithValue("@monto", reserva.MontoEstimado);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // TODO: Actualizar - Recibe una Reserva, ejecuta UPDATE parametrizado y lanza Exception si no afectó ninguna fila
        public void Actualizar(Reserva reserva)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "UPDATE Reservas SET HuespedId=@huespedId, HabitacionNumero=@habNumero, " +
                             "FechaCheckIn=@checkIn, FechaCheckOut=@checkOut, Temporada=@temporada, " +
                             "TotalNoches=@noches, MontoEstimado=@monto WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", reserva.Id);
                cmd.Parameters.AddWithValue("@huespedId", reserva.HuespedId);
                cmd.Parameters.AddWithValue("@habNumero", reserva.HabitacionNumero);
                cmd.Parameters.AddWithValue("@checkIn", reserva.FechaCheckIn);
                cmd.Parameters.AddWithValue("@checkOut", reserva.FechaCheckOut);
                cmd.Parameters.AddWithValue("@temporada", reserva.Temporada);
                cmd.Parameters.AddWithValue("@noches", reserva.TotalNoches);
                cmd.Parameters.AddWithValue("@monto", reserva.MontoEstimado);

                conexion.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    throw new Exception("No existe la reserva #" + reserva.Id + " para actualizar");
                }
            }
        }

        // TODO: CambiarEstado - Recibe id (int) y nuevoEstado (string: Pendiente/Confirmada/Cancelada), ejecuta UPDATE parametrizado
        public void CambiarEstado(int id, string nuevoEstado)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "UPDATE Reservas SET Estado = @estado WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", id);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private Reserva MapearReserva(SqlDataReader reader)
        {
            Reserva r = new Reserva();
            r.Id = (int)reader["Id"];
            r.HuespedId = (int)reader["HuespedId"];
            r.HabitacionNumero = (int)reader["HabitacionNumero"];
            r.FechaCheckIn = (DateTime)reader["FechaCheckIn"];
            r.FechaCheckOut = (DateTime)reader["FechaCheckOut"];
            r.Temporada = (string)reader["Temporada"];
            r.Estado = (string)reader["Estado"];
            r.TotalNoches = (int)reader["TotalNoches"];
            r.MontoEstimado = (decimal)reader["MontoEstimado"];
            r.FechaCreacion = (DateTime)reader["FechaCreacion"];
            return r;
        }
    }
}