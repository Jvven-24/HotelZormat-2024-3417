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
    public interface IHuespedRepository
    {
        List<Huesped> ObtenerTodos();
        Huesped BuscarPorId(int id);
        List<Huesped> Buscar(string textoCedulaONombre);
        void Insertar(Huesped huesped);
        void Actualizar(Huesped huesped);
        void Eliminar(int id);
    }

    public class HuespedRepository : IHuespedRepository
    {
        // TODO: ObtenerTodos - Sin parámetros, ejecuta SELECT con SqlDataReader (while) y retorna List<Huesped> ordenada por apellido/nombre
        public List<Huesped> ObtenerTodos()
        {
            List<Huesped> huespedes = new List<Huesped>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, Nombre, Apellido, TipoDocumento, NumeroDocumento, Nacionalidad, Telefono, Email, FechaRegistro " +
                             "FROM Huespedes ORDER BY Apellido, Nombre";
                SqlCommand cmd = new SqlCommand(sql, conexion);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    huespedes.Add(MapearHuesped(reader));
                }
            }
            return huespedes;
        }

        // TODO: BuscarPorId - Recibe id (int), busca parametrizado (@id) y retorna el Huesped o null
        public Huesped BuscarPorId(int id)
        {
            Huesped h = null;
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, Nombre, Apellido, TipoDocumento, NumeroDocumento, Nacionalidad, Telefono, Email, FechaRegistro " +
                             "FROM Huespedes WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    h = MapearHuesped(reader);
                }
            }
            return h;
        }

        // TODO: Buscar - Recibe textoCedulaONombre (string), ejecuta SELECT con LIKE @texto sobre NumeroDocumento/Nombre/Apellido, retorna List<Huesped>
        public List<Huesped> Buscar(string textoCedulaONombre)
        {
            List<Huesped> huespedes = new List<Huesped>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, Nombre, Apellido, TipoDocumento, NumeroDocumento, Nacionalidad, Telefono, Email, FechaRegistro " +
                             "FROM Huespedes WHERE NumeroDocumento LIKE @texto OR Nombre LIKE @texto OR Apellido LIKE @texto " +
                             "ORDER BY Apellido, Nombre";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@texto", "%" + textoCedulaONombre + "%");

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    huespedes.Add(MapearHuesped(reader));
                }
            }
            return huespedes;
        }

        // TODO: Insertar - Recibe un Huesped, ejecuta INSERT parametrizado contra la tabla Huespedes (Telefono/Email con DBNull si vienen vacíos)
        public void Insertar(Huesped huesped)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "INSERT INTO Huespedes (Nombre, Apellido, TipoDocumento, NumeroDocumento, Nacionalidad, Telefono, Email) " +
                             "VALUES (@nombre, @apellido, @tipoDoc, @numDoc, @nacionalidad, @telefono, @email)";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@nombre", huesped.Nombre);
                cmd.Parameters.AddWithValue("@apellido", huesped.Apellido);
                cmd.Parameters.AddWithValue("@tipoDoc", huesped.TipoDocumento);
                cmd.Parameters.AddWithValue("@numDoc", huesped.NumeroDocumento);
                cmd.Parameters.AddWithValue("@nacionalidad", huesped.Nacionalidad);
                cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(huesped.Telefono) ? (object)DBNull.Value : huesped.Telefono);
                cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(huesped.Email) ? (object)DBNull.Value : huesped.Email);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // TODO: Actualizar - Recibe un Huesped, ejecuta UPDATE parametrizado y lanza Exception si no afectó ninguna fila
        public void Actualizar(Huesped huesped)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "UPDATE Huespedes SET Nombre=@nombre, Apellido=@apellido, TipoDocumento=@tipoDoc, " +
                             "NumeroDocumento=@numDoc, Nacionalidad=@nacionalidad, Telefono=@telefono, Email=@email " +
                             "WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", huesped.Id);
                cmd.Parameters.AddWithValue("@nombre", huesped.Nombre);
                cmd.Parameters.AddWithValue("@apellido", huesped.Apellido);
                cmd.Parameters.AddWithValue("@tipoDoc", huesped.TipoDocumento);
                cmd.Parameters.AddWithValue("@numDoc", huesped.NumeroDocumento);
                cmd.Parameters.AddWithValue("@nacionalidad", huesped.Nacionalidad);
                cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(huesped.Telefono) ? (object)DBNull.Value : huesped.Telefono);
                cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(huesped.Email) ? (object)DBNull.Value : huesped.Email);

                conexion.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    throw new Exception("No existe el huésped #" + huesped.Id + " para actualizar");
                }
            }
        }

        // TODO: Eliminar - Recibe id (int), ejecuta DELETE parametrizado sobre Huespedes
        public void Eliminar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "DELETE FROM Huespedes WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private Huesped MapearHuesped(SqlDataReader reader)
        {
            Huesped h = new Huesped();
            h.Id = (int)reader["Id"];
            h.Nombre = (string)reader["Nombre"];
            h.Apellido = (string)reader["Apellido"];
            h.TipoDocumento = (string)reader["TipoDocumento"];
            h.NumeroDocumento = (string)reader["NumeroDocumento"];
            h.Nacionalidad = (string)reader["Nacionalidad"];
            h.Telefono = reader["Telefono"] == DBNull.Value ? null : (string)reader["Telefono"];
            h.Email = reader["Email"] == DBNull.Value ? null : (string)reader["Email"];
            h.FechaRegistro = (DateTime)reader["FechaRegistro"];
            return h;
        }
    }
}
