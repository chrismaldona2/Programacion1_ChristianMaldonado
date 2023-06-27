using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ej4
{
    public abstract class Empleado
    {
        public string nombre { get; set; }
        public decimal salarioBase { get; set; }
        public string cargo { get; set; }

        public Empleado(string nombre, decimal salarioBase, string cargo)
        {
            this.nombre = nombre;
            this.salarioBase = salarioBase;
            this.cargo = cargo;
        }
        public abstract decimal calcularSalario();
    }
}
