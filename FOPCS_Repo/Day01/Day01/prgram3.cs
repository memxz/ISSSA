using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class prgram3
    {
        static void Main(string[] args)
        {
            /* Print out input number*number */
            Console.WriteLine("Please enter your integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number*number);

            Console.WriteLine("Please enter your number:");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number2 * number2);
            Console.ReadLine();

            Console.WriteLine("Please enter your number:");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{number3:#.##}");
            Console.ReadLine();

            Console.WriteLine("Please enter your number:");
            double number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{number4:0.00}");
            Console.ReadLine();
        }
    }
}
