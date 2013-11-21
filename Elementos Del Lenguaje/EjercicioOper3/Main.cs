using System;

namespace EjercicioOper3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 3. Escribe las sentencias necesarias para evaluar 
             * la expresión matemática ax^4+bx^3-cx^2+dx+k con los valores
             * a=5, b=-1,7, c=2, d=3.5, k=3, x=10,5.*/

            double resultado = 0;
            double a = 5, b = -1.7, c = 2, d = 3.5, k = 3, x = 10.5;

            resultado = a * x * x * x * x + b * x * x * x - c * x * x + d * x + k;
            System.Console.WriteLine(resultado);
        }
    }
}
