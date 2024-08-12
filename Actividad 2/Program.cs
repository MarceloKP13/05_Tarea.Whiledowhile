using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    internal class Program
    {
        //Crea un programa que utilice un bucle while para contar la cantidad de números pares desde
        //1 hasta un número ingresado por el usuario.
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número:");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;
            int cantidadPares = 0;

            while (contador <= numero)
            {
                if (contador % 2 == 0)
                    cantidadPares++;
                contador++;
            }

            Console.WriteLine($"Cantidad de números pares desde 1 hasta {numero}: {cantidadPares}");

            Console.ReadKey();
        }
    }
}
