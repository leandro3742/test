using DataAccesLayer.Interface;
using DataAccesLayer.Models;
using Microsoft.Extensions.Logging;
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
            if (_db.Categorias.Any())
            {
                foreach (Categorias x in _db.Categorias)
                {
                    if (x.nombre.Equals(nombre))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
                return false;
        }

        public bool existeIngrediente(string nombre)
        {
            // Utiliza SingleOrDefault() para buscar un ingrediente por nombre.
            if (_db.Ingredientes.SingleOrDefault(i => i.nombre == nombre) != null)
            {
                return true;
            }
            else
                return false;
        }
    }
}
