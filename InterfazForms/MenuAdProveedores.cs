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
    public partial class MenuAdProveedores : Form
    {
        public MenuAdProveedores()
        {
            InitializeComponent();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaUsuarioProveedor formX = new AltaUsuarioProveedor();
            formX.ShowDialog();
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Muestro el formulario para el perfil Administrador
            MenuAdministrador formAdministrador = new MenuAdministrador(1);
            formAdministrador.ShowDialog();
        }

        private void btnModUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarUsuarioProveedor formX = new ModificarUsuarioProveedor();
            formX.ShowDialog();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            BajaUsuarioProveedor formX = new BajaUsuarioProveedor();
            formX.ShowDialog();
        }
    }
}
