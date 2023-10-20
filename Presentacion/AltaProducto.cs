using System;

public class AltaProducto
{
    private static ValidacionesDatos vd = new ValidacionesDatos();
    private static ProductosNegocio pn = new ProductosNegocio();
    public static List<Productos> productos = new List<Productos>();

    public void DarAltaProducto()
    {
        string inputNombre;
        string inputPrecio;
        string inputStock;
        bool flag;
        int stock = 0;
        double precio = 0;

        do
        {
            Console.Write("Ingrese el nombre del producto: ")
            inputNombre = Console.Readline();
            flag = vd.ValidarVacio(inputNombre, "Nombre");

        } while { flag == false}

        do
        {
            Console.Write("Ingrese el precio del producto: ")
            inputPrecio = Console.Readline();
            flag = vd.ValidarDecimal(inputPrecio, ref precio, "Precio");
            
        } while (flag == false);

        do
        {
            Console.Write("Ingrese la cantidad de stock del producto: ");
            inputStock = Console.Readline();
            flag = vd.ValidarNumero(inputStock, ref stock, "Stock");

        } while (flag == false);

        Productos producto = new Productos();
        producto.IdProducto = new Guid();
        producto.Nombre = inputNombre;
        producto.Precio = inputPrecio;
        producto.Stock = inputStock;
        producto.FechaAlta = Datetime.Now;

    }
}
