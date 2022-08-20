using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("1. Add an integer.\n2. Remove integers based on value.\n3. Remove an integer by its position in the array.\n4. Find an integer based on its value.\n4. Tracks how many elements it is currently holding.\n5. Show the elements it is currently holding.\n=========================");
				Console.Write(" pls enter you selection: ");
				CreateArray ca = new CreateArray();
				int sel=int.Parse(Console.ReadLine());
				switch (sel)
				{
					case 1:
						Console.WriteLine("you have select 1, \npls enter a integer ");
						int input = int.Parse(Console.ReadLine());
						ca.AddElement(input);
						break;
					case 2:
						Console.WriteLine("you have select 2, \npls enter a integer to be removed from array ");
						ca.RemoveElement(ca.myArr, int.Parse(Console.ReadLine()));
						break;
					case 3:
						Console.WriteLine("you have select 3, \npls enter a index to remove lement ");
						ca.RemoveByIndex(ca.myArr, int.Parse(Console.ReadLine()));
						break;

					case 4:
						Console.WriteLine("you have select 4, \npls enter a index to get the value from array ");
						ca.getElement(ca.myArr, int.Parse(Console.ReadLine()));
						break;
					case 5:
						Console.WriteLine("you have select 5, ");
						ca.Count(ca.myArr);
						break;
					case 6:
						Console.WriteLine("you have select 1, \nElement in Array ");
						ca.PrintElement(ca.myArr);
						break;
					default: break;
				
				}
			}
		}

	}
}
