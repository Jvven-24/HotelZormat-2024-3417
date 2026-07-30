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
        public List<RegistroBitacora> ObtenerTodas()
        {
            throw new NotImplementedException();
        }

    }
    



}