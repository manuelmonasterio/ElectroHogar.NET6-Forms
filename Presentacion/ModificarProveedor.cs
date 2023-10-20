using AccesoDatos;
using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace PRESENTACION
{
    public class ModificarProveedor
    {
        public Proveedores ModProveedor()
        {
            string idProveedor;
            bool flag;
            do
            {
                Console.Write("Ingresar el id del proveedor a modificar: ");
                idProveedor = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(idProveedor, "ID Proveedor");
                flag = validador.ValidarID(idProveedor);

            } while (flag == false);

            Menu menu = new Menu();
            Proveedores proveedor = menu.BuscarUsuarioID(idProveedor);
            return proveedor;

            public Proveedores ModifProveedor()
            {
                bool CtrlG = true;
                do
                {
                    Console.WriteLine("Seleccione que tarea va a realizar");
                    Console.WriteLine("1: Modificar Nombre");
                    Console.WriteLine("2: Modificar Apellido");
                    Console.WriteLine("3: Modificar Estado");
                    Console.WriteLine("4: Modificar Email");
                    Console.WriteLine("5: Modificar CUIT");
                    Console.WriteLine("6: Modificar Categoría Asociada");
                    Console.WriteLine("7: Salir");

                    string opcG = Console.ReadLine().ToUpper();

                    switch (opcG)
                    {
                        case "1":


                            break;

                        case "2":


                            break;

                        case "3":

                            break;

                        case "4":


                            break;

                        case "5":

                            break;

                        case "6":

                            break;

                        case "7":
                            Console.WriteLine("Esta volviendo al menú principal");
                            CtrlG = false;
                            break;

                        default:
                            Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente. Presione cualquier tecla para volver");
                            break;
                    }
                }
            }
        }
    }
}
*/