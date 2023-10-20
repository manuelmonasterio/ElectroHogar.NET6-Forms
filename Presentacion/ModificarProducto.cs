using System;

public class ModificarProveedor
{
    public Productos ModProducto()
    {
        string idProducto;
        bool flag;
        do
        {
            Console.Write("Ingresar el id del producto a modificar: ");
            idProducto = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(idProducto, "ID Producto");
            flag = validador.ValidarID(idProducto);

        } while (flag == false);

        Menu menu = new Menu();
        Productos productos = menu.BuscarUsuarioID(idProductos);
        return productos;

        public Productos ModifProductos()
        {
            bool CtrlG = true;
            do
            {
                Console.WriteLine("Seleccione que tarea va a realizar");
                Console.WriteLine("1: Modificar Nombre");
                Console.WriteLine("2: Modificar Precio");
                Console.WriteLine("3: Modificar Stock");
                Console.Writeline("4: Salir");

                string opcG = Console.ReadLine().ToUpper();

                switch (opcG)
                {
                    case "1":


                        break;

                    case "2":


                        break;

                    case "3":

                        break;

                    case "4":
                      Console.WriteLine("Esta volviendo al menú principal");
                       CtrlG = false;

                        break;

                      default:
                        Console.WriteLine("Se ingreso una opcion invalida, intente nuevamente. Presione cualquier tecla para volver");
                        break;
                }
