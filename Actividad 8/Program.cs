using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_8
{
    internal class Program
    {
        //Crea un programa que simule un cajero automático. El programa debe permitir al usuario realizar operaciones
        //como consultar saldo, retirar dinero y depositar dinero.
        //El programa debe utilizar bucles while o do-while para controlar el flujo de las operaciones.
        static void Main(string[] args)
        {
            double saldo = 1000;
            int opcion;

            do
            {
                Console.WriteLine("Menú del cajero automático:");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Depositar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Tu saldo actual es: ${saldo}");
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el monto a retirar:");
                        double retiro = double.Parse(Console.ReadLine());
                        if (retiro <= saldo)
                        {
                            saldo -= retiro;
                            Console.WriteLine($"Has retirado ${retiro}. Tu nuevo saldo es: ${saldo}");
                        }
                        else
                            Console.WriteLine("Saldo insuficiente.");
                        break;
                    case 3:
                        Console.WriteLine("Ingresa el monto a depositar:");
                        double deposito = double.Parse(Console.ReadLine());
                        saldo += deposito;
                        Console.WriteLine($"Has depositado ${deposito}. Tu nuevo saldo es: ${saldo}");
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta nuevamente.");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
