using DataAccesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementations
{
    public class DAL_Mesa: IDAL_Mesa
    {
        private readonly DataContext _db;
        public DAL_Mesa(DataContext db)
        {
            _db = db;
        }
    }
}
