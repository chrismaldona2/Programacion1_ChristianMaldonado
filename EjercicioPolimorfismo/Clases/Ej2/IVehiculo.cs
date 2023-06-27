using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej2
{
    public interface IVehiculo
    {
        int id { get; set; }
        double velocidad { get; set; }
        void acelerar();
    }
}
