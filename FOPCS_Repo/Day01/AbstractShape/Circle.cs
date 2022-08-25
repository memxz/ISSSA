using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
	class Circle:Shape
	{
		private int redius;

		public Circle(int redius, string color):base(color)
		{
			this.Redius = redius;
		}

		public int Redius { get => redius; set => redius = value; }

		public override void Area() {
			if (redius > 0) {
				Console.WriteLine("Circle Area: " + (Math.PI * redius* redius / 2));
			}

		}

	}
}
