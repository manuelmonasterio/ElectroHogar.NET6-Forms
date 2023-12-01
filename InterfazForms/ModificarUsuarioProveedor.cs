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
    public partial class ModificarUsuarioProveedor : Form
    {
        public ModificarUsuarioProveedor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuAdProveedores formX = new MenuAdProveedores();
            formX.ShowDialog();

        }

        ProveedoresNegocio pn = new ProveedoresNegocio();
        Proveedores proveedor = new Proveedores();
        Proveedores proveedor1 = new Proveedores();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string listaerrores = "";
                string proveedorId = txbIDProveedor.Text.Trim();
                string nuevoNombre = txbNuevoNombre.Text.Trim();
                string nuevoApellido = txbNuevoApellido.Text.Trim();
                string nuevoCuit = txbNuevoCuit.Text.Trim();
                string nuevoEmail = txbNuevoMail.Text.Trim();
                string nuevoEstado = txbNuevoEstado.Text.Trim();
                string mensaje = "";
                bool flag;

                listaerrores += ValidacionesForm.ValidarVacio(proveedorId, "ID Proveedor");
                //listaerrores += ValidacionesForm.ValidarVacio(nuevoNombre, "Nombre");
                //listaerrores += ValidacionesForm.ValidarVacio(nuevoApellido, "Apellido");
                //listaerrores += ValidacionesForm.ValidarVacio(nuevoCuit, "CUIT");
                //listaerrores += ValidacionesForm.ValidarVacio(nuevoEmail, "Email");

                
                if (!string.IsNullOrEmpty(listaerrores))
                {
                    txbIDProveedor.Clear();
                    txbNuevoNombre.Clear();
                    txbNuevoApellido.Clear();
                    txbNuevoCuit.Clear();
                    txbNuevoMail.Clear();
                    txbNuevoEstado.Clear();
                    MessageBox.Show(listaerrores, "Error");
                }
                else
                {
                    Proveedores proveedor1 = pn.BuscarProveedorId(proveedorId);
                    if (proveedor != null)
                    {
                        int cuit = 0;

                        if (!string.IsNullOrWhiteSpace(nuevoNombre))
                        {
                            try
                            {
                                pn.ModificarProveedor(proveedorId, nuevoNombre, proveedor1.Apellido, proveedor1.Email, Convert.ToString(proveedor1.Cuit));
                                mensaje += "Cambio de Nombre exitoso";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(nuevoApellido))
                        {
                            try
                            {
                                pn.ModificarProveedor(proveedorId, proveedor1.Nombre, nuevoApellido, proveedor1.Email, Convert.ToString(proveedor1.Cuit));
                                mensaje += "\nCambio de Apellido exitoso";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(nuevoCuit))
                        {
                            if (nuevoCuit.Length == 11)
                            {
                                flag = true;

                                // Verifica que todos los caracteres del CUIT sean dígitos
                                foreach (char c in nuevoCuit)
                                {
                                    if (!char.IsDigit(c))
                                    {
                                        flag = false;
                                        MessageBox.Show("El CUIT debe contener solo dígitos.");
                                        break;
                                    }
                                }
                            }
                            else if (flag = true)
                            {
                                try
                                {
                                    pn.ModificarProveedor(proveedorId, proveedor1.Nombre, proveedor1.Apellido, proveedor1.Email, nuevoCuit);

                                    mensaje += "\nCambio de CUIT exitoso";
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(nuevoEmail))
                        {
                            try
                            {
                                pn.ModificarProveedor(proveedorId, proveedor1.Nombre, proveedor1.Apellido, nuevoEmail, Convert.ToString(proveedor1.Cuit));

                                mensaje += "\nCambio de Email exitoso";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        if (!string.IsNullOrWhiteSpace(nuevoEstado) && nuevoEstado == "ACTIVO")
                        {
                            try
                            {
                                if (proveedor1.Estado == "INACTIVO")
                                {
                                    proveedor1.Estado = "ACTIVO";
                                    pn.ReactivarProveedor(proveedorId);
                                }
                                else
                                {
                                    MessageBox.Show("El usuario ya está Inactivo");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Hubo un problema al realizar la modificación del estado proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (!string.IsNullOrWhiteSpace(nuevoEstado) && nuevoEstado == "INACTIVO")
                        {
                            try
                            {
                                if (proveedor1.Estado == "ACTIVO")
                                {
                                    proveedor1.Estado = "INACTIVO";
                                    pn.BorrarProveedor(proveedorId);
                                }
                                else
                                {
                                    MessageBox.Show("El usuario ya está Activo");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Hubo un problema al realizar la modificación del estado proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Opción no válida. Inténtalo de nuevo.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado el proveedor");
                    }

                MessageBox.Show(mensaje);

                MessageBox.Show("Datos actualizados del proveedor: " +
                "\nNombre: " + proveedor1.Nombre +
                "\nApellido: " + proveedor1.Apellido +
                "\nCuit: " + proveedor1.Cuit +
                "\nEmail: " + proveedor1.Email +
                "\nEstado: " + proveedor1.Estado);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un problema al realizar la modificación del proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
