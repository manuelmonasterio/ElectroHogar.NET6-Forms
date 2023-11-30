using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Exceptions;

namespace PRESENTACION
{
    public class Menu
    {
        public static List<UsuarioModel> usuarios = new List<UsuarioModel>();
        private static ValidacionesDatos valDatos = new ValidacionesDatos();
        private static AltaProveedor altaProv = new AltaProveedor();
        private static BajaProveedor bajaProv = new BajaProveedor();
        private static ModificarProveedor modProv = new ModificarProveedor();
        private static AltaProducto altaProd = new AltaProducto();
        private static BajaProducto bajaProd = new BajaProducto();
        private static ModificarProducto modProd = new ModificarProducto();
        private static RegistrarVenta registrarVenta = new RegistrarVenta();
        private static AltaCliente altaClien = new AltaCliente();
        private static ModificarCliente modClien = new ModificarCliente();


        public static void MenuAdm()
        {
            MetodosUsuarios usu = new MetodosUsuarios();
            UsuarioModel usuario9 = new Administrador();
            UsuarioModel usuario10 = new Supervisores();
            UsuarioModel usuario11 = new Vendedor();
            usuario9 = new Administrador(new Guid(), "Carolina", "Wehner", "Uzal 1234", "1138205055", "carowehner2001@gmail.com", DateTime.Now, new DateTime(2001, 05, 23), new DateTime(2099, 01, 01), "Admini05CW", 1, 43245128, "Cai20233!", "Activo");
            usuarios.Add(usuario9);
            usuario9 = new Supervisores(new Guid(), "Evelyn", "Zivano", "Farrel 1234", "1153376046", "evelynzivano@gmail.com", DateTime.Now, new DateTime(1994, 07, 12), new DateTime(2099, 01, 01), "Admini05EZ", 2, 38491201, "CAI20232", "Activo");
            usuarios.Add(usuario9);
            usuario9 = new Vendedor(new Guid(), "Patricio", "Gerenni", "Cochabamba 1234", "1167845556", "patriciogerenni@gmail.com", DateTime.Now, new DateTime(1999, 04, 20), new DateTime(2099, 01, 01), "Admini05PG", 3, 41823861, "CAI20232", "Activo");
            usuarios.Add(usuario9);

            CategoriaProductos ct = new CategoriaProductos();
            ct.AgregarCategorias();

            bool CtrlAdm = true;
            do
            {
                Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                Console.WriteLine("1: Gestión de usuarios");
                Console.WriteLine("2: Proveedores");
                Console.WriteLine("3: Productos");
                Console.WriteLine("4: Reportes");
                Console.WriteLine("5: Salir");
                string opcAdm = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (opcAdm)
                {
                    case "1":
                        bool CtrlG = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Alta usuario");
                            Console.WriteLine("2: Modificación usuario");
                            Console.WriteLine("3: Baja usuario");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcG = Console.ReadLine().ToUpper();
                            UsuarioModel usuario;
                            Console.Clear();
                            switch (opcG)
                            {
                                case "1":
                                    string inputPerfil;
                                    int perfil = 0;
                                    bool flag;
                                    AltaUsuario alta = new AltaUsuario();
                                    do
                                    {
                                        Console.WriteLine("1- Perfil Administrador");
                                        Console.WriteLine("2- Perfil Supervisor");
                                        Console.WriteLine("3- Perfil Vendedor");
                                        Console.Write("Ingrese el perfil correspondiente para el nuevo usuario:  ");
                                        inputPerfil = Console.ReadLine();
                                        ValidacionesDatos validador = new ValidacionesDatos();
                                        flag = validador.ValidarNumero(inputPerfil, ref perfil, "Perfil");
                                        flag = validador.ValidarTipoNum(ref perfil, "Perfil");

                                    } while (flag == false);

                                    if (perfil == 1)
                                    {
                                        usuario = new Administrador();
                                        alta.DarAltaUsuario(perfil);
                                        usuarios.Add(usuario);
                                    }
                                    else if (perfil == 2)
                                    {
                                        usuario = new Supervisores();
                                        alta.DarAltaUsuario(perfil);
                                        usuarios.Add(usuario);
                                    }
                                    else if (perfil == 3)
                                    {
                                        usuario = new Vendedor();
                                        alta.DarAltaUsuario(perfil);
                                        usuarios.Add(usuario);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No se pudo dar de alta");
                                    }
                                    break;

                                case "2":
                                    //Ingresar modificación usuario                              
                                    string nombre;
                                    flag = false;
                                    ModificarUsuario mod = new ModificarUsuario();
                                    do
                                    {
                                        Console.Write("Ingrese el nombre del usuario que quieres modificar: ");
                                        nombre = Console.ReadLine();
                                        ValidacionesDatos validador = new ValidacionesDatos();
                                        flag = validador.ValidarVacio(nombre, "Nombre del usuario");
                                    } while (flag == false);
                                    Menu menu = new Menu();
                                    UsuarioModel usuario2 = menu.BuscarUsuarioxNombre(nombre);
                                    if(usuario2.host == 1)
                                    {
                                        usuario2 = new Administrador();
                                        usuario2 = mod.ModUsuario(usuario2.host);
                                    }
                                    else if(usuario2.host == 2)
                                    {
                                        usuario2 = new Supervisores();
                                        usuario2 = mod.ModUsuario(usuario2.host);
                                    }
                                    else if(usuario2.host == 3)
                                    {
                                        usuario2 = new Vendedor();
                                        usuario2 = mod.ModUsuario(usuario2.host);
                                    }
                                    else
                                    {
                                        break;
                                    }

                                    break;

                                case "3":
                                    //Ingresar baja usuario
                                    string idB;
                                    flag = false;
                                    do
                                    {
                                        Console.Write("Ingrese el id del usuario que quieres dar de baja: ");
                                        idB = Console.ReadLine();
                                        ValidacionesDatos validador = new ValidacionesDatos();
                                        flag = validador.ValidarVacio(idB, "Id Usuario");
                                        flag = validador.ValidarID(idB);

                                    } while (flag == false);
                                    Menu menu1 = new Menu();
                                    UsuarioModel usuario3 = menu1.BuscarUsuarioID(idB);
                                    if (usuario3.host == 1)
                                    {
                                        BajaUsuario baja = new BajaUsuario();
                                        UsuarioModel usuario4 = new Administrador();
                                        usuario4 = baja.DarBajaUsuario();
                                        usuario4.estado = "INACTIVO";
                                    }
                                    else if (usuario3.host == 2)
                                    {
                                        BajaUsuario baja = new BajaUsuario();
                                        UsuarioModel usuario4 = new Supervisores();
                                        usuario4 = baja.DarBajaUsuario();
                                        usuario4.estado = "INACTIVO";
                                    }
                                    else
                                    {
                                        BajaUsuario baja = new BajaUsuario();
                                        UsuarioModel usuario4 = new Vendedor();
                                        usuario4 = baja.DarBajaUsuario();
                                        usuario4.estado = "INACTIVO";
                                    }
                                    
                                    //pasar a INACTIVO
                                    break;

                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlG = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente. Presione cualquier tecla para volver");
                                    break;
                            }
                        } while (CtrlG);
                        break;

                    case "2":
                        bool CtrlProv = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Alta usuario proveedor");
                            Console.WriteLine("2: Modificación usuario proveedor");
                            Console.WriteLine("3: Baja usuario proveedor");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcProv = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcProv)
                            {
                                case "1":
                                    //Ingresar alta proveedor
                                    altaProv.DarAltaProveedor();
                                    break;

                                case "2":
                                    //Ingresar modificación proveedor
                                    modProv.ModProveedor(                                    //Ingresar modificación proveedor
                                    modProv.GetProveedor());
                                    break;

                                case "3":
                                    //Ingresar baja proveedor
                                    bajaProv.DarBajaProveedor();
                                    break;

                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProv = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlProv);
                        break;

                    case "3":
                        bool CtrlProd = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Alta producto");
                            Console.WriteLine("2: Modificación producto");
                            Console.WriteLine("3: Baja producto");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcProd = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcProd)
                            {
                                case "1":
                                    //Ingresar alta producto
                                    altaProd.DarAltaProducto();
                                    break;

                                case "2":
                                    //Ingresar modificación producto
                                    modProd.ModProducto();
                                    break;

                                case "3":
                                    //Ingresar baja producto
                                    bajaProd.DarBajaProducto();
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProd = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlProd);
                        break;

                    case "4":
                        bool CtrlRep = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Reporte de stock crítico");
                            Console.WriteLine("2: Reporte de ventas por vendedor");
                            Console.WriteLine("3: Reporte de productos más vendido por categoría");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcRep = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcRep)
                            {
                                case "1":
                                    //llamar procedimiento reporte de stock critico
                                    break;

                                case "2":
                                    //llamar procedimiento reporte de ventas
                                    break;

                                case "3":
                                    //llamar procedimiento reporte de productos mas vendidos
                                    break;

                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProd = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlRep);
                        break;

                    case "5":
                        Console.WriteLine("Gracias por utilizar el sistema");
                        // Console.ReadKey(); - MM comenté para arreglar bug de no mostrar menu
                        CtrlAdm = false;
                        break;
                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                        //Console.ReadKey(); - MM comenté para arreglar bug de no mostrar menu
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (CtrlAdm);
        }
        public static void MenuSupervisor()
        {
            bool CtrlSup = true;
            do
            {
                Console.WriteLine("Supervisor, seleccione que tarea va a realizar");
                Console.WriteLine("1: Productos");
                Console.WriteLine("2: Devoluciones");
                Console.WriteLine("3: Reportes");
                Console.WriteLine("4: Salir");
                string opcAdm = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (opcAdm)
                {
                    case "1":
                        bool CtrlProd = true;
                        do
                        {
                            Console.WriteLine("Supervisor, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Alta producto");
                            Console.WriteLine("2: Modificación producto");
                            Console.WriteLine("3: Baja producto");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcProd = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcProd)
                            {
                                case "1":
                                    //Ingresar alta producto
                                    altaProd.DarAltaProducto();
                                    break;
                                case "2":
                                    //Ingresar modificación producto
                                    modProd.ModProducto();
                                    break;
                                case "3":
                                    //Ingresar baja producto
                                    bajaProd.DarBajaProducto();
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProd = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlProd);
                        break;

                    case "2":
                        //Llamar metodo devolucion
                        break;

                    case "3":
                        bool CtrlRep = true;
                        do
                        {
                            Console.WriteLine("Administrador, seleccione que tarea va a realizar");
                            Console.WriteLine("1: Reporte de stock crítico");
                            Console.WriteLine("2: Reporte de ventas por vendedor");
                            Console.WriteLine("3: Reporte de productos más vendido por categoría");
                            Console.WriteLine("4: Volver al menú principal");
                            string opcRep = Console.ReadLine().ToUpper();
                            Console.Clear();
                            switch (opcRep)
                            {
                                case "1":
                                    //llamar procedimiento reporte de stock critico
                                    break;
                                case "2":
                                    //llamar procedimiento reporte de ventas
                                    break;
                                case "3":
                                    //llamar procedimiento reporte de productos mas vendidos
                                    break;
                                case "4":
                                    Console.WriteLine("Esta volviendo al menú principal");
                                    CtrlProd = false;
                                    break;
                                default:
                                    Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                                    break;
                            }
                        } while (CtrlRep);
                        break;

                    case "4":
                        Console.WriteLine("Gracias por utilizar el sistema");
                        Console.ReadKey();
                        CtrlSup = false;
                        break;

                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (CtrlSup);
        }
        public static void MenuVendedor()
        {
            bool CtrlVend = true;
            do
            {
                Console.WriteLine("Vendedor, seleccione que tarea va a realizar");
                Console.WriteLine("1: Venta");
                Console.WriteLine("2: Agregar cliente ");
                Console.WriteLine("3: Modificar cliente ");
                Console.WriteLine("4: Reporte de ventas por vendedor ");
                Console.WriteLine("5: Salir");
                string opcVend = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (opcVend)
                {
                    case "1":
                        //Llamar metodo venta
                        registrarVenta.registrarVenta();
                        break;
                    case "2":
                        //Llamar metodo agregar cliente
                        altaClien.DarAltaCliente();
                        break;
                    case "3":
                        //Llamar metodo modificar cliente
                        modClien.ModCliente();
                        break;
                    case "4":
                        //Llamar reporte
                        break;
                    case "5":
                        Console.WriteLine("Gracias por utilizar el sistema");
                        Console.ReadKey();
                        CtrlVend = false;
                        break;
                    default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (CtrlVend);
        }

        public UsuarioModel BuscarUsuarioID(string idUsuario)
        {
            bool flag = false;

            flag = valDatos.ValidarID(idUsuario);

            if (flag == true)
            {
                idUsuario = Guid.NewGuid().ToString();
            }
            Guid idGuid;
            if (Guid.TryParse(idUsuario, out idGuid))
            {
                UsuarioModel usuarioEncontrado = Menu.usuarios.Find(u => u.id == idGuid);
                if (usuarioEncontrado != null)
                {
                    return usuarioEncontrado;
                }
                else
                {
                    throw new UsuarioNoEncontradoException(); // Lanzar una excepción personalizada si el usuario no se encuentra.
                }
            }
            else
            {
                throw new FormatoIDInvalidoException(); // Lanzar una excepción personalizada si el formato del ID es inválido.
            }

            //return Menu.usuarios.Find(u => u.id == idUsuario);
        }

        public UsuarioModel BuscarUsuarioxNombre(string NombreUsuario)
        {

            return Menu.usuarios.Find(u => u.usuario == NombreUsuario);
        }

    }
}