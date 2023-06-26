using System;
using Clases;

namespace Ejercicio
{
    class ejOpcional
    {
        static void Main(string[] args)
        {
            int? opcion = -1;
            do
            {
                Console.WriteLine("\n\n========================= MENU =========================\n");
                Console.WriteLine("     1. Ver productos\n     2. Carrito de compras\n     0. Salir");
                Console.WriteLine("\n========================================================\n\n");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Producto.verProductos();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        int opcionCarrito = -1;
                        do
                        {
                            Console.WriteLine("\n\n================== CARRITO DE COMPRAS ==================\n");
                            Console.WriteLine("     1. Ver productos del carrito\n     2. Añadir productos al carrito\n     3. Eliminar productos del carrito\n     0. Volver al menú principal");
                            Console.WriteLine("\n========================================================\n\n");
                            opcionCarrito = int.Parse(Console.ReadLine());
                            switch (opcionCarrito)
                            {
                                case 1:
                                    Console.Clear();
                                    CarritoDeCompras.verProductos();
                                    Console.WriteLine("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.Clear();
                                    CarritoDeCompras.agregarProducto();
                                    Console.WriteLine("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Clear();
                                    CarritoDeCompras.eliminarProducto();
                                    Console.WriteLine("Presione una tecla para continuar...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 0:
                                    Console.Clear();
                                    Console.WriteLine("\n\n========================================================\n");
                                    Console.WriteLine("    Volviendo al menú principal...");
                                    break;
                            }
                        } while (opcionCarrito != 0);
                        Console.WriteLine("\n========================================================\n\n");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != 0);
        }
    }
}