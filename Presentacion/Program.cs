using Modelo;
using System;
using System.Collections.Generic;
using PRESENTACION;
using System.Net;
using Negocio;

namespace Presentacion
{
    internal class Program
    {
        public static List<UsuarioModel> usuarios = new List<UsuarioModel>();
        private static LoginInicio log = new LoginInicio();
        private static MetodosUsuarios met = new MetodosUsuarios();
        //UsuarioModel usuario = new UsuarioModel();

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a Electro Hogar SA.");
            //met.CrearUsuariosAdmin();
            UsuarioModel usuario = new Administrador();
            usuario = new Administrador(new Guid(), "Carolina", "Wehner", "Uzal 1234", "1138205055", "carowehner2001@gmail.com", DateTime.Now, new DateTime(2001, 05, 23), new DateTime(2099, 01, 01), "Admini05CW", 1, 43245128, "Cai20233!", "Activo");
            usuarios.Add(usuario);
            usuario = new Administrador(new Guid(), "Evelyn", "Zivano", "Farrel 1234", "1153376046", "evelynzivano@gmail.com", DateTime.Now, new DateTime(1994, 07, 12), new DateTime(2099, 01, 01), "Admini05EZ", 1, 38491201, "CAI20232", "Activo");
            usuarios.Add(usuario);
            usuario = new Administrador(new Guid(), "Patricio", "Gerenni", "Cochabamba 1234", "1167845556", "patriciogerenni@gmail.com", DateTime.Now, new DateTime(1999, 04, 20), new DateTime(2099, 01, 01), "Admini05PG", 1, 41823861, "CAI20232", "Activo");
            usuarios.Add(usuario);

            //declaro variable para definir el perfil para el menú
            int PerfilMenu = 0;

            string inputNombreUsuario = log.IngresarUsuario();
            //usuario = usuarios.Find(u => u.usuario == inputNombreUsuario);
            if (usuarios.Find(u => u.usuario == inputNombreUsuario) == null)
            {
                Console.WriteLine("Usuario no existe, se debera dar de alta con un Administrador.");

            }
            else
            {
                MetodosUsuarios perfil = new MetodosUsuarios();;
                PerfilMenu = usuario.host;
            }
            string inputContraseña = LoginInicio.IngresarContraseña();
            LoginInicio.BuscarContraseña(usuario, inputContraseña, usuario.fechacontraseña);

            //Agrego menu según perfil del usuario
            if (PerfilMenu == 1)
            {
                Menu.MenuAdm();
            }
            if (PerfilMenu == 2)
            {
                Menu.MenuSupervisor();
            }
            else
            {
                Menu.MenuVendedor();
            }

        }

        public UsuarioModel BuscarUsuario(string inputUsuario)
        {
            return usuarios.Find(u => u.usuario == inputUsuario);
        }

        public void ListarUsuarios()
        {
            bool flag = false;
            ValidacionesDatos validador = new ValidacionesDatos();
            Console.WriteLine("ingrese el id del usuario: ");
            string id = Console.ReadLine();
            flag = validador.ValidarVacio(id, "Id Usuario");
            flag = validador.ValidarID(id);
            BuscarUsuario(id);

            if (flag == true)
            {
                if (usuarios.Count > 0)
                {
                    foreach (UsuarioModel UM in usuarios)
                    {
                        Console.WriteLine("El usuario con Id " + id + " es: " + BuscarUsuario(id));
                    }
                }
                else
                {
                    Console.WriteLine("No existen usuarios con el id seleccionado");
                }

            }
        }

    }
}
