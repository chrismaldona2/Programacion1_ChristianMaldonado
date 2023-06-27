using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej3
{
    public class Rectangulo : Figura
    {
        private double largo, ancho;
        public Rectangulo(double largo, double ancho) : base("rectangulo")
        {
            this.largo = largo;
            this.ancho = ancho;
        }
        public override double calcularArea()
        {
            return largo * ancho;
        }
    }
}
