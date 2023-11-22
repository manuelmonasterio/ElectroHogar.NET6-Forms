using AccesoDatos;
using Modelo;
using Modelo.Exceptions;
using Negocio;
using PRESENTACION;
using System;
using System.ComponentModel.DataAnnotations;


public class AltaProveedor
{
    private static ValidacionesDatos vd = new ValidacionesDatos();
    private static ProveedoresNegocio pn = new ProveedoresNegocio();
    public static List<Proveedores> proveedores = new List<Proveedores>();
    public static CategoriaProductos categoria = new CategoriaProductos();

    public void DarAltaProveedor()
    {
        string inputNombre;
        string inputApellido;
        string inputDireccion;
        string inputTelefono;
        string inputEmail;
        string inputCuit = "";
        int cuit = 0;
        bool flag;

        do
        {
            Console.Write("Ingresar el nombre: ");
            inputNombre = Console.ReadLine();
            flag = vd.ValidarVacio(inputNombre, "Nombre");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar el apellido: ");
            inputApellido = Console.ReadLine();
            flag = vd.ValidarVacio(inputApellido, "Apellido");
        } while (flag == false);


        do
        {
            Console.Write("Ingresar un mail: ");
            inputEmail = Console.ReadLine();
            flag = vd.ValidarVacio(inputEmail, "Email");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar su cuit: ");
            flag = vd.ValidarNumero(inputCuit, ref cuit, "CUIT");
        } while (flag == false);

        Proveedores proveedor = new Proveedores();
        proveedor.Id = new Guid(); 
        proveedor.Nombre = inputNombre;
        proveedor.Apellido = inputApellido;
        proveedor.Email = inputEmail;
        proveedor.Cuit = cuit;
        proveedor.FechaAlta = DateTime.Now;
        proveedor.Estado = "ACTIVO";

        ProveedorModelDatos proveedorDatos = new ProveedorModelDatos();
        proveedorDatos.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
        proveedorDatos.Nombre = inputNombre;
        proveedorDatos.Apellido = inputApellido;
        proveedorDatos.Email = inputEmail;
        proveedorDatos.CUIT = inputCuit;

        try
        {
            pn.CrearProveedor(proveedorDatos);
            Console.WriteLine("Alta exitosa");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        /* SE TIENE QUE IMPLEMENTAR DENTRO DEL WEB SERVICE --CW
         * try
        {
            met.CrearProveedor(proveedor);
            Console.WriteLine("Alta exitosa");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }*/

    }
    public void AsociarCategoriaAProveedor()
    {
        bool flag;
        string inputproveedorId;
        Proveedores proveedor;
        do
        {
            Console.Write("Seleccione el ID del proveedor al que desea asociar una categoría: ");
            inputproveedorId = Console.ReadLine();
            flag = vd.ValidarVacio(inputproveedorId, "ID Proveedor");
            flag = vd.ValidarID(inputproveedorId);

            proveedor = pn.BuscarProveedorId(inputproveedorId);

            if (proveedor == null)
            {
                Console.WriteLine("Proveedor no encontrado.");
                flag = false;
            }

        } while (flag == false);

        categoria.MostrarCategoriasProducto();
        string inputCategoriaId;
        int categoriaId = 0;

        do
        {
            Console.Write("Seleccione el ID de la categoría de producto a asociar: ");
            inputCategoriaId = Console.ReadLine();
            flag = vd.ValidarVacio(inputCategoriaId, "ID Categoria");
            flag = vd.ValidarNumero(inputCategoriaId, ref categoriaId, "ID Categoria");
            categoria = categoria.BuscarCategoriaId(categoriaId);
            if (categoria == null)
            {
                Console.WriteLine("Categoría de producto no encontrada.");
                flag = false;                 
            }
        } while (flag == false);

        proveedor.IdCategoria = categoriaId;
        Console.WriteLine("Categoría de producto asociada al proveedor exitosamente.");
    }
}
