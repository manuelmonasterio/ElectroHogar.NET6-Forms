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
                string mensaje = "";

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

                                    mensaje += ("Cambio de precio exitoso");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(stockStr))
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

                                    mensaje += ("\nCambio de stock exitoso");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(stockStr) && estadoStr == "ACTIVO")
                        {
                            try
                            {
                                if (producto.Estado == "INACTIVO")
                                {
                                    producto.Estado = "ACTIVO";
                                    pn.ReactivarProducto(productoId);
                                }
                                else
                                {
                                    MessageBox.Show("El producto ya está Inactivo");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Hubo un problema al realizar la modificación del estado producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (!string.IsNullOrWhiteSpace(stockStr) && estadoStr == "INACTIVO")
                        {
                            try
                            {
                                if (producto.Estado == "ACTIVO")
                                {
                                    producto.Estado = "INACTIVO";
                                    pn.BorrarProducto(productoId);
                                }
                                else
                                {
                                    MessageBox.Show("El producto ya está Activo");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Hubo un problema al realizar la modificación del estado producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opción no válida. Inténtalo de nuevo.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }

                MessageBox.Show(mensaje);

                MessageBox.Show("Datos actualizados del producto " + producto.Nombre + ": " +
                "\nPrecio: " + precio +
                "\nStock: " + producto.Stock);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar la modificación del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
