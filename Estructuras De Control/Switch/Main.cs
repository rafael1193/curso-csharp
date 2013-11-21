using System;

namespace Switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Escribe \"salir\" para salir"); 
            System.Console.WriteLine("Escribe \"entrar\" para entrar");

            string comando = System.Console.ReadLine(); 

            switch (comando)
            { 
                case "salir": 
                    System.Console.WriteLine("Estoy saliendo"); 
                    break; 
                case "entrar": 
                    System.Console.WriteLine("Estoy entrando"); 
                    break; 
                default: 
                    System.Console.WriteLine("No has introducido un comando válido"); 
                    break; 
            }
        }
    }
}
