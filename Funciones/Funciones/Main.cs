using System;

namespace Funciones
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float num = -3.569F;
            double numAbs = ValorAbsoluto(num); //num, de tipo float, es compatible con double

            Saludar("Antonio");
        }

        public static double ValorAbsoluto(double a)
        {
            if (a >= 0)
                return a;
            else
                return -a;
        }

        private static void Saludar(string nombrePersona)
        {
            System.Console.WriteLine("Hola, " + nombrePersona);
        }
    }
}
