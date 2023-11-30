﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ValidacionesUsuario
    {
        public static string ValidarNombreUsuario(string nombreUsuario, string nombre, string apellido, int min, int max)
        {
            if (nombreUsuario.Length >= min && nombreUsuario.Length <= max)
            {
                // Convertimos todo a minúsculas para hacer la comparación sin distinción entre mayúsculas y minúsculas
                string nombreUsuarioLower = nombreUsuario.ToLower();
                string nombreLower = nombre.ToLower();
                string apellidoLower = apellido.ToLower();

                // Verificamos si el nombre de usuario contiene el nombre o el apellido
                if (nombreUsuarioLower.Contains(nombreLower) || nombreUsuarioLower.Contains(apellidoLower))
                {
                    throw new Exception("El nombre de usuario no puede contener ni su nombre ni su apellido.");
                }
                else
                {
                    return null; // El nombre de usuario es válido
                }
            }
            else
            {
                throw new Exception("El nombre de usuario debe tener entre 8 y 15 caracteres.");
            }
        }

        /* public static void ValidarexpiraciónContraseña (DateTime  FechaContraseña)
         {
             DateTime Hoy = DateTime.Today; 
             DateTime fechaHoy = Convert.ToDateTime(Hoy);
             DateTime fechaContraseña = Convert.ToDateTime(FechaContraseña);
             TimeSpan difFechas = fechaHoy - fechaContraseña;
             int días = difFechas.Days;
             while (días > 30)
             {
                 Console.WriteLine("Su contraseña a expirado, por favor ingrese una nueva contraseña");
                 string NuevaContra = Console.ReadLine();
                 ValidarContraseña(NuevaContra);

             }

         }
         */
        public static string ValidarContraseña(string contraseña)
        {
            bool flag = false;
            bool contieneMayus = false;
            bool contieneNumero = false;

            //while (flag == false)
            //{
                foreach (char caracter in contraseña)
               {
                    if (char.IsUpper(caracter))
                    {
                        contieneMayus = true;
                        //si tiene una Mayuscula entonces OK esta y pasa a la siguiente
                    }
                    else if (char.IsDigit(caracter))
                    {
                        contieneNumero = true;
                        //si tiene un Número entonces OK
                    }

                }
                if (contieneMayus == true && contieneNumero == true)
                {
                    //si tiene por lo menos una mayus y un número pasa a validar la cantidad de caracteres
                    if (contraseña.Length < 8 || contraseña.Length > 15)
                    {
                        throw new Exception("\n- La contraseña debe tener entre 8 y 15 caracteres. \n- La contraseña debe tener como mínimo una letra mayuscula y un número. \n\nPor favor vuelva a introducir una contraseña válida");
                        //contraseña = Console.ReadLine();
                    }
                    else
                    {
                        //si esta todo ok entonces true
                        flag = true;
                    }
                }
                else
                {
                    //este else se dispara cuando la contra no tiene ni una mayus ni un número
                    throw new Exception("\n- La contraseña debe tener entre 8 y 15 caracteres. \n- La contraseña debe tener como mínimo una letra mayuscula y un número. \n\nPor favor vuelva a introducir una contraseña válida");
                    //contraseña = Console.ReadLine();
                }
                //dejé ambos mensajes en las validaciones porque me parece mejor para la experiencia del usuario que sepa desde el inicio todas las condiciones para cumplir con la contraseña
                //sin tener que pifear cada una para conocer todas las condiciones necesarias
                return null;
            //}
        }
    }
}
