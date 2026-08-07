// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Excepciones
{
    // TODO: HabitacionOcupadaException - Excepción propia del negocio con la propiedad NumeroHabitacion; se lanza desde HabitacionService/ReservaService/EstadiaService y se atrapa en la UI antes que el catch genérico de Exception
    public class HabitacionOcupadaException : Exception
    {
        public int NumeroHabitacion { get; }

        public HabitacionOcupadaException(int numero, string mensaje) : base(mensaje)
        {
            NumeroHabitacion = numero;
        }
    }
}