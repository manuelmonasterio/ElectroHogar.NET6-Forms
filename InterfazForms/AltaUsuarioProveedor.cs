using AccesoDatos;
using Modelo;
using Negocio;
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
    public partial class AltaUsuarioProveedor : Form
    {
        public AltaUsuarioProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdProveedores formX = new MenuAdProveedores();
            formX.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProveedoresNegocio pn = new ProveedoresNegocio();
            ValidacionesUsuario validacionesUsuario = new ValidacionesUsuario();
            try
            {
                string listaerrores = "";
                string inputNombre = txbNombre.Text;
                string inputApellido = txbApellido.Text;
                string inputEmail = txbMail.Text;
                string inputCUIT = txbCUIT.Text;
                int cuit = Convert.ToInt32(txbCUIT.Text);

                listaerrores += ValidacionesForm.ValidarVacio(inputNombre, "Nombre");
                listaerrores += ValidacionesForm.ValidarVacio(inputApellido, "Apellido");
                listaerrores += ValidacionesForm.ValidarVacio(inputEmail, "Correo Electrónico");
                listaerrores += ValidacionesForm.ValidarVacio(inputCUIT, "CUIT");
                listaerrores += ValidacionesForm.ValidarCuit(inputCUIT, ref cuit);
                //validarNumero cuit

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {

                    Proveedores proveedor = new Proveedores();
                    proveedor.Id = new Guid();
                    proveedor.Nombre = inputNombre;
                    proveedor.Apellido = inputApellido;
                    proveedor.Email = inputEmail;
                    proveedor.Cuit = cuit;
                    proveedor.FechaAlta = DateTime.Now;
                    proveedor.Estado = "ACTIVO";

                    ProveedorModelDatos proveedorDatos = new ProveedorModelDatos();
                    proveedorDatos.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                    proveedorDatos.Nombre = inputNombre;
                    proveedorDatos.Apellido = inputApellido;
                    proveedorDatos.Email = inputEmail;
                    proveedorDatos.CUIT = inputCUIT;

                    try
                    {
                        pn.CrearProveedor(proveedorDatos);
                        //Console.WriteLine("Alta exitosa");
                        MessageBox.Show("Alta exitosa");
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar el alta de proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AltaUsuarioProveedor_Load(object sender, EventArgs e)
        {
            //no tocar
        }
    }
}
