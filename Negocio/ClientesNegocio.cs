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
            return ClientesDatos.ListarProductos();
        }

        public Productos BuscarProductoId(string clienteId)
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
    }
