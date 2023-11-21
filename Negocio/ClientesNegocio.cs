using AccesoDatos;
using Modelo;
using Modelo.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClientesNegocio
    {
        public List<Clientes> ListarClientes()
        {
            return ClientesDatos.ListarClientes();
        }

        public void CrearCliente(ClienteModelDatos cliente)
        {
            //Este es el idUsuario Master
            cliente.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ClientesDatos.CrearCliente(cliente);
        }

        public static Clientes BuscarClienteId(string clienteId)
        {
            bool flag = false;

            //flag = vd.ValidarID(clienteId);
            List<Clientes> clientes = ClientesDatos.ListarClientes();

            if (flag == true)
            {
                clienteId = Guid.NewGuid().ToString();
            }

            Guid idGuid;
            if (Guid.TryParse(clienteId, out idGuid))
            {
                Clientes clienteEncontrado = clientes.Find(p => p.IdCliente == idGuid);
                if (clienteEncontrado != null)
                {
                    return clienteEncontrado;
                }
                else
                {
                    throw new UsuarioNoEncontradoException(); // Lanzar una excepción personalizada si el usuario no se encuentra.
                }
            }
            else
            {
                throw new FormatoIDInvalidoException(); // Lanzar una excepción personalizada si el formato del ID es inválido.
            }

        }

        public void ModificarCliente(string direccion, string telefono, string email)
        {
            String idUsuario = UsuarioDatos.CambiarContraseña(direccion, telefono, email);
        }

        public void BorrarCliente(string idCliente)
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ClientesDatos.BorrarCliente(idCliente, IdUsuarioMaster);
        }

        public void ReactivarCliente(string idCliente)
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ClientesDatos.ReactivarCliente(idCliente, IdUsuarioMaster);
        }
    }
}
