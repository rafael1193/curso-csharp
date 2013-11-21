using System;

namespace Switch2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("¿Que quieres hacer?"); 
            Console.WriteLine("Qu'est-ce que tu veux faire?"); 
            Console.WriteLine("What do you want to do?"); 

            string command = Console.ReadLine(); 

            switch (command)
            { 
                case "salir": 
                case "sortir": 
                case "exit": 
                    Console.WriteLine("Adiós"); 
                    break; 
                case "entrar": 
                case "entrer": 
                case "enter": 
                    Console.WriteLine("Hola"); 
                    break; 
                default: 
                    Console.WriteLine("Command not found!"); 
                    break; 
            }
        }
    }
}
