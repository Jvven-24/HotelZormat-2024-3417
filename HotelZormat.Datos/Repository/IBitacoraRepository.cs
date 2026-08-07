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
    public interface IBitacoraRepository
    {
        void Registrar(int usuarioId, string accion, string detalle);
        List<RegistroBitacora> ObtenerTodas();
    }
   
    public class BitacoraRepository : IBitacoraRepository
    {
        // TODO: Registrar - Recibe usuarioId (int), accion (string) y detalle (string), ejecuta INSERT parametrizado en Bitacora para auditar la acción
        public void Registrar(int usuarioId, string accion, string detalle)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "INSERT INTO Bitacora (UsuarioId, Accion, Detalle) " +
                             "VALUES (@usuarioId, @accion, @detalle)";       

                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@accion", accion);
                cmd.Parameters.AddWithValue("@detalle", (object)detalle ?? DBNull.Value);  

                conexion.Open();
                cmd.ExecuteNonQuery();                                      
            }
        }
        // TODO: ObtenerTodas - Sin parámetros, ejecuta SELECT ordenado por FechaHora DESC con SqlDataReader, retorna List<RegistroBitacora>
        public List<RegistroBitacora> ObtenerTodas()
        {
            List<RegistroBitacora> registros = new List<RegistroBitacora>();
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT Id, UsuarioId, Accion, Detalle, FechaHora FROM Bitacora ORDER BY FechaHora DESC";
                SqlCommand cmd = new SqlCommand(sql, conexion);

                conexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    registros.Add(MapearRegistro(reader));
                }
            }
            return registros;
        }

        private RegistroBitacora MapearRegistro(SqlDataReader reader)
        {
            RegistroBitacora r = new RegistroBitacora();
            r.Id = (int)reader["Id"];
            r.UsuarioId = (int)reader["UsuarioId"];
            r.Accion = (string)reader["Accion"];
            r.Detalle = reader["Detalle"] == DBNull.Value ? null : (string)reader["Detalle"];
            r.FechaHora = (DateTime)reader["FechaHora"];
            return r;
        }

    }
    



}