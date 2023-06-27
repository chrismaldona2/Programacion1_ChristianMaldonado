using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej2
{
    public class Bicicleta : IVehiculo
    {
        public int id { get; set; }
        public double velocidad { get; set; }
        public void acelerar()
        {
            velocidad += 3;
            Console.Write($"El ciclista de la bici {id} peladea más rapido y ahora su velocidad es de {velocidad}km/h");
        }
    }
}
