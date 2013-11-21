using System;

namespace EjercicioOper2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* 2. ¿Qué resultados se obtienen al realizar las operaciones siguientes? 
             * Si hay errores en la compilación, corríjelos y da una explicación de por qué suceden.*/
            int a = 10, b = 3, d, e;
            bool c;
            float x, y;
            x = a / b;
            c = a < b; //c ha sido declarado como int y se intenta usar como bool
            d = a + b++;
            e = ++a - b;
            y = (float)a / b;
        }
    }
}
