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
    public class ProductosNegocio
    {
        public List<Productos> ListarProductos()
        {
            return ProductosDatos.ListarProductos();
        }

        public Productos BuscarProductoId(string productoId)
        {
            bool flag = false;

            //flag = vd.ValidarID(productoId);
            List<Productos> productos = ProductosDatos.ListarProductos();

            if (flag == true)
            {
                productoId = Guid.NewGuid().ToString();
            }
            Guid idGuid;
            if (Guid.TryParse(productoId, out idGuid))
            {
                Productos productoEncontrado = productos.Find(p => p.IdProducto == idGuid);
                if (productoEncontrado != null)
                {
                    return productoEncontrado;
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
