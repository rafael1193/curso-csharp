using System;

namespace AmbitoDeVariable
{
    class Program
    {
        int altura;

        public void UnaFuncion()
        {
            int anchura;
            if (true)
            {
                int profundidad;
            }

            /*La siguiente línea contiene un error, e impide que el programa se compile y ejecute*/
            // profundidad = 30; //¡¡¡ERROR!!!
        }

        #region Main
        public static void Main(string[] args)
        {
            Program prog = new Program();
            prog.UnaFuncion();
        }
        #endregion
    }
}
