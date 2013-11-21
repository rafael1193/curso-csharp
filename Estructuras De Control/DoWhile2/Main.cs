using System;

namespace DoWhile2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool correcta = false;

            do
            {
                Console.WriteLine("Contraseña:");
                if (Console.ReadLine() == "seña")
                {
                    correcta = true;
                } else
                {
                    Console.WriteLine("Contraseña errónea...");
                }
            } while (correcta == false);

            Console.WriteLine("¡Contraseña correcta!");
        }
    }
}
