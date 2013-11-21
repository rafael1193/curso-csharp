using System;

namespace For2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("La tabla del 6"); 
            Console.WriteLine("--------------"); 
            Console.WriteLine(); 

            /*¡Cuidado con los bucles infinitos!*/
            for (int n = 1; n <=10; n -= 1)
            { 
                Console.WriteLine(6 * n); 
            }
        }
    }
}
