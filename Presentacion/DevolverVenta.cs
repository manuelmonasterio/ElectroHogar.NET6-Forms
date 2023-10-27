using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class DevolverVenta
    {
        private static ValidacionesDatos vd = new ValidacionesDatos();
        private static ProductosNegocio pn = new ProductosNegocio();
        public static List<Ventas> ventas = new List<Ventas>();


        //public Ventas devolverVenta()
        //{
        //    string idVenta = "";
        //    string idProducto = "";
        //    string venta = "";

        //    int cantidad = 0;

        //    bool flag;

        //    //do
        //    //{
        //    //    Console.Write("Ingrese el Id de la venta a devolver: ");
        //    //    idVenta = Console.ReadLine();
        //    //    venta = ProductosNegocio.BuscarVentaId(idVenta);
        //    //    flag = vd.ValidarVacio(idVenta, "ID Venta");
        //    //    flag = vd.ValidarID(idVenta);

        //    //} while (flag == false);


        //    Productos producto = new Productos();

        //    //producto = ProductosNegocio.BuscarProductoId(idProducto);

        //    //producto.Stock = producto.Stock + cantidad;

        //    return venta;
        //}
    }
}
