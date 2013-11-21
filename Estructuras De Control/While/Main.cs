using System;

namespace TablaDel6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 1; 

            Console.WriteLine("La tabla del 6"); 
            Console.WriteLine("--------------"); 
            Console.WriteLine(); 
             
            while (n <= 10)
            { 
                Console.WriteLine(6 * n); 
                n = ++n; // Debemos incrementar la variable n 
            } 

            Console.ReadKey(true); //Para que no se nos cierre...
        }
    }
}