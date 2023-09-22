using Domain.DT;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        internal static Ingredientes SetIngrediente(DTIngrediente x)
        {
            Ingredientes aux = new Ingredientes();

            aux.id_Ingrediente = x.id_Ingrediente;
            aux.nombre = x.nombre;
            aux.stock = x.stock;
            aux.id_Categoria = x.id_Categoria;

            return aux;
        }

        public Ingredientes GetIngrediente()
        {
            Ingredientes aux = new Ingredientes();

            aux.id_Categoria = id_Categoria;
            aux.nombre = nombre;
            aux.stock = stock;
            aux.id_Categoria = id_Categoria;

            return aux;
        }
    }
}
