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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //vuelve a GestionUsuario
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
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
                string inputPerfil = txbPerfil.Text;
                int perfil = Convert.ToInt32(txbPerfil.Text);
                string inputDni = txbDNI.Text;
                int dni = Convert.ToInt32(txbDNI.Text); 
                string NombreUsuario = txbNombreUsuario.Text;
                string inputContra = txbContrasena2.Text;

                
                listaerrores += ValidacionesForm.ValidarVacio(inputNombre, "Nombre");
                listaerrores += ValidacionesForm.ValidarVacio(inputApellido, "Apellido");
                listaerrores += ValidacionesForm.ValidarVacio(inputDireccion, "Dirección");
                listaerrores += ValidacionesForm.ValidarVacio(inputTelefono, "Teléfono");
                listaerrores += ValidacionesForm.ValidarVacio(inputEmail, "Correo Electrónico");
                listaerrores += ValidacionesForm.ValidarVacio(inputFechaNacimiento, "Fecha de Nacimiento");
                listaerrores += ValidacionesForm.ValidarVacio(inputPerfil, "Perfil");
                listaerrores += ValidacionesForm.ValidarVacio(inputDni, "DNI");
                listaerrores += ValidacionesForm.ValidarVacio(inputContra, "Contraseña");

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    MetodosUsuarios met = new MetodosUsuarios();
                    //metodo para dar de alta
                    MetodosUsuarios usu = new MetodosUsuarios();
                    UsuarioModelDatos usuario = new UsuarioModelDatos();
                    usuario.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                    usuario.Host = perfil;
                    usuario.Nombre = inputNombre;
                    usuario.Apellido = inputApellido;
                    usuario.Dni = dni;
                    usuario.Direccion = inputDireccion;
                    usuario.Telefono = inputTelefono;
                    usuario.Email = inputEmail;
                    usuario.FechaNacimiento = fechaNacimiento;
                    usuario.NombreUsuario = NombreUsuario;
                    usuario.Contraseña = inputContra;
                    try
                    {
                        met.CrearUsuario(usuario);
                        //Console.WriteLine("Alta exitosa");
                        MessageBox.Show("Alta exitosa");

                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (perfil == 1)
                    {
                        UsuarioModel usuario1 = new Administrador();
                        usuario1.id = new Guid();
                        usuario1.host = perfil;
                        usuario1.nombre = inputNombre;
                        usuario1.apellido = inputApellido;
                        usuario1.dni = dni;
                        usuario1.direccion = inputDireccion;
                        usuario1.telefono = inputTelefono;
                        usuario1.email = inputEmail;
                        usuario1.fechaAlta = DateTime.Now;
                        usuario1.fechaNacimiento = fechaNacimiento;
                        //usuario.fechaBaja = new DateTime(2999, 12, 31);
                        usuario1.usuario = NombreUsuario;
                        usuario1.contraseña = inputContra;
                        usuario1.fechacontraseña = DateTime.Today;
                        met.CrearUsuarioLista(usuario1);

                    }
                    else if (perfil == 2)
                    {
                        UsuarioModel usuario1 = new Supervisores();
                        usuario1.id = new Guid();
                        usuario1.host = perfil;
                        usuario1.nombre = inputNombre;
                        usuario1.apellido = inputApellido;
                        usuario1.dni = dni;
                        usuario1.direccion = inputDireccion;
                        usuario1.telefono = inputTelefono;
                        usuario1.email = inputEmail;
                        usuario1.fechaAlta = DateTime.Now;
                        usuario1.fechaNacimiento = fechaNacimiento;
                        //usuario1.fechaBaja = new DateTime(2999, 12, 31);
                        usuario1.usuario = NombreUsuario;
                        usuario1.contraseña = inputContra;
                        usuario1.fechacontraseña = DateTime.Today;
                        met.CrearUsuarioLista(usuario1);
                    }
                    else
                    {
                        UsuarioModel usuario1 = new Vendedor();
                        usuario1.id = new Guid();
                        usuario1.host = perfil;
                        usuario1.nombre = inputNombre;
                        usuario1.apellido = inputApellido;
                        usuario1.dni = dni;
                        usuario1.direccion = inputDireccion;
                        usuario1.telefono = inputTelefono;
                        usuario1.email = inputEmail;
                        usuario1.fechaAlta = DateTime.Now;
                        usuario1.fechaNacimiento = fechaNacimiento;
                        //usuario1.fechaBaja = new DateTime(2999, 12, 31);
                        usuario1.usuario = NombreUsuario;
                        usuario1.contraseña = inputContra;
                        usuario1.fechacontraseña = DateTime.Today;
                        met.CrearUsuarioLista(usuario1);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar el alta de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
