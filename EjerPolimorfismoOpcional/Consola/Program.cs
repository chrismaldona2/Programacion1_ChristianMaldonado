using System;
using Clases;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>();
            productos.Add(new ProductoDigital("Elden Ring PS5 (Digital)", 22999, 44470));
            productos.Add(new ProductoFisico("Heladera Samsung freezer superior Twin Cooling Plus", 347999, 59));
            productos.Add(new ProductoFisico("Samsung Galaxy S23 Ultra", 475999, 0.234));
            productos.Add(new ProductoDigital("God of War: Ragnarok PS5 (Digital)", 21999, 118000));
            productos.Add(new ProductoDigital("EA Sports FIFA 23 PS5 (Digital)", 25000, 44000));
            productos.Add(new ProductoFisico("Samsung Galaxy Buds2 Blanco", 52999, 0.046));
            Console.WriteLine("\n\n============================================================================\n");
            Console.WriteLine("                                 PRODUCTOS");
            Console.WriteLine("\n============================================================================\n\n");
            foreach (var producto in productos)
            {
                Console.WriteLine($"     Nombre: {producto.nombre}");
                Console.WriteLine($"     Precio: {producto.precio:c}");
                Console.WriteLine($"     Impuestos: {producto.calcularImpuesto():c}");
                Console.WriteLine($"     Total con impuestos: {producto.calcularTotal():c}");
                Console.WriteLine();
            }
            Console.WriteLine("\n============================================================================\n");
        }
    }
}