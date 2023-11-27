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
                else
                {
                    this.Close();
                    //abre formulario correspondiente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar el login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
