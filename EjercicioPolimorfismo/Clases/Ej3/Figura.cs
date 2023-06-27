using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej3
{
    public abstract class Figura
    {
        public string nombre;
        public Figura(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract double calcularArea();
    }
}
