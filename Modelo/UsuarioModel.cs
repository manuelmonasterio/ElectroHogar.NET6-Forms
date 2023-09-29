using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    abstract public class UsuarioModel
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaBaja { get; set; }
        public string usuario { get; set; }
        public Int32 host { get; set; }
        public Int32 dni { get; set; }
        public string contraseña { get; set; }
        public DateTime fechacontraseña { get; set; }

        public string estado { get; set; }
        public UsuarioModel(string Id, string Nombre, string Apellido, string Direccion, string Telefono, string Email, DateTime FechaAlta, DateTime FechaNacimiento, DateTime FechaBaja, string Usuario, Int32 Host, Int32 Dni, string Contraseña, string Estado)
        {
            id = Id;
            nombre = Nombre;
            apellido = Apellido;
            direccion = Direccion;
            telefono = Telefono;
            email = Email;
            fechaAlta = FechaAlta;
            fechaNacimiento = FechaNacimiento;
            fechaBaja = FechaBaja;
            usuario = Usuario;
            host = Host;
            dni = Dni;
            contraseña = Contraseña;
            fechacontraseña = DateTime.Today;
            estado = Estado;
        }
        public UsuarioModel()
        {
        }

        public List<UsuarioModel> FindAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public bool Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
