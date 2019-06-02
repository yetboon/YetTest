using System;
using System.Threading;

namespace Project
{
	public class Program
	{
		private static void Main(string[] args)
		{
			
			Console.ReadKey();
		}
	}
	
	
	public class Essential
	{
		//TernaryOperator : Nested
		public static void ternaryOperator()
		{
			while(true)
			{
				int i = Convert.ToInt32(Console.ReadLine());
				int result = i < 5 ? 1 : i > 5 ? 2 : i == 5 ? 555 : 0;
				Console.WriteLine(result);
			}
		}
		
		//Enum : Get the value of enum
		public static void getEnumName()
		{
			Console.WriteLine(Enum.GetName(typeof(ic),2));
		}
		enum ic
		{
			a,
			e,
			i,
			o,
			u
		}
		
		//Math : used the sin to make a curve value
		public static void i1()
		{
			for (double i = 0; i <= 90; i++) {
				Thread.Sleep(50);
				Console.WriteLine("{0} |{1}",i, Math.Sin((i * Math.PI) /180));
			}
		}
		
		//Get&Set :
		public static int inum
		{
			get {
				return 0;
			}
			set {
				//
			}
		}
	}
}
