using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class RegistrarVenta
    {
        private static ValidacionesDatos vd = new ValidacionesDatos();
        private static ProductosNegocio pn = new ProductosNegocio();
        public static List<Ventas> ventas = new List<Ventas>();


        public Ventas registrarVenta()
        {
            string idVenta = "";
            string idProducto;
            string idCliente;
            string idUsuario;
            int cantidad = 0;
            Productos producto = new Productos();

            bool flag;           

            do
            {
                Console.Write("Ingrese el Id del producto vendido: ");
                idProducto = Console.ReadLine();
                producto = ProductosNegocio.BuscarProductoId(idProducto);
                flag = vd.ValidarVacio(idProducto, "ID Producto");
                flag = vd.ValidarID(idProducto);

            } while (flag == false);

     
            do
            {
                Console.Write("Ingrese el Id del cliente: ");
                idCliente = Console.ReadLine();
                Clientes cliente = ClientesNegocio.BuscarClienteId(idCliente);
                flag = vd.ValidarVacio(idCliente, "ID Cliente");
                flag = vd.ValidarID(idCliente);

            } while (flag == false);

            Menu menu = new Menu();

            do
            {
                Console.Write("Ingrese el Id del usuario: ");
                idUsuario = Console.ReadLine();
                UsuarioModel usuario = menu.BuscarUsuarioID(idCliente);
                flag = vd.ValidarVacio(idUsuario, "ID Usuario");
                flag = vd.ValidarID(idUsuario);

            } while (flag == false);

         

            do
            {
                Console.Write("Ingrese la cantidad: ");
                cantidad = int.Parse(Console.ReadLine());
                
                if (cantidad > 0)
                {
                    flag = true;
                }

                else 
                {
                    flag = false;
                }

            } while (flag == false);


            //Ventas venta = new Ventas();

            //venta.IdVenta = idVenta;
            //venta.IdCliente = idCliente;
            //venta.IdProducto = idProducto;
            //venta.IdUsuario = idUsuario;
            //venta.Cantidad = cantidad;
            //venta.Estado = "";
            //venta.FechaAlta = DateTime.Now;
          

            var venta = new Ventas("", idProducto, idCliente, idUsuario, cantidad, "ACTIVO", DateTime.Now.Date);
            ventas.Add(venta);

            producto.Stock = producto.Stock - cantidad;
      
            return venta;
        }
    }
}
