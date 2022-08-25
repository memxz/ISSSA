using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
	abstract class Shape
	{
		private string color;

		public Shape(string color)
		{
			this.Color = color;
		}

		public string Color { get => color; set => color = value; }
		public string GetColor() {
			return color;
		}
		public abstract void Area();
	}
}
