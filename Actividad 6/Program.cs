using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6
{
    internal class Program
    {
        //Escribe un programa que calcule el factorial de un número ingresado por el usuario utilizando un bucle while.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine());
            int factorial = 1;

            while (numero > 1)
            {
                factorial *= numero;
                numero--;
            }

            Console.WriteLine($"El factorial es: {factorial}");

            Console.ReadKey();
        }
    }
}
