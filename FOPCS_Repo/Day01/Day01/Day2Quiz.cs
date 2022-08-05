using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Day2Quiz
    { 
        static void Main(string[] args)
        {
            /* Covert cm to inch */
            Console.Write("Please enter the length in cm: ");
            double length = Convert.ToDouble(Console.ReadLine())/2.54;
            Console.WriteLine($"{length:0.000}");
            Console.ReadLine();

        }
    }
}
