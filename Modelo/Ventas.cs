using System;
using System.Net;

public class Ventas
{
	public string _idventa { get; set; }
	public string _idproducto { get; set; }
	public string _idcliente { get; set; }
	public string _idusuario { get; set; }
	public int _cantidad { get; set; }
	public string _estado { get; set; }
	public DateTime _fechaAlta { get; set; }

	public string IdVenta { get => _idventa; set => _idventa = value; }
    public string IdProducto { get => _idproducto; set => _idproducto = value; }
	public string IdCliente { get => _idcliente; set => _idcliente = value; }
	public string IdUsuario { get => _idusuario; set => _idusuario = value; }
	public int Cantidad { get => _cantidad; set => _cantidad = value; }
	public string Estado { get => _estado; set => _estado = value; }
	public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

    public Ventas(string IdVenta, string IdProducto, string IdCliente, string IdUsuario, int Cantidad, string Estado, DateTime FechaAlta)
    {
        _idventa = IdVenta;
        _idproducto = IdProducto;
        _idcliente = IdCliente;
        _idusuario = IdUsuario;
        _cantidad = Cantidad;
        _estado = Estado;
        _fechaAlta = DateTime.Today;         
    }
}
