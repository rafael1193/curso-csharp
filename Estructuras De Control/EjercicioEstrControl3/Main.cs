using System;

namespace EjercicioEstrControl3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 3. Un año es bisiesto si es divisible entre 4, a menos que sea divisible entre 100. 
             * Sin embargo, si un año es divisible entre 100 y además es divisible entre 400, también resulta bisiesto. 
             * Escribe un programa que muestre si un año es bisiesto. Para comprobar que funciona bien, prueba con los años 0, 400, 1492, 1900, 2000 y 2013
             * ¿Cuantos años bisiestos hay en un siglo?*/
            int unAño = 2013;
            if ((unAño % 4 == 0 && unAño % 100 != 0) || (unAño % 400 == 0))
            {
                Console.WriteLine("El año " + unAño + " si es bisiesto");
            } else
            {
                Console.WriteLine("El año " + unAño + " no es bisiesto");
            }

            // Para saber cuantos años bisiestos hay en un siglo realizamos una iteración sobre todos los años que lo componen
            int añosBisisestos = 0; // Lleva la cuenta del numero de años bisiestos encontrados
            int siglo = 20; // Siglo sobre el que se hace la prueba

            for (int año = (siglo - 1) * 100; año < siglo * 100; ++año)
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    añosBisisestos += 1;
                }
            }

            Console.WriteLine("En el siglo " + siglo.ToString() + " hay " + añosBisisestos + " años bisiestos.");
        }
    }
}
