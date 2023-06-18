using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.EJ1
{
    public class Gato : Animal
    {
        public Gato(string nombre = "gato") : base(nombre) { }
        public override void HacerSonido()
        {
            Console.WriteLine($"El gato hace miau.");
        }
    }
}
