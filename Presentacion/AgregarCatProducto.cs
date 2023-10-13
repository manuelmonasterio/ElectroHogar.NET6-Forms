using System;

public class Categorias
{
	public void AgregarCategorias()
	{
		List <CategoriaProducto> categorias = new List <CategoriaProducto>();
        categorias.Add(new CategoriaProducto { Id = 1, Nombre = "Audio" });
        categorias.Add(new CategoriaProducto { Id = 2, Nombre = "Celulares" });
        categorias.Add(new CategoriaProducto { Id = 3, Nombre = "Electro Hogar" });
        categorias.Add(new CategoriaProducto { Id = 4, Nombre = "Informática" });
        categorias.Add(new CategoriaProducto { Id = 5, Nombre = "Smart TV" });

    }
    public void MostrarCategoriasProducto()
    {
        foreach (var categoria in categorias)
        {
            Console.WriteLine($"ID: {categoria.Id}, Nombre: {categoria.Nombre}");
        }
    }
}
