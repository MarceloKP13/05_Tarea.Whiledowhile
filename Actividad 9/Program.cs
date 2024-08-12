using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_9
{
    internal class Program
    {
        //Escribe un programa que elija una palabra aleatoria de un diccionario y le pida al usuario que la adivine.
        //El programa debe utilizar un bucle while para seguir pidiendo intentos hasta que el usuario acierte la palabra.
        static void Main(string[] args)
        {
            string[] palabras = { "manzana", "banana", "naranja", "pera" };
            Random random = new Random();
            string palabraSeleccionada = palabras[random.Next(palabras.Length)];
            string intentoUsuario;

            Console.WriteLine("Adivina la fruta:");

            do
            {
                intentoUsuario = Console.ReadLine();
                if (intentoUsuario != palabraSeleccionada)
                    Console.WriteLine("Incorrecto. Intenta nuevamente:");
                else
                    Console.WriteLine("¡Correcto! Has adivinado la palabra.");
            } while (intentoUsuario != palabraSeleccionada);

            Console.ReadKey();
        }
    }
}
