namespace Ejercicios1
{
    class para_for
    {
        static void Main(String[] args)
        {
            //EJ 1
            int num;
            int suma = 0;
            Console.WriteLine("Ingrese 5 valores enteros:");
            for (int i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                suma += num;
            }
            Console.WriteLine("\nEl resultado de la suma es " + suma + ".\n");

            //EJ 2
            double num2;
            double suma2 = 0;
            Console.WriteLine("Ingrese 8 números para sacar su promedio:");
            for (int i = 0; i < 8; i++)
            {
                num2 = double.Parse(Console.ReadLine().Replace(".", ","));
                suma2 += num2;
            }
            double promedio = suma2 / 8;
            Console.WriteLine("\nEl promedio de los números ingresados es " + promedio + ".\n");

            //EJ 3
            double costo;
            int cantidad;
            double total;
            double total_final = 0;
            Console.WriteLine("Ingrese el costo y total a comprar de los productos para devolver el total final a pagar:\n");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Ingrese el costo del producto " + i + ":");
                costo = double.Parse(Console.ReadLine().Replace(".", ","));
                Console.WriteLine("Ingrese el total a comprar:");
                cantidad = int.Parse(Console.ReadLine());
                total = costo * cantidad;
                total_final += total;
                Console.WriteLine();
            }
            Console.WriteLine("El costo final de todos los productos es $" + total_final + ".\n");

            //EJ 4
            Console.WriteLine("Ingrese 8 números para determinar el mayor:");
            double mayor = 0;
            for (int i = 0; i < 8; i++)
            {
                num2 = double.Parse(Console.ReadLine().Replace(".", ","));
                if (num2 > mayor)
                {
                    mayor = num2;
                }
            }
            Console.WriteLine("\nEl mayor de los números ingresados es el " + mayor + ".\n");

            //EJ 5
            Console.WriteLine("Ingrese los datos de 5 clientes para determinar quien gasto más:\n");
            mayor = 0;
            double gasto;
            string? nombre;
            string cliente_mayor = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Total gastado:");
                gasto = double.Parse(Console.ReadLine().Replace(".", ","));
                if (gasto  > mayor)
                {
                    mayor = gasto;
                    cliente_mayor = nombre;
                }
                Console.WriteLine();
            }
            Console.WriteLine("El cliente que más gastó fue " + cliente_mayor + " con un gasto de $" + mayor + ".");
        }
    }
}