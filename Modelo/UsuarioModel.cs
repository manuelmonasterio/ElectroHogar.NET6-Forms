using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

namespace Modelo
{
    abstract public class UsuarioModel
    {
        public int intentoFallido { get; set; } = 0;
        public Guid id { get; set; }

        [JsonProperty("id")]
        public string IdString
        {
            get { return id.ToString(); }
            set
            {
                if (Guid.TryParse(value, out var guidValue))
                {
                    id = guidValue;
                }
                // No establecer el valor predeterminado (Guid.Empty) en caso de error
            }
        }

        [JsonIgnore]
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string usuario { get; set; }
        public Int32 host { get; set; }
        public Int32 dni { get; set; }
        public string contraseña { get; set; }


        public DateTime fechaAlta { get; set; }
        public DateTime fechaBaja { get; set; }
        public DateTime fechacontraseña { get; set; }
        public string estado { get; set; }

        public UsuarioModel(Guid Id, string Nombre, string Apellido, string Direccion, string Telefono, string Email, DateTime FechaAlta, DateTime FechaNacimiento, DateTime FechaBaja, string Usuario, Int32 Host, Int32 Dni, string Contraseña, string Estado)
        {
            id = new Guid();
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

        public void IncrementarIntentoFallido()
        {
            intentoFallido++;
            if (intentoFallido >= 3) 
            {
                DesactivarUsuario();
            }
        }

        public void DesactivarUsuario()
        {
           estado = "INACTIVO";
        }

        public void ResetearIntentoFallido()
        {
            intentoFallido = 0;
        }
    }
}
