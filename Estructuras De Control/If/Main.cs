using System;

namespace Multometro
{
    class Program
    {
        public static void Main(string[] args)
        {
            double maximoGeneral = 0.25;
            double maximoReducido = 0.15;

            double tasaAlcohol = 0.05;
            bool conductorNobel = false;

            System.Console.WriteLine("¿Te acabas de sacar el carnet? [s/n]:");
            string leido = Console.ReadLine();
            if (leido == "s")
            {
                conductorNobel = true;
            } else
            {
                conductorNobel = false;
            }
            
            System.Console.WriteLine("¿Cuanto has bebido?:");
            tasaAlcohol = double.Parse(Console.ReadLine());

            // También se podría poner como conductorNobel == true
            if (conductorNobel)
            {
                if (tasaAlcohol > maximoReducido)
                {
                    Console.WriteLine("¡Multa!");
                } else // Si no vas borracho
                {
                    Console.WriteLine("Perfecto, puedes continuar");
                }
            } else // Si conductorNobel == false
            {
                if (tasaAlcohol > maximoGeneral)
                {
                    Console.WriteLine("¡Multa!");
                } else // Si no vas borracho
                {
                    Console.WriteLine("Perfecto, puedes continuar");
                }
            }   
            
            Console.ReadKey(true); //Para que no se nos cierre...
        }
    }
}