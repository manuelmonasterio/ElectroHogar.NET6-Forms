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
    public partial class ModificarProducto : Form
    {
        private int host;
        public ModificarProducto(int host)
        {
            InitializeComponent();
            this.host = host;
        }

        ProductosNegocio pn = new ProductosNegocio();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuProductos formX = new MenuProductos(host);
            formX.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //no tocar
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            try
            {
                string listaerrores = "";
                string productoId = txbIDProducto.Text.Trim();
                string precioStr = txbNuevoPrecio.Text.Trim();
                string stockStr = txbNuevoStock.Text.Trim();
                string estadoStr = txbNuevoEstado.Text.Trim();
                int stock = 0;
                double precio = 0;
                bool flag = false;
                string vacio = "No fueron modificados: ";

                listaerrores += ValidacionesForm.ValidarVacio(productoId, "ID Producto");
                vacio += ValidacionesForm.ValidarVacio(precioStr, "Precio");
                vacio += ValidacionesForm.ValidarVacio(stockStr, "Stock");

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbIDProducto.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    Productos producto = ProductosNegocio.BuscarProductoId(productoId);

                    if (producto != null)
                    {
                        if (!string.IsNullOrWhiteSpace(precioStr))
                        {
                            ValidacionesDatos validador = new ValidacionesDatos();
                            flag = validador.ValidarDecimal(precioStr, ref precio, "Precio");
                            if (!flag)
                            {
                                MessageBox.Show("Precio no válido. Debe ser un número decimal válido.");
                            }
                            else
                            {
                                try
                                {
                                    pn.ModificarProducto(productoId, precio, producto.Stock);

                                    Console.WriteLine("Cambio de precio exitoso");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }
                        else if (!string.IsNullOrWhiteSpace(stockStr))
                        {
                            ValidacionesDatos validador = new ValidacionesDatos();
                            flag = validador.ValidarNumero(stockStr, ref stock, "Stock");

                            if (!flag)
                            {
                                MessageBox.Show("Stock no válido. Debe ser un número entero válido.");
                            }
                            else
                            {
                                try
                                {
                                    pn.ModificarProducto(productoId, producto.Precio, stock);

                                    MessageBox.Show("Cambio de stock exitoso");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                        else if(!string.IsNullOrWhiteSpace(stockStr) && (estadoStr == "ACTIVO" || estadoStr == "INACTIVO"))
                        {
                            if (producto.Estado == "INACTIVO")
                            {
                                producto.Estado = "ACTIVO";
                                pn.ReactivarProducto(productoId);
                            }
                            else if (producto.Estado == "ACTIVO")
                            {
                                producto.Estado = "INACTIVO";
                                pn.BorrarProducto(productoId);
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error inesperado. No se modificará el estado del producto");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opción no válida. Inténtalo de nuevo.");
                        }

                        MessageBox.Show("Datos actualizados del producto " + producto.Nombre + ": " +
                            "\nPrecio: " + precio +
                            "\nStock: " + producto.Stock);
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar la modificación del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
