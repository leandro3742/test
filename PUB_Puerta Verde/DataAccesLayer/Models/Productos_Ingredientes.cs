using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Producto_Ingrediente")]
    [PrimaryKey(nameof(id_Producto), nameof(id_Ingrediente))]
    public class Productos_Ingredientes
    {
        public int id_Producto { get; set; }
        public int id_Ingrediente { get; set; }
    }
}
