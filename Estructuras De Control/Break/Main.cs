using System;

namespace Break
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //La tabla del 6 con break 
            Console.WriteLine("La tabla del 6"); 
            Console.WriteLine("--------------"); 
            Console.WriteLine(); 

            for (int n = 1;; ++n)
            { 
                Console.WriteLine(6 * n); 
                if (n == 10)
                { 
                    break; 
                } 
            }
        }
    }
}
