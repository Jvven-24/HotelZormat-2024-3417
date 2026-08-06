// Cedula : 402-1937000-0
using HotelZormat.Datos.Repositorio;
using HotelZormat.Modelo;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HotelZormat.Negocio.Servicios
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IBitacoraRepository _bitacoraRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
            _bitacoraRepository = new BitacoraRepository();
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

            if (GenerarHash(contrasena) == usuario.Contrasena)
            {
                SesionActual.UsuarioLogueado = usuario;
                _bitacoraRepository.Registrar(usuario.Id, "Login", "Inicio de sesión exitoso");
                return usuario;
            }

            return null;
        }

        public Usuario BuscarPorId(int id)
        {
            return _usuarioRepository.BuscarPorId(id);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _usuarioRepository.ObtenerTodos();
        }

        public void Guardar(Usuario usuario, string contrasenaPlano)
        {
            if (string.IsNullOrWhiteSpace(usuario.NombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(usuario.NombreCompleto))
            {
                throw new ArgumentException("El nombre completo es obligatorio");
            }
            if (string.IsNullOrWhiteSpace(usuario.Rol))
            {
                throw new ArgumentException("Selecciona un rol");
            }

            Usuario existente = _usuarioRepository.BuscarPorNombreUsuario(usuario.NombreUsuario);
            if (existente != null && existente.Id != usuario.Id)
            {
                throw new ArgumentException("Ya existe un usuario activo con ese nombre de usuario");
            }

            if (usuario.Id == 0)
            {
                if (string.IsNullOrWhiteSpace(contrasenaPlano))
                {
                    throw new ArgumentException("La contraseña es obligatoria para un usuario nuevo");
                }
                if (contrasenaPlano.Length < 6)
                {
                    throw new ArgumentException("La contraseña debe tener al menos 6 caracteres");
                }

                usuario.Contrasena = GenerarHash(contrasenaPlano);
                _usuarioRepository.Insertar(usuario);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(contrasenaPlano))
                {
                    if (contrasenaPlano.Length < 6)
                    {
                        throw new ArgumentException("La contraseña debe tener al menos 6 caracteres");
                    }
                    usuario.Contrasena = GenerarHash(contrasenaPlano);
                }
                else
                {
                    usuario.Contrasena = null;
                }

                _usuarioRepository.Actualizar(usuario);
            }
        }

        public void Eliminar(int id)
        {
            if (SesionActual.UsuarioLogueado != null && SesionActual.UsuarioLogueado.Id == id)
            {
                throw new ArgumentException("No puedes desactivar tu propio usuario mientras tienes la sesión abierta");
            }

            _usuarioRepository.Desactivar(id);
        }

        private string GenerarHash(string textoPlano)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
