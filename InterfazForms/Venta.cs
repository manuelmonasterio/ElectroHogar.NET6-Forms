using Modelo;
using Modelo.Exceptions;
using Negocio;
using AccesoDatos;
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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuVendedor formX = new MenuVendedor();
            formX.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
