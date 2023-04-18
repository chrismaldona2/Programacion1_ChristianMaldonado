using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Repaso2
{
    internal class Ejercicios
    {
        static void Main(string[] args)
        {
            int codigo = 1;
            double precio;
            int cantidad;
            int cantidad_max = 0;
            int codigo_max = 0;
            int ventas;
            List<(int, double, int)> datos_productos = new List<(int, double, int)>();
            Console.WriteLine("Carga de productos: \n" + "Ingrese 0 para finalizar... \n");
            do
            {
                Console.WriteLine("Ingrese el codigo del producto:");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 0)
                {
                    Console.WriteLine("\nFinalizando carga... \n");
                    break;
                }

                Console.WriteLine("Precio:");
                precio = double.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                cantidad = int.Parse(Console.ReadLine());

                if (cantidad > cantidad_max)
                {
                    cantidad_max = cantidad;
                    codigo_max = codigo;
                }

                Console.WriteLine();
                datos_productos.Add((codigo, precio, cantidad));
            } while (codigo != 0);
            Console.WriteLine("El producto " + codigo_max + " tiene más unidades, con un total de " + cantidad_max + " unidades. \n");

            List<int> productos_sin_stock = new List<int>();
            for (int i = 0;  i < datos_productos.Count; i++)
            {
                Console.WriteLine("Ingrese las ventas del producto " + datos_productos[i].Item1 + ":");
                ventas = int.Parse(Console.ReadLine());
                if ((datos_productos[i].Item3 - ventas) <= 0)
                {
                    productos_sin_stock.Add(datos_productos[i].Item1);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Los productos sin stock son los que tienen código : " + string.Join(", ", productos_sin_stock) + ".");
        }
    }
}
