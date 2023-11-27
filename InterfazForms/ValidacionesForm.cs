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
    }
}
