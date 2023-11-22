using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class BajaProducto
    {
        private static ValidacionesDatos vd = new ValidacionesDatos();
        private static ProductosNegocio pn = new ProductosNegocio();

        public Productos DarBajaProducto()
        {
            string idProducto;
            bool flag;

            do
            {

                Console.Write("Ingrese el Id del producto a dar de baja: ");
                idProducto = Console.ReadLine();
                flag = vd.ValidarVacio(idProducto, "ID Producto");
                flag = vd.ValidarID(idProducto);

            } while (flag == false);

            Menu menu = new Menu();
            Productos producto = ProductosNegocio.BuscarProductoId(idProducto);
            producto.Estado = "INACTIVO";
            pn.BorrarProducto(idProducto);
            return producto;
        }
    }
}
