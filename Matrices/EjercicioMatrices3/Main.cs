using System;

namespace EjercicioMatrices3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 3. Inventa una función que ordene el contenido de una matriz. */

            /* Existen multitudes de algoritmos de ordenación, cada uno con
             * sus ventajas e inconvenientes.
             * En https://es.wikipedia.org/wiki/Algoritmo_de_ordenamiento 
             * puedes ver la variedad que existe*/

            int[] listaDeNumeros = new int[]{6,1,3,51,5 - 1,36,3,-9,0,-13};

            Console.WriteLine("Desordenada:");
            MostrarLista(listaDeNumeros);

            Ordenar(listaDeNumeros);
            Console.WriteLine("Ordenada:");
            MostrarLista(listaDeNumeros);
        }

        /* Ordena "lista" */
        public static void Ordenar(int[] lista)
        {
            int i = 1;
            int j = 2;

            while (i <= lista.Length - 1)
            {
                if (lista [i - 1] <= lista [i])
                {
                    i = j;
                    j += 1;
                } else
                {
                    // Intercambiar lista[i-1] y lista [i]
                    int temp = lista [i - 1];
                    lista [i - 1] = lista [i];
                    lista [i] = temp;

                    i -= 1;
                    if (i == 0)
                    {
                        i = 1;
                    }
                }
            }
        }

        /* Muestra "lista" en la consola*/
        public static void MostrarLista(int[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista [i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
