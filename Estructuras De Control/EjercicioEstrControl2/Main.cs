using System;

namespace EjercicioEstrControl2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 2. Haz una calculadora que pida 2 números y que luego los sume, reste, multiplique o divide, 
             * según quiera el usuario. Sugerencia: para la elección de la operación usa una estructura switch. 
             * Para leer un número desde la consola ejecuta lo siguiente:
             * double entradaNumero = double.Parse(System.Console.ReadLine());
             * Ahora entradaNumero alojará el valor que el usuario ha introducido.*/
            bool salir = false;
            
            System.Console.WriteLine(" _____________ ");
            System.Console.WriteLine("| CALCULADORA |");
            System.Console.WriteLine("|_____________|");
            System.Console.WriteLine();

            while (salir == false)
            {

                System.Console.Write("1er número: ");
                double num1 = double.Parse(System.Console.ReadLine());

                System.Console.Write("2º número: ");
                double num2 = double.Parse(System.Console.ReadLine());

                System.Console.WriteLine();

                System.Console.WriteLine("1 - Suma");
                System.Console.WriteLine("2 - Resta");
                System.Console.WriteLine("3 - Multiplicación");
                System.Console.WriteLine("4 - División");
                System.Console.WriteLine("5 - Módulo");
                System.Console.WriteLine("s - Salir");
                System.Console.WriteLine();
                System.Console.Write("Elige operación [1 - 5, s]: ");
                string operacion = System.Console.ReadLine();

                switch (operacion)
                {
                    case "1":
                        System.Console.WriteLine(num1 + num2);
                        break;
                    case "2":
                        System.Console.WriteLine(num1 - num2);
                        break;
                    case "3":
                        System.Console.WriteLine(num1 * num2);
                        break;
                    case "4":
                        System.Console.WriteLine(num1 / num2);
                        break;
                    case "5":
                        System.Console.WriteLine(num1 % num2);
                        break;
                    case "s":
                        System.Console.WriteLine("Hasta luego");
                        salir = true;
                        break;
                    default:
                        System.Console.WriteLine("Operación errónea");
                        break;
                }

                System.Console.WriteLine();
            }

            /* Posibles mejoras al programa: más operaciones, control de división por cero...*/

        }
    }
}
