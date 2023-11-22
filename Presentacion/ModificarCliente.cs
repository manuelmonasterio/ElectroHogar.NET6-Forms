using System;
using AccesoDatos;
using Modelo;
using Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class ModificarCliente
    {
        ClientesNegocio cn = new ClientesNegocio();
        public Clientes ModCliente()
        {
            Console.Write("Ingrese el ID del cliente a buscar para modificar sus datos (0 para salir): ");
            string clienteId = Console.ReadLine();

            if (int.Parse(clienteId) == 0)
            {
                Console.WriteLine("No ingreso un cliente valido");
            }
       
            Clientes cliente = ClientesNegocio.BuscarClienteId(clienteId);

            if (cliente != null)
            {
                Console.WriteLine("Datos del Cliente:");
                Console.WriteLine("Dirección: " + cliente.Direccion);
                Console.WriteLine("Teléfono: " + cliente.Telefono);
                Console.WriteLine("Email: " + cliente.Email);
                Console.WriteLine("Estado: " + cliente.Estado);

                Console.WriteLine("\n¿Qué dato deseas modificar? (direccion/telefono/email/estado/salir):");
                string opcion = Console.ReadLine().ToLower();

                bool flag;
                string nuevaDireccion;
                string nuevoTelefono;
                string nuevoEmail;

                if (opcion == "salir")
                {
                    Console.WriteLine("Selecciono salir");
                }
                else if (opcion == "Dirección")
                {
                    do
                    {
                        Console.Write("Nueva Dirección: ");
                        nuevaDireccion = Console.ReadLine();
                        cliente.Direccion = nuevaDireccion;
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(cliente.Direccion, "Direccion");

                    } while (flag == false);


                    try
                    {
                        cn.ModificarCliente(nuevaDireccion, cliente.Telefono, cliente.Email);
                        
                        Console.WriteLine("Cambio de Dirección exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (opcion == "Teléfono")
                {
                    do
                    {
                        Console.Write("Nuevo Teléfono: ");
                        nuevoTelefono = Console.ReadLine();
                        cliente.Telefono = nuevoTelefono;
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(cliente.Telefono, "Telefono");

                    } while (flag == false);

                    try
                    {
                        cn.ModificarCliente(cliente.Direccion, nuevoTelefono, cliente.Email);

                        Console.WriteLine("Cambio de Teléfono exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (opcion == "Email")
                {
                    do
                    {
                        Console.Write("Nuevo Email: ");
                        nuevoEmail = Console.ReadLine();
                        cliente.Email = nuevoEmail;
                        ValidacionesDatos validador = new ValidacionesDatos();
                        flag = validador.ValidarVacio(cliente.Email, "Email");

                    } while (flag == false);

                    try
                    {
                        cn.ModificarCliente(cliente.Direccion, cliente.Telefono, nuevoEmail);

                        Console.WriteLine("Cambio de Email exitoso");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }


                }
                else if (opcion == "Estado")
                {
                    string idCliente = Convert.ToString(cliente.IdCliente);
                    do
                    {
                        Console.Write("El estado actual del cliente es: " + cliente.Estado);

                        Console.Write("Desea modiciarlo, Ingrese S o N");

                        string confirmar = Console.ReadLine().ToUpper();

                        if (confirmar=="S" && cliente.Estado == "INACTIVO")
                        {
                            cliente.Estado = "ACTIVO";
                            flag = true;
                            cn.ReactivarCliente(idCliente);
                        }

                        else if(confirmar== "S" && cliente.Estado == "ACTIVO")
                        {
                            cliente.Estado = "INACTIVO";
                            flag = true;
                            cn.BorrarCliente(idCliente);
                        }

                        else if(confirmar == "N")
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

                Console.WriteLine("Datos actualizados del Cliente:");
                Console.WriteLine("Nombre: " + cliente.Nombre);
                Console.WriteLine("Dirección: " + cliente.Direccion);
                Console.WriteLine("Teléfono: " + cliente.Telefono);
                Console.WriteLine("Email: " + cliente.Email);
                Console.WriteLine("Estado: " + cliente.Estado);

            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }

            return cliente;
        }
    }
}
