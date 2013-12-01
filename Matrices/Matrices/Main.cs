using System;

namespace Matrices
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[5]; /* Inicialización indicando el numero de elementos */

            int[] array2 = new int[] { 1, 3, 5, 7, 9 }; /* Declarando los elementos */

            int[] array3 = { 1, 2, 3, 4, 5, 6 }; /* Sintaxis simplificada */

            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char letraA = vocales [0];
            char letraU = vocales [4];
            //char error = vocales [5]; /* Se dispara el error “IndexOutOfRangeException” porque el elemento nº5, empezando en 0, no existe*/

            string[] frases = new string[4];
            frases[0] = "javi calvo";
            frases[1] = "delegado hijo de puta";
            frases[2] = "rubalcaba conservador";
            frases[3] = "maria tiscar";

            Console.WriteLine(frases[3]);

            Console.ReadKey();
        }
    }
}
