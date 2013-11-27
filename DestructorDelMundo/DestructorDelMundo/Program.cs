using System;
using System.Threading; /*Insertar esta línea para no tener que escribir System.Threading delante de Thread.Sleep(1000)*/

namespace DestructorDelMundo
{
	class Program
	{
		public static void Main(string[] args)
		{
			string respuesta; /*Almacena la respuesa*/
			bool haRespondido = false; /*Almacena si ha respondido a la pregunta*/
			
			Console.BackgroundColor = ConsoleColor.DarkRed; /*Establece que el fondo de las letras será rojo oscuro*/
			Console.ForegroundColor = ConsoleColor.White; /*Establece que las letras serán blancas*/
			Console.Clear(); /*Limpia la pantalla*/
	
			while(haRespondido == false) /*Mientras no responda "s", "y" o "n", repetir la pregunta*/
			{
				Console.Write("¿Quieres destruir el mundo? ");
				respuesta = Console.ReadLine();	/*Lee lo introducido por el usuario*/
				switch (respuesta) { /*Realiza una acion distinta en función de `respuesta'*/
					case "s":
					case "y":
						haRespondido = true;
						for(int i = 10; i > 0; --i) /*Cuenta atrás desde 10 a 0*/
						{
							Console.WriteLine(i);
							for(int j = 10 - i; j > 0; --j) /*Conforme la cuenta atrás se acerque más a 0, más veces pitará*/
							{
								Console.Beep(880, 500 / j); /*Pitar a 880Hz durante 500/j ms*/
								
							}

							if(Environment.OSVersion.Platform == PlatformID.Unix) /*Lo de dentro de este if solo se ejecuta en *nix*/
							{
								Thread.Sleep(500); /*System.Threading.Thread.Sleep(1000) duerme el programa durante 1000ms*/
							}
						}
						Console.WriteLine("Mundo destruido");
						break;
					case "n":
						Console.WriteLine("No se destruye");
						haRespondido = true;
						break;
					default: /*Si no se escribe ni "s", ni "y", ni "n"*/
						Console.WriteLine("Tienes que decidirte");
						break;
				}
			}
			Console.ReadLine(); /*Para que no se cierre*/
		}
	}
}