using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_7
{
    internal class Program
    {
        //Desarrolla un programa que solicite al usuario que ingrese un número entero positivo hasta que introduzca un valor válido.
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Ingresa un número entero positivo:");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);

            Console.WriteLine($"El número ingresado es: {numero}");

            Console.ReadKey();
        }
    }
}
