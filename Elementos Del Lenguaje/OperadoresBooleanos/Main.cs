using System;

namespace OperadoresBooleanos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool a = false;
            bool b = true;

            System.Console.WriteLine(a && b);
            System.Console.WriteLine(a & b);
            System.Console.WriteLine(a || b);
            System.Console.WriteLine(a | b);
            System.Console.WriteLine(a ^ b);
            System.Console.WriteLine(!a);
        }
    }
}
