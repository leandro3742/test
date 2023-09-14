using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class ClientePreferencial
    {
        public int id_Cli_Preferencial { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }
        public float saldo { get; set; }

        public ClientePreferencial()
        {
        }

        public ClientePreferencial(int id_Cli_Preferencial, string nombre, string apellido, int telefono, float saldo)
        {
            this.id_Cli_Preferencial = id_Cli_Preferencial;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.saldo = saldo;
        }
    }
}
