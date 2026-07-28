using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cedula : 402-1937000-0
namespace HotelZormat.Modelo
{
    public class Estadia
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public System.DateTime FechaCheckInReal { get; set; }
        public System.DateTime? FechaCheckOutReal { get; set; }
        public string Estado { get; set; }
    }
}