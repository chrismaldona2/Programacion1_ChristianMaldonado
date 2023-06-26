using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Clases
{
    public class CarritoDeCompras
    {
        private static List<Producto> listaCarrito = new List<Producto>();
        public static void verProductos()
        {
            decimal precioTotal = 0;
            Console.WriteLine("\n\n============= LISTA DE PRODUCTOS - CARRITO =============\n");
            Console.WriteLine("    PRODUCTOS:");
            if (listaCarrito.Count == 0)
            {
                Console.WriteLine("\n        No hay productos añadidos en el carrito.");
            }
            else
            {
                foreach (var producto in listaCarrito)
                {
                    Console.WriteLine($"        ID: {producto.idProducto}");
                    Console.WriteLine($"        Nombre : {producto.nombre}");
                    Console.WriteLine($"        Precio: {producto.precio:c}\n");
                    precioTotal += producto.precio;
                }
                Console.WriteLine($"    TOTAL: {precioTotal:c}");
            }
            Console.WriteLine("\n========================================================\n\n");
            
        }

        public static void agregarProducto()
        {
            Console.WriteLine("\n\n================== CARRITO DE COMPRAS ==================\n");
            Console.WriteLine("              ¿Que producto desea agregar?              \n");
            Console.WriteLine("Id del producto: ");
            int id = int.Parse(Console.ReadLine());
            var producto = comprobarProducto(id, Producto.listaProductos());
            if (producto != null)
            {
                listaCarrito.Add(producto);
                Console.WriteLine("Producto exitosamente agregado al carrito.");
            }
            else
            {
                Console.WriteLine("No se ha encontrado el producto especificado.");
            }
            Console.WriteLine("\n========================================================\n\n");
        }

        public static void eliminarProducto()
        {
            Console.WriteLine("\n\n================== CARRITO DE COMPRAS ==================\n");
            Console.WriteLine("        ¿Que producto desea eliminar del carrito?       \n");
            Console.WriteLine("Id del producto: ");
            int id = int.Parse(Console.ReadLine());
            var producto = comprobarProducto(id, listaCarrito);
            if (producto != null)
            {
                listaCarrito.Remove(producto);
                Console.WriteLine("Producto exitosamente eliminado del carrito.");
            }
            else
            {
                Console.WriteLine("El producto especificado no ha sido añadido al carrito.");
            }
            Console.WriteLine("\n========================================================\n\n");
        }

        private static Producto comprobarProducto(int id, List<Producto> lista)
        {
            foreach (var producto in lista)
            {
                if (producto.idProducto == id)
                {
                    return producto;
                }
            }
            return null;
        }

        
    }
}
