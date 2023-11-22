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
    public class VentasNegocio
    {
        
        public void CrearVenta(VentaModelDatos venta)
        {
            //Este es el idUsuario Master
            cliente.IdUsuario = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            VentaDatos.CrearVenta(venta);
        }

        public void DevolverVenta(string idVenta)
        {
            String IdUsuarioMaster = "D347CE99-DB8D-4542-AA97-FC9F3CCE6969";
            VentaDatos.DevolverVenta(idVenta, IdUsuarioMaster);
        }

    }
}
