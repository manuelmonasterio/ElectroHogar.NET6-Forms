using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProveedorModelDatos
    {
        private string _idUsuario;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _cuit;

        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public string CUIT { get => _cuit; set => _cuit = value; }
    }
}
