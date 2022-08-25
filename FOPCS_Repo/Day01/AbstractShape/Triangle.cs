using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
	class Triangle:Shape
	{
		private int height;
		private int width;

		public Triangle(int height, int width, string color):base(color)
		{
			Height = height;
			Width = width;
		}

		public int Height { get => height; set => height = value; }
		public int Width { get => width; set => width = value; }
		public override void Area() {
			if(width>0 && height>0)
			Console.WriteLine("The Triangle Area: "+width*height/2);
		}
	}
}
