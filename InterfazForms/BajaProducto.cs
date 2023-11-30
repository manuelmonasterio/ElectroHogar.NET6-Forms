using Modelo;
using Negocio;
using Modelo.Exceptions;
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
    public partial class BajaProducto : Form
    {
        public BajaProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionUsuario formX = new GestionUsuario();
            formX.ShowDialog();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            //txbIDProducto.Text;
            ProductosNegocio pn = new ProductosNegocio();
            try
            {
                string listaerrores = "";
                string idProducto = txbIDProducto.Text;

                listaerrores += ValidacionesForm.ValidarVacio(idProducto, "ID Usuario");
                listaerrores += ValidacionesForm.ValidarID(idProducto);

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbIDProducto.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    Menu menu = new Menu();
                    Productos producto = ProductosNegocio.BuscarProductoId(idProducto);
                    producto.Estado = "INACTIVO";
                    pn.BorrarProducto(idProducto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
