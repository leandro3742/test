using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Mesa")]
    public class Mesas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_Mesa { get; set; }
        public bool enUso { get; set; }
        public bool registro_Activo { get; set; }
    }
}
