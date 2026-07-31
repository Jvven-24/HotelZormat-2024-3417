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
    public class BitacoraService
    {
        private readonly IBitacoraRepository _repo;

        public BitacoraService()
        {
            _repo = new BitacoraRepository();
        }

        public List<RegistroBitacora> ObtenerTodas()
        {
            return _repo.ObtenerTodas();
        }

        public List<RegistroBitacora> ObtenerPorAccion(string accion)
        {
            List<RegistroBitacora> resultado = new List<RegistroBitacora>();
            foreach (RegistroBitacora r in _repo.ObtenerTodas())
            {
                if (r.Accion == accion)
                {
                    resultado.Add(r);
                }
            }
            return resultado;
        }
    }
}
