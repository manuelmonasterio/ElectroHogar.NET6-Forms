using Modelo;
using Modelo.Exceptions;
using Negocio;
using AccesoDatos;
using PRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazForms
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuVendedor formX = new MenuVendedor();
            formX.ShowDialog();
        }

        private static ValidacionesDatos vd = new ValidacionesDatos();
        private static ProductosNegocio pn = new ProductosNegocio();
        private static VentasNegocio vn = new VentasNegocio();
        private static ClientesNegocio cn = new ClientesNegocio();
        public static List<Ventas> ventas = new List<Ventas>();
        private static CategoriaProductos cp = new CategoriaProductos();
        Ventas venta = null;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarVenta();
        }

        public Ventas registrarVenta()
        {
            string idVenta = Guid.NewGuid().ToString(); // Generar un ID de venta único.
            string idCliente = txbIDCliente.Text;
            string idUsuario = txbIDUsuario.Text;
            string idProducto = txbIDProducto.Text;
            int cantidad = Convert.ToInt32(txbCantidad.Text);
            List<(string IdProducto, int Cantidad)> productosVendidos = new List<(string, int)>();

            bool flag;

            do
            {
                Console.Write("Ingrese el ID del cliente: ");
                idCliente = Console.ReadLine();
                flag = vd.ValidarVacio(idCliente, "ID Cliente") && vd.ValidarID(idCliente);

                if (!flag)
                {
                    Console.WriteLine("ID de cliente no válido. Inténtelo de nuevo.");
                }

            } while (!flag);

            do
            {
                Console.Write("Ingrese el ID del usuario: ");
                idUsuario = Console.ReadLine();
                flag = vd.ValidarVacio(idUsuario, "ID Usuario") && vd.ValidarID(idUsuario);

                if (!flag)
                {
                    Console.WriteLine("ID de usuario no válido. Inténtelo de nuevo.");
                }

            } while (!flag);

            // Solicitar la lista de productos vendidos
            do
            {
                Console.Write("Ingrese el ID del producto vendido (o '0' para finalizar): ");
                idProducto = Console.ReadLine();

                if (idProducto == "0")
                {
                    break; // Salir del bucle cuando el usuario finalice la entrada de productos.
                }

                flag = vd.ValidarVacio(idProducto, "ID Producto") && vd.ValidarID(idProducto);

                if (flag)
                {
                    cantidad = SolicitarCantidadProducto();

                    if (cantidad > 0)
                    {
                        productosVendidos.Add((idProducto, cantidad));

                        VentaModelDatos VentaDatos = new VentaModelDatos();
                        VentaDatos.IdCliente = idCliente;
                        VentaDatos.IdUsuario = idUsuario;
                        VentaDatos.IdProducto = idProducto;
                        VentaDatos.Cantidad = cantidad;

                        try
                        {
                            vn.CrearVenta(VentaDatos);
                            Console.WriteLine("Producto vendido");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cantidad no válida. Debe ser un número positivo.");
                    }
                }
                else
                {
                    Console.WriteLine("ID de producto no válido. Inténtelo de nuevo.");
                }

            } while (true);

            // Crear una fila por cada producto vendido
            foreach ((string IdProducto, int Cantidad) productoVenta in productosVendidos)
            {
                Ventas venta = new Ventas(idVenta, productoVenta.IdProducto, idCliente, idUsuario, productoVenta.Cantidad, "ACTIVO", DateTime.Now.Date);
                ventas.Add(venta);

                // Actualizar el stock del producto
                Productos producto = ProductosNegocio.BuscarProductoId(productoVenta.IdProducto);
                producto.Stock -= productoVenta.Cantidad;
            }

            // Aplicar descuentos (puedes mantener la lógica de descuentos como antes)
            double descuento = AplicarDescuentos(venta, productosVendidos);

            // Calcular el total de la venta (puedes mantener la lógica de cálculo de total como antes)
            double totalVenta = CalcularTotalVenta(productosVendidos) - descuento;

            // Generar el comprobante de venta (puedes mantener la lógica de generación de comprobante como antes)
            GenerarComprobante(venta, productosVendidos, totalVenta);

            return ventas.First(); // Devuelve la primera venta de la lista.
        }

        private int SolicitarCantidadProducto()
        {
            int cantidad = 0;

            do
            {
                Console.Write("Ingrese la cantidad: ");
                int.TryParse(Console.ReadLine(), out cantidad);
            } while (cantidad <= 0);

            return cantidad;
        }

        private double CalcularTotalVenta(List<(string IdProducto, int Cantidad)> productosVendidos)
        {
            double totalVenta = 0;

            foreach ((string IdProducto, int Cantidad) productoVenta in productosVendidos)
            {
                Productos producto = ProductosNegocio.BuscarProductoId(productoVenta.IdProducto);
                totalVenta += producto.Precio * productoVenta.Cantidad;
            }

            return totalVenta;
        }

        private double AplicarDescuentos(Ventas venta, List<(string IdProducto, int Cantidad)> productosVendidos)
        {
            double totalDescuento = 0;

            // Obtener la lista de categorías de productos
            CategoriaProductos categoriaProductos = new CategoriaProductos();
            categoriaProductos.AgregarCategorias();

            // Verificar si la venta contiene productos de la categoría "Electro Hogar" que sumen más de $100,000
            bool contieneElectroHogar = productosVendidos.Any(productoVenta =>
            {
                Productos producto = ProductosNegocio.BuscarProductoId(productoVenta.IdProducto);
                CategoriaProductos categoria = cp.BuscarCategoriaId(producto.IdCategoria);
                return categoria != null && categoria.Descripcion == "Electro Hogar";
            });

            double totalVenta = CalcularTotalVenta(productosVendidos);

            // Aplicar el descuento "Promo Electro Hogar" (5%) si se cumple la condición
            if (contieneElectroHogar && totalVenta > 100000)
            {
                totalDescuento += totalVenta * 0.05; // 5% de descuento
            }

            // Aplicar el descuento "Promo Cliente Nuevo" (5%) si es la primera compra del cliente
            if (EsPrimeraCompraCliente(venta.IdCliente))
            {
                totalDescuento += totalVenta * 0.05; // 5% de descuento
            }

            return totalDescuento;
        }

        private bool EsPrimeraCompraCliente(string idCliente)
        {
            // Verificar si el cliente ha realizado compras anteriores
            return !ventas.Any(venta => venta.IdCliente == idCliente);
        }


        private void GenerarComprobante(Ventas venta, List<(string IdProducto, int Cantidad)> productosVendidos, double totalVenta)
        {
            Console.WriteLine("Comprobante de Venta");
            Console.WriteLine("Empresa: Electro Hogar");
            Console.WriteLine("Fecha de Operación: " + venta.FechaAlta.ToString("dd/MM/yyyy"));
            Console.WriteLine("Datos del Cliente: " + ClientesNegocio.BuscarClienteId(venta.IdCliente));
            Console.WriteLine("Detalle de Productos:");

            foreach ((string IdProducto, int Cantidad) productoVenta in productosVendidos)
            {
                Productos producto = ProductosNegocio.BuscarProductoId(productoVenta.IdProducto);
                Console.WriteLine($"- Producto: {producto.IdProducto}");
                Console.WriteLine($"- Descripción: {producto.Nombre}");
                Console.WriteLine($"- Cantidad: {productoVenta.Cantidad}");
                Console.WriteLine($"- Monto Unitario: {producto.Precio:C}");
                Console.WriteLine($"- Monto Total: {producto.Precio * productoVenta.Cantidad:C}");
            }

            // Agregar lógica para mostrar las promociones aquí

            Console.WriteLine("Total a Pagar: " + totalVenta.ToString("C"));
        }
    }
}
