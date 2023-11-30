using Modelo;
using Modelo.Exceptions;
using Negocio;
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
    public partial class BajaUsuarioProveedor : Form
    {
        public BajaUsuarioProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdProveedores formX = new MenuAdProveedores();
            formX.ShowDialog();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            ProveedoresNegocio pn = new ProveedoresNegocio();
            try
            {
                string listaerrores = "";
                string idProveedor = txbIDProveedor.Text;

                listaerrores += ValidacionesForm.ValidarVacio(idProveedor, "ID Usuario");
                listaerrores += ValidacionesForm.ValidarID(idProveedor);

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbIDProveedor.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    Menu menu = new Menu();
                    Proveedores proveedor = pn.BuscarProveedorId(idProveedor);
                    proveedor.Estado = "INACTIVO";
                    pn.BorrarProveedor(idProveedor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
