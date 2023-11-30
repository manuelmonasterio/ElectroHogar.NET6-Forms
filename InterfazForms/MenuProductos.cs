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
    public partial class MenuProductos : Form
    {
        private int host;
        public MenuProductos(int host)
        {
            InitializeComponent();
            this.host = host;
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            if (host == 1) 
            {
                this.Hide();
                MenuAdministrador formX = new MenuAdministrador(host);
                formX.ShowDialog();
            }
            else if (host == 2)
            {
                this.Hide();
                MenuSupervisor formX = new MenuSupervisor(host);
                formX.ShowDialog();
            }
            else if (host == 3)
            {
                this.Hide();
                MenuVendedor formX = new MenuVendedor(host);
                formX.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error inesperado. \nIntente nuevamente.");
                
            }
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaProducto formX = new AltaProducto(host);
            formX.ShowDialog();
        }

        //modificar producto
        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarProducto formX = new ModificarProducto(host);
            formX.ShowDialog();
        }

        private void btnBajaProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            BajaProducto formX = new BajaProducto();
            formX.ShowDialog();
        }
    }
}
