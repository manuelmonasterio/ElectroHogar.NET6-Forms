using System;
using System.Collections.Generic;
using Modelo;
using Negocio;

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
                Console.WriteLine("No ingreso un proveedor válido");
                return null;
            }

            ProveedoresNegocio proveedoresNegocio = new ProveedoresNegocio();
            Proveedores proveedor = proveedoresNegocio.BuscarProveedorId(proveedorId);

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
                        Console.Write("Nuevo CUIT: ");
                        string nuevoCuit = Console.ReadLine();

                        // Verifica que el CUIT tenga 11 dígitos
                        if (nuevoCuit.Length == 11)
                        {
                            flag = true;

                            // Verifica que todos los caracteres del CUIT sean dígitos
                            foreach (char c in nuevoCuit)
                            {
                                if (!char.IsDigit(c))
                                {
                                    flag = false;
                                    Console.WriteLine("El CUIT debe contener solo dígitos.");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("El CUIT debe tener 11 dígitos.");
                            flag = false;
                        }

                        if (int.TryParse(nuevoCuit, out int cuitNumero))
                        {
                            proveedor.Cuit = cuitNumero;
                        }
                        else
                        {
                            Console.WriteLine("El nuevo CUIT no es válido. Debe ser un número.");
                        }

                    } while (!flag);
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
                        Console.Write("Desea modificarlo? Ingrese 'S' para activar o 'N' para desactivar: ");
                        string confirmar = Console.ReadLine().ToUpper();

                        if (confirmar == "S")
                        {
                            if (proveedor.Estado == "INACTIVO")
                            {
                                proveedor.Estado = "ACTIVO";
                            }
                            else if (proveedor.Estado == "ACTIVO")
                            {
                                proveedor.Estado = "INACTIVO";
                            }
                            flag = true;
                        }
                        else if (confirmar == "N")
                        {
                            Console.WriteLine("No se modificará el estado del proveedor");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("No ingresó un valor correcto.");
                            flag = false;
                        }
                    } while (flag == false);
                }
                else
                {
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                }

                Console.WriteLine("Datos actualizados del proveedor:");
                Console.WriteLine("Nombre: " + proveedor.Nombre);
                Console.WriteLine("Apellido: " + proveedor.Apellido);
                Console.WriteLine("Cuit: " + proveedor.Cuit);
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
