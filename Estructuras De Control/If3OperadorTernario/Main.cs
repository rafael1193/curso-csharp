using System;

namespace If3OperadorTernario
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double temperaturaEbullicion = 100;
            double temperatura = 120;

            System.Console.WriteLine((temperatura >= temperaturaEbullicion) ? "Está hirviendo" : "Continua líquida...");
        }
    }
}
