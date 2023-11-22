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
    public class ProveedoresNegocio
    {
        public List<Proveedores> ListarProveedores()
        {
            return ProveedoresDatos.ListarProveedores();
        }

        public Proveedores BuscarProveedorId(string proveedorId)
        {
            bool flag = false;

            //flag = vd.ValidarID(proveedorId);
            List<Proveedores> proveedores = ProveedoresDatos.ListarProveedores();

            if (flag == true)
            {
                proveedorId = Guid.NewGuid().ToString();
            }
            Guid idGuid;
            if (Guid.TryParse(proveedorId, out idGuid))
            {
                Proveedores proveedorEncontrado = proveedores.Find(p => p.Id == idGuid);
                if (proveedorEncontrado != null)
                {
                    return proveedorEncontrado;
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
        public void CrearProveedor(ProveedorModelDatos proveedor)
        {
            //Este es el idUsuario Master
            proveedor.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ProveedoresDatos.CrearProveedor(proveedor);

        }
        public void ModificarProveedor(string id, string nombre, string apellido, string email, string cuit)
        {
            String idUsuario = ProductosDatos.ModificarProducto(id, nombre, apellido, email, cuit);
        }
        public void BorrarProveedor(string idProveedor)
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ProveedoresDatos.BorrarProveedor(idProveedor, IdUsuarioMaster);
        }

        public void ReactivarProveedor(string idProveedor)
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            ProveedoresDatos.ReactivarProveedor(idProveedor, IdUsuarioMaster);
        }
    }
}
