using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej1
{
    public class Perro : Animal
    {
        public Perro() : base("Perro") { }
        
        public override string hacerSonido()
        {
            return "El perro hace guau.";
        }
    }
}
