using System;
using System.Timers;

namespace Ejercicios1
{
    class Do_While
    {
        static void Main(string[] args)
        {
            //EJ 1
            int clave = 0;
            Console.WriteLine("Iniciar sesión: \n");
            do
            {
                Console.WriteLine("Usuario:");
                string usuario = Console.ReadLine();
                Console.WriteLine("Contraseña:");
                clave = int.Parse(Console.ReadLine());
                if (clave != 667788)
                {
                    Console.WriteLine("\nContraseña incorrecta. Vuelva a intentarlo...\n");
                }
                else
                {
                    Console.WriteLine("\nIngresando...\n");
                }
            } while (clave != 667788);

            //EJ 2 - EJ 3
            double num = -1;
            double suma_negativos = 0;
            int contador = 0;
            Console.WriteLine("Ingrese números negativos: \n" + "    Ingrese un número positivo para sacar el promedio de negativos ingresados.\n");
            do
            {
                num = double.Parse(Console.ReadLine().Replace(".", ","));
                if (num < 0)
                {
                    suma_negativos = suma_negativos + num;
                    contador = contador + 1;
                }
                else
                {
                    double promedio = suma_negativos / contador;
                    Console.WriteLine("\nEl promedio de números negativos es: " + promedio + ".\n");
                }
            } while (num < 0);

            //EJ 4 - 5
            Console.WriteLine("Ingrese números de 3 cifras: \n" + "     Ingrese un número mayor o menor a 3 cifras para mostrar el promedio de números con 3 cifras ingresados.\n");
            string? num2 = "123";
            string num2_tres_cifras_check = "123";
            double suma_tres_cifras = 0;
            contador = 0;
            do
            {
                num2 = Console.ReadLine().Replace(".",",");
                num2_tres_cifras_check = num2.Replace("-", "").Replace(",", ""); 
                if (num2_tres_cifras_check.Length == 3)
                {

                    contador = contador + 1;
                    suma_tres_cifras = suma_tres_cifras + double.Parse(num2);
                }
                else
                {
                    double promedio = suma_tres_cifras / contador;
                    Console.WriteLine("\nEl promedio de números de 3 cifras es: " + promedio + ".\n");
                }
            } while (num2_tres_cifras_check.Length == 3);
        }
    }
}
