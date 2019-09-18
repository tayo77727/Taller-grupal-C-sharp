/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:13 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 *  3)	Contar los múltiplos de 5 desde la unidad hasta un numero N que ingrese el usuario 
			*/ 
			
			int num,contador=0;
			Console.Write("Digite un numero: ");
			num = int.Parse(Console.ReadLine());
			
			for(int i=1;i<=num;i++ ){
				
				if(i%5==0){
					Console.Write("\nEste numero: "+i+" es un multiplo del 5.\n");
					contador++;
				}
			}
			
			Console.Write("\nLa cantidad de multiplos del 5 son: "+contador+"\n");
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}