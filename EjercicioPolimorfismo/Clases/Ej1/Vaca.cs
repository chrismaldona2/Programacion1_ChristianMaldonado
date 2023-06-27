using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej1
{
    public class Vaca : Animal
    {
        public Vaca() : base("Vaca") { }
        
        public override string hacerSonido()
        {
            return "La vaca hace muu.";
        }
    }
}
