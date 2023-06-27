using System;

namespace Clases
{
    public abstract class Producto
    {
        public string nombre {get; set;}
        public double precio { get; set;}

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public abstract double calcularImpuesto();
        public abstract double calcularTotal();

    }
}