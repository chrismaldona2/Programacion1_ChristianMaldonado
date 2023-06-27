using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProductoFisico : Producto
    {
        public double peso { get; set; }
        public ProductoFisico(string nombre, double precio,  double peso): base(nombre, precio)
        {
            this.peso = peso;
        }
        public override double calcularImpuesto()
        {
            double impuesto = precio * 0.1;
            return impuesto;
        }
        public override double calcularTotal()
        {
            double total = precio + calcularImpuesto();
            return total;
        }
    }
}
