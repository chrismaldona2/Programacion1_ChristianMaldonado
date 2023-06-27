using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProductoDigital : Producto
    {
        public double tamaño { get; set; }
        public ProductoDigital(string nombre, double precio,  double tamaño): base(nombre, precio)
        {
            this.tamaño = tamaño;
        }
        public override double calcularImpuesto()
        {
            double impuesto = precio * 0.05;
            return impuesto;
        }
        public override double calcularTotal()
        {
            double total = precio + calcularImpuesto();
            return total;
        }
    }
}
