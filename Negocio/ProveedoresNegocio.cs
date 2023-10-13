using AccesoDatos;
using Modelo;
using Modelo.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProveedoresNegocio
    {
        public List<Proveedores> ListarProveedores()
        {
            return ProveedoresDatos.ListarProveedores();
        }

        public Proveedores BuscarProveedorId(string proveedorId)
        {
            bool flag = false;

            //flag = vd.ValidarID(proveedorId);
            List<Proveedores> proveedores = ProveedoresDatos.ListarProveedores();

            if (flag == true)
            {
                proveedorId = Guid.NewGuid().ToString();
            }
            Guid idGuid;
            if (Guid.TryParse(proveedorId, out idGuid))
            {
                Proveedores proveedorEncontrado = proveedores.Find(p => p.Id == idGuid);
                if (proveedorEncontrado != null)
                {
                    return proveedorEncontrado;
                }
                else
                {
                    throw new UsuarioNoEncontradoException(); // Lanzar una excepción personalizada si el usuario no se encuentra.
                }
            }
            else
            {
                throw new FormatoIDInvalidoException(); // Lanzar una excepción personalizada si el formato del ID es inválido.
            }

        }
    }
}
