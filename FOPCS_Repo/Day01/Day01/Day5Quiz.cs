using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Day5Quiz
    {
        static void Main(string[] args)
        {
            int[,] theArray = new int[,] { { 5, 3 }, { 2, 9 }, { 2, 9 }, { 5, 1 }, { 7, 1 }, { 8, 3 }, { 0, 3 }, { 2, 2 }, { 9, 7 } };
            int count = 0;
            Console.Write("Please enter a number (0-9): "); int input = Convert.ToInt32(Console.ReadLine());
            //Your code here }
            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    if (input == theArray[i, j])
                        count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There is no {0} in the array.", input);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number of {0} is {1}", input, count);
                Console.ReadLine();
            }
                

        }
    }
}
