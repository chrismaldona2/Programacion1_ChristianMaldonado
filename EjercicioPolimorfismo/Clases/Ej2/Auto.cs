using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej2
{
    public class Auto : IVehiculo
    {
        public int id { get; set; }
        public double velocidad { get; set; }
        public void acelerar()
        {
            velocidad += 18;
            Console.Write($"El auto {id} aceleró y ahora su velocidad es de {velocidad}km/h");
        }
    }
}
