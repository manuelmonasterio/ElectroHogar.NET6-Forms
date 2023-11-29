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
    public partial class MenuSupervisor : Form
    {
        public MenuSupervisor()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuProductos formLogin = new MenuProductos();
            formLogin.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes formLogin = new Reportes();
            formLogin.ShowDialog();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Devoluciones formLogin = new Devoluciones();
            formLogin.ShowDialog();
        }
    }
}
