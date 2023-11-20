using System;
using Modelo;
using Modelo.Exceptions;
using Negocio;
using PRESENTACION;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

public class Reportes
{
    public static List<Ventas> ventas = new List<Ventas>();
    public static Ventas v = new Ventas();
    public static List<Vendedores> vendedores = new List<Vendedores>();
    public static List<Productos> productos = new List<Productos>();
    public static List<CategoriasProducto> categorias = new List<CategoriasProducto>();
    public static CategoriasProducto cp = new CategoriasProducto();
    public static Productos p = new Productos();
    public static UsuarioModel um = new UsuarioModel();

    public void StockCritico(List<Productos> productos)
    {
        //if (p.StockMaximo < lo que definamos como Stock Maximo) entonces se sigue adelante
        var productosCriticos = productos.FindAll(p => p.Stock < p.StockMaximo * 0.25).OrderBy(p => p.IdCategoria);

        Console.WriteLine("Reporte de Stock Crítico");
        Console.WriteLine("========================");

        // Se crea secuencia de categorías únicas a partir de la lista de productos críticos para iterar sobre cada categoría única, mostrando los productos asociados a cada una.
        foreach (var categoria in productosCriticos.Select(p => p.IdCategoria).Distinct())
        {
            Console.WriteLine($"Categoría: {categoria}"); //poner el nombre de la categoría de CategoríaProducto

            foreach (var producto in productosCriticos.Where(p => p.IdCategoria == categoria))
            {
                Console.WriteLine($"   - Producto: {producto.Nombre}, Stock: {producto.Stock}");
            }

        }

        if (UsuarioModel is Supervisor || UsuarioModel is Administrador)
        {
            int cantidadProductosCriticos = productosCriticos.Count();
            Console.WriteLine($"¡Hay {cantidadProductosCriticos} productos con stock crítico!");
        }
    }

    public void VentasxVendedor(List<Ventas> ventas, List<Vendedores> vendedores)
    {
        Console.WriteLine("Reporte de Ventas por Vendedor");
        Console.WriteLine("===============================");

        // Para obtener todos los meses y vendedores únicos
        var mesesUnicos = ventas.Select(v => v.FechaAlta.Month).Distinct();
        var vendedoresUnicos = vendedores.Select(v => v.Nombre && a => a.Apellido).Distinct();

        foreach (var mes in mesesUnicos)
        {
            foreach (var vendedorNombre in vendedoresUnicos)
            {
                // Se busca el vendedor por nombre y apellido
                var vendedor = vendedores.Find(v => v.Nombre == Nombre && a => a.Apellido == Apellido);

                if (vendedor != null)
                {
                    // Se filtra ventas por mes y vendedor
                    var ventasFiltradas = ventas.Where(v => v.FechaAlta.Month == mes && v.Vendedor.Id == vendedor.Id)
                        .ToList();

                    if (ventasFiltradas.Count > 0)
                    {
                        int cantidadVentas = ventasFiltradas.Count;
                        float montoTotal = ventasFiltradas.Sum(v => v.Monto);

                        Console.WriteLine($"Mes: {mes}, Vendedor: {vendedorNombre}");
                        Console.WriteLine($"   - Cantidad de Ventas: {cantidadVentas}");
                        Console.WriteLine($"   - Monto Total: ${montoTotal}");
                    }
                }
            }

        }
    }

    public void ProductosMasVendidos(List<Productos> productos, List<Ventas> ventas)
    {
        Console.WriteLine("Reporte de Productos Más Vendidos por Categoría");
        Console.WriteLine("==============================================");

        //Se bbtiene todas las categorías únicas
        var categoriasUnicas = productos.Select(p => p.IdCategoria).Distinct();

        foreach (var categoria in categoriasUnicas)
        {
            // se filtra productos por categoría
            var productosPorCategoria = productos.Where(p => p.IdCategoria == categoria).ToList();

            if (productosPorCategoria > 0)
            {
                Console.WriteLine($"Categoría: {categoria}"); //poner nombre o descripción de la categoría en CategoríaProductos

                // Calcular la cantidad total vendida para cada producto en la categoría
                var productosVendidos = new List<ProductosVendidos>();

                foreach (var producto in productosPorCategoria)
                {
                    int cantidadVendida = 0;

                    foreach (var venta in ventas)
                    {
                        if (venta.Id == producto.Id)
                        {
                            cantidadVendida += venta.Cantidad;
                        }
                    }

                    productosVendidos.Add(new ProductoVendido
                    {
                        Producto = producto,
                        CantidadVendida = cantidadVendida
                    });
                }

                // Mostrar los productos más vendidos en la categoría
                foreach (var productosVendidos in productosVendidos.OrderByDescending(p => p.CantidadVendida))
                {
                    Console.WriteLine($"   - Producto: {productosVendidos.Producto.Nombre}, Cantidad Vendida: {productosVendidos.CantidadVendida}");
                }

            }
        }
    }
}

