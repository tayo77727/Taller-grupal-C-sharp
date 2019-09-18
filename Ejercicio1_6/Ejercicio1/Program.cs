/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 07:57 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
		    /*
		   	1)Realice un programa que solicite al usuario Ingresar un número y mostrar la suma de los números que lo anteceden. 
			*/
			int num, suma=0;
			
			Console.Write("Digite un numero: ");
			num = int.Parse(Console.ReadLine());
			
			for(int i=0; i<=num; i++){
				
				suma=suma+i;
			}
			
			Console.Write("La suma de los numeros que lo anteceden son: "+suma);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}