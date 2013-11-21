using System;

namespace OperadoresBits
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 255;
            int r = 0;
            int m = 32;

            MostrarBits(r);
            r = a & 0xF;  // r=15. Pone a cero todos los bits excepto los 4 menos significativos
            MostrarBits(r);
            r = r | m;    // r=47. Pone a uno los bits de r que estén a 1 en m
            MostrarBits(r);
            r = a & ~0x7; // r=248. Pone a 0 los 3 bits menos significativos de a
            MostrarBits(r);
            r = a >> 7;   // r=1. Desplazamiento a la derecha 7 bits
            MostrarBits(r);
            r = m << 1;   // r=64. Equivale a r = m * 2
            MostrarBits(r);
            r = m >> 1;   // r=16. Equivale a r = m / 2
            MostrarBits(r);
            /* Los desplazamientos de bits son muy utilizados para realizar 
             * la operación 2^n donde n es un número entero.
             * 
             * En un procesador, la operación desplazamiento se realiza en 
             * pocos ciclos de reloj mientras que una exponenciación cualquiera
             * es mucho más costosa.
             */
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
