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
            throw new NotImplementedException();    
        }

        public Habitacion BuscarPorNumero(int numero)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(Habitacion habitacion)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int numero)
        {
            throw new NotImplementedException();
        }

        public void CambiarEstado(int numero, string nuevoEstado)
        {
            throw new NotImplementedException();
        }
    }
}
