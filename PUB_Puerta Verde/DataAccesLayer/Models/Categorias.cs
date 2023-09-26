using Domain.DT;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Categoria")]
    public class Categorias
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_Categoria { get; set; }
        public string nombre { get; set; }
        public bool registro_Activo { get; set; }

        public static Categorias SetCategoria(DTCategoria x)
        {
            Categorias aux = new Categorias();

            aux.id_Categoria = x.id_Categoria;
            aux.nombre = x.nombre;
            aux.registro_Activo = true;

            return aux;
        }

        public Categorias GetCategoria()
        {
            Categorias aux = new Categorias();

            aux.id_Categoria = id_Categoria;
            aux.nombre = nombre;
            aux.registro_Activo = registro_Activo;

            return aux;
        }
    }
}
