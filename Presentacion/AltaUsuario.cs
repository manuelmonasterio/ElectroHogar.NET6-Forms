using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos; 

namespace PRESENTACION
{
    public class AltaUsuario
    {
        private static MetodosUsuarios met = new MetodosUsuarios();
        public void DarAltaUsuario(int perfil)
        {
            bool flag = false;
            string inputNombre;
            string inputApellido;
            string inputDireccion;
            string inputTelefono;
            string inputEmail;
            string inputFechaNacimiento;
            DateTime fechaNacimiento = DateTime.Now;
            string inputPerfil;
            string inputDni;
            int dni = 0;
            string NombreUsuario;
            string inputContra;
            int minCaracteresUsuario = 8;
            int maxCaracteresUsuario = 15;

            do
            {
                Console.Write("Ingresar el nombre: ");
                inputNombre = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputNombre, "Nombre");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar el apellido: ");
                inputApellido = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputApellido, "Apellido");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar la dirección: ");
                inputDireccion = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputDireccion, "Dirección");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar un teléfono: ");
                inputTelefono = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputTelefono, "Telefono");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar un mail: ");
                inputEmail = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputEmail, "Email");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar tu fecha de nacimiento: ");
                inputFechaNacimiento = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarFecha(inputFechaNacimiento, ref fechaNacimiento, "Fecha de Nacimiento");
            } while (flag == false);

            Console.WriteLine("ADVERTENCIA");
            Console.WriteLine("El Nombre de Usuario debe tener entre 8 a 15 caracteres y no debe tener su nombre ni apellido dentro del mismo.");
            do
            {
                // Console.WriteLine("El Nombre de Usuario debe tener entre 8 a 15 caracteres y no debe tener su nombre o apellido dentro del mismo.");
                Console.Write("Ingresar Nombre de Usuario: ");
                NombreUsuario = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(NombreUsuario, "Nombre");

                /* ValidacionesUsuario validadorUsuario = new ValidacionesUsuario();
                try
                {
                    flag = validadorUsuario.ValidarNombreUsuario(NombreUsuario,inputNombre, inputApellido, minCaracteresUsuario, maxCaracteresUsuario);
                } catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                } */

            } while (flag == false);

            do
            {
                Console.Write("Ingresar su DNI: ");
                inputDni = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarNumero(inputDni, ref dni, "DNI");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar su Contraseña: ");
                inputContra = Console.ReadLine();
                try
                {
                    ValidacionesUsuario.ValidarContraseña(inputContra);
                    //validacion contraseña nuevo usuario
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (flag == false);
            MetodosUsuarios usu = new MetodosUsuarios();
            UsuarioModelDatos usuario = new UsuarioModelDatos();
            usuario.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            usuario.Host = perfil;
            usuario.Nombre = inputNombre;
            usuario.Apellido = inputApellido;
            usuario.Dni = dni;
            usuario.Direccion = inputDireccion;
            usuario.Telefono = inputTelefono;
            usuario.Email = inputEmail;
            usuario.FechaNacimiento = fechaNacimiento;
            usuario.NombreUsuario = NombreUsuario;
            usuario.Contraseña = inputContra;
            try
            {
                met.CrearUsuario(usuario);
                Console.WriteLine("Alta exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (perfil == 1)
            {
                UsuarioModel usuario1 = new Administrador();
                usuario1.id = new Guid();
                usuario1.host = perfil;
                usuario1.nombre = inputNombre;
                usuario1.apellido = inputApellido;
                usuario1.dni = dni;
                usuario1.direccion = inputDireccion;
                usuario1.telefono = inputTelefono;
                usuario1.email = inputEmail;
                usuario1.fechaAlta = DateTime.Now;
                usuario1.fechaNacimiento = fechaNacimiento;
                //usuario.fechaBaja = new DateTime(2999, 12, 31);
                usuario1.usuario = NombreUsuario;
                usuario1.contraseña = inputContra;
                usuario1.fechacontraseña = DateTime.Today;
                met.CrearUsuarioLista(usuario1);

            }
            else if(perfil == 2)
            {
                UsuarioModel usuario1 = new Supervisores();
                usuario1.id = new Guid();
                usuario1.host = perfil;
                usuario1.nombre = inputNombre;
                usuario1.apellido = inputApellido;
                usuario1.dni = dni;
                usuario1.direccion = inputDireccion;
                usuario1.telefono = inputTelefono;
                usuario1.email = inputEmail;
                usuario1.fechaAlta = DateTime.Now;
                usuario1.fechaNacimiento = fechaNacimiento;
                //usuario1.fechaBaja = new DateTime(2999, 12, 31);
                usuario1.usuario = NombreUsuario;
                usuario1.contraseña = inputContra;
                usuario1.fechacontraseña = DateTime.Today;
                met.CrearUsuarioLista(usuario1);
            }
            else
            {
                UsuarioModel usuario1 = new Vendedor();
                usuario1.id =new Guid();
                usuario1.host = perfil;
                usuario1.nombre = inputNombre;
                usuario1.apellido = inputApellido;
                usuario1.dni = dni;
                usuario1.direccion = inputDireccion;
                usuario1.telefono = inputTelefono;
                usuario1.email = inputEmail;
                usuario1.fechaAlta = DateTime.Now;
                usuario1.fechaNacimiento = fechaNacimiento;
                //usuario1.fechaBaja = new DateTime(2999, 12, 31);
                usuario1.usuario = NombreUsuario;
                usuario1.contraseña = inputContra;
                usuario1.fechacontraseña = DateTime.Today;
                met.CrearUsuarioLista(usuario1);
            }
        }
    }
}
