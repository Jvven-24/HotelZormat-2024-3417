// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Modelo;

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
}