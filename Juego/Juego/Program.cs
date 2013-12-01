/*
 * Creado por SharpDevelop.
 * Usuario: rafael1193
 * Fecha: 28/11/2013
 * Hora: 18:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Juego
{
	class Program
	{
		public static void Main(string[] args)
		{
			/* ¡Mejora este juego para que lo sea de verdad! */
			
			
			int posX=3; // Posición X del monigote
			int posY=6; // Posición Y del monigote
			char simbolo = '☺'; // Monigote
			ConsoleColor colorSimbolo = ConsoleColor.White; // Color del monigote
			
			Console.CursorLeft=posX;
			Console.CursorTop=posY;
			
			while(true) // Repetir indefinidamente
			{
				Console.BackgroundColor = ConsoleColor.DarkRed; // Color de fondo
				Console.ForegroundColor = colorSimbolo; // Color del texto
				Console.Clear(); // Limpiar pantalla
				Console.CursorLeft=posX; // Posición X del cursor
			    Console.CursorTop=posY; // Posición Y del cursor
				Console.Write(simbolo); // Pintar el monigote
				
				ConsoleKey tecla = Console.ReadKey(true).Key; //Esperar a que se intoduzca una tecla y guardarla en la variable `tecla´
				System.Console.Beep(440,50); // Hacer un sonidito :)
				switch (tecla) {
						// En función de la tecla pulsada hacer una acción u otra
						case ConsoleKey.UpArrow:
							posY = posY - 1;
							break;
						case ConsoleKey.DownArrow:
							posY = posY + 1;
							break;
						case ConsoleKey.LeftArrow:
							posX = posX - 1;
							break;
						case ConsoleKey.RightArrow:
							posX = posX + 1;
							break;
						default:
							
							break;
				}
			}

			/* Si quieres que el programa no se pare para esperar una tecla, pon
			 * 
			 * if(Console.KeyAvailable) //Con esto sólo lees una tecla si se ha pulsado
			 * {
			 *     ConsoleKey tecla = Console.ReadKey(true).Key;
			 *     switch (tecla) 
			 *     {
             *          case ConsoleKey.UpArrow:
             *              posY = posY - 1;
             *              break;
             *          case ConsoleKey.DownArrow:
             *              posY = posY + 1;
             *              break;
             *          case ConsoleKey.LeftArrow:
             *              posX = posX - 1;
             *              break;
             *          case ConsoleKey.RightArrow:
             *              posX = posX + 1;
             *              break;
             *          default:
             *              break;
			 *     }
			 * }
			 * 
			 */
			
			Console.WriteLine();

			Console.ReadKey(true);
		}
	}
}