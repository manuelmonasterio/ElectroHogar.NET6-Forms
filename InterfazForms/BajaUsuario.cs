﻿using Modelo;
using Modelo.Exceptions;
using Negocio;
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
            try
            {
                string listaerrores = "";
                string idUsuario = txbIDUsuario.Text;
                bool flag = true;

                listaerrores += ValidacionesForm.ValidarVacio(idUsuario, "ID Usuario");
                listaerrores += ValidacionesForm.ValidarID(idUsuario);

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbIDUsuario.Clear();
                    MessageBox.Show(listaerrores, "Error");
                    flag = false;
                }
                else if (flag == true)
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
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar la baja de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
