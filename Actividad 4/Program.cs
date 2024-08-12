using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    internal class Program
    {
        //Desarrolla un programa que presente un menú interactivo al usuario utilizando un bucle while.
        //El menú debe permitir al usuario elegir entre diferentes opciones, como realizar una operación
        //matemática o salir del programa.
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Recibir un saludo");
                Console.WriteLine("2. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Hola, espero que estés teniendo un bello día.");
                        break;
                    case 2:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta nuevamente.");
                        break;
                }
            } while (opcion != 2);
        }
    }
}
