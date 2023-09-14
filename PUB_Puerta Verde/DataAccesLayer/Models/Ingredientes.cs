using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Ingrediente")]
    public class Ingredientes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_Ingrediente { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        [ForeignKey("Categoria")]
        public int? id_Categoria { get; set; }

    }
}
