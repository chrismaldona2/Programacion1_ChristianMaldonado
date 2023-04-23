using System;

namespace Ejercicios2
{
    class Ejercicios_Variados
    {
        static void Main(string[] args)
        {
            //EJ 1
            int[] codigos = new int[10];
            double[] precios = new double[10];
            int[] stock = new int[10];
            int codigo = 0;
            int indice_mayor = -1;
            int mayor_stock = 0;

            Console.WriteLine("Carga de productos:");
            do
            {
                Console.WriteLine("\nIngrese el codigo del producto:");
                codigo = int.Parse(Console.ReadLine());
                if ((codigo >= 1) && (codigo <= 10))
                {
                    codigos[codigo - 1] = codigo;
                    Console.WriteLine("Ingrese el precio:");
                    precios[codigo - 1] = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad existente:");
                    stock[codigo - 1] = int.Parse(Console.ReadLine());
                    if (stock[codigo - 1] > mayor_stock)
                    {
                        mayor_stock = stock[codigo - 1];
                        indice_mayor = codigo;
                    }
                }
                else if (codigo != 0)
                {
                    Console.WriteLine("\nIncorrecto. Ingrese un codígo de entre 1 y 10.\n");
                }
                else
                {
                    Console.WriteLine("\nFinalizando carga.\n");
                }
            } while (codigo != 0);
            Console.WriteLine("El producto con codígo " + indice_mayor + " cuenta con la mayor cantidad de unidades: " + mayor_stock + ".\n");

            //EJ 2
            int[] ventas = new int[10];
            List<int> codigos_sin_stock = new List<int>();
            Console.WriteLine("Registro de ventas:");
            do
            {
                Console.WriteLine("Ingrese el codígo del producto a registrar:");
                codigo = int.Parse(Console.ReadLine());
                if ((codigos.Contains(codigo) && codigo !=0))
                {
                    Console.WriteLine("Ventas:");
                    ventas[codigo - 1] = int.Parse(Console.ReadLine());
                    if (stock[codigo - 1] - ventas[codigo - 1] <= 0)
                    {
                        codigos_sin_stock.Add(codigo);
                    }
                }
                else if (codigo != 0)
                {
                    Console.WriteLine("\nEl código ingresado no está registrado.");
                }
                else
                {
                    Console.WriteLine("\nFinalizando carga...");
                }
                Console.WriteLine();
            } while(codigo != 0);
            Console.WriteLine("Los productos sin stock son los cuyo código es: " +  string.Join(" - ", codigos_sin_stock) + ".\n");

            //EJ 3
            string?[] nombres = new string[10];
            List <string> ventas_menores = new List<string>();
            Console.WriteLine("Carga de nombres:");
            foreach (int i in codigos) 
            {
                if (i != 0)
                {
                    Console.WriteLine("Ingrese el nombre del producto con código " + i + ":");
                    nombres[i - 1] = Console.ReadLine();

                    if (ventas[i - 1] < 10)
                    {
                        ventas_menores.Add(nombres[i - 1]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Los productos con menos de 10 unidades vendidas fueron: " + string.Join(" - ", ventas_menores) + ".");

        }
    }
}