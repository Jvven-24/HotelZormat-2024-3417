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
    public class EstadiaService
    {
        private readonly IEstadiaRepository _repo;
        private readonly IReservaRepository _reservaRepo;
        private readonly IHabitacionRepository _habitacionRepo;
        private readonly IBitacoraRepository _bitacoraRepo;
       

        public EstadiaService()
        {
            _repo = new EstadiaRepository();
            _reservaRepo = new ReservaRepository();
            _habitacionRepo = new HabitacionRepository();
            _bitacoraRepo = new BitacoraRepository();
        }
        public List<Estadia> ObtenerHistorialPorHuesped(int huespedId)
        {
            return _repo.ObtenerHistorialPorHuesped(huespedId);
        }
        public void HacerCheckIn(int reservaId)
        {
            Reserva reserva = _reservaRepo.BuscarPorId(reservaId);
            if (reserva == null)
            {
                throw new ArgumentException("No existe la reserva #" + reservaId);
            }
            if (reserva.Estado != "Confirmada")
            {
                throw new InvalidOperationException(
                    "La reserva #" + reservaId + " debe estar Confirmada para hacer check-in (estado actual: " + reserva.Estado + ")");
            }

            Habitacion hab = _habitacionRepo.BuscarPorNumero(reserva.HabitacionNumero);
            if (hab != null && hab.Estado == "Ocupada")
            {
                throw new HabitacionOcupadaException(hab.Numero,
                    "La habitación " + hab.Numero + " ya está ocupada");
            }

            Estadia estadia = new Estadia();
            estadia.ReservaId = reservaId;
            estadia.FechaCheckInReal = DateTime.Now;
            estadia.Estado = "Activa";
            _repo.Insertar(estadia);

            _habitacionRepo.CambiarEstado(reserva.HabitacionNumero, "Ocupada");

            int usuarioId = SesionActual.UsuarioLogueado.Id;
            _bitacoraRepo.Registrar(usuarioId, "CheckIn", "Reserva #" + reservaId + " hab. " + reserva.HabitacionNumero);
        }
    }
}
