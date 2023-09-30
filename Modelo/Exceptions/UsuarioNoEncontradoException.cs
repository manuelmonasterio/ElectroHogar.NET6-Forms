using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Exceptions
{
    // Excepción para el caso en el que no se encuentra un usuario.
    public class UsuarioNoEncontradoException : Exception
    {
        public UsuarioNoEncontradoException() : base("El usuario no se encontró.") { }
    }

}
