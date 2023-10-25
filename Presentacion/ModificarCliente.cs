﻿using System;
using AccesoDatos;
using Modelo;
using Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION

public class ModificarCliente
{
	public Clientes ModCliente()
	{
        
        Console.Write("Ingrese el ID del cliente a buscar para modificar sus datos (0 para salir): ");
        string clienteId = (Console.ReadLine());

        if (clienteId == 0)
        {
            break;
        }

        Clientes cliente = BuscarClienteId(clienteId);

        if (cliente != null)
        {

            Console.WriteLine("Datos del Cliente:");
            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Dirección: " + cliente.Direccion);
            Console.WriteLine("Teléfono: " + cliente.Telefono);
            Console.WriteLine("Email: " + cliente.Email);
            Console.WriteLine("Estado: " + cliente.Estado);

            Console.WriteLine("\n¿Qué dato deseas modificar? (nombre/direccion/telefono/email/estado/salir):");
            string opcion = Console.ReadLine().ToLower();

            bool flag;

            if (opcion == "salir")
            {
                break;
            }
            else if (opcion == "nombre")
            {
                do
                {
                    Console.Write("Nuevo Nombre: ");
                    cliente.Nombre = Console.ReadLine();
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(cliente.Nombre, "Nombre");

                } while (flag == false);
            }
            else if (opcion == "direccion")
            {
                do
                {
                    Console.Write("Nueva Dirección: ");
                    cliente.Direccion = Console.ReadLine();
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(cliente.Direccion, "Direccion");

                } while (flag == false);

            }
            else if (opcion == "telefono")
            {
                do
                {
                    Console.Write("Nuevo Teléfono: ");
                    cliente.Telefono = Console.ReadLine();
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(cliente.Telefono, "Telefono");

                } while (flag == false);

            }
            else if (opcion == "email")
            {
                do
                {
                    Console.Write("Nuevo Email: ");
                    cliente.Email = Console.ReadLine();
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(cliente.Email, "Email");

                } while (flag == false);

            }
            else if (opcion == "estado")
            {
                do
                {
                    Console.Write("Nuevo Estado: ");
                    cliente.Estado = Console.ReadLine();
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(cliente.Estado, "Estado");

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
        
    }
}