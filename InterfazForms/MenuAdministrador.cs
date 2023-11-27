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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //vacio
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();

            GestionUsuario formGestionUsuarios = new GestionUsuario();
            formGestionUsuarios.ShowDialog();
        }
    }
}
