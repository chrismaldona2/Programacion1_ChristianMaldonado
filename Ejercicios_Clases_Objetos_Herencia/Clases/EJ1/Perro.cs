using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.EJ1
{
    public class Perro : Animal
    {
        public Perro(string nombre = "perro") : base(nombre) { }
        public override void HacerSonido()
        {
            Console.WriteLine($"El perro hace guau.");
        }
    }
}
