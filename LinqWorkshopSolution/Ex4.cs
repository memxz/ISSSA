using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWorkshopSolution
{
    class Ex4
    {
        static void Main()
        {
            Solution();

            Console.ReadKey();
        }

        static void Solution()
        {
            int[] numbers1 = { 0, 1, 2, 3, 4 };
            int[] numbers2 = { 5, 6, 7, 8, 9 };

            var iter = from number1 in numbers1
                       from number2 in numbers2
                       where number1 * number2 > 20
                       select new { number1, number2 };

            foreach (var item in iter)
                Console.WriteLine("{0},{1}", item.number1, item.number2);
        }
    }
}
