using System;

namespace TablaDel6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 0; // Distinto al ejemplo del while

            Console.WriteLine("La tabla del 6");
            Console.WriteLine("--------------");
            Console.WriteLine();
            
            do
            {
                n = ++n;
                Console.WriteLine(6 * n);
                
            } while(n < 10); //¡No olvides el punto y coma!

            Console.ReadKey(true); //Para que no se nos cierre...
        }
    }
}