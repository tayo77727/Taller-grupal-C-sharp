/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:22 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 *4) Ingresar 10 números, sumar los positivos y multiplicar los negativos. 
			*/ 
			
			int num, sumaP=0;
			long multiplicacionN=1;
			
			for(int i=1;i<=10;i++){
				Console.Write("Digite un numero: ");
				num = int.Parse(Console.ReadLine());
				
				if (num>0){
					sumaP=sumaP+num;
				}else{
					multiplicacionN=multiplicacionN*num;
				}
				
			}
			
			Console.Write("\nLa suma de los numeros positivos es: "+sumaP);
			Console.Write("\nLa multiplicacion de los numeros negativos es: "+multiplicacionN);
			
			Console.Write("");
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}