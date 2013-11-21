using System;

namespace If2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nombre = Console.ReadLine();
            if (nombre == "Antonio")
            {
                Console.WriteLine("Hola " + nombre);
            } else if (nombre == "Pepe")
            {
                Console.WriteLine("Hola " + nombre);
            } else
            {
                Console.WriteLine("Si no eres Antonio ni Pepe, entonces no te concozco :(");
            }
        }
    }
}
