using System;
using System.Collections.Generic;
using Modelo;
using Negocio;

namespace PRESENTACION
{
    public class ModificarProveedor
    {
        ProveedoresNegocio pn = new ProveedoresNegocio();
        Proveedores proveedor1 = new Proveedores();
        public Proveedores GetProveedor()
        {
            Proveedores proveedor = new Proveedores();
            return proveedor;
        }

        public Proveedores ModProveedor(Proveedores proveedor)
        {
            Console.Write("Ingrese el ID del proveedor a buscar para modificar sus datos (0 para salir): ");
            string proveedorId = Console.ReadLine();

            if (int.Parse(proveedorId) == 0)
            {
                Console.WriteLine("No ingreso un proveedor válido");
                return null;
            }

            Proveedores proveedor1 = pn.BuscarProveedorId(proveedorId);

            if (proveedor != null)
            {
                Console.WriteLine("Datos del Proveedor:");
                Console.WriteLine("Nombre: " + proveedor1.Nombre);
                Console.WriteLine("Apellido: " + proveedor1.Apellido);
                Console.WriteLine("Cuit: " + proveedor1.Cuit);
                Console.WriteLine("Email: " + proveedor1.Email);
                Console.WriteLine("Estado: " + proveedor1.Estado);

                Console.WriteLine("\n¿Qué dato deseas modificar? (nombre/apellido/email/cuit/estado/salir):");
                string opcion = Console.ReadLine().ToLower();

                bool flag;
                int cuit = 0;
                string nuevoNombre;
                string nuevoApellido;
                string nuevoEmail;
                string nuevoCuit;

                if (opcion == "salir")
                {
                    Console.WriteLine("Selecciono salir");
                }
                else if (opcion == "nombre")
                {
                    do
                    {
                        Console.Write("Nuevo Nombre: ");
                        nuevoNombre = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(nuevoNombre, "Nombre");
                    } while (flag == false);
                    try
                    {
                        pn.ModificarProveedor(proveedorId, nuevoNombre, proveedor1.Apellido, proveedor1.Email, Convert.ToString(proveedor1.Cuit));

                        Console.WriteLine("Cambio de Nombre exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (opcion == "apellido")
                {
                    do
                    {
                        Console.Write("Nuevo apellido: ");
                        nuevoApellido = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(nuevoApellido, "Apellido");
                    } while (flag == false);
                    try
                    {
                        pn.ModificarProveedor(proveedorId, proveedor1.Nombre, nuevoApellido, proveedor1.Email, Convert.ToString(proveedor1.Cuit));

                        Console.WriteLine("Cambio de apellido exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (opcion == "cuit")
                {
                    do
                    {
                        Console.Write("Nuevo CUIT: ");
                        nuevoCuit = Console.ReadLine();

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

                    } while (!flag);
                    try
                    {
                        pn.ModificarProveedor(proveedorId, proveedor1.Nombre, proveedor1.Apellido, proveedor1.Email, nuevoCuit);

                        Console.WriteLine("Cambio de CUIT exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (opcion == "email")
                {
                    do
                    {
                        Console.Write("Nuevo Email: ");
                        nuevoEmail = Console.ReadLine();
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(proveedor1.Email, "Email");
                    } while (flag == false);
                    try
                    {
                        pn.ModificarProveedor(proveedorId, proveedor1.Nombre, proveedor1.Apellido, nuevoEmail, Convert.ToString(proveedor1.Cuit));

                        Console.WriteLine("Cambio de Email exitoso");
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
                        Console.Write("El estado actual del proveedor es: " + proveedor1.Estado);
                        Console.Write("Desea modificarlo? Ingrese 'S' para activar o 'N' para desactivar: ");
                        string confirmar = Console.ReadLine().ToUpper();

                        if (confirmar == "S")
                        {
                            if (proveedor1.Estado == "INACTIVO")
                            {
                                proveedor1.Estado = "ACTIVO";
                                flag = true;
                                pn.ReactivarProveedor(proveedorId);
                            }
                            else if (proveedor1.Estado == "ACTIVO")
                            {
                                proveedor1.Estado = "INACTIVO";
                                flag = true;
                                pn.BorrarProveedor(proveedorId);
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
                Console.WriteLine("Nombre: " + proveedor1.Nombre);
                Console.WriteLine("Apellido: " + proveedor1.Apellido);
                Console.WriteLine("Cuit: " + proveedor1.Cuit);
                Console.WriteLine("Email: " + proveedor1.Email);
                Console.WriteLine("Estado: " + proveedor1.Estado);
            }
            else
            {
                Console.WriteLine("Proveedor no encontrado.");
            }

            return proveedor;
        }
    }
}
