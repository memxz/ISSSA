using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Console.WriteLine(wayOfSum(n));
            Console.ReadKey();
        }
        public static int wayOfSum(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            if(n== 3)
                return 4;
            return wayOfSum(n - 1) + wayOfSum(n - 2) + wayOfSum(n - 3);
        }
    }
}
