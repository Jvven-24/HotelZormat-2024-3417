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
    public interface IUsuarioRepository
    {
        Usuario BuscarPorNombreUsuario(string nombreUsuario);
        Usuario BuscarPorId(int id);
        List<Usuario> ObtenerTodos();
        void Insertar(Usuario usuario);
        void Actualizar(Usuario usuario);   
        void Desactivar(int id);
    }
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario BuscarPorNombreUsuario(string nombreUsuario)
        {
            Usuario usuario = null;
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, NombreUsuario, Contrasena, NombreCompleto, Rol, Activo " +
                             "FROM Usuarios WHERE NombreUsuario = @usuario AND Activo = 1";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@usuario", nombreUsuario);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = (int)reader["Id"];
                    usuario.NombreUsuario = (string)reader["NombreUsuario"];
                    usuario.Contrasena = (string)reader["Contrasena"];
                    usuario.NombreCompleto = (string)reader["NombreCompleto"];
                    usuario.Rol = (string)reader["Rol"];
                    usuario.Activo = (bool)reader["Activo"];
                }
            }
            return usuario;
        }
        public Usuario BuscarPorId(int id)
        {
            Usuario usuario = null;
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, NombreUsuario, Contrasena, NombreCompleto, Rol, Activo " +
                             "FROM Usuarios WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = (int)reader["Id"];
                    usuario.NombreUsuario = (string)reader["NombreUsuario"];
                    usuario.Contrasena = (string)reader["Contrasena"];
                    usuario.NombreCompleto = (string)reader["NombreCompleto"];
                    usuario.Rol = (string)reader["Rol"];
                    usuario.Activo = (bool)reader["Activo"];
                }
            }
            return usuario;

        }
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, NombreUsuario, Contrasena, NombreCompleto, Rol, Activo FROM Usuarios";
                SqlCommand cmd = new SqlCommand(sql, conexion);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = (int)reader["Id"];
                    usuario.NombreUsuario = (string)reader["NombreUsuario"];
                    usuario.Contrasena = (string)reader["Contrasena"];
                    usuario.NombreCompleto = (string)reader["NombreCompleto"];
                    usuario.Rol = (string)reader["Rol"];
                    usuario.Activo = (bool)reader["Activo"];
                    lista.Add(usuario);
                }
            }
            return lista;
        }

        public void Insertar(Usuario usuario)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "INSERT INTO Usuarios (NombreUsuario, Contrasena, NombreCompleto, Rol, Activo) " +
                             "VALUES (@usuario, @contrasena, @nombreCompleto, @rol, 1)";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                cmd.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
                cmd.Parameters.AddWithValue("@rol", usuario.Rol);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Actualizar(Usuario usuario)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql;
                if (!string.IsNullOrEmpty(usuario.Contrasena))
                {
                    sql = "UPDATE Usuarios SET NombreUsuario = @usuario, Contrasena = @contrasena, " +
                          "NombreCompleto = @nombreCompleto, Rol = @rol WHERE Id = @id";
                }
                else
                {
                    sql = "UPDATE Usuarios SET NombreUsuario = @usuario, " +
                          "NombreCompleto = @nombreCompleto, Rol = @rol WHERE Id = @id";
                }

                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@nombreCompleto", usuario.NombreCompleto);
                cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                cmd.Parameters.AddWithValue("@id", usuario.Id);
                if (!string.IsNullOrEmpty(usuario.Contrasena))
                {
                    cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                }

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Desactivar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "UPDATE Usuarios SET Activo = 0 WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", id);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
