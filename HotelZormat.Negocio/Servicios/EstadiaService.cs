// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Datos.Repositorio;

namespace HotelZormat.Negocio.Servicios
{
    public class EstadiaService
    {
        private readonly IEstadiaRepository _repo;

        public EstadiaService(IEstadiaRepository repo)
        {
            _repo = repo;
        }
    }
}