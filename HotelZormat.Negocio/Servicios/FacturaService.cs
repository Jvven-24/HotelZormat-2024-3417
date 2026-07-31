// Cedula : 402 - 1937000 - 0
using HotelZormat.Datos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Servicios
{
    public class FacturaService
    {
        private readonly IFacturaRepository _repo;

        public FacturaService()
        {
            _repo = new FacturaRepository();
        }

        public int ContarFacturasPorRango(DateTime desde, DateTime hasta)
        {
            if (hasta < desde)
            {
                throw new ArgumentException("La fecha 'Hasta' debe ser mayor o igual a 'Desde'");
            }
            return _repo.ContarFacturasPorRango(desde, hasta);
        }

        public decimal ObtenerIngresosPorRango(DateTime desde, DateTime hasta)
        {
            if (hasta < desde)
            {
                throw new ArgumentException("La fecha 'Hasta' debe ser mayor o igual a 'Desde'");
            }
            return _repo.ObtenerIngresosPorRango(desde, hasta);
        }
    }
}
