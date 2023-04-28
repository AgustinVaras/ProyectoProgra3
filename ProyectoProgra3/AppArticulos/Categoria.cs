﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArticulos
{
    internal class Categoria
    {
        //Atributos
        private int id;
        private string descripcion;

        //Constructor
        public Categoria(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        //Constructor vacio
        public Categoria()
        {

        }

        //Propiedades set & get
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
}
