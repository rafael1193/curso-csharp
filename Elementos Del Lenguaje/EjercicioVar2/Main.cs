using System;

namespace EjercicioVar2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*2. Escribe un programa que muestre “HOLA” con letras “de molde” usando *, teniendo en cuenta que cada letra tiene 5 caracteres de ancho y 7 de alto.

            Ejemplo:

            *   *
            *   *
            *   *
            *****
            *   *
            *   *
            *   *   */

            System.Console.WriteLine("*   * ***** *     *****");
            System.Console.WriteLine("*   * *   * *     *   *");
            System.Console.WriteLine("*   * *   * *     *   *");
            System.Console.WriteLine("***** *   * *     *****");
            System.Console.WriteLine("*   * *   * *     *   *");
            System.Console.WriteLine("*   * *   * *     *   *");
            System.Console.WriteLine("*   * ***** ***** *   *");

            /*Otra solución usando @*/
            System.Console.WriteLine(@"*   * ***** *     *****
*   * *   * *     *   *
*   * *   * *     *   *
***** *   * *     *****
*   * *   * *     *   *
*   * *   * *     *   *
*   * ***** ***** *   *"
            );

        }
    }
}
