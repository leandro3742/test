﻿using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DT
{
    public class DTCategoria
    {
        public int id_Categoria { get; set; }
        public string nombre { get; set; }
        public List<Ingrediente> ingredientes { get; set; }

        public DTCategoria()
        {
            ingredientes = new List<Ingrediente>();
        }

        public DTCategoria(int id_Categoria, string nombre)
        {
            this.id_Categoria = id_Categoria;
            this.nombre = nombre;
        }
    }
}