// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Excepciones
{
    public class HabitacionOcupadaException : Exception
    {
        public int NumeroHabitacion { get; }

        public HabitacionOcupadaException(int numero, string mensaje) : base(mensaje)
        {
            NumeroHabitacion = numero;
        }
    }
}