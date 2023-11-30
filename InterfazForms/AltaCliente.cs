using AccesoDatos;
using Modelo;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfazForms
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuVendedor formX = new MenuVendedor(3);
            formX.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ClientesNegocio pn = new ClientesNegocio();
            List<Clientes> clientes = new List<Clientes>();

            PRESENTACION.Menu menu = new PRESENTACION.Menu();

            try
            {
                string listaerrores = "";
                string inputNombre = txbNombre.Text;
                string inputApellido = txbApellido.Text;
                string inputDireccion = txbDireccion.Text;
                string inputTelefono = txbTelefono.Text;
                string inputEmail = txbMail.Text;
                string inputFechaNacimiento = txbFecNac.Text;
                DateTime fechaNacimiento = DateTime.Now;
                string inputDNI = txbDNI.Text;
                int dni = Convert.ToInt32(txbDNI.Text);
                string inputHost = txbHost.Text;
                Guid IdUsuario = new Guid();
                string inputIdUsuario = txbID.Text;
                bool flag = false;

                listaerrores += ValidacionesForm.ValidarVacio(inputNombre, "Nombre");
                listaerrores += ValidacionesForm.ValidarVacio(inputApellido, "Apellido");
                listaerrores += ValidacionesForm.ValidarVacio(inputDireccion, "Dirección");
                listaerrores += ValidacionesForm.ValidarVacio(inputTelefono, "Teléfono");
                listaerrores += ValidacionesForm.ValidarVacio(inputEmail, "Correo Electrónico");
                listaerrores += ValidacionesForm.ValidarVacio(inputFechaNacimiento, "Fecha de Nacimiento");
                listaerrores += ValidacionesForm.ValidarVacio(inputHost, "Perfil");
                listaerrores += ValidacionesForm.ValidarVacio(inputDNI, "DNI");
                listaerrores += ValidacionesForm.ValidarVacio(inputIdUsuario, "ID");
                listaerrores += ValidacionesForm.ValidarFecha(inputFechaNacimiento);

                

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbNombre.Clear();
                    txbApellido.Clear();
                    txbDireccion.Clear();
                    txbTelefono.Clear();
                    txbMail.Clear();
                    txbFecNac.Clear();
                    txbDNI.Clear();
                    txbHost.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else if (menu.BuscarUsuarioID(inputIdUsuario) is null)
                {
                    Console.WriteLine("El Id del Usuario introducido no es válido");
                }
                else if (menu.BuscarUsuarioID(inputIdUsuario) is not null)
                {
                    Guid.TryParse(inputIdUsuario, out IdUsuario);
                    flag = true;
                }
                else if (flag == true)
                {
                    Clientes cliente = new Clientes();
                    cliente.IdCliente = new Guid();
                    cliente.Nombre = inputNombre;
                    cliente.Apellido = inputApellido;
                    cliente.Direccion = inputDireccion;
                    cliente.Telefono = inputTelefono;
                    cliente.Email = inputEmail;
                    cliente.Host = inputHost;
                    cliente.FechaNacimiento = Convert.ToDateTime(inputFechaNacimiento);
                    cliente.DNI = Convert.ToInt32(inputDNI);
                    cliente.FechaAlta = DateTime.Now;
                    cliente.IdUsuario = IdUsuario;

                    ClienteModelDatos clienteDatos = new ClienteModelDatos();
                    clienteDatos.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                    clienteDatos.Host = inputHost;
                    clienteDatos.Nombre = inputNombre;
                    clienteDatos.Apellido = inputApellido;
                    clienteDatos.Dni = dni;
                    clienteDatos.Direccion = inputDireccion;
                    clienteDatos.Telefono = inputTelefono;
                    clienteDatos.Email = inputEmail;
                    clienteDatos.FechaNacimiento = fechaNacimiento;

                    try
                    {
                        pn.CrearCliente(clienteDatos);
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
                MessageBox.Show($"Hubo un problema al realizar el alta de cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
