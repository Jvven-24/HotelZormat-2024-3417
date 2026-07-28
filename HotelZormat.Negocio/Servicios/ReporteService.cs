// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Datos.Repositorio;

namespace HotelZormat.Negocio.Servicios
{
    public class ReporteService
    {
        private readonly IFacturaRepository _repoFactura;
        private readonly IReservaRepository _repoReserva;

        public ReporteService(IFacturaRepository repoFactura, IReservaRepository repoReserva)
        {
            _repoFactura = repoFactura;
            _repoReserva = repoReserva;
        }
    }
}