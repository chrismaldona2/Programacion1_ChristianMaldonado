using System;

namespace Ejercicios1
{
    class mientras_while
    {
        static void Main(string[] args)
        {

            //EJ 1 - EJ 2
            double num = 1;
            double suma = 0;
            int contador = 0;
            Console.WriteLine("Ingrese números positivos:" + "\n    Ingrese 0 para saber la suma y el promedio de los números ingresados.\n");
            while (num != 0)
            {
                num = double.Parse(Console.ReadLine().Replace(".",","));
                if (num > 0)
                {
                    suma += num;
                    contador++;
                }
                else if (num < 0) 
                {
                    Console.WriteLine("\n Por favor, ingrese números positivos... \n");
                }
                else
                {
                    double promedio = suma / contador;
                    Console.WriteLine("\nLa suma total de los números positivos ingresados es " + suma + ".");
                    Console.WriteLine("El promedio es " + promedio + ".\n");
                }
            }

            //EJ 3
            string? nombre = " ";
            contador = 0;
            Console.WriteLine("Ingrese nombres:\n" + "    Cuando finalice presione Enter sin escribir ningun caracter para saber cuantos nombres han sido ingresados.");
            while (nombre != "")
            {
                nombre = Console.ReadLine();
                if (nombre != "")
                {
                    contador++;
                }
            }
            Console.WriteLine("Se han ingresado " + contador + " nombres.\n");
            
            //EJ 4
            double costo = 1;
            int i = 0;
            int cantidad;
            double total;
            double total_final = 0;
            Console.WriteLine("Ingrese el costo de los productos y la cantidad a comprar para determinar un total final:\n" + "    Ingrese costo 0 para finalizar la carga de productos.\n");
            while (costo != 0) 
            {
                Console.WriteLine("Costo - Producto " + (i+1) + ":");
                costo = double.Parse(Console.ReadLine().Replace(".", ","));
                if (costo == 0)
                {
                    break;
                }
                Console.WriteLine("Cantidad a comprar:");
                cantidad = int.Parse(Console.ReadLine());
                total = costo * cantidad;
                total_final += total;
                Console.WriteLine();
            }
            Console.WriteLine("\nEl costo final de todos los productos es $" + total_final + ".\n");

            //EJ 5
            int cantidad_productos;
            total_final = 0;
            Console.WriteLine("Ingrese cuantos productos distintos han sido comprados:");
            cantidad_productos = int.Parse(Console.ReadLine());
            for (i = 0; i < cantidad_productos; i++)
            {
                Console.WriteLine("\nIngrese el precio del producto " + (i + 1) + ":");
                costo = double.Parse(Console.ReadLine().Replace(".",","));
                Console.WriteLine("Cantidad comprada:");
                cantidad = int.Parse(Console.ReadLine());
                total = costo * cantidad;
                total_final += total;
            }
            Console.WriteLine("\nEl costo final de los productos comprados es $" + total_final + ".");
        }
    }
}