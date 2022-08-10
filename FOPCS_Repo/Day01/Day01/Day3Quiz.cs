using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Day3Quiz
    {
        static double unit = 500;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.Write("Number of items to purchase:");
            double number = Convert.ToDouble(Console.ReadLine());
            double total = unit * number;
            if (total <= 2000)
            {
                Console.Write("Please pay: $" + $"{total:#,#.00}");
                Console.ReadLine();
            }
            else if (total>2000 && total <= 3000)
            {
                Console.Write("Please pay: $" + $"{(total * 0.97):#,#.00}");
                Console.ReadLine();
            }
            else if(total > 3000 && total <= 6000)
            {
                Console.Write("Please pay: $" + $"{(total*0.95):#,#.00}");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Please pay $: " + $"{(total * 0.92):#,#.00}");
                Console.ReadLine();
            }
            
        }
    }
}
