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
    public class DAL_ClientePreferencial: IDAL_ClientePreferencial
    {
        private readonly DataContext _db;
        public DAL_ClientePreferencial(DataContext db)
        {
            _db = db;
        }

        bool IDAL_ClientePreferencial.set_Cliente(DTCliente_Preferencial dtCP)
        {
            ClientesPreferenciales aux = ClientesPreferenciales.SetCliente(dtCP);
            try
            {
                _db.ClientesPreferenciales.Add(aux);
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
