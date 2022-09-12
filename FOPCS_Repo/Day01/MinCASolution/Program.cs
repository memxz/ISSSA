using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCASolution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] testArr = { 1, 3, 2, 10, 4, 9, 7, 15, 6, 5 };
            TwoSum ts = new TwoSum();
            foreach(int key in ts.twoSum(testArr,10).Keys)
            {
                Console.WriteLine("{"+key + "," + ts.twoSum(testArr, 10)[key]+"}");
            }
            Console.ReadLine();
        }
    }
}
