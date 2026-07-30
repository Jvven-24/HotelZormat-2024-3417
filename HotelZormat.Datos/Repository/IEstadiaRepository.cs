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
    public interface IEstadiaRepository
    {
        void Insertar(Estadia estadia);
        Estadia BuscarActivaPorHabitacion(int numeroHabitacion);
        void Cerrar(int id, DateTime fechaSalida);
        List<Estadia> ObtenerHistorialPorHuesped(int huespedId);
        List<Estadia> ObtenerActivasDelDia();
    }
    public class EstadiaRepository : IEstadiaRepository
    {
        public void Insertar(Estadia estadia)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "INSERT INTO Estadias (ReservaId, FechaCheckInReal, Estado) VALUES (@reservaId, @checkIn, @estado)";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@reservaId", estadia.ReservaId);
                cmd.Parameters.AddWithValue("@checkIn", estadia.FechaCheckInReal);
                cmd.Parameters.AddWithValue("@estado", estadia.Estado);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Estadia BuscarActivaPorHabitacion(int numeroHabitacion)
        {
            Estadia e = null;
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT e.Id, e.ReservaId, e.FechaCheckInReal, e.FechaCheckOutReal, e.Estado " +
                             "FROM Estadias e INNER JOIN Reservas r ON e.ReservaId = r.Id " +
                             "WHERE r.HabitacionNumero = @numero AND e.Estado = 'Activa'";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@numero", numeroHabitacion);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    e = MapearEstadia(reader);
                }
            }
            return e;
        }

        public void Cerrar(int id, DateTime fechaSalida)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "UPDATE Estadias SET FechaCheckOutReal = @salida, Estado = 'Finalizada' WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@salida", fechaSalida);
                cmd.Parameters.AddWithValue("@id", id);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Estadia> ObtenerHistorialPorHuesped(int huespedId)
        {
            List<Estadia> estadias = new List<Estadia>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT e.Id, e.ReservaId, e.FechaCheckInReal, e.FechaCheckOutReal, e.Estado " +
                             "FROM Estadias e INNER JOIN Reservas r ON e.ReservaId = r.Id " +
                             "WHERE r.HuespedId = @huespedId ORDER BY e.FechaCheckInReal DESC";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@huespedId", huespedId);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    estadias.Add(MapearEstadia(reader));
                }
            }
            return estadias;
        }

        public List<Estadia> ObtenerActivasDelDia()
        {
            List<Estadia> estadias = new List<Estadia>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, ReservaId, FechaCheckInReal, FechaCheckOutReal, Estado FROM Estadias WHERE Estado = 'Activa'";
                SqlCommand cmd = new SqlCommand(sql, conexion);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    estadias.Add(MapearEstadia(reader));
                }
            }
            return estadias;
        }

        private Estadia MapearEstadia(SqlDataReader reader)
        {
            Estadia e = new Estadia();
            e.Id = (int)reader["Id"];
            e.ReservaId = (int)reader["ReservaId"];
            e.FechaCheckInReal = (DateTime)reader["FechaCheckInReal"];
            e.FechaCheckOutReal = reader["FechaCheckOutReal"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["FechaCheckOutReal"];
            e.Estado = (string)reader["Estado"];
            return e;
        }
    }
}