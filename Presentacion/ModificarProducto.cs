using AccesoDatos;
using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class ModificarProducto
    {
        public Productos ModProducto()
        {
            Console.Write("Ingrese el ID del producto a buscar para modificar sus datos (0 para salir): ");
            string? productoId = Console.ReadLine();

            if (int.Parse(productoId) == 0)
            {
                Console.WriteLine("No ingreso un producto valido");
            }

            Productos producto = ProductosNegocio.BuscarProductoId(productoId);

            if (producto != null)
            {
                Console.WriteLine("Datos del Producto:");
                Console.WriteLine("Nombre: " + producto.Nombre);
                Console.WriteLine("Precio: " + producto.Precio);
                Console.WriteLine("Stock: " + producto.Stock);

                Console.WriteLine("\n¿Qué dato deseas modificar? (nombre/precio/stock/salir):");
                string opcion = Console.ReadLine().ToLower();

                bool flag;
                int stock = 0;
                double precio = 0;

                if (opcion == "salir")
                {
                    Console.WriteLine("Selecciono salir");
                }
                else if (opcion == "nombre")
                {
                    do
                    {
                        Console.Write("Nuevo Nombre: ");
                        producto.Nombre = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(producto.Nombre, "Nombre");

                    } while (flag == false);
                }
                else if (opcion == "precio")
                {
                    do
                    {
                        Console.Write("Nuevo precio: ");
                        string precioStr = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarDecimal(precioStr, ref precio, "Precio");

                        if (!flag)
                        {
                            Console.WriteLine("Precio no válido. Debe ser un número decimal válido.");
                        }

                    } while (!flag);

                }
                else if (opcion == "stock")
                {
                    do
                    {
                        Console.Write("Nuevo stock: ");
                        string stockStr = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarNumero(stockStr, ref stock, "Stock");

                        if (!flag)
                        {
                            Console.WriteLine("Stock no válido. Debe ser un número entero válido.");
                        }

                    } while (!flag);


                }
                else
                {
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                }

                Console.WriteLine("Datos actualizados del producto:");
                Console.WriteLine("Nombre: " + producto.Nombre);
                Console.WriteLine("Precio: " + precio);
                Console.WriteLine("Stock: " + stock);

            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }

            return producto;
        }
    }
}
     