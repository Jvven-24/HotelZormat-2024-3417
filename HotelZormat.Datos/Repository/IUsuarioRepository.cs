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
    }

}
