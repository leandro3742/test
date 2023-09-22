using DataAccesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementations
{
    public class DAL_Producto: IDAL_Producto
    {
        private readonly DataContext _db;
        public DAL_Producto(DataContext db)
        {
            _db = db;
        }
    }
}
