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
        private readonly IFacturaRepository _facturaRepo;
        private readonly ReservaService _reservaService;


        public EstadiaService()
        {
            _repo = new EstadiaRepository();
            _reservaRepo = new ReservaRepository();
            _habitacionRepo = new HabitacionRepository();
            _bitacoraRepo = new BitacoraRepository();
            _facturaRepo = new FacturaRepository();
            _reservaService = new ReservaService();
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

        public List<Estadia> ObtenerActivas()
        {
            return _repo.ObtenerActivasDelDia();
        }

        public Estadia BuscarPorId(int id)
        {
            return _repo.BuscarPorId(id);
        }

        public Factura HacerCheckOut(int estadiaId)
        {
            Estadia estadia = _repo.BuscarPorId(estadiaId);
            if (estadia == null || estadia.Estado != "Activa")
            {
                throw new InvalidOperationException("La estadía #" + estadiaId + " no está Activa");
            }

            Reserva reserva = _reservaRepo.BuscarPorId(estadia.ReservaId);
            if (reserva == null)
            {
                throw new ArgumentException("No existe la reserva asociada a la estadía #" + estadiaId);
            }

            Habitacion hab = _habitacionRepo.BuscarPorNumero(reserva.HabitacionNumero);
            if (hab == null)
            {
                throw new ArgumentException("No existe la habitación " + reserva.HabitacionNumero);
            }

            int noches = Math.Max(1, _reservaService.CalcularNoches(estadia.FechaCheckInReal, DateTime.Now));
            decimal tarifaNoche = _reservaService.CalcularTarifaConTemporada(hab.TarifaBase, reserva.Temporada);
            decimal subtotal = noches * tarifaNoche;
            decimal itbis = subtotal * 0.18m;
            decimal propina = subtotal * 0.10m;
            decimal total = subtotal + itbis + propina;

            Factura factura = new Factura();
            factura.NCF = _facturaRepo.ObtenerSiguienteNCF();
            factura.EstadiaId = estadiaId;
            factura.Subtotal = subtotal;
            factura.Itbis = itbis;
            factura.Propina = propina;
            factura.Total = total;
            factura.FechaEmision = DateTime.Now;
            _facturaRepo.Insertar(factura);

            _repo.Cerrar(estadiaId, DateTime.Now);
            _habitacionRepo.CambiarEstado(reserva.HabitacionNumero, "Limpieza");

            int usuarioId = SesionActual.UsuarioLogueado.Id;
            _bitacoraRepo.Registrar(usuarioId, "CheckOut", "Estadía #" + estadiaId + " hab. " + reserva.HabitacionNumero);
            _bitacoraRepo.Registrar(usuarioId, "Facturacion", "Factura " + factura.NCF + " por " + total.ToString("N2"));

            return factura;
        }
    }
}
