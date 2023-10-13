using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Exceptions
{
    public class ProveedorNoEncontradoException : Exception
    {
        // Excepción para el caso en el que no se encuentra un usuario.
            public ProveedorNoEncontradoException() : base("El proveedor no se encontró.") { }
        
    }
}
