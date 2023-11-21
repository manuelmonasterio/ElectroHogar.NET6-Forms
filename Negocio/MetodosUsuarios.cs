using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;
using AccesoDatos.Utilidades;
using System.ComponentModel;

namespace Negocio
{
    public class MetodosUsuarios
    {
        List<UsuarioModel> usuarios = new List<UsuarioModel>();

        public void CrearUsuario(UsuarioModelDatos usuario)
        {
            //Este es el idUsuario Master
            usuario.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            UsuarioDatos.CrearUsuario(usuario);
        }

        /*public void CrearUsuariosAdmin()
        {
            UsuarioModelDatos usuario = new UsuarioModelDatos();

            usuario.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            usuario.Host = 1;
            usuario.Nombre = "Carolina";
            usuario.Apellido = "Wehner";
            usuario.Dni = 32531831;
            usuario.Direccion = "Calle false 123";
            usuario.Telefono = "44443333";
            usuario.Email = "test@test.com";
            usuario.FechaNacimiento = DateTime.Now.AddYears(-22);
            usuario.NombreUsuario = "Admini05CW";
            usuario.Contraseña = "CAI20232";
            CrearUsuario(usuario);

            usuario.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            usuario.Host = 1;
            usuario.Nombre = "Evelyn";
            usuario.Apellido = "Zivano";
            usuario.Dni = 38491201;
            usuario.Direccion = "Calle false 123";
            usuario.Telefono = "44443333";
            usuario.Email = "test@test.com";
            usuario.FechaNacimiento = DateTime.Now.AddYears(-30);
            usuario.NombreUsuario = "Adminis05EZ";
            usuario.Contraseña = "CAI20232";
            CrearUsuario(usuario);

            usuario.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            usuario.Host = 1;
            usuario.Nombre = "Patricio";
            usuario.Apellido = "Gerenni";
            usuario.Dni = 41823861;
            usuario.Direccion = "Calle false 123";
            usuario.Telefono = "44443333";
            usuario.Email = "test@test.com";
            usuario.FechaNacimiento = DateTime.Now.AddYears(-30);
            usuario.NombreUsuario = "Adminis05PG";
            usuario.Contraseña = "CAI20232";
            CrearUsuario(usuario);

            UsuarioModel usuario1 = new Administrador();
            usuario1 = new Administrador(new Guid(), "Carolina", "Wehner", "Uzal 1234", "1138205055", "carowehner2001@gmail.com", DateTime.Now, new DateTime(2001, 05, 23), new DateTime(2099, 01, 01), "AdministradoraCW", 1, 43245128, "CAI20232", "Activo");
            usuarios.Add(usuario1);
            usuario1 = new Administrador(new Guid(), "Evelyn", "Zivano", "Farrel 1234", "1153376046", "evelynzivano@gmail.com", DateTime.Now, new DateTime(1994, 07, 12), new DateTime(2099, 01, 01), "AdministradoraEZ", 1, 38491201, "CAI20232", "Activo");
            usuarios.Add(usuario1);
            usuario1 = new Administrador(new Guid(), "Patricio", "Gerenni", "Cochabamba 1234", "1167845556", "patriciogerenni@gmail.com", DateTime.Now, new DateTime(1999, 04, 20), new DateTime(2099, 01, 01), "AdministradorPG", 1, 41823861, "CAI20232", "Activo");
            usuarios.Add(usuario1);
        }*/

        public void CrearUsuarioLista(UsuarioModel usuario)
        {
            usuarios.Add(usuario);
        }



        public string BuscarPerfil(UsuarioModel usuarioEncontrado, int inputhost)
        {
            string msj = "";
            if (usuarioEncontrado.host == 1)
            {
                msj = $"Usuario encontrado: {usuarioEncontrado.nombre}" + "\n" + "Con Perfil de Administrador";
            }
            else if (usuarioEncontrado.host == 2)
            {
                msj = $"Usuario encontrado: {usuarioEncontrado.nombre}" + "\n" + "Con Perfil de Supervisor";
            }
            else if (usuarioEncontrado.host == 3)
            {
                msj = $"Usuario encontrado: {usuarioEncontrado.nombre}" + "\n" + "Con Perfil de Vendedor";
            }

            return msj;
        }

        public String Login(Login login)
        {
            String idUsuario = UsuarioDatos.Login(login);
            return idUsuario;
        }

        public void CambiarContraseña(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            String idUsuario = UsuarioDatos.CambiarContraseña(nombreUsuario, contraseña, contraseñaNueva);
        }

        public void BorrarUsuario(string idUsuario)
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            UsuarioDatos.BorrarUsuario(idUsuario, IdUsuarioMaster);
        }
    }
}
