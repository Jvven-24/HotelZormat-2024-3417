using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cedula : 402-1937000-0
namespace HotelZormat.Modelo
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int Piso { get; set; }
        public string Estado { get; set; }
        public int Capacidad { get; set; }
        public decimal TarifaBase { get; set; }

        public bool EstaDisponible()
        {
            return Estado == "Disponible";
        }
    }
}