using DataAccesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementations
{
    public class DAL_FuncionesExtras: IDAL_FuncionesExtras
    {
        private readonly DataContext _db;
        private IDAL_Casteo _cas;
        public DAL_FuncionesExtras(DataContext db, IDAL_Casteo cas)
        {
            _db = db;
            _cas = cas;
        }

        public DAL_FuncionesExtras()
        {
        }

        bool IDAL_FuncionesExtras.existeCategoria(string nombre)
        {
            return true;
        }
    }
}
