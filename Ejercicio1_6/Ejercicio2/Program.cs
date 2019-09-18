/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:07 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 * 2)	Mostrar los números del 1 hasta un  número x ingresado por el usuario.
			 */ 
			
			int num;
			
			Console.Write("Digite un numero: ");
			num = int.Parse(Console.ReadLine());
			
			for(int i=1; i<=num;i++){
				Console.Write("\n"+i);
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}