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
    public partial class ModificarProducto : Form
    {
        private int host;
        public ModificarProducto(int host)
        {
            InitializeComponent();
            this.host = host;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuProductos formX = new MenuProductos(host);
            formX.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //no tocar
        }
    }
}
