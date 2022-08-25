using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Exceptions
{
	class Triangle
	{
		private double side1, side2, side3;

		public Triangle(double side1, double side2, double side3)
		{
			this.side1 = side1;
			this.side2 = side2;
			this.side3 = side3;
			if (!IsValidTriangle(side1,side2,side3)) {
				throw new BadTriangleException("Invalid sides");
			}
		}

		public double Side1 { get => side1; set => side1 = value; }
		public double Side2 { get => side2; set => side2 = value; }
		public double Side3 { get => side3; set => side3 = value; }

		//Use the following logic if you need

		private static bool IsValidTriangle(double side1, double side2, double side3)
		{
			return side1 > 0 && side2 > 0 && side3 > 0 &&
			   side1 + side2 > side3 &&
			   side1 + side3 > side2 &&
			   side2 + side3 > side1;
		}
		public double Perimeter() {
			return side1 + side2 + side3;
		}
		public double Area() {
			return Math.Sqrt((Perimeter() / 2 - side1) * (Perimeter() / 2 - side1) * (Perimeter() / 2 - side1));
		}
	}
}
