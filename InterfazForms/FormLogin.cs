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

        private void btnLogin_Click(object sender, EventArgs e)
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
                else if (usuario == "Administrador")
                {
                    // Oculto el formulario
                    this.Hide();

                    //Muestro el formulario para el perfil Administrador
                    MenuAdministrador formAdministrador = new MenuAdministrador();
                    formAdministrador.ShowDialog();
                }
                else if (usuario == "Supervisor")
                {
                    // Oculto el formulario
                    this.Hide();

                    //Muestro el formulario para el perfil Supervisor
                    MenuSupervisor formSupervisor = new MenuSupervisor();
                    formSupervisor.ShowDialog();
                }
                else
                {
                    this.Hide();

                    //Muestro el formulario para el perfil Vendedor
                    MenuVendedor formVendedor = new MenuVendedor();
                    formVendedor.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar el login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //no tocar
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego");
            this.Close();
        }
    }
}

