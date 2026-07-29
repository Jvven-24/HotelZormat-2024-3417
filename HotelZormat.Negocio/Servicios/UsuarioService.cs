// Cedula : 402-1937000-0
using HotelZormat.Datos.Repositorio;
using HotelZormat.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Servicios
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IBitacoraRepository _bitacoraRepository;         

        public UsuarioService(IUsuarioRepository usuarioRepository, IBitacoraRepository bitacoraRepository)
        {
            _usuarioRepository = usuarioRepository;
            _bitacoraRepository = bitacoraRepository;
        }

        public Usuario IniciarSesion(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {                                                              
                return null;
            }

            Usuario usuario = _usuarioRepository.BuscarPorNombreUsuario(nombreUsuario); 

            if (usuario == null)
            {                                                           
                return null;
            }

            if (contrasena == usuario.Contrasena)
            {                                                              
                SesionActual.UsuarioLogueado = usuario;
              

                _bitacoraRepository.Registrar(usuario.Id, "Login", "Inicio de sesión exitoso");  

                return usuario;                                        
            }

            return null;                                                   
        }
    }
}

