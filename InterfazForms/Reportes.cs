using Modelo;
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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdministrador formX = new MenuAdministrador();
            formX.ShowDialog();
            //if ()
            //{
                //logica para mostrar el menu correspondiente
            //}
        }

        private void btnProdxCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            RPxC formX = new RPxC();
            formX.ShowDialog();
        }

        private void btnVentasxVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            RVxV formX = new RVxV();
            formX.ShowDialog();
        }

        private void btnStockCritico_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSC formX = new RSC();
            formX.ShowDialog();
        }
    }
}
