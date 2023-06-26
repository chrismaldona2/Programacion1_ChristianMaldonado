using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro : Producto
    {
        public string autor { get; set; }
        public string genero { get; set; }
        public int nroPaginas { get; set; }

    }
}
