using Modelo;
using Negocio;
using PRESENTACION;
using System;

public class BajaProveedor
{

    private static ValidacionesDatos vd = new ValidacionesDatos();
    private static ProveedoresNegocio pn = new ProveedoresNegocio();
    public Proveedores DarBajaProveedor()
	{
		
        string idProveedor;
		bool flag;

        do
        {
            Console.Write("Ingresar el id del proveedor a dar de baja: ");
            idProveedor = Console.ReadLine();
            flag = vd.ValidarVacio(idProveedor, "ID Proveedor");
            flag = vd.ValidarID(idProveedor);

        } while (flag == false);

        Menu menu = new Menu();
        Proveedores proveedor = pn.BuscarProveedorId(idProveedor);
        proveedor.Estado = "INACTIVO";
        return proveedor;
    }
}

