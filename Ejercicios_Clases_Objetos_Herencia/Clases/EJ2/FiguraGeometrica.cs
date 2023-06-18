using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases.EJ2
{
    public abstract class FiguraGeometrica
    {
        public string nombre { get; set; }

        public FiguraGeometrica(string nombre)
        {
            this.nombre = nombre;
        }
        public abstract double CalcularArea();
    }
}
