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
            string nombre = "";
            List<(int, double, int)> datos_productos = new List<(int, double, int)>();

            // EJ 1
            Console.WriteLine("Carga de productos: \n" + "Evite reingresar el mismo codigo.\n" + "Ingrese 0 para finalizar... \n");
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

            // EJ 2
            List<int> productos_sin_stock = new List<int>();
            List<int> productos_con_menos_de_10_ventas = new List<int>(); //EJ 3
            Console.WriteLine("Registro de ventas: \n" + "Ingrese 0 para finalizar...\n");
            do
            {
                Console.WriteLine("Ingrese el código del producto:");
                codigo = int.Parse(Console.ReadLine());
                if (codigo != 0)
                {
                    for (int i = 0; i <  datos_productos.Count() ; i++)
                    {
                        if (codigo == datos_productos[i].Item1)
                        {
                            Console.WriteLine("Ingrese las ventas que tuvo:");
                            ventas = int.Parse(Console.ReadLine());
                            if (datos_productos[i].Item3 - ventas <= 0)
                            {
                                productos_sin_stock.Add(codigo);
                            }
                            //EJ 3
                            if (ventas < 10)
                            {
                                productos_con_menos_de_10_ventas.Add(codigo);
                            }
                        }
                    }
                }
                Console.WriteLine();
            } while (codigo != 0);
            Console.WriteLine("Los productos sin stock son los que tienen código : " + string.Join(", ", productos_sin_stock) + ".\n");
            // EJ 3

            List<string> nombres_productos_con_menos_de_10_ventas = new List<string>();
            Console.WriteLine("Carga de nombres:");
            for (int i = 0; i < datos_productos.Count(); i++)
            {
                Console.WriteLine("Ingrese el nombre del producto con codigo " + datos_productos[i].Item1 + ":");
                nombre = Console.ReadLine();
                if (productos_con_menos_de_10_ventas.Contains(datos_productos[i].Item1)){
                    nombres_productos_con_menos_de_10_ventas.Add(nombre);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Los productos con menos de 10 ventas fueron: " + string.Join(", ", nombres_productos_con_menos_de_10_ventas) + ".\n");
        }
    }
}
