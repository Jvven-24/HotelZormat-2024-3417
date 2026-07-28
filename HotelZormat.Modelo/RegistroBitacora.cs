// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelZormat.Modelo
{
    public class RegistroBitacora
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Accion { get; set; }
        public string Detalle { get; set; }
        public System.DateTime FechaHora { get; set; }
    }
}
