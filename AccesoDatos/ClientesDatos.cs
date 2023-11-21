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

        public static string ModificarCliente(string direccion, string telefono, string email)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("IdUsuario", "D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            map.Add("Direccion", direccion);
            map.Add("Telefono", telefono);
            map.Add("Email", email);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Cliente/PatchCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
        }

        public static void BorrarCliente(string idCliente, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idCliente);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Cliente/BajaCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }

        public static string ReactivarCliente(string idCliente, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idCliente);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Cliente/ReactivarCliente", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
        }

        /*public static Clientes ObtenerCliente()
        {
            HttpResponseMessage response = WebHelper.Get("Cliente/GetCliente");

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
        }*/

    }

    
}