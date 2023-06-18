using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.EJ3
{
    public class Gerente : Empleado
    {
        public double bonificación = 10000;
        public Gerente(string nombre, double salario) : base(nombre, salario) { }
        public override double calcularSalario()
        {
            return salario + bonificación;
        }
    }
}
