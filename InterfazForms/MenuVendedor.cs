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
    public partial class MenuVendedor : Form
    {
        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void btnRVxV_Click(object sender, EventArgs e)
        {
            this.Hide();
            RVxV formX = new RVxV();
            formX.ShowDialog();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venta formX = new Venta();
            formX.ShowDialog();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaCliente formX = new AltaCliente();
            formX.ShowDialog();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarCliente formX = new ModificarCliente();
            formX.ShowDialog();
        }
    }
}
