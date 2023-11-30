using Modelo;
using Negocio;
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
        private int host;
        public Reportes(int host)
        {
            InitializeComponent();
            this.host = host;
        }

        private void btnVolver_Click(object sender, EventArgs e)
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
         

        }

        private void btnProdxCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            RPxC formX = new RPxC(host);
            formX.ShowDialog();
        }

        private void btnVentasxVendedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            RVxV formX = new RVxV(host);
            formX.ShowDialog();
        }

        private void btnStockCritico_Click(object sender, EventArgs e)
        {
            this.Hide();
            RSC formX = new RSC(host);
            formX.ShowDialog();
        }
    }
}
