using System;

namespace EjercicioMatrices2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 2. Programa un juego estilo "Ahorcado", en el que la 
             * máquina debe elegir una palabra de entre las que conoce 
             * para que el jugador la adivine.*/

            string[] palabras = new string[]
            {
                "programa",
                "manzana",
                "libro",
                "murcielago",
                "ñu",
                "ahorcado",
                "casa",
                "electrial",
                "constitucion",
                "suburbio"
            };

            Random generador = new Random();

            /* El método .ToCharArray() devuelve una matriz de caracteres 
             * a partir de un string */
            char[] palabraOculta = palabras [generador.Next(palabras.Length)].ToCharArray();

            /* Las letras no adivinadas son "_" */
            char[] letrasAdivinadas = PalabraAHuecos(palabraOculta);

            Console.WriteLine("Esta es la palabra oculta");
            Console.WriteLine(letrasAdivinadas);

            int intentosResantes = 10; /* Los intentos se acaban ¿eh? */

            while (!PalabraResuelta(palabraOculta,letrasAdivinadas)) /*Mientras la palabra no esté resuelta...*/
            {
                //
                //Console.WriteLine(palabraOculta); /* ¡Descomenta esta línea solo en las pruebas! */
                //
                Console.WriteLine();
                Console.Write("Escribe una letra: ");
                string entrada = Console.ReadLine();
                if (Sustituir(palabraOculta, letrasAdivinadas, entrada [0]/*Hay que poner char, no string*/))
                {
                    Console.WriteLine("Correcto");
                } else
                {
                    intentosResantes -= 1;

                    Console.WriteLine("Esa letra no está.");
                    Console.Write("Te quedan ");
                    Console.Write(intentosResantes);
                    Console.WriteLine(" intentos restantes.");

                    if (intentosResantes <= 0)
                    {
                        /*Si el numero de intentos es menor o igual que cero, sal del bucle*/
                        break;
                    }
                }

                Console.WriteLine(letrasAdivinadas); /* Muestra las letras ya adivinadas */
            }

            if (intentosResantes > 0)
            {
                Console.WriteLine("¡Palabra resuelta!");
            } else /* Si se habían acabado los intentos... */
            {
                Console.Write("¡Perdiste!");
                Console.WriteLine(" La palabra correcta era:");
                Console.WriteLine(palabraOculta);
            }
            Console.ReadKey();

        }

        /* Devuelve un matriz char[] del tamaño de "palabra" rellena con huecos. */
        public static char[] PalabraAHuecos(char[] palabra)
        {
            char[] resultado = new char[palabra.Length];

            for (int i = 0; i < palabra.Length; ++i)
            {
                resultado [i] = '_';
            }

            return resultado;
        }

        /* Comprueba si se ha adivinado "palabraOculta" */
        public static bool PalabraResuelta(char[] palabraOculta, char[] letrasAdivinadas)
        {
            for (int i = 0; i < palabraOculta.Length; ++i)
            {
                if (!(palabraOculta [i] == letrasAdivinadas [i]))
                {
                    /* Si una letra ya no coincide, la palabra no está resuelta */
                    return false;
                }
            }

            return true;
        }

        /* Comprueba que la letra está contenida en "palabraOculta".
         * Si lo está, devuelve "true" y sustituye la letra en "letrasAdivinadas". */
        public static bool Sustituir(char[] palabraOculta, char[] letrasAdivinadas, char letra)
        {
            bool encontrada = false;

            for (int i = 0; i < palabraOculta.Length; ++i)
            {
                if (palabraOculta [i] == letra)
                {
                    letrasAdivinadas [i] = palabraOculta [i];
                    encontrada = true;
                }
            }

            return encontrada;
        }
    }
}
