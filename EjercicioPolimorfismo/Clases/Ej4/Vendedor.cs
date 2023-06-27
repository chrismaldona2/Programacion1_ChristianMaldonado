using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej4
{
    public class Vendedor : Empleado
    {
        private decimal comision {get;set;}
        public Vendedor(string nombre, decimal salarioBase, decimal comision) : base(nombre, salarioBase, "Vendedor")
        {
            this.comision = comision;
        }
        public override decimal calcularSalario()
        {
            return salarioBase + comision;
        }
    }
}
