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
    public interface IFacturaRepository
    {
        void Insertar(Factura factura);
        string ObtenerSiguienteNCF();
        decimal ObtenerIngresosPorRango(DateTime desde, DateTime hasta);
        int ContarFacturasPorRango(DateTime desde, DateTime hasta);
    }
    public class FacturaRepository : IFacturaRepository
    {
        public string ObtenerSiguienteNCF()
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                conexion.Open();

                SqlCommand cmdUpdate = new SqlCommand(
                    "UPDATE SecuenciaNCF SET UltimoNumero = UltimoNumero + 1 WHERE Tipo = 'B02'", conexion);
                cmdUpdate.ExecuteNonQuery();

                SqlCommand cmdSelect = new SqlCommand(
                    "SELECT UltimoNumero FROM SecuenciaNCF WHERE Tipo = 'B02'", conexion);
                int numero = (int)cmdSelect.ExecuteScalar();

                return "B02" + numero.ToString("D8");
            }
        }

        public void Insertar(Factura factura)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "INSERT INTO Facturas (NCF, EstadiaId, Subtotal, Itbis, Propina, Total) " +
                             "VALUES (@ncf, @estadiaId, @subtotal, @itbis, @propina, @total)";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@ncf", factura.NCF);
                cmd.Parameters.AddWithValue("@estadiaId", factura.EstadiaId);
                cmd.Parameters.AddWithValue("@subtotal", factura.Subtotal);
                cmd.Parameters.AddWithValue("@itbis", factura.Itbis);
                cmd.Parameters.AddWithValue("@propina", factura.Propina);
                cmd.Parameters.AddWithValue("@total", factura.Total);

                conexion.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public decimal ObtenerIngresosPorRango(DateTime desde, DateTime hasta)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT ISNULL(SUM(Total), 0) FROM Facturas WHERE FechaEmision BETWEEN @desde AND @hasta";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);

                conexion.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }
        public int ContarFacturasPorRango(DateTime desde, DateTime hasta)
        {
            using (SqlConnection conexion = new SqlConnection(ConfiguracionBD.ObtenerConnectionString()))
            {
                string sql = "SELECT COUNT(*) FROM Facturas WHERE FechaEmision BETWEEN @desde AND @hasta";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);

                conexion.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}