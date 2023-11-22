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
        ProductosNegocio pn = new ProductosNegocio(); 
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

                Console.WriteLine("\n¿Qué dato deseas modificar? (precio/stock/estado/salir):");
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
                        pn.ModificarProducto(productoId, precio, producto.Stock);

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
                        pn.ModificarProducto(productoId, producto.Precio, stock);

                        Console.WriteLine("Cambio de stock exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (opcion == "estado")
                {
                    do
                    {
                        Console.Write("El estado actual del producto es: " + producto.Estado);

                        Console.Write("Desea modiciarlo, Ingrese S o N");

                        string confirmar = Console.ReadLine().ToUpper();

                        if (confirmar == "S" && producto.Estado == "INACTIVO")
                        {
                            producto.Estado = "ACTIVO";
                            flag = true;
                            pn.ReactivarProducto(productoId);
                        }

                        else if (confirmar == "S" && producto.Estado == "ACTIVO")
                        {
                            producto.Estado = "INACTIVO";
                            flag = true;
                            pn.BorrarProducto(productoId);
                        }

                        else if (confirmar == "N")
                        {
                            Console.WriteLine("No se modificará el estado de cliente");
                            flag = true;
                        }

                        else
                        {
                            Console.WriteLine("No ingreso un valor correcto");
                            flag = false;
                        }

                    } while (flag == false);
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
     