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
    public static class ProveedoresDatos
    {
       
        public static List<Proveedores> ListarProveedores()
        {
            HttpResponseMessage response = WebHelper.Get("Proveedor/TraerProveedores");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Proveedores> listadoProveedores = JsonConvert.DeserializeObject<List<Proveedores>>(contentStream);
                return listadoProveedores;
            }

        }

        public static void CrearProveedor(ProveedorModelDatos proveedor)
        {
            var jsonRequest = JsonConvert.SerializeObject(proveedor);

            HttpResponseMessage response = WebHelper.Post("Proveedor/AgregarProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }

        public static string ModificarProveedor(string id, string nombre, string apellido, string email, string cuit)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("ID", id);
            map.Add("IdUsuario", "D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            map.Add("Nombre", nombre);
            map.Add("Apellido", apellido);
            map.Add("Email", email);
            map.Add("CUIT", cuit);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Proveedor/ModificarProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
        }

        public static void BorrarProveedor(string idProveedor, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idProveedor);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteConBody("Proveedor/BajaProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

        }

        public static string ReactivarProveedor(string idProveedor, string idUsuarioMaster)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("id", idProveedor);
            map.Add("idUsuario", idUsuarioMaster);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Proveedor/ReactivarProveedor", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
        }
    }

    
}
