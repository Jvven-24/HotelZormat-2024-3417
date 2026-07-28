// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Datos.Repositorio;

namespace HotelZormat.Negocio.Servicios
{
    public class HuespedService
    {
        private readonly IHuespedRepository _repo;

        public HuespedService(IHuespedRepository repo)
        {
            _repo = repo;
        }
    }
}
