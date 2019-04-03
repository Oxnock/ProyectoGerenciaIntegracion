﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMvcApp.Models.Mauricio
{
    public class Consulta
    {
        private List<Familia> familias;

        public Consulta()
        {

        }

        public Consulta(List<Familia> _familia)
        {
            this.familias = _familia;
        }

        public List<Familia> GetFamilias()
        {
            return this.familias;
        }

        private List<Categoria> categorias;



        public Consulta(List<Categoria> _categorias)
        {
            this.categorias = _categorias;
        }

        public List<Categoria> GetCategorias()
        {
            return this.categorias;
        }
    }
}
