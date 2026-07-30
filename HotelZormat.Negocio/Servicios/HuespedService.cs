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
    public class HuespedService
    {
        private readonly IHuespedRepository _repo;

        public HuespedService()
        {
            _repo = new HuespedRepository();
        }
        public List<string> ValidarHuesped(Huesped h)
        {
            var errores = new List<string>();

            if (string.IsNullOrWhiteSpace(h.Nombre))
            {
                errores.Add("El nombre no puede estar vacío");
            }

            if (string.IsNullOrWhiteSpace(h.Apellido))
            {
                errores.Add("El apellido no puede estar vacío");
            }

            if (h.TipoDocumento != "Cedula" && h.TipoDocumento != "Pasaporte")
            {
                errores.Add("El tipo de documento debe ser 'Cedula' o 'Pasaporte'");
            }
            else if (h.TipoDocumento == "Cedula")
            {
                if (string.IsNullOrWhiteSpace(h.NumeroDocumento) || h.NumeroDocumento.Length != 11)
                {
                    errores.Add("La cédula debe tener exactamente 11 dígitos");
                }
                else
                {
                    foreach (char c in h.NumeroDocumento)
                    {
                        if (!char.IsDigit(c))
                        {
                            errores.Add("La cédula solo puede contener dígitos");
                            break;
                        }
                    }
                }
            }
            else if (h.TipoDocumento == "Pasaporte")
            {
                if (string.IsNullOrWhiteSpace(h.NumeroDocumento))
                {
                    errores.Add("El número de pasaporte no puede estar vacío");
                }
            }

            if (string.IsNullOrWhiteSpace(h.Nacionalidad))
            {
                errores.Add("La nacionalidad no puede estar vacía");
            }

            return errores;
        }

        public void Guardar(Huesped h)
        {
            List<string> errores = ValidarHuesped(h);

            if (errores.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errores));
            }

            if (h.Id == 0)
            {
                _repo.Insertar(h);
            }
            else
            {
                _repo.Actualizar(h);
            }
        }
        public List<Huesped> ObtenerTodos()
        {
            return _repo.ObtenerTodos();
        }

        public Huesped BuscarPorId(int id)
        {
            return _repo.BuscarPorId(id);
        }

        public List<Huesped> Buscar(string texto)
        {
            return _repo.Buscar(texto);
        }

        public void Eliminar(int id)
        {
            _repo.Eliminar(id);
        }
    }
}
