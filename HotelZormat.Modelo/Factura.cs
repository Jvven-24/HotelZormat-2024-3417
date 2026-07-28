// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelZormat.Modelo
{
    public class Factura
    {
        public int Id { get; set; }
        public string NCF { get; set; }
        public int EstadiaId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Itbis { get; set; }
        public decimal Propina { get; set; }
        public decimal Total { get; set; }
        public System.DateTime FechaEmision { get; set; }
    }
}