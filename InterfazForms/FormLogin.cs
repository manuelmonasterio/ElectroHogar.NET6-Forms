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

namespace InterfazForms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string listaerrores = "";
                string usuario = txbUsuario.Text;
                string contrasena = txbContrasena.Text;

                listaerrores += ValidacionesForm.ValidarVacio(usuario, "Usuario");
                listaerrores += ValidacionesForm.ValidarVacio(contrasena, "Contraseña");

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    MessageBox.Show(listaerrores, "Error");
                }
                else if (string.IsNullOrEmpty(listaerrores))
                {
                    IntentosLogin(usuario); // Llamada al método directamente
                }
                else
                {
                    this.Close();
                    // Abre formulario correspondiente según perfil de usuario logeado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar el login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IntentosLogin(string inputNombreUsuario)
        {
            MetodosUsuarios met = new MetodosUsuarios();
            int contador = 0;
            Login login; // Crear una nueva instancia de Login

            do
            {
                inputNombreUsuario = IngresarUsuarioWindowsForms();
                login = new Login(); // Crear una nueva instancia en cada iteración
                if (login.NombreUsuario != inputNombreUsuario)
                {
                    MessageBox.Show("El nombre de usuario no es el mismo que ingresó anteriormente", "Advertencia");
                    contador--;
                }
                IngresarContraseñaWindowsForms();
                try
                {
                    string idUsuario = met.Login(login);
                    MessageBox.Show($"Login exitoso. El idUsuario es {idUsuario}", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar el login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            } while (contador < 4);

            MessageBox.Show("Usted excedió la cantidad máxima de intentos y su Usuario ha pasado a estado INACTIVO", "Advertencia");
        }

        private string IngresarUsuarioWindowsForms()
        {
            bool flag = false;
            string inputNombreUsuario = "";

            try
            {
                do
                {
                    inputNombreUsuario = txbUsuario.Text;
                    ValidacionesDatos validador = new ValidacionesDatos();
                    flag = validador.ValidarVacio(inputNombreUsuario, "Nombre del Usuario");

                } while (flag == false);
                return inputNombreUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al ingresar el nombre de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "algo sucedió mal";
            }
        }

        private string IngresarContraseñaWindowsForms()
        {
            bool flag = false;
            string inputContraseña = "";
            do
            {
                inputContraseña = txbContrasena.Text;
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputContraseña, "Contraseña");
            } while (flag == false);

            return inputContraseña;
        }
    }
}
