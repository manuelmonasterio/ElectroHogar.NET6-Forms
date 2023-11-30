﻿using System;
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
    public partial class RVxV : Form
    {
        private int host;
        public RVxV(int host)
        {
            InitializeComponent();
            this.host = host;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (host == 3) 
            {
                this.Hide();
                MenuVendedor formX = new MenuVendedor(host);
                formX.ShowDialog();
            }
            else
            {
                this.Hide();
                Reportes formX = new Reportes(host);
                formX.ShowDialog();
            }
        }
    }
}
