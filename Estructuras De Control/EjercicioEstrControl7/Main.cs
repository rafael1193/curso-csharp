using System;

namespace EjercicioEstrControl7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 7. Haz un programa que calcule la sucesión de Fibonacci hasta un término que se
             * pueda fijar arbitrariamente. Dale formato a la salida.*/

            /*f_n = f_{n-1} + f_{n-2}*/

            Console.WriteLine("Calculo término que desees de la sucesión de fiboncacci");
            Console.Write("¿Cual quieres?: ");

            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("¡No hay términos negativos!");
            } else if (n == 0)
            {
                Console.WriteLine(1);
            } else if (n == 1)
            {
                Console.WriteLine(1);
            } else
            {
                int termN2 = 1; // Almacena f(n-2)
                int termN1 = 1; // Almacena f(n-1)
                int termN = 2; // Almacena f(n)

                for (int i = 2; i < n; ++i)
                {
                    termN = termN1 + termN2; // f(n) = f(n-1) + f(n-2)
                    termN2 = termN1; // Actualiza el termino f(n-2)
                    termN1 = termN; // Actualiza el termino f(n-1)
                }

                Console.Write("f(");
                Console.Write(n);
                Console.Write(") = ");
                Console.WriteLine(termN);
            }
            Console.ReadKey();
        }
    }
}
