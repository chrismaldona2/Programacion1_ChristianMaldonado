using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.EJ3
{
    public class Empleado
    {
        public string nombre { get; set; }
        public double salario { get; set; }

        public Empleado(string nombre, double salario) 
        {
            this.nombre = nombre;
            this.salario = salario;
        }
        public virtual double calcularSalario()
        {
            return salario;
        }
    }
}
