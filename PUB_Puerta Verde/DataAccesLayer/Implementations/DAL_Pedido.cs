using DataAccesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementations
{
    public class DAL_Pedido: IDAL_Pedido
    {
        private readonly DataContext _db;
        public DAL_Pedido(DataContext db)
        {
            _db = db;
        }
    }
}
