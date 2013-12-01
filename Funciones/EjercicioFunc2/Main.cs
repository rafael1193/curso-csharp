using System;

namespace EjercicioFunc2
{
    class MainClass
    {
        /* 2. Escribe una función Factorial, que calcule el factorial de un número.
         * Intenta hacerlo de dos maneras, iterativa y recursiva.*/

        public static void Main(string[] args)
        {
            int numero = 10;

            Console.WriteLine(FactorialIterativo(numero));
            Console.WriteLine(FactorialRecursivo(numero));
        }

        /* Aunque la funcion factorial siempre devuelve un número entero, 
         * su valor crece muy rápido. Usando int o long se desbordaría muy rápido.
         * Es preferible usar double o float porque permite un rango numerico mayor
         * aún siendo a costa de precisión.*/
        public static double FactorialIterativo(double n)
        {
            double resultado = 1;

            for (double i = 1; i <= n; ++i)
            {
                resultado *= i;
            }

            return resultado;
        }

        /* Alternativa de calculo de un factorial.
         * Si llamas a esta función con un valor de entrada grande
         * te ganarás un "Stack Overflow","Desbordamiento de pila" ;D */
        public static double FactorialRecursivo(double n)
        {
            if ((n == 0) || (n == 1))
            {
                return 1;
            } else
            {
                return n * FactorialRecursivo(n - 1);
            }
        }

    }
}
