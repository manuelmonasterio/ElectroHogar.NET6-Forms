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
    public partial class ModificarUsuario : Form
    {
        private static MetodosUsuarios met = new MetodosUsuarios();
        private static int indiceContraseña = 0;
        public ModificarUsuario()
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
            BorrarUsuario();
            //try
            //{
            //    string listaerrores = "";
            //    string idUsuario = txbNombreUsuario.Text;
            //    bool flag = false;

            //    listaerrores += ValidacionesForm.ValidarVacio(idUsuario, "ID Usuario");
            //    listaerrores += ValidacionesForm.ValidarID(idUsuario);

            //    if (!string.IsNullOrEmpty(listaerrores))
            //    {
            //        txbNombreUsuario.Clear();
            //        MessageBox.Show(listaerrores, "Error");
            //        flag = true;
            //    }
            //    if (flag == false)
            //    {
            //        Menu menu = new Menu();
            //        UsuarioModel usuario = menu.BuscarUsuarioID(idUsuario);
            //        usuario.estado = "INACTIVO";
            //        MessageBox.Show("Usuario dado de baja correctamente");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario no encontrado");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Hubo un problema al realizar la baja de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btnNuevaContra_Click(object sender, EventArgs e)
        {
            CambiarContraseña();
        }
        public UsuarioModel BuscarUsuarioxNombre(string NombreUsuario)
        {

            return Menu.usuarios.Find(u => u.usuario == NombreUsuario);
        }

        public void CambiarContraseña()
        {
            try
            {
                string listaerrores = "";
                string nombreUsuario = txbNombreUsuario.Text.Trim();
                string contraseña;
                string contraseñaNueva = txbNuevaContra.Text.Trim();

                listaerrores += ValidacionesForm.ValidarVacio(nombreUsuario, "Nombre Usuario");
                listaerrores += ValidacionesForm.ValidarVacio(contraseñaNueva, "Nueva Contraseña");

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbNombreUsuario.Clear();
                    txbNuevaContra.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    try
                    {
                        UsuarioModel usuario = BuscarUsuarioxNombre(nombreUsuario);
                        contraseña = usuario.contraseña;
                        met.CambiarContraseña(nombreUsuario, contraseña, contraseñaNueva);
                        contraseña = contraseñaNueva;
                        indiceContraseña = indiceContraseña + 1;
                        MessageBox.Show("Cambio de clave exitoso");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar la modificación de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void BorrarUsuario()
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            string idUsuario = txbIDUsuario.Text;
            try
            {
                string listaerrores = "";

                listaerrores += ValidacionesForm.ValidarVacio(idUsuario, "ID Usuario");

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbIDUsuario.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    UsuarioDatos.BorrarUsuario(idUsuario, IdUsuarioMaster);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar el alta de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnNuevoEstado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En mantenimiento");
            //void cambiarEstado()
            //{
            //    //No esta en la Web Service 
            //}
        }
    }
}
