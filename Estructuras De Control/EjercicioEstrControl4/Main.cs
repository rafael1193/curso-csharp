using System;

namespace EjercicioEstrControl4
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /* 4. Programar también sirve para hacer juegos. Escribe un software que se invente
             * un número para que el jugador lo adivine. Cada vez que el jugador introduzca su
             * hipótesis, la máquina debe responder si el número oculto es mayor o menor.*/

            Random generador = new Random();
            int numeroPensado = generador.Next(101);

            int hipotesis = 0;

            Console.WriteLine("He pensado un número entre 0 y 100. Adivina cual es...");

            while (hipotesis != numeroPensado)
            {
                Console.Write("¿Cual crees que es?: ");
                hipotesis = int.Parse(Console.ReadLine());

                if (numeroPensado < hipotesis)
                {
                    Console.WriteLine("Lo siento, mi número es menor");
                } else if (numeroPensado > hipotesis)
                {
                    Console.WriteLine("Lo siento, mi número es mayor");
                }
            }

            Console.Write("¡Si! ¡Acertaste!");

            Console.ReadKey();
        }
    }
}
