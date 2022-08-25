using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Exceptions
{
	class Program
	{/**
          * TODO: test class Triangle
          * 
          * Test 2 scenarios:
          * 1. Create a valid triangle and then display 
          * its perimeter and area. 
          * 
          * 2. Create an invalid triangle and then display
          * its perimeter and area.
          * What happens to the program?
          * 
          * Then:
          * 3. Put the creating triangles part into a 
          * try-catch block, then display the error 
          * message if there is any exception.
          * 
          * In the 2nd scenario, can the triangle's perimeter 
          * and area be displayed?
          * 
          */
        static void Main(string[] args)
		{
            try
            {
                Triangle ta1 = new Triangle(3, 4, 5);
                Triangle ta = new Triangle(1, 2, 3);
                Console.WriteLine("Perimeter: {0}", ta1.Perimeter());
                Console.WriteLine("Perimeter: {0}", ta.Perimeter());
                Console.WriteLine("Area: {0}", ta1.Area());
                Console.WriteLine("Area: {0}", ta.Area());
                Console.Read();
            }
            catch (BadImageFormatException be) { Console.WriteLine(be.Message); }
        }
	}
}
