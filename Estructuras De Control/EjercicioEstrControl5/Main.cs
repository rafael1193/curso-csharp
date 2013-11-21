using System;

namespace EjercicioEstrControl5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*5. Escribe un programa que permita a tu ordenador jugar a "Piedra, Papel, Tijeras".*/

            /* Tu ordenador no tiene generador aleatorio de piedras, papeles y tijeras,
             * pero si de números.
             * 
             * Vamos a representar cada estado del juego con un numero
             * 
             * 0 <- piedra
             * 1 <- papel
             * 2 <- tijera
             * 
             * Existe un elemento del lenguaje llamado "enumeración" que se usa para hacer
             * asignaciones como las que acabamos de hacer. No vamos a estudiar en este curso
             * las enumeraciones, pero son muy sencillas.
             * 
             * En http://msdn.microsoft.com/es-es/library/4s1w24dx%28v=vs.90%29.aspx tienes 
             * información sobre como se usan.
             */

            Random gener = new Random();
            int eleccionMaquina = gener.Next(3);

            Console.WriteLine("¿'piedra', 'papel' o 'tijeras'?");
            Console.Write("Tu: ");
            string elecionJugStr = Console.ReadLine();

            int eleccionJugador = -1;

            switch (elecionJugStr)
            {
                case "piedra":
                    eleccionJugador = 0;
                    break;
                case "papel":
                    eleccionJugador = 1;
                    break;
                case "tijeras":
                    eleccionJugador = 2;
                    break;
                default: // Se ha escrito algo distinto a 'piedra', 'papel' o 'tijeras'
                    Console.WriteLine("¿Qué es \"" + elecionJugStr + "\" ?");
                    break;
            }

            if (eleccionJugador >= 0 && eleccionJugador <= 2) // Si el jugador ha elegido bien...
            {
                if (eleccionJugador == 0) // Si jug -> piedra
                {
                    if (eleccionMaquina == 0) // Si maq -> piedra
                    {
                        Console.WriteLine("Ordenador: piedra");
                        Console.WriteLine("=== Empate ===");
                    } else if (eleccionMaquina == 1) // Si maq -> papel
                    {
                        Console.WriteLine("Ordenador: papel");
                        Console.WriteLine("--- Tu pierdes ---");
                    } else if (eleccionMaquina == 2) // Si maq -> tijeras
                    {
                        Console.WriteLine("Ordenador: tijeras");
                        Console.WriteLine("+++ Tu ganas +++");
                    }
                } else if (eleccionJugador == 1) // Si jug -> papel
                {
                    if (eleccionMaquina == 0) // Si maq -> piedra
                    {
                        Console.WriteLine("Ordenador: piedra");
                        Console.WriteLine("+++ Tu ganas +++");
                    } else if (eleccionMaquina == 1) // Si maq -> papel
                    {
                        Console.WriteLine("Ordenador: papel");
                        Console.WriteLine("=== Empate ===");
                    } else if (eleccionMaquina == 2) // Si maq -> tijeras
                    {
                        Console.WriteLine("Ordenador: tijeras");
                        Console.WriteLine("--- Tu pierdes ---");
                    }

                } else if (eleccionJugador == 2) // Si jug -> tijeras
                {
                    if (eleccionMaquina == 0) // Si maq -> piedra
                    {
                        Console.WriteLine("Ordenador: piedra");
                        Console.WriteLine("--- Tu pierdes ---");
                    } else if (eleccionMaquina == 1) // Si maq -> papel
                    {
                        Console.WriteLine("Ordenador: papel");
                        Console.WriteLine("+++ Tu ganas +++");
                    } else if (eleccionMaquina == 2) // Si maq -> tijeras
                    {
                        Console.WriteLine("Ordenador: tijeras");
                        Console.WriteLine("=== Empate ===");
                    }
                }
            }

            /* El sistema para comprobar quien ha ganado es un poco farragoso
             * ¿Alguna idea para mejorarlo?
             */
        }
    }
}
