﻿using AccesoDatos;
using Modelo;
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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //vuelve a GestionUsuario
            GestionUsuario formX = new GestionUsuario();
            formX.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //ValidacionesUsuario validacionesUsuario = new ValidacionesUsuario();
            try
            {
                string listaerrores = "";
                string inputNombre = txbNombre.Text.Trim();
                string inputApellido = txbApellido.Text.Trim();
                string inputDireccion = txbDireccion.Text.Trim();
                string inputTelefono = txbTelefono.Text.Trim();
                string inputEmail = txbMail.Text.Trim();
                string inputFechaNacimiento = txbFecNac.Text.Trim();
                DateTime fechaNacimiento = DateTime.Now;
                string inputPerfil = txbPerfil.Text.Trim();
                string inputDni = txbDNI.Text.Trim();
                string NombreUsuario = txbNombreUsuario.Text.Trim();
                string inputContra = txbContrasena2.Text.Trim();
                int perfil = Convert.ToInt32(txbPerfil.Text);
                int dni = Convert.ToInt32(txbDNI.Text);

                listaerrores += ValidacionesForm.ValidarVacio(inputNombre, "Nombre");
                listaerrores += ValidacionesForm.ValidarVacio(inputApellido, "Apellido");
                listaerrores += ValidacionesForm.ValidarVacio(inputDireccion, "Dirección");
                listaerrores += ValidacionesForm.ValidarVacio(inputTelefono, "Teléfono");
                listaerrores += ValidacionesForm.ValidarVacio(inputEmail, "Correo Electrónico");
                listaerrores += ValidacionesForm.ValidarVacio(inputFechaNacimiento, "Fecha de Nacimiento");
                listaerrores += ValidacionesForm.ValidarVacio(inputPerfil, "Perfil");
                listaerrores += ValidacionesForm.ValidarVacio(inputDni, "DNI");
                listaerrores += ValidacionesForm.ValidarVacio(inputContra, "Contraseña");
                listaerrores += ValidacionesForm.ValidarFecha(inputFechaNacimiento);
                listaerrores += ValidacionesUsuario.ValidarNombreUsuario(NombreUsuario, inputNombre, inputApellido, 8, 15);
                listaerrores += ValidacionesUsuario.ValidarContraseña(inputContra);

                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbNombreUsuario.Clear();
                    txbContrasena2.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    MetodosUsuarios met = new MetodosUsuarios();
                    MetodosUsuarios usu = new MetodosUsuarios();
                    UsuarioModelDatos usuario = new UsuarioModelDatos();
                    usuario.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
                    usuario.Host = perfil;
                    usuario.Nombre = inputNombre;
                    usuario.Apellido = inputApellido;
                    usuario.Dni = dni;
                    usuario.Direccion = inputDireccion;
                    usuario.Telefono = inputTelefono;
                    usuario.Email = inputEmail;
                    usuario.FechaNacimiento = fechaNacimiento;
                    usuario.NombreUsuario = NombreUsuario;
                    usuario.Contraseña = inputContra;
                    try
                    {
                        met.CrearUsuario(usuario);
                        //Console.WriteLine("Alta exitosa");
                        MessageBox.Show("Alta exitosa");

                        //tras usuario creado limpia campos y vuelve al menu de gestion de usuarios
                        txbNombre.Clear();
                        txbApellido.Clear();
                        txbDireccion.Clear();
                        txbTelefono.Clear();
                        txbMail.Clear();
                        txbFecNac.Clear();
                        txbPerfil.Clear();
                        txbDNI.Clear();
                        txbNombreUsuario.Clear();
                        txbContrasena2.Clear();
                        this.Hide();
                        GestionUsuario formGestionUsuarios = new GestionUsuario();
                        formGestionUsuarios.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (perfil == 1)
                    {
                        UsuarioModel usuario1 = new Administrador();
                        usuario1.id = new Guid();
                        usuario1.host = perfil;
                        usuario1.nombre = inputNombre;
                        usuario1.apellido = inputApellido;
                        usuario1.dni = dni;
                        usuario1.direccion = inputDireccion;
                        usuario1.telefono = inputTelefono;
                        usuario1.email = inputEmail;
                        usuario1.fechaAlta = DateTime.Now;
                        usuario1.fechaNacimiento = fechaNacimiento;
                        //usuario.fechaBaja = new DateTime(2999, 12, 31);
                        usuario1.usuario = NombreUsuario;
                        usuario1.contraseña = inputContra;
                        usuario1.fechacontraseña = DateTime.Today;
                        met.CrearUsuarioLista(usuario1);

                    }
                    else if (perfil == 2)
                    {
                        UsuarioModel usuario1 = new Supervisores();
                        usuario1.id = new Guid();
                        usuario1.host = perfil;
                        usuario1.nombre = inputNombre;
                        usuario1.apellido = inputApellido;
                        usuario1.dni = dni;
                        usuario1.direccion = inputDireccion;
                        usuario1.telefono = inputTelefono;
                        usuario1.email = inputEmail;
                        usuario1.fechaAlta = DateTime.Now;
                        usuario1.fechaNacimiento = fechaNacimiento;
                        //usuario1.fechaBaja = new DateTime(2999, 12, 31);
                        usuario1.usuario = NombreUsuario;
                        usuario1.contraseña = inputContra;
                        usuario1.fechacontraseña = DateTime.Today;
                        met.CrearUsuarioLista(usuario1);
                    }
                    else if (perfil == 3)
                    {
                        UsuarioModel usuario1 = new Vendedor();
                        usuario1.id = new Guid();
                        usuario1.host = perfil;
                        usuario1.nombre = inputNombre;
                        usuario1.apellido = inputApellido;
                        usuario1.dni = dni;
                        usuario1.direccion = inputDireccion;
                        usuario1.telefono = inputTelefono;
                        usuario1.email = inputEmail;
                        usuario1.fechaAlta = DateTime.Now;
                        usuario1.fechaNacimiento = fechaNacimiento;
                        //usuario1.fechaBaja = new DateTime(2999, 12, 31);
                        usuario1.usuario = NombreUsuario;
                        usuario1.contraseña = inputContra;
                        usuario1.fechacontraseña = DateTime.Today;
                        met.CrearUsuarioLista(usuario1);
                    }
                    else
                    {
                        txbPerfil.Clear();
                        MessageBox.Show("Seleccione un perfil válido");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar el alta de usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
