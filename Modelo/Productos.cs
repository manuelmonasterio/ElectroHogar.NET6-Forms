using System;

public class Productos
{
	public string _nombre { get; set; }
	public string _idproducto { get; set; }
    public string _idcategoria { get; set; }
    public string _idusuario { get; set; }
    public string _idproveedor { get; set; }
    public double _precio { get; set; }
    public int _stock { get; set; }
    public datetime _fechaAlta { get; set; }
    public datetime _fechaBaja { get; set; }


    public string IdProducto { get => _idproducto; set => _idproducto = value; }
    public string Nombre { get => _nombre; set => _nombre = value; }
    public string IdUsuario { get => _idusuario; set => _idusuario = value; }
    public string IdCategoria { get => _idcategoria; set => _idcategoria = value; }
    public string IdProveedor { get => _idproveedor; set => _idproveedor = value; }
    public double Precio { get => _precio; set => _precio = value; }
    public int Stock { get => _stock; set => _stock = value; }
    public datetime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
    public datetime FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

    override
       public String ToString() => Id + " " + Nombre + " " + Descripcion;
}
