using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Exceptions
{
    // Excepción para el caso en el que el formato del ID es inválido.
    public class FormatoIDInvalidoException : Exception
    {
        public FormatoIDInvalidoException() : base("El formato del ID es inválido.") { }
    }
}
