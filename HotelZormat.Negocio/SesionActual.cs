// Cedula : 402-1937000-0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelZormat.Modelo;

namespace HotelZormat.Negocio
{
    public static class SesionActual
    {
        public static Usuario UsuarioLogueado { get; set; }

        public static bool EsAdministrador
        {
            get { return UsuarioLogueado != null && UsuarioLogueado.Rol == "Administrador"; }
        }
    }
}