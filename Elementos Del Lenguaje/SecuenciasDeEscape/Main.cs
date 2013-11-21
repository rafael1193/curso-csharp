using System;

namespace SecuenciasDeEscape
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\'"); // Apóstrofe
            Console.WriteLine("\""); // Comillas
            Console.WriteLine("\\"); // Barra invertida
            Console.WriteLine("\0"); // Caracter NUL
            Console.WriteLine("\a"); // "Beep"
            Console.WriteLine("\b"); // "Borrar"
            Console.WriteLine("\n"); // "Nueva línea" -> separador de linea en Windows y GNU/Linux
            Console.WriteLine("\r"); // "Retorno de carro" -> separador de linea en Mac OS X
            Console.WriteLine("\t"); // Tabulador
            Console.WriteLine("\u1D60"); // Caracter Unicode: Letra griega "fi"

            Console.WriteLine("\"Me gusta programar y poner tabuladores\tcuando\tescribo\"");
            Console.WriteLine("Tambien, escribir e\u00F1es");

            Console.WriteLine(@"D:\Programas\virus.exe");

            Console.ReadKey(true); //Para que no se nos cierre...
        }
    }
}
