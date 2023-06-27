using System;
using Clases;
using Clases.Ej1;
using Clases.Ej2;
using Clases.Ej3;
using Clases.Ej4;
using Clases.Ej5;

namespace ejPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n=================================================================================================================\n");
            Console.WriteLine("   Ejercicios Polimorfismo - Christian Maldonado");
            Console.WriteLine("\n=================================================================================================================\n");
            Console.WriteLine("     EJERCICIO 1:\n");
            List<Animal> animales = new List<Animal>();
            Perro perro = new Perro();
            Vaca vaca = new Vaca();
            Gato gato = new Gato();
            Animal animal1 = new Animal("rinoceronte");
            animales.Add(perro);
            animales.Add(vaca);
            animales.Add(gato);
            animales.Add(animal1);
            foreach (var animal in animales)
            {
                Console.WriteLine("         " + animal.hacerSonido());
            }

            Console.WriteLine("\n=================================================================================================================\n");
            Console.WriteLine("     EJERCICIO 2:\n");
            List<IVehiculo> vehiculos = new List<IVehiculo>();
            Auto auto1 = new Auto { id = 1, velocidad = 70 };
            Bicicleta bici1 = new Bicicleta { id = 1, velocidad = 8 };
            Auto auto2 = new Auto { id = 2, velocidad = 100 };
            Bicicleta bici2 = new Bicicleta { id = 2, velocidad = 10 };
            vehiculos.Add(auto1);
            vehiculos.Add(auto2);
            vehiculos.Add(bici1);
            vehiculos.Add(bici2);

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo is Auto)
                {
                    Console.WriteLine($"         El auto {vehiculo.id} está yendo a {vehiculo.velocidad}km/h");
                }
                else if (vehiculo is Bicicleta)
                {
                    Console.WriteLine($"         La bici {vehiculo.id} está yendo a {vehiculo.velocidad}km/h");
                }
            }

            Console.WriteLine($"         Todos aceleran.");
            foreach (var vehiculo in vehiculos)
            {
                Console.Write("\n         ");
                vehiculo.acelerar();
            }

            Console.WriteLine("\n\n=================================================================================================================\n");
            Console.WriteLine("     EJERCICIO 3:\n");
            List<Figura> figuras = new List<Figura>();
            Rectangulo rectangulo = new Rectangulo(3, 5);
            Circulo circulo = new Circulo(2);
            figuras.Add(rectangulo);
            figuras.Add(circulo);
            foreach (var figura in figuras)
            {
                Console.WriteLine($"         El area del {figura.nombre} es de: {figura.calcularArea()} cm2.");
            }
            Console.WriteLine("\n=================================================================================================================\n");
            Console.WriteLine("     EJERCICIO 4:\n");
            Console.WriteLine("         EMPLEADOS:");
            List<Empleado> empleados = new List<Empleado>();
            Gerente gerente1 = new Gerente("Jorge Ramirez", 120500, 10800);
            Gerente gerente2 = new Gerente("Pedro Sanchez", 113600, 9400);
            Vendedor vendedor1 = new Vendedor("Ramon Perez", 98750, 5000);
            empleados.Add(gerente1);
            empleados.Add(gerente2);
            empleados.Add(vendedor1);
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"\n         NOMBRE: {empleado.nombre} - CARGO: {empleado.cargo} - SALARIO BASE: {empleado.salarioBase:c} - SALARIO FINAL: {empleado.calcularSalario():c}");
            }

            Console.WriteLine("\n=================================================================================================================\n");
            Console.WriteLine("     EJERCICIO 5:\n");
            List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>();
            Guitarra instrumento1 = new Guitarra();
            Bateria instrumento2 = new Bateria();
            Piano instrumento3 = new Piano();
            instrumentos.Add(instrumento1);
            instrumentos.Add(instrumento2);
            instrumentos.Add(instrumento3);
            foreach (var instrumento in instrumentos)
            {
                Console.WriteLine($"         {instrumento.tocarInstrumento()}");
            }
            Console.WriteLine("\n=================================================================================================================\n");
        }
    }
}