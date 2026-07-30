// Cedula : 402-1937000-0
using HotelZormat.Datos.Repositorio;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Excepciones;
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

        public List<Habitacion> ObtenerPorFiltro(int? piso, string estado)
        {
            return _repo.ObtenerPorFiltro(piso, estado);
        }

        public Habitacion BuscarPorNumero(int numero)
        {
            return _repo.BuscarPorNumero(numero);
        }

        public void Guardar(Habitacion h)
        {
            if (h.Numero <= 0)                                              
            {
                throw new ArgumentException("El número de habitación debe ser mayor a 0");
            }
            if (!ReservaService.ValidarTipoHabitacion(h.Tipo))
            {
                throw new ArgumentException("Tipo de habitación inválido: " + h.Tipo);
            }
            if (h.Capacidad < 1)
            {
                throw new ArgumentException("La capacidad debe ser al menos 1");
            }
            if (h.TarifaBase <= 0)
            {
                throw new ArgumentException("La tarifa debe ser mayor a 0");
            }

            Habitacion existente = _repo.BuscarPorNumero(h.Numero);        

            if (existente != null)
            {
                if (existente.Estado == "Ocupada" && h.Estado == "Disponible")   
                {
                    throw new HabitacionOcupadaException(h.Numero,
                        "La habitación " + h.Numero + " está ocupada, debe pasar por Limpieza antes de estar Disponible");
                }
                _repo.Actualizar(h);                                        
            }
            else
            {
                _repo.Insertar(h);                                          
            }
        }

        public void Eliminar(int numero, bool esAdministrador)
        {
            if (!esAdministrador)                                           
            {
                throw new UnauthorizedAccessException("Solo el Administrador puede eliminar habitaciones");
            }

            Habitacion existente = _repo.BuscarPorNumero(numero);

            if (existente != null && existente.Estado == "Ocupada")
            {
                throw new HabitacionOcupadaException(numero,
                    "No se puede eliminar la habitación " + numero + " porque está ocupada");
            }

            _repo.Eliminar(numero);
        }
    }
}