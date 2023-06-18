using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.EJ2
{
    public class Cuadrado : FiguraGeometrica
    {
        public double ladoCuadrado { get; set; }
        public Cuadrado(double ladoCuadrado, string nombre = "Cuadrado") : base(nombre)
        {   
            this.ladoCuadrado = ladoCuadrado;
        }
        public override double CalcularArea()
        {
            return ladoCuadrado * ladoCuadrado;
        }
    }
}
