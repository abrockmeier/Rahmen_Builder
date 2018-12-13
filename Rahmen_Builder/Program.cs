using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rahmen_Builder
{
	class Program
	{
		
		static void Main(string[] args)
		{
			int length;
			Console.WriteLine("Bitte eine Zahl eingeben:");
			length = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < length; i++)
			{
				if ((i == 0)||(i == length-1))
				{
					for (int k = 1; k < length; k++)
					{
						Console.Write("X ");	
					}
				}
			
				Console.Write("Y     ");
				//Console.WriteLine();
				if ( (i <= length) && ((i == length) || (i >= 1)))
				{
					Console.Write("  Z");
						for (int j = 0; j <= length; j++)
						{
							Console.Write("  ");
						}
				}
				
				
				Console.WriteLine();
			}
		Console.Read();
		}
	}
}
