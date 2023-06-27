using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej4
{
    public class Gerente : Empleado
    {
        private decimal bono {get; set;}
        public Gerente(string nombre, decimal salarioBase, decimal bono):base(nombre, salarioBase, "Gerente") 
        {
            this.bono = bono;
        }
        public override decimal calcularSalario()
        {
            return salarioBase + bono;
        }
    }
}
