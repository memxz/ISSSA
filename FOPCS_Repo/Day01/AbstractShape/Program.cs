using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
	class Program
	{
		static void Main(string[] args)
		{
			Shape sp = new Circle(2, "red");
			Shape sp1 = new Triangle(2,3,"green");
			Shape sp2 = new Retangular(2, 3, "blue");
			sp.Area();
			Console.WriteLine(sp.Color);
			sp1.Area();
			Console.WriteLine(sp1.Color);
			sp2.Area();
			Console.WriteLine(sp2.Color);
			Console.Read();
		}
	}
}
