// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Datos.Repositorio;
using HotelZormat.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class ReservaService
    {
        private readonly IReservaRepository _repo;

        public ReservaService(IReservaRepository repo)
        {
            _repo = repo;
        }

        public bool ValidarTipoHabitacion(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo)) return false;
            return tipo == "Sencilla" || tipo == "Doble" || tipo == "Suite";
        }

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
    }
}
