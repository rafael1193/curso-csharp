using System;

namespace EjercicioEstrControl6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 6. Mejora el programa que calcula la tabla de multiplicar del 6, 
             * para que muestre las tablas del 1 al 9. Hazlo usando bucles 
             * while y for y formatea la salida.*/

            Console.WriteLine("Tablas de multiplicar");

            int n = 1;
            while (n <= 9)
            {
                Console.WriteLine();
                Console.WriteLine("============"); 
                Console.Write("Tabla del ");
                Console.WriteLine(n);
                Console.WriteLine("------------"); 
                Console.WriteLine(); 

                for (int m = 1; m <= 9; m += 1)
                {
                    Console.Write(n);
                    Console.Write(" x ");
                    Console.Write(m);
                    Console.Write(" = ");
                    Console.Write(n * m);
                    Console.Write("\n");
                }

                n += 1;
            }

        }
    }
}
