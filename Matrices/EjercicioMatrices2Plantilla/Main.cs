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

            /* Requisitos:
             * El programa debe seleccionar una palabra al azar de entre una lista
             * El programa debe dar un número de intentos limitado
             * 
             * Consejo:
             * Empieza por lo mas simple, muestra una palabra aleatoria en pantalla,
             * ve construyendo poco a poco el resto de requisitos. Cuando el programa
             * funcione, ¡ponle gráficos guays!
             */

            string[] palabras = new string[]
            {
                /* rellenar con palabras variadas */
            };

            /* Funciones que necesitarás utilizar: */

            /* Obtener una "palabra" al azar de entre las que hay en "palabras" */
            Random generador = new Random();
            string palabra = palabras[generador.Next(palabras.Length)]; 

            /* El método .ToCharArray() devuelve una matriz de caracteres a partir de un string */
            char[] palabraChar = palabra.ToCharArray(); 

            /*PalabraAHuecos({'c','o','c','h','e'}) ---> {'_','_','_','_','_'} */
            /*PalabraResuelta({'c','o','l','a'}, {'l','c','a'}) ---> true */
            /*Sustituir({'c','o','l','a'}, {'l','c','a'}, 'o') ---> true y ahora letrasAdivinadas es {'l','c','a','o'}*/

            //----------------------------------------------

            while (true /* Mientras la palabra no esté resuelta... */) 
            {
                //
                //Console.WriteLine(palabraOculta); /* ¡Descomenta esta línea solo en las pruebas! */
                //
                Console.WriteLine();
                Console.Write("Escribe una letra: ");
                string entrada = Console.ReadLine();

                /* Recuerda que un `string' es un `char[]' */

                if (true /*Si la palabra es correcta*/)
                {

                } else /*Si no es correcta*/
                {

                }

                Console.WriteLine(/*letrasAdivinadas*/); /* Muestra las letras ya adivinadas */
            }
            /*Una vez que se ha resuelto la palabra...*/
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

        /* Comprueba que "letra" está contenida en "palabraOculta".
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
