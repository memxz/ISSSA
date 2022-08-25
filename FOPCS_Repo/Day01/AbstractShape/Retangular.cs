using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
	class Retangular:Shape
	{
		private int height;
		private int width;

		public Retangular(int height, int width, string color) : base(color)
		{
			Height = height;
			Width = width;
		}

		public int Height { get => height; set => height = value; }
		public int Width { get => width; set => width = value; }
		public override void Area()
		{
			if (width > 0 && height > 0)
				Console.WriteLine("The Retangular Area: " + width * height);
		}
	}
}
