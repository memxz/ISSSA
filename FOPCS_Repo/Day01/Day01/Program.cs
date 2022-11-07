using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("John Smith\ne0011223@u.nus.edu");
            for(; ; )
            {
                Console.Write("Pls enter interger: ");
                string input=Console.ReadLine();
                try
                {
                    int input2 = int.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ouch! FormatException.");
                    continue;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Ouch! OverflowException.");
                    continue;
                }
                Console.WriteLine("Your number is " + input);
                Console.ReadLine();
                /*finally
                {
                    Console.WriteLine("Your number is " + input);
                    Console.ReadLine();
                }*/
            }
            
           
        }
    }
}
