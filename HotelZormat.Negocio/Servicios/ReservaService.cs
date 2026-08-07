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
    public class ReservaService
    {
        private readonly IReservaRepository _repo;
        private readonly IHabitacionRepository _habitacionRepo;

        public ReservaService()
        {
            _repo = new ReservaRepository();
            _habitacionRepo = new HabitacionRepository();
        }

        public static bool ValidarTipoHabitacion(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo)) return false;
            return tipo == "Sencilla" || tipo == "Doble" || tipo == "Suite";
        }

        // TODO: ObtenerDescuentoPorTemporada - Recibe temporada (string), switch que retorna el factor de descuento/recargo (Alta 0, Media 0.10, Baja 0.20, Pico -0.15)
        public decimal ObtenerDescuentoPorTemporada(string temporada)
        {
            decimal factor;

            switch (temporada)
            {
                case "Baja":
                    factor = 0.20m;
                    break;

                case "Media":
                    factor = 0.10m;
                    break;

                case "Alta":
                    factor = 0m;
                    break;

                case "Pico":
                    factor = -0.15m; // negativo = recarga
                    break;

                default:
                    throw new ArgumentException("Temporada desconocida: " + temporada);
            }

            return factor;
        }

        // TODO: GenerarLineasFactura - Recibe noches (int) y tarifaPorNoche (decimal), arma una línea por noche con un for, retorna List<string>
        public List<string> GenerarLineasFactura(int noches, decimal tarifaPorNoche)
        {
            var lineas = new List<string>();

            if (noches <= 0)
            {
                return lineas;
            }

            for (int i = 1; i <= noches; i++)
            {
                string linea = "Noche " + i + ": RD$ " + tarifaPorNoche;
                lineas.Add(linea);
            }

            return lineas;
        }

        // TODO: BuscarPrimeraDisponible - Recibe una List<Habitacion> y capacidadMinima (int), recorre con foreach+break y retorna la primera disponible con esa capacidad
        public Habitacion BuscarPrimeraDisponible(List<Habitacion> habitaciones, int capacidadMinima)
        {
            if (habitaciones == null)
            {
                return null;
            }

            Habitacion encontrada = null;

            foreach (var hab in habitaciones)
            {
                if (hab.EstaDisponible() && hab.Capacidad >= capacidadMinima)
                {
                    encontrada = hab;
                    break;
                }
            }

            return encontrada;
        }

        // TODO: ValidarReserva - Recibe huesped, tipoHabitacion, noches, temporada y cantidadHuespedes, valida todo (incluye try/catch interno para la temporada) y retorna List<string> de errores
        public List<string> ValidarReserva(Huesped huesped, string tipoHabitacion, int noches, string temporada, int cantidadHuespedes)
        {
            var errores = new List<string>();

            if (huesped == null)
            {
                errores.Add("El huésped es requerido");
            }
            else if (string.IsNullOrWhiteSpace(huesped.Nombre))
            {
                errores.Add("El nombre del huésped no puede estar vacío");
            }

            if (noches < 1)
            {
                errores.Add("La reserva debe ser de al menos 1 noche");
            }
            else if (noches > 30)
            {
                errores.Add("La reserva no puede exceder 30 noches");
            }

            if (!ValidarTipoHabitacion(tipoHabitacion))
            {
                errores.Add("Tipo de habitación inválido: " + tipoHabitacion);
            }

            try
            {
                ObtenerDescuentoPorTemporada(temporada);
            }
            catch (ArgumentException)
            {
                errores.Add("Temporada inválida: " + temporada);
            }

            if (cantidadHuespedes > 4)
            {
                errores.Add("ADVERTENCIA: cantidad de huéspedes elevada, verificar capacidad");
            }

            return errores;
        }
        // TODO: CalcularTarifaConTemporada - Recibe tarifaBase (decimal) y temporada (string), switch Alta/Media/Baja con el % de descuento, retorna decimal
        public decimal CalcularTarifaConTemporada(decimal tarifaBase, string temporada)
        {
            decimal descuento;
            switch (temporada)
            {
                case "Alta": descuento = 0m; break;
                case "Media": descuento = 0.10m; break;
                case "Baja": descuento = 0.20m; break;
                default: throw new ArgumentException("Temporada desconocida: " + temporada);
            }
            return tarifaBase * (1 - descuento);
        }

        // TODO: CalcularNoches - Recibe checkIn y checkOut (DateTime), valida que checkOut > checkIn (lanza ArgumentException si no), retorna la cantidad de noches (int)
        public int CalcularNoches(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new ArgumentException("La fecha de salida debe ser posterior a la de entrada");
            }
            return (checkOut.Date - checkIn.Date).Days;
        }

        public List<Reserva> ObtenerTodas()
        {
            return _repo.ObtenerTodas();
        }

        // TODO: ObtenerProximas - Recibe dias (int), delega en el repositorio y retorna List<Reserva> confirmadas en ese rango
        public List<Reserva> ObtenerProximas(int dias)
        {
            return _repo.ObtenerProximas(dias);
        }

        // TODO: CrearReserva - Recibe una Reserva, valida fecha/habitación, lanza HabitacionOcupadaException si aplica, calcula noches y monto, la guarda en estado Pendiente
        public void CrearReserva(Reserva r)
        {
            if (r.FechaCheckIn.Date < DateTime.Today)
            {
                throw new ArgumentException("La fecha de entrada no puede ser en el pasado");
            }

            Habitacion hab = _habitacionRepo.BuscarPorNumero(r.HabitacionNumero);
            if (hab == null)
            {
                throw new ArgumentException("La habitación " + r.HabitacionNumero + " no existe");
            }
            if (hab.Estado == "Ocupada" || hab.Estado == "Reservada")
            {
                throw new HabitacionOcupadaException(hab.Numero,
                    "La habitación " + hab.Numero + " no está disponible para reservar");
            }

            r.TotalNoches = CalcularNoches(r.FechaCheckIn, r.FechaCheckOut);
            r.MontoEstimado = r.TotalNoches * CalcularTarifaConTemporada(hab.TarifaBase, r.Temporada);
            r.Estado = "Pendiente";

            _repo.Insertar(r);
        }

        // TODO: ConfirmarReserva - Recibe reservaId (int), cambia la reserva a Confirmada y la habitación a Reservada
        public void ConfirmarReserva(int reservaId)
        {
            Reserva r = _repo.BuscarPorId(reservaId);
            if (r == null)
            {
                throw new ArgumentException("No existe la reserva #" + reservaId);
            }

            _repo.CambiarEstado(reservaId, "Confirmada");
            _habitacionRepo.CambiarEstado(r.HabitacionNumero, "Reservada");
        }

        // TODO: CancelarReserva - Recibe reservaId (int), cambia la reserva a Cancelada y libera la habitación a Disponible si estaba Reservada
        public void CancelarReserva(int reservaId)
        {
            Reserva r = _repo.BuscarPorId(reservaId);
            if (r == null)
            {
                throw new ArgumentException("No existe la reserva #" + reservaId);
            }

            _repo.CambiarEstado(reservaId, "Cancelada");

            Habitacion hab = _habitacionRepo.BuscarPorNumero(r.HabitacionNumero);
            if (hab != null && hab.Estado == "Reservada")
            {
                _habitacionRepo.CambiarEstado(r.HabitacionNumero, "Disponible");
            }
        }
        public Reserva BuscarPorId(int id)
        {
            return _repo.BuscarPorId(id);
        }
    }
}
