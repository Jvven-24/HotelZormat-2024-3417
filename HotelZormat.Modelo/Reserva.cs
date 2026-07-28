// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelZormat.Modelo
{
    public class Reserva
    {
        public int Id { get; set; }
        public int HuespedId { get; set; }
        public int HabitacionNumero { get; set; }
        public System.DateTime FechaCheckIn { get; set; }
        public System.DateTime FechaCheckOut { get; set; }
        public string Temporada { get; set; }
        public string Estado { get; set; }
        public int TotalNoches { get; set; }
        public decimal MontoEstimado { get; set; }
        public System.DateTime FechaCreacion { get; set; }
    }
}
