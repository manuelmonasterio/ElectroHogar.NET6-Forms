using Modelo;
using Modelo.Exceptions;
using Negocio;
using PRESENTACION;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.InteropServices.ObjectiveC;

public class AltaProducto
{
    private static ValidacionesDatos vd = new ValidacionesDatos();
    private static ProductosNegocio pn = new ProductosNegocio();
    public static List<Productos> productos = new List<Productos>();
    // public static UsuarioModel usuario = new Supervisores();
    // public static UsuarioModel usuario = new Administradores();

    public void DarAltaProducto()
    {
        string inputNombre;
        string inputPrecio;
        string inputStock;
        bool flag;
        bool flag2;
        int stock = 0;
        double precio = 0;
        string inputCat;
        int inputCategoria;
        Guid idCat = Guid.Empty;

        do
        {
            Console.Write("Ingrese el nombre del producto: ");
            inputNombre = Console.ReadLine();
            flag = vd.ValidarVacio(inputNombre, "Nombre");

        } while (flag == false);

        do
        {
            flag = false;
            Console.Write("Ingrese el precio del producto: ");
            inputPrecio = Console.ReadLine();
            flag = vd.ValidarDecimal(inputPrecio, ref precio, "Precio");

        } while (flag == false);

        do
        {
            flag = false;
            Console.Write("Ingrese la cantidad de stock del producto: ");
            inputStock = Console.ReadLine();
            flag = vd.ValidarNumero(inputStock, ref stock, "Stock");

        } while (flag == false);

        do
        {
            flag = false;
            Console.Write("Ingrese la categoria del producto utilizando el número de ID de la categoría: ");
            inputCat = Console.ReadLine();
            inputCategoria = Convert.ToInt32(inputCat);
            CategoriaProductos categoriaProductos = new CategoriaProductos();
            flag2 = false;

            if (categoriaProductos.BuscarCategoriaId(inputCategoria) is null)
            {
                Console.WriteLine("La categoría introducida no es válida");
            }
            else if (categoriaProductos.BuscarCategoriaId(inputCategoria) is not null)
            {
                inputCat = Convert.ToString(inputCategoria);
                Guid.TryParse(inputCat, out idCat);
                flag = true;
                flag2 = true;
            }

        } while (flag == false);

        Productos producto = new Productos();
        producto.IdProducto = new Guid();
        producto.Nombre = inputNombre;
        producto.Precio = Convert.ToSingle(inputPrecio);
        producto.Stock = Convert.ToInt32(inputStock);
        producto.StockMaximo = 10000;
        producto.FechaAlta = DateTime.Now;
        producto.IdCategoria = inputCategoria;

        /*if (producto.Stock < 0.25 * producto.Stock) 
        {
            if (usuario is Administrador || usuario is Supervisor)
            {
               Console.WriteLine($"{producto.Nombre} - Stock: {producto.Stock}");
               Console.WriteLine("¡ALERTA! Stock bajo.");
            }

        }*/

        /* otra posibilidad con StockMaximo como propiedad
         if (usuario is Supervisor || usuario is Administrador)
        {
            foreach (Productos producto in productos)
            {
                // Calcular el porcentaje de stock actual en comparación con el stock máximo
                double porcentajeStock = (double)producto.Stock / producto.StockMaximo * 100;

                // Verificar si el stock es menor al 25%
                if (porcentajeStock < 25)
                {
                    // Mostrar la alerta en la pantalla principal
                    MostrarAlerta($" ¡ALERTA! Stock bajo para el producto: {producto.Nombre}");
                }
            }
        }
         */

        Console.WriteLine("Se agregó el producto correctamente");
    }
}