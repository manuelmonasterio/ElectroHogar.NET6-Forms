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
        public MenuProductos()
        {
            InitializeComponent();
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador formX = new MenuAdministrador();
            formX.ShowDialog();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaProducto formX = new AltaProducto();
            formX.ShowDialog();
        }

        //modificar producto
        private void btnProducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarProducto formX = new ModificarProducto();
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
