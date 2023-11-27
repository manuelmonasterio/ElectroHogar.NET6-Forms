using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
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

    }
}
