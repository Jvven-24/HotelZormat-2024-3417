// Cedula : 402-1937000-0
using HotelZormat.Datos.Repositorio;
using HotelZormat.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Servicios
{
    public class HabitacionService
    {
        private readonly IHabitacionRepository _repo;

        public HabitacionService()
        {
            _repo = new HabitacionRepository();
        }
        public List<Habitacion> ObtenerTodas()
        {
            return _repo.ObtenerTodas();
        }
    }
}