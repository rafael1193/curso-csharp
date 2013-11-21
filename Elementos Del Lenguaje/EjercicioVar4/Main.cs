using System;

namespace EjercicioVar4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*4. A la vista de este programa, ¿que diferencias observas entre los tipos float y double?*/

            float raizFloat = (float)Math.Sqrt(2);
            double raizDouble = Math.Sqrt(2);
            Console.WriteLine(raizFloat);
            Console.WriteLine(raizDouble);
            
            Console.ReadKey(true);
        }
    }
}