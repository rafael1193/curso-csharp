using System;

namespace EjercicioFunc3
{
    class MainClass
    {
        /* 3. Utiliza el método Factorial del ejercicio anterior para programar
         * otra nueva llamada Combinatoria, que calcule el coeficiente binomial 
         * de dos números.
         */

        public static void Main(string[] args)
        {
            Console.WriteLine(Combinatoria(4, 2));
        }

        public static double Combinatoria(double n, double k)
        {
            if (n >= k)
            {
                return (Factorial(n) / (Factorial(k) * (Factorial(n - k))));
            } else
            {
                return 0;
            }
        }

        public static double Factorial(double n)
        {
            double resultado = 1;

            for (double i = 1; i <= n; ++i)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
