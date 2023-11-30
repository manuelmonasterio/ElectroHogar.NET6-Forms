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
    public partial class RSC : Form
    {
        private int host;
        public RSC(int host)
        {
            InitializeComponent();
            this.host = host;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes formX = new Reportes(host);
            formX.ShowDialog();
        }
    }
}
