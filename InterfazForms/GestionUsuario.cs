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
    public partial class GestionUsuario : Form
    {
        public GestionUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Muestro el formulario para el perfil Administrador
            MenuAdministrador formAdministrador = new MenuAdministrador();
            formAdministrador.ShowDialog();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            AltaUsuario formAltaUsuario = new AltaUsuario();
            formAltaUsuario.ShowDialog();
        }

        private void btnModUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarUsuario formX = new ModificarUsuario();
            formX.ShowDialog();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            BajaUsuario formX = new BajaUsuario();
            formX.ShowDialog();
        }
    }
}
