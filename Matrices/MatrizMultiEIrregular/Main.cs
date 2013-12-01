using System;

namespace MatrizMultiEIrregular
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Matriz multidimensional
            int[,] mapaMulti = new int [3, 2]; /* Matriz “mapa” de 3 unidades de alto y 2 de ancho */
            mapaMulti [2, 1] = 137;

            // Matriz irregular (jagged)
            int[][] mapaJagged = new int [3][]; /* Matriz “mapa” de 3 unidades de alto */

            /* Como una matriz jagged es una matriz de matrices, para cada elemento de 
             * la matriz principal hay que crearle una matriz interior */
            mapaJagged [0] = new int[3];
            mapaJagged [1] = new int[8];
            mapaJagged [2] = new int[2];

            mapaJagged [2] [1] = -3; //El elemento 1 de la matriz 2
        }
    }
}
