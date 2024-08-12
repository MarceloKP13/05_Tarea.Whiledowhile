using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_10
{
    internal class Program
    {
        //Desarrolla un programa que genere contraseñas aleatorias seguras utilizando un bucle while o do-while.
        //La contraseña debe cumplir con ciertos requisitos de longitud, complejidad y caracteres especiales.
        static void Main(string[] args)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            int longitud = 8;
            StringBuilder contrasena = new StringBuilder();
            Random random = new Random();

            do
            {
                contrasena.Clear();
                for (int i = 0; i < longitud; i++)
                {
                    int index = random.Next(caracteres.Length);
                    contrasena.Append(caracteres[index]);
                }
                Console.WriteLine($"Contraseña generada: {contrasena.ToString()}");
            } while (contrasena.Length < longitud);

            Console.ReadKey();
        }
    }
}
