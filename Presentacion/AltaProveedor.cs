using System;

public class AltaProveedor
{
	public void DarAltaProveedor()
	{
        string inputNombre;
        string inputApellido;
        string inputDireccion;
        string inputTelefono;
        string inputEmail;
        string inputCuit;

        do
        {
            Console.Write("Ingresar el nombre: ");
            inputNombre = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputNombre, "Nombre");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar el apellido: ");
            inputApellido = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputApellido, "Apellido");
        } while (flag == false);


        do
        {
            Console.Write("Ingresar un mail: ");
            inputEmail = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(inputEmail, "Email");
        } while (flag == false);

        do
        {
            Console.Write("Ingresar su cuit: ");
            inputCuit = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarNumero(inputCuit, ref cuit, "CUIT");
        } while (flag == false);

        public void AsociarCategoriaAProveedor()
        {
            bool flag; 

            Console.Write("Seleccione el ID del proveedor al que desea asociar una categoría: ");
            int proveedorId = Console.ReadLine();
            flag = validador.ValidarVacio(proveedorId, "ID Proveedor");
            flag = validador.ValidarID(proveedorId);

            Proveedores proveedor = proveedores.Find(p => p.Id == proveedorId);

            if (proveedor == null)
            {
                Console.WriteLine("Proveedor no encontrado.");
                return;
            }

            MostrarCategoriasProducto();

            Console.Write("Seleccione el ID de la categoría de producto a asociar: ");
            int categoriaId = Console.ReadLine();
            flag = validador.ValidarVacio(categoriaId, "ID Categoria");
            flag = validador.ValidarID(categoriaId);
            AgregarCatProducto categorias = categoria.Find(c => c.Id == categoriaId);

            if (categoria == null)
            {
                Console.WriteLine("Categoría de producto no encontrada.");
                return;
            }

            proveedor.AgregarCatProducto.Add(categoria);
            Console.WriteLine("Categoría de producto asociada al proveedor exitosamente.");
        }
    }
}
