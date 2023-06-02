using Ejer_con_Lista;
using System;
using System.Collections.Generic;

namespace Ejer_con_Lista
{
    class program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            int cod = 1;
            Console.WriteLine("\nCarga de Clientes: (Ingrese como código '0' para finalizar)\n");
            do
            {
                Console.WriteLine("Codigo del cliente:");
                cod = int.Parse(Console.ReadLine());

                if (cod == 0)
                {
                    break;
                }

                Cliente cliente = new Cliente();
                cliente.cod = cod;

                Console.WriteLine("Nombre completo:");
                cliente.nombre = Console.ReadLine();

                Console.WriteLine("Dirección:");
                cliente.direccion = Console.ReadLine();

                Console.WriteLine("Correo electrónico:");
                cliente.correo = Console.ReadLine();

                cliente.Facturas = new List<float>();

                cliente.Pagos = new List<float>();

                clientes.Add(cliente);
                Console.WriteLine();
            } while (cod != 0);

            Console.WriteLine("\nLista de clientes:\n");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Código: {cliente.cod} - Nombre: {cliente.nombre} - Dirección: {cliente.direccion} - Correo: {cliente.correo}");
            }



            Console.WriteLine("\nCarga de Facturas: (Ingrese como código '0' para finalizar)\n");
            do
            {
                Console.WriteLine("Código del cliente:");
                cod = int.Parse(Console.ReadLine());

                if (cod == 0)
                {
                    break;
                }

                Cliente cliente = clientes.Find(x => x.cod == cod);

                if (cliente != null)
                {
                    Console.WriteLine("Ingrese el monto de la factura: ");
                    float monto = float.Parse(Console.ReadLine());
                    cliente.agregarFactura(monto);
                }
                else
                {
                    Console.WriteLine("\nError - Cliente no encontrado.\n");
                }

                Console.WriteLine();
            } while (cod != 0);


            Console.WriteLine("\nCarga de Pagos: (Ingrese como código '0' para finalizar)\n");
            do
            {
                Console.WriteLine("Código del cliente:");
                cod = int.Parse(Console.ReadLine());

                if (cod == 0)
                {
                    break;
                }

                Cliente cliente = clientes.Find(x => x.cod == cod);

                if (cliente != null)
                {
                    Console.WriteLine("Ingrese el monto pagado: ");
                    float monto = float.Parse(Console.ReadLine());
                    cliente.agregarPago(monto);
                }
                else
                {
                    Console.WriteLine("\nError - Cliente no encontrado.\n");
                }

                Console.WriteLine();
            } while (cod != 0);


            Console.WriteLine("\nClientes con deudas:");
            foreach (Cliente cliente in clientes)
            {
                float deuda = cliente.calcularDeuda();
                if (deuda > 0)
                {
                    Console.WriteLine($"Nombre: {cliente.nombre} - Deuda: {deuda}");
                }
            }

            float deudaMax = 0;
            float pagoMax = 0;
            Cliente clienteMasDebe = null;
            Cliente clienteMasPago = null;
            foreach (Cliente cliente in clientes)
            {
                float deuda = cliente.calcularDeuda();
                float totalPagos = cliente.Pagos.Sum();
                
                if (deuda > deudaMax)
                {
                    clienteMasDebe = cliente;
                }

                if (totalPagos > pagoMax)
                {
                    clienteMasPago = cliente;
                }
            }

            Console.WriteLine("\nCliente que más debe:\n" + $"Nombre: {clienteMasDebe.nombre} - Correo: {clienteMasDebe.correo}");
            Console.WriteLine("\nCliente que más pago:\n" + $"Nombre: {clienteMasPago.nombre} - Correo: {clienteMasPago.correo}");
            Console.WriteLine("\nClientes con más pagos que deudas:\n");
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Pagos.Sum() > cliente.calcularDeuda())
                {
                    Console.WriteLine($"Nombre: {cliente.nombre} - Dirección: {cliente.direccion}");
                }
            }
        }
    }    
}