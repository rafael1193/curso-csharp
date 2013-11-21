using System;

namespace EjercicioOper1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*1. ¿Que ocurre cuando se efectúa la operación a XOR a, donde a es un número entero?*/
            int a = 0xFF;
			int b = 3;
            MostrarBits(a);
            int x = a << b;
            MostrarBits(x);
            /* Si se aplica esta operación se obtiene el valor 0.
             * Esto puede parecer trivial, pero tiene aplicación práctica.
             * A bajo nivel, para obtener el valor 0 en el registro de un procesador,
             * en ocasiones se ejecuta más rápido a XOR a con un numero cualquiera, que mover el valor 0.*/

        }

        public static void MostrarBits(int numero)
        {
            for (int i = 0; i < sizeof(int)*8; ++i)
            {
                if ((numero << i) >= 0)
                {
                    System.Console.Write("0");
                } else
                {
                    System.Console.Write("1");
                }
            }
            System.Console.WriteLine();
        }
    }
}
