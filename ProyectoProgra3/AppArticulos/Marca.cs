using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArticulos
{
    internal class Marca
    {
        //Atributos
        private int id;
        private string descripcion;

        //Constructor
        public Marca(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        //Constructor vacio
        public Marca()
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
