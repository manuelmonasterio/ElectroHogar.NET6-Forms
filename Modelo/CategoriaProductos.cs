using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class CategoriaProductos
    {
        public int _idCategoria { get; set; }
        public string _descripcionCategoria { get; set; }

        public int Id { get => _idCategoria; set => _idCategoria = value; }
        public string Descripcion { get => _descripcionCategoria; set => _descripcionCategoria = value; }

        public static List<CategoriaProductos> categorias = new List<CategoriaProductos>();

        public void AgregarCategorias()
        {
            categorias.Add(new CategoriaProductos { _idCategoria = 1, _descripcionCategoria = "Audio" });
            categorias.Add(new CategoriaProductos { _idCategoria = 2, _descripcionCategoria = "Celulares" });
            categorias.Add(new CategoriaProductos { _idCategoria = 3, _descripcionCategoria = "Electro Hogar" });
            categorias.Add(new CategoriaProductos { _idCategoria = 4, _descripcionCategoria = "Informática" });
            categorias.Add(new CategoriaProductos { _idCategoria = 5, _descripcionCategoria = "Smart TV" });
        }

        public void MostrarCategoriasProducto()
        {
            foreach (var categoria in categorias)
            {
                Console.WriteLine($"ID: {categoria.Id}, Nombre: {categoria.Descripcion}");
            }
        }

        public CategoriaProductos BuscarCategoriaId(int IdCategoria)
        {
            return categorias.Find(p => p._idCategoria == IdCategoria); ;
        }
    }

}

