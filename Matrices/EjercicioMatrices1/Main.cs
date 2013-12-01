using System;

namespace EjercicioMatrices1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 1. Escribe una función que tome como entrada una matriz de 
             * dos dimensiones y muestre su contenido en la consola en 
             * forma de tabla*/

            int[,] matriz = new int[,]
            {
                {21,32,49,-3},
                {14,37,56,48},
                {30,90,25,62}
            };

            MostrarMatriz(matriz);
        }

        /* El método .GetLength(n) devuelve el tamaño de la matriz para 
         * la dimensión "n"*/
        public static void MostrarMatriz(int[,] mapa)
        {
            for (int y = 0; y < mapa.GetLength(0); ++y)
            {
                for (int x = 0; x < mapa.GetLength(1); ++x)
                {
                    System.Console.Write(mapa [y, x] + " ");
                }

                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
    }
}
