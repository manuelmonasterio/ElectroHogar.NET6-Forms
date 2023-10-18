using System;

public class Ventas
{
	public string _idventa { get; set; }
	public string _idproducto { get; set; }
	public string _idcliente { get; set; }
	public string _idusuario { get; set; }
	public int _cantidad { get; set; }
	public int _estado { get; set; }
	public Datetime _fechaAlta { get; set; }

	public string IdVenta { get => _idventa; set => _idventa = value; }
    public string IdProducto { get => _idproducto; set => _idproducto = value; }
	public string IdCliente { get => _idcliente; set => _idcliente = value; }
	public string IdUsuario { get => _idusuario; set => _idusuario = value; }
	public int Cantidad { get => _cantidad; set => _cantidad = value; }
	public int Estado { get => _estado; set => _estado = value; }
	public Datetime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
}
