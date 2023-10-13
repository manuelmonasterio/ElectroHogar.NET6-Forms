using System;

public class Productos
{
	public string _nombre {get; set }
	public string _descripcion { get; set; }
	public string _id { get; set; }

    public string Id { get => _id; set => _id = value; }
    public string Nombre { get => _nombre; set => _nombre = value; }
	public string Descripcion { get => _ descripcion; set => _descripcion = value; }

    override
       public String ToString() => Id + " " + Nombre + " " + Descripcion;
}
