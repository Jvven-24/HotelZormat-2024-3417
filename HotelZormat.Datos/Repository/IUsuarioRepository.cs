// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Modelo;

namespace HotelZormat.Datos.Repositorio
{
    public interface IUsuarioRepository
    {
        Usuario BuscarPorNombreUsuario(string nombreUsuario);
    }
}
