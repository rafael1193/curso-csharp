using System;

namespace OperadoresAsignacion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int i = 10;

            i += 5;  // i=15
            i /= 3;  // i=5
            i *= 4;  // i=20
            i >>= 1; // i=10
            System.Console.WriteLine(i);

            /*Ambos códigos son equivalentes*/

            i = 10;

            i = i + 5;  // i=15
            i = i / 3;  // i=5
            i = i * 4;  // i=20
            i = i >> 1; // i=10
            System.Console.WriteLine(i);

            /*Incremento y Decremento*/
            int x = 0;
            int n = 0;
            x = ++n;
            System.Console.WriteLine(x);

            n = 0;
            x = n++;
            System.Console.WriteLine(x);

            /*Expresión compleja con incrementos y decrementos*/
            float y = 0;
            float a = 20;
            float b = 10;
            float d = 4;
            y = (a - b++) * (--b - d) * b++ / (b - d);
            System.Console.WriteLine(y);
        }
    }
}
