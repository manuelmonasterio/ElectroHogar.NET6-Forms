using System;

public class AltaProducto
{
    private static ValidacionesDatos vd = new ValidacionesDatos();

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
    }
}
