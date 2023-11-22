using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class VentaModelDatos
    {
        private string _idcliente;
        private string _idusuario;
        private string _idproducto;
        private int _cantidad;

        public string IdCliente { get => _idcliente; set => _idcliente = value; }
        public string IdUsuario { get => _idusuario; set => _idusuario = value; }
        public string IdProducto { get => _idproducto; set => _idproducto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}
