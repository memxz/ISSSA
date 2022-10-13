using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkshopSolution
{
    class Ex2
    {
        static void Main()
        {
            Solution();
           
            Console.ReadKey();
        }

        static void Solution()
        {
            int[] numbers = { 20, 12, 6, 10, 0, 3, 1 };

            var iter = from number in numbers
                       orderby number
                       select number;

            foreach (var number in iter)
                Console.Write("{0}  ", number);
        }

        

    }
}
