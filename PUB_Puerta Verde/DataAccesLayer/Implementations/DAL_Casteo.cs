using DataAccesLayer.Interface;
using DataAccesLayer.Models;
using Domain.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementations
{
    public class DAL_Casteo : IDAL_Casteo
    {
        DTIngrediente IDAL_Casteo.getDTIngrediente(Ingredientes x)
        {
            DTIngrediente aux = new DTIngrediente();
            aux.id_Ingrediente = x.id_Ingrediente;
            aux.nombre = x.nombre;
            aux.stock = x.stock;
            aux.id_Categoria = x.id_Categoria;

            return aux;
        }

        DTProducto IDAL_Casteo.getDTProducto(Productos c)
        {
            DTProducto aux = new DTProducto();
            aux.id_Producto = c.id_Producto;
            aux.nombre = c.nombre;
            aux.precio = c.precio;
            aux.descripcion = c.descripcion;
            return aux;
        }

        DTCategoria IDAL_Casteo.getDTCategoria(Categorias x)
        {
            DTCategoria aux = new DTCategoria();
            aux.id_Categoria = x.id_Categoria;
            aux.nombre = x.nombre;
            return aux;
        }
    }
}
