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
    public partial class AltaUsuarioProveedor : Form
    {
        public AltaUsuarioProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdProveedores formX = new MenuAdProveedores();
            formX.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
