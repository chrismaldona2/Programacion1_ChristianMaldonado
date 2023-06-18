using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.EJ3
{
    public class Asistente : Empleado
    {
        public double deduccion = 5000;
        public Asistente(string nombre, double salario) : base(nombre, salario) { }
        public override double calcularSalario()
        {
            return salario - deduccion;
        }
    }
}
