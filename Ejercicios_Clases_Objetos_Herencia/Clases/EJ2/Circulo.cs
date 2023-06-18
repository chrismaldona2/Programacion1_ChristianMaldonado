using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.EJ2
{
    public class Circulo : FiguraGeometrica
    {
        public double radio { get; set; }
        public Circulo(double radio, string nombre = "Circulo") : base(nombre)
        {
            this.radio = radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
