using AccesoDatos.Utilidades;
using Modelo;
using Modelo.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net.Http;

namespace AccesoDatos
{
    public static class ClientesDatos
    {
       
        public static List<Clientes> ListarClientes()
        {
            HttpResponseMessage response = WebHelper.Get("Proveedor/TraerProveedores");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Clientes> listadoProveedores = JsonConvert.DeserializeObject<List<Clientes>>(contentStream);
                return listadoProveedores;
            }
        }

        
        public static void CrearCliente(ClienteModelDatos cliente)
        {
            var jsonRequest = JsonConvert.SerializeObject(cliente);

            HttpResponseMessage response = WebHelper.Post("Cliente/AgregarCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }
    }

    
}