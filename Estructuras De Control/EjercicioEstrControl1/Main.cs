using System;

namespace EjercicioEstrControl1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*1. Observa este programa. Hay dos sentencias if y una else. ¿A qué if pertenece el else?*/
            int count = 1;
            if (count < 10) // If nº1
            if ((count % 4) == 2) // If nº2
                System.Console.Write("Una condición\n");
            else
                System.Console.Write("Otra condición\n"); 
            /* Solución:
             * ¡Nunca hagas esto! (Si lo ejecutas, verás que es la 2)
             */
        }
    }
}
