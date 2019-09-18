/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 18/09/2019
 * Time: 08:46 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*
			 *6) Ingresar X cantidad de pesos y mostrar la cantidad de personas que pesan más de 80 kg y menos de 80 kg 
			*/ 
			
			int numpersonas,contador1=0,contador2=0;
			double peso;
			
			Console.Write("Digite la cantidad de personas: ");
			numpersonas= int.Parse(Console.ReadLine());
			
			for(int i=1;i<=numpersonas;i++){
				Console.Write("Digite el peso en KILOGRAMOS: ");
				peso=double.Parse(Console.ReadLine());
				
				if(peso>80){
					contador1++;
					
				}else{
					contador2++;
					
				}
			}
			
			Console.Write("\nla cantidad de personas que pesan mas de 80KG es: "+contador1);
			Console.Write("\nla cantidad de personas que pesan menos de 80KG es: "+contador2);
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}