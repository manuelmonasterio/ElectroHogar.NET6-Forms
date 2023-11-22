using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ClienteModelDatos
    {
        private string _idUsuario;
        private string _host;
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _direccion;
        private string _telefono;
        private string _email;
        private DateTime _fechaNacimiento;


        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public string Host { get => _host; set => _host = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

    }
}
