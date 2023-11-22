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
    public static class ProductosDatos
    {

        public static List<Productos> ListarProductos()
        {
            HttpResponseMessage response = WebHelper.Get("Producto/TraerProductos");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }
            else
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Productos> listadoProductos = JsonConvert.DeserializeObject<List<Productos>>(contentStream);
                return listadoProductos;
            }
        }
        public static void CrearProducto(ProductoModelDatos producto)
        {
            var jsonRequest = JsonConvert.SerializeObject(producto);

            HttpResponseMessage response = WebHelper.Post("Producto/AgregarProducto", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }
        public static string ModificarProducto(string id, double precio, int stock)
        {
            Dictionary<String, String> map = new Dictionary<String, String>();
            map.Add("ID", id);
            map.Add("IdUsuario", "D347CE99-DB8D-4542-AA97-FC9F3CCE6969");
            map.Add("Precio", precio);
            map.Add("Stock", stock);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Producto/ModificarProducto", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStream());

            String respuesta = reader.ReadToEnd();

            return respuesta;
        }
    }
    public static void BorrarProducto(string idProducto, string idUsuarioMaster)
    {
        Dictionary<String, String> map = new Dictionary<String, String>();
        map.Add("id", idProducto);
        map.Add("idUsuario", idUsuarioMaster);

        var jsonRequest = JsonConvert.SerializeObject(map);

        HttpResponseMessage response = WebHelper.DeleteConBody("Producto/BajaProducto", jsonRequest);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Verifique los datos ingresados");
        }

    }

    public static string ReactivarProducto(string idProducto, string idUsuarioMaster)
    {
        Dictionary<String, String> map = new Dictionary<String, String>();
        map.Add("id", idProducto);
        map.Add("idUsuario", idUsuarioMaster);

        var jsonRequest = JsonConvert.SerializeObject(map);

        HttpResponseMessage response = WebHelper.Patch("Producto/ReactivarProducto", jsonRequest);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Verifique los datos ingresados");
        }

        var reader = new StreamReader(response.Content.ReadAsStream());

        String respuesta = reader.ReadToEnd();

        return respuesta;
    }


}