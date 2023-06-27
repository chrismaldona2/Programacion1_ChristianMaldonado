using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej1
{
    public class Gato : Animal
    {
        public Gato() : base("Gato") { }

        public override string hacerSonido()
        {
            return "El gato hace miau.";
        }
    }
}
