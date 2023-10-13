using System;

public class BajaProveedor
{
	public Proveedores DarBajaProveedor()
	{
		string idProveedor;
		bool flag;

        do
        {
            Console.Write("Ingresar el id del proveedor a dar de baja: ");
            idProveedor = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(idProveedor, "ID Proveedor");
            flag = validador.ValidarID(idProveedor);

        } while (flag == false);

        Menu menu = new Menu();
        Proveedores proveedor = menu.BuscarUsuarioID(idProveedor);
        proveedor.estado = "INACTIVO";
        return proveedor;
    }
}
}
