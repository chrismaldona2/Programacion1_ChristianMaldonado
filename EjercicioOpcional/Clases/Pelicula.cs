using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pelicula : Producto
    {
        public string director { get; set; }
        public string duracion { get; set; }
        public string genero { get; set; }
        public string idioma { get; set; }
    }
}
