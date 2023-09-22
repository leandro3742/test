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
    public class DAL_Ingrediente: IDAL_Ingrediente
    {
        private readonly DataContext _db;
        public DAL_Ingrediente(DataContext db)
        {
            _db = db;
        }

        public List<Ingredientes> getIngrediente()
        {
            return _db.Ingredientes.Select(x => x.GetIngrediente()).ToList();
        }

        public bool set_Ingrediente(DTIngrediente dti)
        {
            Ingredientes aux = Ingredientes.SetIngrediente(dti);
            try
            {
                _db.Ingredientes.Add(aux);
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
