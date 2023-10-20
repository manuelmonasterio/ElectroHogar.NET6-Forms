using System;

public class Productos
{
	public string _nombre { get; set; }
	public Guid _idproducto { get; set; }
    public Guid _idcategoria { get; set; }
    public Guid _idusuario { get; set; }
    public Guid _idproveedor { get; set; }
    public double _precio { get; set; }
    public int _stock { get; set; }
    public DateTime _fechaAlta { get; set; }
    public DateTime _fechaBaja { get; set; }


    public Guid IdProducto { get => _idproducto; set => _idproducto = value; }
    public string Nombre { get => _nombre; set => _nombre = value; }
    public Guid IdUsuario { get => _idusuario; set => _idusuario = value; }
    public Guid IdCategoria { get => _idcategoria; set => _idcategoria = value; }
    public Guid IdProveedor { get => _idproveedor; set => _idproveedor = value; }
    public double Precio { get => _precio; set => _precio = value; }
    public int Stock { get => _stock; set => _stock = value; }
    public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    public DateTime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

    override
       public String ToString() => _idproducto + " " + Nombre + " ";
}
