using System;

namespace EjercicioEstrControl8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*8. Escribe un programa que cuente el número de bits a 1 
             * que hay en un número entero de tipo int. Por ejemplo,
             * el número 5, que en binario es
             * 00000000000000000000000000000101, tiene
             * 2 bits a 1.*/

            // Recuerda que en C# el tipo de dato int es un entero de 32 bits

            Console.Write("Introduce un número entero: ");

            int numero = int.Parse(Console.ReadLine());

            int unos = 0;

            // Algoritmo 1: desplazando a la izquierda y comprobando el signo 
            // (el MSB de un entero en complemento a 2 es el signo)
            for (int i = 0; i < 32; ++i)
            {
                if ((numero << i) < 0)
                {
                    unos += 1;
                }
            }

            Console.WriteLine("Algoritmo 1");
            Console.WriteLine("-----------");
            Console.Write("Hay ");
            Console.Write(unos);
            Console.WriteLine(" unos ");
            Console.WriteLine();

            //Algoritmo 2: desplazando a la derecha, y con la operación AND sacando el LSB
            unos = 0;
            for (int i = 0; i < 32; ++i)
            {
                if (((numero >> i) & 0x00000001) == 1)
                {
                    unos += 1;
                }
            }

            Console.WriteLine("Algoritmo 2");
            Console.WriteLine("-----------");
            Console.Write("Hay ");
            Console.Write(unos);
            Console.WriteLine(" unos ");
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
