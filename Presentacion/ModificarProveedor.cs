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
    public class ModificarProveedor
    {
        public Proveedores ModProveedor()
        {
            Console.Write("Ingrese el ID del proveedor a buscar para modificar sus datos (0 para salir): ");
            string? proveedorId = Console.ReadLine();

            if (int.Parse(proveedorId) == 0)
            {
                Console.WriteLine("No ingreso un proveedor valido");
            }

            Proveedores proveedor = ProveedoresNegocio.BuscarProveedorId(proveedorId);

            if (proveedor != null)
            {
                Console.WriteLine("Datos del Proveedor:");
                Console.WriteLine("Nombre: " + proveedor.Nombre);
                Console.WriteLine("Apellido: " + proveedor.Apellido);
                Console.WriteLine("Cuit: " + proveedor.Cuit);
                Console.WriteLine("Email: " + proveedor.Email);
                Console.WriteLine("Estado: " + proveedor.Estado);

                Console.WriteLine("\n¿Qué dato deseas modificar? (nombre/apellido/cuit/email/estado/salir):");
                string opcion = Console.ReadLine().ToLower();

                bool flag;
                int cuit = 0;

                if (opcion == "salir")
                {
                    Console.WriteLine("Selecciono salir");
                }
                else if (opcion == "nombre")
                {
                    do
                    {
                        Console.Write("Nuevo Nombre: ");
                        proveedor.Nombre = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(proveedor.Nombre, "Nombre");

                    } while (flag == false);
                }
                else if (opcion == "apellido")
                {
                    do
                    {
                        Console.Write("Nuevo apellido: ");
                        proveedor.Apellido = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(proveedor.Apellido, "Apellido");

                    } while (flag == false);

                }
                else if (opcion == "cuit")
                {
                    do
                    {
                        Console.Write("Nuevo cuit: ");
                        proveedor.Cuit = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarNumero(proveedor.Cuit, ref cuit,"Cuit");

                    } while (flag == false);

                }
                else if (opcion == "email")
                {
                    do
                    {
                        Console.Write("Nuevo Email: ");
                        proveedor.Email = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(proveedor.Email, "Email");

                    } while (flag == false);

                }
                else if (opcion == "estado")
                {
                    do
                    {
                        Console.Write("El estado actual del proveedor es: " + proveedor.Estado);

                        Console.Write("Desea modiciarlo, Ingrese S o N");

                        string confirmar = Console.ReadLine().ToUpper();

                        if (confirmar == "S" && proveedor.Estado == "INACTIVO")
                        {
                            proveedor.Estado = "ACTIVO";
                            flag = true;
                        }

                        else if (confirmar == "S" && cliente.Estado == "ACTIVO")
                        {
                            proveedor.Estado = "INACTIVO";
                            flag = true;
                        }

                        else if (confirmar == "N")
                        {
                            Console.WriteLine("No se modificará el estado del proveedor");
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

                Console.WriteLine("Datos actualizados del proveedor:");
                Console.WriteLine("Nombre: " + proveedor.Nombre);
                Console.WriteLine("Apellido: " + proveedor.Apellido);
                Console.WriteLine("Cuit: " + cuit);
                Console.WriteLine("Email: " + proveedor.Email);
                Console.WriteLine("Estado: " + proveedor.Estado);

            }
            else
            {
                Console.WriteLine("Proveedor no encontrado.");
            }

            return proveedor;
        }
    }

}
         
              