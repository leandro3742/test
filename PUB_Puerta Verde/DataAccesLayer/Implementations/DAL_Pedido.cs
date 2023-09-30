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
    public class DAL_Pedido: IDAL_Pedido
    {
        private readonly DataContext _db;
        public DAL_Pedido(DataContext db)
        {
            _db = db;
        }

        public bool set_Cliente(DTPedido dtP)
        {
            Pedidos aux = Pedidos.SetPedido(dtP);
            try
            {
                _db.Pedidos.Add(aux);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
