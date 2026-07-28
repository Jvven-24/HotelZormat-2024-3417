// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Modelo;



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
}
