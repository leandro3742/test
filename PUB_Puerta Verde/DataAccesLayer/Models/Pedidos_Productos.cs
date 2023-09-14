using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Pedido_Producto")]
    [PrimaryKey(nameof(id_Pedido), nameof(id_Producto))]
    public class Pedidos_Productos
    {
        public int id_Pedido { get; set; }
        public int id_Producto { get; set; }
    }
}
