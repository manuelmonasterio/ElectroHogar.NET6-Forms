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
        ProductosNegocio cn = new ProductosNegocio(); 
        public Productos ModProducto()
        {
            Console.Write("Ingrese el ID del producto a buscar para modificar sus datos (0 para salir): ");
            string productoId = Console.ReadLine();

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

                Console.WriteLine("\n¿Qué dato deseas modificar? (precio/stock/salir):");
                string opcion = Console.ReadLine().ToLower();

                bool flag;
                int stock = 0;
                double precio = 0;
                string precioStr;
                string stockStr;
                if (opcion == "salir")
                {
                    Console.WriteLine("Selecciono salir");
                }
                
                else if (opcion == "precio")
                {
                    do
                    {
                        Console.Write("Nuevo precio: ");
                        precioStr = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarDecimal(precioStr, ref precio, "Precio");

                        if (!flag)
                        {
                            Console.WriteLine("Precio no válido. Debe ser un número decimal válido.");
                        }

                    } while (!flag);
                    try
                    {
                        cn.ModificarProducto(productoId, precioStr, producto.Stock);

                        Console.WriteLine("Cambio de precio exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (opcion == "stock")
                {
                    do
                    {
                        Console.Write("Nuevo stock: ");
                        stockStr = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarNumero(stockStr, ref stock, "Stock");

                        if (!flag)
                        {
                            Console.WriteLine("Stock no válido. Debe ser un número entero válido.");
                        }

                    } while (!flag);
                    try
                    {
                        cn.ModificarCliente(productoId, producto.Precio, stockStr);

                        Console.WriteLine("Cambio de stock exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

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
     