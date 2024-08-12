using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Tarea.Whiledowhile
{
    internal class Program
    {
        //Desarrolla un programa que genere un número aleatorio entre 1 y 100 y le pida al usuario que lo adivine.
        //El programa debe utilizar un bucle while para seguir pidiendo intentos hasta que el usuario acierte el número.
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intento = 0;

            Console.WriteLine("Adivina el número entre 1 y 100:");

            while (intento != numeroAleatorio)
            {
                intento = int.Parse(Console.ReadLine());
                if (intento < numeroAleatorio)
                    Console.WriteLine("Demasiado bajo. Intenta nuevamente:");
                else if (intento > numeroAleatorio)
                    Console.WriteLine("Demasiado alto. Intenta nuevamente:");
                else
                    Console.WriteLine("¡Correcto! Has adivinado el número.");
            }

            Console.ReadKey();
        }
    }
}
