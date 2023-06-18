using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using Clases.EJ1;
using Clases.EJ2;
using Clases.EJ3;
using Clases.EJ4;
using Clases.EJ5;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJ1
            Console.WriteLine("\n==================================================================================================================\n");
            Console.WriteLine("Ejercicio 1:");
            List<Animal> animales = new List<Animal>();
            animales.Add(new Animal("camello"));
            animales.Add(new Perro());
            animales.Add(new Gato());

            foreach (var animal in animales)
            {
                animal.HacerSonido();
            }

            //EJ2
            Console.WriteLine("\n==================================================================================================================\n");
            Console.WriteLine("Ejercicio 2:");
            List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();
            figuras.Add(new Cuadrado(2));
            figuras.Add(new Circulo(3));
            foreach (var figura in figuras)
            {
                double resultado = figura.CalcularArea();
                Console.WriteLine($"El area del {figura.nombre} es {resultado}.");
            }

            //EJ3
            Console.WriteLine("\n==================================================================================================================\n");
            Console.WriteLine("Ejercicio 3:");
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new Empleado("Ramon Perez", 85300));
            empleados.Add(new Asistente("Jorge Morales", 101750));
            empleados.Add(new Gerente("Lionel Messi", 120470));
            empleados.Add(new Asistente("Marcos Lopez", 105430));
            empleados.Add(new Empleado("Jose García", 88700));
            foreach (var empleado in empleados)
            {
                empleado.salario = empleado.calcularSalario();
                Console.WriteLine($"Nombre: {empleado.nombre} - Salario: ${empleado.salario} - Cargo: {empleado.GetType().Name}");
            }

            //EJ3
            Console.WriteLine("\n==================================================================================================================\n");
            Console.WriteLine("Ejercicio 4:");
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            Motocicleta moto1 = new Motocicleta { marca = "Kawasaki", modelo = "Ninja H2R"};
            Automovil auto1 = new Automovil { marca = "BMW", modelo = "M5" };
            Motocicleta moto2 = new Motocicleta { marca = "Yamaha", modelo = "R7"};
            Motocicleta moto3 = new Motocicleta { marca = "BMW", modelo = "S1000RR" };
            vehiculos.Add (moto1);
            vehiculos.Add(auto1);
            vehiculos.Add(moto2);
            vehiculos.Add(moto3);
            Console.WriteLine("VEHICULOS REGISTRADOS:");
            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo is Motocicleta)
                {
                    Console.WriteLine($"Marca: {vehiculo.marca} - Modelo: {vehiculo.modelo} - Tipo: Motocicleta - Cantidad de ruedas: {((Motocicleta)vehiculo).cantRuedas}");
                }
                else if (vehiculo is Automovil)
                {
                    Console.WriteLine($"Marca: {vehiculo.marca} - Modelo: {vehiculo.modelo} - Tipo: Automovil - Cantidad de ruedas: {((Automovil)vehiculo).cantRuedas}");
                }
                else
                {
                    Console.WriteLine($"Marca: {vehiculo.marca} - Modelo: {vehiculo.modelo} - Tipo: Sin especificar - Cantidad de ruedas: Sin especificar");
                }
                
            }

            //EJ5
            Console.WriteLine("\n==================================================================================================================\n");
            Console.WriteLine("Ejercicio 5:");
            List<CuentaBancaria> cuentas = new List<CuentaBancaria>();
            CuentaCorriente cuenta1 = new CuentaCorriente { numeroCuenta = "940328754", saldo = 123405.30, limiteSobregiro = 30000};
            CuentaCorriente cuenta2 = new CuentaCorriente { numeroCuenta = "578493021", saldo = 102543.70, limiteSobregiro = 26000};
            CuentaDeAhorro cuenta3 = new CuentaDeAhorro { numeroCuenta = "782346085", saldo = 345932.50, tasaInteres = 0.02};
            CuentaCorriente cuenta4 = new CuentaCorriente { numeroCuenta = "345068203", saldo = 145093.63, limiteSobregiro = 33500};
            CuentaDeAhorro cuenta5 = new CuentaDeAhorro { numeroCuenta = "678594302", saldo = 253405.26, tasaInteres = 0.05};
            cuentas.Add(cuenta1);
            cuentas.Add(cuenta2);
            cuentas.Add(cuenta3);
            cuentas.Add(cuenta4);
            cuentas.Add(cuenta5);
            Console.WriteLine("CUENTAS:");
            foreach (var cuenta in cuentas)
            {
                if (cuenta is CuentaCorriente)
                {
                    Console.WriteLine($"Número de cuenta: {cuenta.numeroCuenta} - Tipo de cuenta: Cuenta Corriente - Saldo: ${cuenta.saldo} - Límite de sobregiro: ${((CuentaCorriente)cuenta).limiteSobregiro}");
                } else if (cuenta is CuentaDeAhorro)
                {
                    Console.WriteLine($"Número de cuenta: {cuenta.numeroCuenta} - Tipo de cuenta: Cuenta de Ahorro - Saldo: ${cuenta.saldo} - Tasa de interés: {(((CuentaDeAhorro)cuenta).tasaInteres)*100}%");
                }
            }
            Console.WriteLine("\n==================================================================================================================\n");
        }
    }
}
