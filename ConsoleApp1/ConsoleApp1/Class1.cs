using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double num;
            List<double> numeros = new List<double> { 1, 2, 3, 4};
            num = Convert.ToDouble(Console.ReadLine());
            numeros.Add(num);
            Console.WriteLine("Resultado: \n" + "Los elementos de la lista son: " + string.Join(", ", numeros) + ".");

        }
    }
}
