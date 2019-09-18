/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:37 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 *5) Mostrar el cuadrado y el cubo de los primeros 10 números. 
			*/ 
			
			double cuadrado, cubo;
			
			for(int i=1;i<=10;i++){
				cuadrado = Math.Pow(i,2);
				cubo = Math.Pow(i,3);
				
				Console.Write("\nEl cuadrado de "+i+" es: "+cuadrado);
				Console.Write("\nEl cubo de "+i+" es: "+cubo+"\n");
			}
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}