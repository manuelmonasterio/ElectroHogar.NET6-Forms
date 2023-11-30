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
    public partial class FormLogin : Form
    {
        public List<UsuarioModel> usuarios = new List<UsuarioModel>();
        public FormLogin()
        {
            InitializeComponent();
            //MetodosUsuarios usu = new MetodosUsuarios();
            UsuarioModel usuario9 = new Administrador();
            UsuarioModel usuario10 = new Supervisores();
            UsuarioModel usuario11 = new Vendedor();
            usuario9 = new Administrador(new Guid(), "Carolina", "Wehner", "Uzal 1234", "1138205055", "carowehner2001@gmail.com", DateTime.Now, new DateTime(2001, 05, 23), new DateTime(2099, 01, 01), "Admini05CW", 1, 43245128, "CAI20232", "Activo");
            usuarios.Add(usuario9);
            usuario10 = new Supervisores(new Guid(), "Evelyn", "Zivano", "Farrel 1234", "1153376046", "evelynzivano@gmail.com", DateTime.Now, new DateTime(1994, 07, 12), new DateTime(2099, 01, 01), "Admini05EZ", 2, 38491201, "CAI20232", "Activo");
            usuarios.Add(usuario10);
            usuario11 = new Vendedor(new Guid(), "Patricio", "Gerenni", "Cochabamba 1234", "1167845556", "patriciogerenni@gmail.com", DateTime.Now, new DateTime(1999, 04, 20), new DateTime(2099, 01, 01), "Admini05PG", 3, 41823861, "CAI20232", "Activo");
            usuarios.Add(usuario11);
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string listaerrores = "";
                string usuario = txbUsuario.Text;
                string contrasena = txbContrasena.Text;
                bool flag = true;

                listaerrores += ValidacionesForm.ValidarVacio(usuario, "Usuario");
                listaerrores += ValidacionesForm.ValidarVacio(contrasena, "Contraseña");

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    MessageBox.Show(listaerrores, "Error");
                    txbUsuario.Clear();
                    txbContrasena.Clear();
                    flag = false;
                }
                else if (flag == true)
                {
                    UsuarioModel usuarioEncontrado = usuarios.FirstOrDefault(n => n.usuario == usuario);
                    if (usuarioEncontrado != null)
                    {
                        if (usuarioEncontrado.contraseña == contrasena)
                        {
                            if (usuarioEncontrado.estado == "Activo")
                            {
                                usuarioEncontrado.ResetearIntentoFallido();
                                if (flag == true && usuarioEncontrado.host == 1)
                                {
                                    //Muestro el formulario para el perfil Administrador
                                    this.Hide();
                                    MenuAdministrador formAdministrador = new MenuAdministrador(usuarioEncontrado.host);
                                    formAdministrador.ShowDialog();
                                }
                                else if (flag == true && usuarioEncontrado.host == 2)
                                {
                                    // Oculto el formulario
                                    this.Hide();

                                    //Muestro el formulario para el perfil Supervisor
                                    MenuSupervisor formSupervisor = new MenuSupervisor(usuarioEncontrado.host);
                                    formSupervisor.ShowDialog();
                                }
                                else if (flag == true && usuarioEncontrado.host == 3)
                                {
                                    this.Hide();

                                    //Muestro el formulario para el perfil Vendedor
                                    MenuVendedor formVendedor = new MenuVendedor(usuarioEncontrado.host);
                                    formVendedor.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El usuario está inactivo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario o la contraseña es incorrecto");
                            txbUsuario.Clear();
                            txbContrasena.Clear();
                            usuarioEncontrado.IncrementarIntentoFallido();
                            if (usuarioEncontrado.estado == "INACTIVO")
                            {
                                MessageBox.Show("Se ha desactivado el usuario debido a 3 intentos fallidos");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña es incorrecto");
                        txbUsuario.Clear();
                        txbContrasena.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña es incorrecto");
                    txbUsuario.Clear();
                    txbContrasena.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar el login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //no tocar
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta luego");
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

