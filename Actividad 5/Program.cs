using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5
{
    internal class Program
    {
        //Crea un programa que simule el juego de piedra, papel o tijera contra el usuario.
        //El programa debe utilizar un bucle while para repetir el juego hasta que el usuario decida salir.
        static void Main(string[] args)
        {
            string[] opciones = { "piedra", "papel", "tijera" };
            string eleccionUsuario;
            string eleccionComputadora;
            Random random = new Random();
            int eleccionComputadoraIndice;

            do
            {
                Console.WriteLine("Elige piedra, papel o tijera (o escribe 'salir' para terminar):");
                eleccionUsuario = Console.ReadLine().ToLower();

                if (eleccionUsuario != "salir")
                {
                    eleccionComputadoraIndice = random.Next(opciones.Length);
                    eleccionComputadora = opciones[eleccionComputadoraIndice];

                    Console.WriteLine($"La computadora elige: {eleccionComputadora}");

                    if (eleccionUsuario == eleccionComputadora)
                        Console.WriteLine("Es un empate.");
                    else if ((eleccionUsuario == "piedra" && eleccionComputadora == "tijera") ||
                             (eleccionUsuario == "papel" && eleccionComputadora == "piedra") ||
                             (eleccionUsuario == "tijera" && eleccionComputadora == "papel"))
                        Console.WriteLine("¡Ganaste!");
                    else
                        Console.WriteLine("Perdiste.");
                }

            } while (eleccionUsuario != "salir");
        }
    }
}
