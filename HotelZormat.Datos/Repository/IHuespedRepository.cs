// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Modelo;

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
}
