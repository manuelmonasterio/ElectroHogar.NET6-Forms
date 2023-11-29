using Modelo;
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
    public partial class BajaUsuario : Form
    {
        public BajaUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionUsuario formX = new GestionUsuario();
            formX.ShowDialog();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            string idUsuario = txbIDUsuario.Text;
            bool flag;

            //Console.Write("Ingresar el id del usuario a dar de baja: ");
            //idUsuario = Console.ReadLine();
            ValidacionesDatos validador = new ValidacionesDatos();
            flag = validador.ValidarVacio(idUsuario, "ID Usuario");
            flag = validador.ValidarID(idUsuario);

            if (flag == true)
            {
                Menu menu = new Menu();
                UsuarioModel usuario = menu.BuscarUsuarioID(idUsuario);
                usuario.estado = "INACTIVO";
                MessageBox.Show("Usuario dado de baja correctamente");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
