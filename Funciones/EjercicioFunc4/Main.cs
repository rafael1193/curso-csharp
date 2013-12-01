using System;

namespace EjercicioFunc4
{
    class MainClass
    {
        /* 4. Escribe una función Mayor que, tomando dos números, devuelva el mayor de ellos.
         * Después programa otra función que, usando internamente la función Mayor, devuelva
         * el mayor de 3 números.*/

        public static void Main(string[] args)
        {
            int x = 1;
            int y = 4;
            int z = -3;

            Console.WriteLine(Mayor(x, y, z));
        }

        public static int Mayor(int a, int b)
        {
            if (a > b)
            {
                return a;
            } else if (a < b)
            {
                return b;
            } else
            {
                return 0;
            }
        }

        /* Si, puede haber varios métodos con el mismo nombre siempre que tengan distintos 
         * argumentos, en número o tipo de dato*/
        public static int Mayor(int a, int b, int c)
        {
            return Mayor(Mayor(a, b), c);
        }
    }
}
