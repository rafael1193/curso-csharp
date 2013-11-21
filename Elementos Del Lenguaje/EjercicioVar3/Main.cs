using System;

namespace EjercicioVar3
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*3. Observa este programa:

                int voltaje = 1;
                int intensidad = 10;
                int resistencia = voltaje / intensidad;
                Console.Write(resistencia);
                Console.Write(" ohmios");
                
                Console.ReadKey(true);
            
            Al ejecutarlo obtienes

                0 ohmios

            que no es el resultado que esperas.

            ¿Puedes explicar el por qué? ¿Qué cambios debes hacer para obtener el resultado correcto?*/

            /*Solución*/

            float voltaje = 1;
            float intensidad = 10;
            float resistencia = voltaje / intensidad;
            Console.Write(resistencia);
            Console.Write(" ohmios");
                
            Console.ReadKey(true);
        }
    }
}
