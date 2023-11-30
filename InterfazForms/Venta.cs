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
            MenuVendedor formX = new MenuVendedor(3);
            formX.ShowDialog();
        }

        private static ProductosNegocio pn = new ProductosNegocio();
        private static VentasNegocio vn = new VentasNegocio();
        private static ClientesNegocio cn = new ClientesNegocio();
        public static List<Ventas> ventas = new List<Ventas>();
        private static CategoriaProductos cp = new CategoriaProductos();
        Ventas venta = null;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string listaerrores = "";
                string idVenta = Guid.NewGuid().ToString(); // Generar un ID de venta único.
                string idCliente = txbIDCliente.Text;
                string idUsuario = txbIDUsuario.Text;
                string idProducto = txbIDProducto.Text;
                string cant = txbCantidad.Text;
                int cantidad = Convert.ToInt32(txbCantidad.Text);

                Productos producto = ProductosNegocio.BuscarProductoId(idProducto);

                List<(string IdProducto, int Cantidad)> productosVendidos = new List<(string, int)>();

                bool flag = false;

                listaerrores += ValidacionesForm.ValidarVacio(idCliente, "ID Cliente");
                listaerrores += ValidacionesForm.ValidarVacio(idUsuario, "ID Usuario");
                listaerrores += ValidacionesForm.ValidarVacio(idProducto, "ID Producto");
                listaerrores += ValidacionesForm.ValidarVacio(cant, "Cantidad");
                listaerrores += ValidacionesForm.ValidarID(idCliente);
                listaerrores += ValidacionesForm.ValidarID(idUsuario);
                listaerrores += ValidacionesForm.ValidarID(idProducto);
                //listaerrores += ValidacionesForm.ValidarNumero(cant, "Cantidad");

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbIDCliente.Clear();
                    txbIDUsuario.Clear();
                    txbIDProducto.Clear();
                    txbCantidad.Clear();
                    MessageBox.Show(listaerrores, "Error");
                    flag = true;
                }
                else if (cantidad > producto.Stock)
                {
                    MessageBox.Show("Este producto solo cuenta con " + producto.Stock + "unidades.");
                    flag = true;
                }
                else if (flag == false && cantidad > 0)
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
                        MessageBox.Show("Producto vendido");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Ventas venta = new Ventas(idVenta, productoVenta.IdProducto, idCliente, idUsuario, productoVenta.Cantidad, "ACTIVO", DateTime.Now.Date);
            //ventas.Add(venta);

            //// Actualizar el stock del producto
            //Productos producto = ProductosNegocio.BuscarProductoId(productoVenta.IdProducto);
            //producto.Stock -= productoVenta.Cantidad;

            //// Aplicar descuentos (puedes mantener la lógica de descuentos como antes)
            //double descuento = AplicarDescuentos(venta, productosVendidos);

            //// Calcular el total de la venta (puedes mantener la lógica de cálculo de total como antes)
            //double totalVenta = CalcularTotalVenta(productosVendidos) - descuento;

            //// Generar el comprobante de venta (puedes mantener la lógica de generación de comprobante como antes)
            //GenerarComprobante(venta, productosVendidos, totalVenta);

            //return ventas.First(); // Devuelve la primera venta de la lista.
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string IdProducto = txbIDProducto.Text;
            int cantidad = Convert.ToInt32(txbCantidad.Text);
            string idCliente = txbIDCliente.Text;
            string idUsuario = txbIDUsuario.Text;

            Productos producto = ProductosNegocio.BuscarProductoId(IdProducto);
            if (cantidad > producto.Stock)
            {
                MessageBox.Show("Este producto solo cuenta con " + producto.Stock + "unidades.");
            }
            VentaModelDatos VentaDatos = new VentaModelDatos();
            VentaDatos.IdCliente = idCliente;
            VentaDatos.IdUsuario = idUsuario;
            VentaDatos.IdProducto = Convert.ToString(producto.IdProducto);
            VentaDatos.Cantidad = cantidad;
        }
    }
}



//    private double CalcularTotalVenta(List<(string IdProducto, int Cantidad)> productosVendidos)
//    {
//        double totalVenta = 0;

//        foreach ((string IdProducto, int Cantidad) productoVenta in productosVendidos)
//        {
//            Productos producto = ProductosNegocio.BuscarProductoId(productoVenta.IdProducto);
//            totalVenta += producto.Precio * productoVenta.Cantidad;
//        }

//        return totalVenta;
//    }

//    private double AplicarDescuentos(Ventas venta, List<(string IdProducto, int Cantidad)> productosVendidos)
//    {
//        double totalDescuento = 0;

//        // Obtener la lista de categorías de productos
//        CategoriaProductos categoriaProductos = new CategoriaProductos();
//        categoriaProductos.AgregarCategorias();

//        // Verificar si la venta contiene productos de la categoría "Electro Hogar" que sumen más de $100,000
//        bool contieneElectroHogar = productosVendidos.Any(productoVenta =>
//        {
//            Productos producto = ProductosNegocio.BuscarProductoId(productoVenta.IdProducto);
//            CategoriaProductos categoria = cp.BuscarCategoriaId(producto.IdCategoria);
//            return categoria != null && categoria.Descripcion == "Electro Hogar";
//        });

//        double totalVenta = CalcularTotalVenta(productosVendidos);

//        // Aplicar el descuento "Promo Electro Hogar" (5%) si se cumple la condición
//        if (contieneElectroHogar && totalVenta > 100000)
//        {
//            totalDescuento += totalVenta * 0.05; // 5% de descuento
//        }

//        // Aplicar el descuento "Promo Cliente Nuevo" (5%) si es la primera compra del cliente
//        if (EsPrimeraCompraCliente(venta.IdCliente))
//        {
//            totalDescuento += totalVenta * 0.05; // 5% de descuento
//        }

//        return totalDescuento;
//    }

//    private bool EsPrimeraCompraCliente(string idCliente)
//    {
//        // Verificar si el cliente ha realizado compras anteriores
//        return !ventas.Any(venta => venta.IdCliente == idCliente);
//    }


//    private void GenerarComprobante(Ventas venta, List<(string IdProducto, int Cantidad)> productosVendidos, double totalVenta)
//    {
//        MessageBox.Show("Comprobante de Venta " +
//            "\nEmpresa: Electro Hogar " + 
//            "\nFecha de Operación: " + venta.FechaAlta.ToString("dd/MM/yyyy") + 
//            "\nDatos del Cliente: " + ClientesNegocio.BuscarClienteId(venta.IdCliente) + 
//            "\nDetalle de Productos:");

//        foreach ((string IdProducto, int Cantidad) productoVenta in productosVendidos)
//        {
//            Productos producto = ProductosNegocio.BuscarProductoId(productoVenta.IdProducto);
//            Console.WriteLine($"- Producto: {producto.IdProducto}");
//            Console.WriteLine($"- Descripción: {producto.Nombre}");
//            Console.WriteLine($"- Cantidad: {productoVenta.Cantidad}");
//            Console.WriteLine($"- Monto Unitario: {producto.Precio:C}");
//            Console.WriteLine($"- Monto Total: {producto.Precio * productoVenta.Cantidad:C}");
//        }

//        // Agregar lógica para mostrar las promociones aquí

//        Console.WriteLine("Total a Pagar: " + totalVenta.ToString("C"));
//    }
//}