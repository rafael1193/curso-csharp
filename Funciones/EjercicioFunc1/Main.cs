using System;

namespace EjercicioFunc1
{
    class MainClass
    {
        /* 1. La mayoría del código de los ejercicios del capítulo “Estructuras de control básicas“
         * se puede convertir en métodos. Coge el código de la tabla del 6 y conviértelo en un
         * método, de tal manera que devuelva una cadena de caracteres con la tabla de multiplicar
         * del número que se desee.*/

        public static void Main(string[] args)
        {
            Console.WriteLine(TablaMultiplicar(6));
        }

        public static string TablaMultiplicar(int numero)
        {
            string resultado = "";

            for (int m = 1; m <= 10; m += 1)
            {
                resultado += numero;
                resultado += " x ";
                resultado += m;
                resultado += " = ";
                resultado += numero * m;
                resultado += "\n";
            }

            return resultado;
        }
    }
}
