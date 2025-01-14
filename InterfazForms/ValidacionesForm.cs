﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Exceptions;
using Negocio;
using AccesoDatos;
using PRESENTACION;

namespace InterfazForms
{
    public static class ValidacionesForm
    {
        public static string ValidarVacio(string valor, string campo)
        {
            string error = "";

            if (string.IsNullOrEmpty(valor.Trim()))
                error = ($"El campo {campo} no puede estar vacio.\n");
            return error;
        }

        public static string ValidarFecha(string fecha)
        {
            if (!DateTime.TryParse(fecha, out DateTime date))
            {
                //Console.WriteLine("El dato no es una fecha valida en el campo: " + campo + ".");
                return "El dato no es una fecha valida";
            }
            else if (date <= new DateTime(1910, 01, 01) || date > DateTime.Today)
            {
                //Console.WriteLine("La fecha es inválida en el campo: " + campo + ".");
                return "La fecha es inválida";
            }
            return null;
        }

        public static bool ValidarNumero(string input, ref int valor, string campo)
        {
            bool flag = false;

            if (int.TryParse(input, out valor))
            {
                if (valor >= 0)
                {
                    return true; // La conversión fue exitosa y el número es positivo
                }
                else
                {
                    throw new ArgumentException($"Por favor, ingresar un valor positivo en el campo {campo}.");
                }
            }
            else
            {
                throw new ArgumentException($"Por favor, ingresar un valor numérico en el campo {campo}.");
            }

            return flag;
        }
        public static string ValidarCuit(string input, ref int cuit)
        {
            string flag = "";

            // Elimina guiones si están presentes
            input = input.Replace("-", "");

            if (input.Length != 11 || !long.TryParse(input, out long cuitLong))
            {
                //Console.WriteLine($"Por favor, ingresar un CUIT válido en el campo {campo}.");
                flag = "Por favor, ingresar un CUIT válido";
            }
            else
            {
                cuit = (int)cuitLong;
                flag = "";
            }
            return flag;
        }
        public static string ValidarID(string input)
        {
            ValidacionesDatos vd = new ValidacionesDatos();

            string error = "";
            if (!(input.Length == 36))
            {
                //los tipos de dato GUID tienen 36 caracteres
                //Console.WriteLine("El ID debe tener 36 caracteres.");
                error = "El ID debe tener 36 caracteres.";
            }
            else if (vd.FormatoGuid(input) == false)
            {
                //Console.WriteLine("El ID contiene dígitos especiales y solo debe contener números");
                error = "El ID contiene dígitos especiales y solo debe contener números";
            }
            else if (Guid.TryParse(input, out Guid idvalidado))
            {
                //Console.WriteLine("El ID contiene un formato válido.");
                //MessageBox.Show("El ID contiene un formato válido."); //comento porque no tiene sentido hacer una alerta para avisar que está bien el 
            }
            else
            {
                error = "El ID no contiene un formato válido";
                //Console.WriteLine("El ID no contiene un formato válido");
            }

            return error;
        }

    }
}
