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
    public class ModificarUsuario
    {
        private static MetodosUsuarios met = new MetodosUsuarios();
        private static int indiceContraseña = 0;
        private static String Contraseña = "Password_" + indiceContraseña;
        public UsuarioModel ModiUsuario()
        {
            string idUsuario;
            bool flag;
            do
            {
                Console.Write("Ingresar el id del usuario a modificar: ");
                idUsuario = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(idUsuario, "ID Usuario");
                flag = validador.ValidarID(idUsuario);

            } while (flag == false);

            Menu menu = new Menu();
            UsuarioModel usuario = menu.BuscarUsuarioID(idUsuario);
            return usuario;
        }

        public UsuarioModel ModUsuario(int host)
        {
            bool CtrlG = true;
            do
            {
                Console.WriteLine("Seleccione que tarea va a realizar");
                Console.WriteLine("1: Modificar Contraseña");
                Console.WriteLine("2: Modificar Estado");
                Console.WriteLine("3: Baja usuario");
                Console.WriteLine("4: Salir");

                string opcG = Console.ReadLine().ToUpper();

                switch (opcG)
                {
                    case "1":

                        CambiarContraseña();
                        break;

                    case "2":
                        cambiarEstado();
                        break;

                    case "3":
                        BorrarUsuario();
                        break;

                    case "4":
                        Console.WriteLine("Esta volviendo al menú principal");
                        CtrlG = false;
                        break;

                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente. Presione cualquier tecla para volver");
                        break;
                }
                if (host == 1)
                {
                    UsuarioModel usuario = new Administrador();
                    return usuario;
                }
                else if (host == 2)
                {
                    UsuarioModel usuario = new Supervisores();
                    return usuario;
                }
                else
                {
                    UsuarioModel usuario = new Vendedor();
                    return usuario;
                }
            } while (CtrlG);

        }

            public void CambiarContraseña()
            {
                string nombreUsuario ;
                string contraseña = Contraseña;
                string contraseñaNueva;
                bool flag;
                do
                {
                    Console.Write("Ingresar el nombre del usuario a modificar: ");
                    nombreUsuario = Console.ReadLine();
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(nombreUsuario, "Nombre Usuario");

                } while (flag == false);

                do
                {
                    Console.Write("Ingresar la nueva contraseña: ");
                    contraseñaNueva = Console.ReadLine();
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(contraseñaNueva, "Contraseña");

                } while (flag == false);

                try
                {
                    met.CambiarContraseña(nombreUsuario, contraseña, contraseñaNueva);
                    contraseña = contraseñaNueva;
                    indiceContraseña = indiceContraseña + 1;
                    Console.WriteLine("Cambio de clave exitoso");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public void cambiarEstado()
            {
               //No esta en la Web Service 
            }

            public void BorrarUsuario()
            {
                String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                string idUsuario;
                bool flag;
                do
                {
                    Console.Write("Ingresar el id del usuario a modificar: ");
                    idUsuario = Console.ReadLine();
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(idUsuario, "ID Usuario");
                    flag = validador.ValidarID(idUsuario);

                } while (flag == false);
                UsuarioDatos.BorrarUsuario(idUsuario, IdUsuarioMaster);
            }



    }
}

