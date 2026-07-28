// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Modelo;

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
}