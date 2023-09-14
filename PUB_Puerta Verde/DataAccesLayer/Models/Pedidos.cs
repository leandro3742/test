using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    [Table(name: "Pedido")]
    public class Pedidos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_Pedido { get; set; }
        public float valorPedido { get; set; }
        public PedidoEstado_Pago estadoPago { get; set; }
        public PedidoEstado_Proceso estadoProceso { get; set; }
        public TimeSpan hora_ingreso { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public int numero_movil { get; set; }
        public bool pago { get; set; }
        [ForeignKey("User")]
        public string username { get; set; }
        [ForeignKey("Cliente_Preferencial")]
        public int id_Cli_Preferencial { get; set; }
        [ForeignKey("Mesa")]
        public int id_Mesa { get; set; }
    }
}
