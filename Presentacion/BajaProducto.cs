using System;

public class BajaProducto
{
    private static ValidacionesDatos vd = new ValidacionesDatos();
	private static ProductosNegocio pn = new ProductosNegocio();

    public Productos DarBajaProducto()
	{
		string idProducto;
		bool flag;

		do
		{

			Console.Write("Ingrese el Id del producto a dar de baja: ");
			idProducto = Console.Readline();
			flag = vd.ValidarVacio(idProducto, "ID Producto");
			flag = vd.ValidarID(idProducto);

		} while (flag == false);

        Menu menu = new Menu();
		Productos producto = pn.BuscarProducto(idProducto);
		return producto;
    }
}
