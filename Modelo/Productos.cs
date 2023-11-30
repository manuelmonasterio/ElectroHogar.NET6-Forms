using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

public class Productos
{
	public string _nombre { get; set; }
	public Guid _idproducto { get; set; }

    public int _idcategoria { get; set; }
    public Guid _idusuario { get; set; }
    public Guid _idproveedor { get; set; }

    [JsonProperty("id")]
    public string IdString
    {
        get { return _idproducto.ToString(); }
        set
        {
            if (Guid.TryParse(value, out var guidValue))
            {
                _idproducto = guidValue;
            }
            // No establecer el valor predeterminado (Guid.Empty) en caso de error
        }
    }

    [JsonIgnore]
    public Guid IdProductos
    {
        get { return _idproducto; }
        set { _idproducto = value; }
    }

    [JsonProperty("_idu")]
    public string IdUsuarioString
    {
        get { return _idusuario.ToString(); }
        set
        {
            if (Guid.TryParse(value, out var guidValue))
            {
                _idusuario = guidValue;
            }
            // No establecer el valor predeterminado (Guid.Empty) en caso de error
        }
    }

    [JsonIgnore]
    public Guid IdUsu
    {
        get { return _idusuario; }
        set { _idusuario = value; }
    }

    [JsonProperty("_idprov")]
    public string IdProveedorString
    {
        get { return _idproveedor.ToString(); }
        set
        {
            if (Guid.TryParse(value, out var guidValue))
            {
                _idproveedor = guidValue;
            }
            // No establecer el valor predeterminado (Guid.Empty) en caso de error
        }
    }

    [JsonIgnore]
    public Guid IdProv
    {
        get { return _idproveedor; }
        set { _idproveedor = value; }
    }


    public double _precio { get; set; }
    public int _stock { get; set; }
    public int _stockMaximo { get; set; }
    public DateTime _fechaAlta { get; set; }
    public DateTime? _fechaBaja { get; set; }

    public string _estado { get; set; }


    public Guid IdProducto { get => _idproducto; set => _idproducto = value; }
    public string Nombre { get => _nombre; set => _nombre = value; }
    public Guid IdUsuario { get => _idusuario; set => _idusuario = value; }
    public int IdCategoria { get => _idcategoria; set => _idcategoria = value; }
    public Guid IdProveedor { get => _idproveedor; set => _idproveedor = value; }
    public double Precio { get => _precio; set => _precio = value; }
    public int Stock { get => _stock; set => _stock = value; }
    public int StockMaximo { get => _stockMaximo; set => _stockMaximo = value; }
    public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
    public string Estado { get => _estado; set => _estado = value; }

    override public String ToString() => _idproducto + " " + Nombre + " ";

    public Productos()
    {

    }
    public Productos(string Nombre, Guid IdUsuario, int IdCategoria, Guid IdProveedor, double Precio, int Stock, int StockMaximo, DateTime FechaBaja, string Estado)
    {
        _nombre = Nombre;
        _idproducto = IdProducto;
        _idusuario = IdUsuario;
        _idcategoria = IdCategoria;
        _idproveedor = IdProveedor;
        _precio = Precio;
        _stock = Stock;
        _stockMaximo = StockMaximo;
        _fechaAlta = DateTime.Today;
        _fechaBaja = FechaBaja;
        _estado = Estado;
    }
}
