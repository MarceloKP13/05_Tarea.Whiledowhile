using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Program
    {
        //Escribe un programa que utilice un bucle do-while para imprimir en la consola
        //una secuencia de números de 10 a 0, de forma decreciente.
        static void Main(string[] args)
        {
            int numero = 10;
            Console.WriteLine($"Secuencia Decreciente:");
            do
            {
                Console.WriteLine(numero);
                numero--;
            } while (numero >= 0);

            Console.ReadKey();
        }
    }
}
