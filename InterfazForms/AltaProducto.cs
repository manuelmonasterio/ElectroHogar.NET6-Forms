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
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuProductos formX = new MenuProductos();
            formX.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductosNegocio pn = new ProductosNegocio();
            try
            {
                string listaerrores = "";
                string inputNombre = txbNombre.Text;
                string inputPrecio = txbPrecio.Text;
                string inputStock = txbStock.Text;
                int stock = Convert.ToInt32(txbStock.Text);
                double precio = Convert.ToDouble(txbPrecio.Text);
                string inputCat = txbCat.Text;
                int inputCategoria = Convert.ToInt32(txbCat.Text);
                Guid idCat = Guid.Empty;

                listaerrores += ValidacionesForm.ValidarVacio(inputNombre, "Nombre");
                listaerrores += ValidacionesForm.ValidarVacio(inputPrecio, "Precio");
                listaerrores += ValidacionesForm.ValidarVacio(inputStock, "Stock");
                listaerrores += ValidacionesForm.ValidarVacio(inputCat, "Categoria Producto");
                //listaerrores += ValidacionesForm.ValidarNumero(stock);
                //listaerrores += ValidacionesForm.ValidarNumero(inputCategoria);

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbNombre.Clear();
                    txbPrecio.Clear();
                    txbStock.Clear();
                    txbCat.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    Productos producto = new Productos();
                    producto.IdProducto = new Guid();
                    producto.Nombre = inputNombre;
                    producto.Precio = Convert.ToSingle(inputPrecio);
                    producto.Stock = Convert.ToInt32(inputStock);
                    producto.StockMaximo = 10000;
                    producto.FechaAlta = DateTime.Now;
                    producto.IdCategoria = inputCategoria;

                    ProductoModelDatos productoDatos = new ProductoModelDatos();
                    productoDatos.IdCategoria = inputCategoria;
                    //productoDatos.IdProducto = Convert.ToString(producto.IdProducto); --CW no tiene ID directamente se lo crea automaticamente el swagger
                    productoDatos.Nombre = inputNombre;
                    productoDatos.Precio = Convert.ToSingle(inputPrecio);
                    productoDatos.Stock = Convert.ToInt32(inputStock);

                    try
                    {
                        pn.CrearProducto(productoDatos);
                        //Console.WriteLine("Alta exitosa");
                        MessageBox.Show("Alta exitosa");
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message);
                    }

                    //Console.WriteLine("Se agregó el producto correctamente");
                    MessageBox.Show("Se agregó el producto correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
