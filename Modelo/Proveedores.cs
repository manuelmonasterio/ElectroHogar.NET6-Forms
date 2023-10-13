using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedores
    {
        private Guid _id;
        private int _idCategoria;
        private string _nombre;
        private string _apellido;
        private string _email;
        private int _cuit;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;
        private string _estado;
        

        public Guid Id { get => _id; set => _id = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Email { get => _email; set => _email = value; }
        public int Cuit { get => _cuit; set => _cuit = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja1 { get => _fechaBaja; set => _fechaBaja = value; }
        public string Estado { get => _estado; set => _estado = value; }

        override
        public String ToString() => Cuit + " " + Nombre + " " + Apellido;


    }
}
