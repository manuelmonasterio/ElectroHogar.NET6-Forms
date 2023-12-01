using Newtonsoft.Json;
using System;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

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
        private string _cuitString;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;
        private string _estado;

        [JsonProperty("id")]
        public string IdString
        {
            get { return _id.ToString(); }
            set
            {
                if (Guid.TryParse(value, out var guidValue))
                {
                    _id = guidValue;
                }
                // No establecer el valor predeterminado (Guid.Empty) en caso de error
            }
        }

        [JsonIgnore]
        public Guid Idp
        {
            get { return _id; }
            set { _id = value; }
        }

        [JsonProperty("idCategoria")]
        public int IdCategoria
        {
            get => _idCategoria;
            set => _idCategoria = value;
        }

        [JsonProperty("nombre")]
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        [JsonProperty("apellido")]
        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        [JsonProperty("email")]
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        [JsonProperty("cuit")]
        public string CuitString
        {
            get { return _cuitString; }
            set
            {
                _cuitString = value;

                if (int.TryParse(value, out var cuitValue))
                {
                    _cuit = cuitValue;
                }
                // Puedes manejar el caso en el que la conversión no sea exitosa de alguna manera
            }
        }

        [JsonIgnore]
        public int Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }

        [JsonProperty("fechaAlta")]
        public DateTime FechaAlta
        {
            get => _fechaAlta;
            set => _fechaAlta = value;
        }

        [JsonProperty("fechaBaja")]
        public DateTime? FechaBaja
        {
            get => _fechaBaja;
            set => _fechaBaja = value;
        }

        [JsonProperty("estado")]
        public string Estado
        {
            get => _estado;
            set => _estado = value;
        }

        override
        public String ToString() => Cuit + " " + Nombre + " " + Apellido;
    }
}
