//#define B1
//#define B2
//#define B3
//#define B4
//#define B5
//#define B6
//#define B7_8_9
//#define B10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class ExerciseB
    {
        static void Main(string[] args)
        {
            #region B1
            #if B1 || B2
            Console.Write("Please enter your number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("square root of the number is: " + $"{Math.Sqrt(number1):#.##}");
             Console.ReadLine();
            #endif
            #endregion

            #region B2
            #if B2
            Console.WriteLine("square root of the number is: " + $"{Math.Sqrt(number1):0.000}");
            Console.ReadLine();
            #endif
            #endregion

            #region B3
            #if B3
            Console.Write("Please enter your base salay:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{salary * 1.13:#,0.00}");
            Console.ReadLine();
            #endif
            #endregion

            #region B4
            #if B4
            Console.Write("Please enter temperature in Centigrade (C):");
            double Centigrade = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = Centigrade * 1.8 + 32;
            Console.WriteLine($"{Fahrenheit:#}");
            Console.ReadLine();
            #endif
            #endregion

            #region B5
            #if B5
            Console.Write("Please input the value of x:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x * x * 5 - 4 * x + 3;
            Console.WriteLine("output the value of y is:" + y);
            Console.ReadLine();
            #endif
            #endregion

            #region B6
            #if B6
            Console.WriteLine("Please input 4 value in sequence (x1,y1,x2,y2): ");

            string[] temp = Console.ReadLine().Split(',');
            double[] temp1 = Array.ConvertAll(temp, Double.Parse);

            // Console.WriteLine(temp1[2]);

            double res = Math.Sqrt(Math.Pow((temp1[2] - temp1[0]), 2) + Math.Pow((temp1[3] - temp1[1]), 2));

            Console.WriteLine("The distance between the two points is " + res);
            Console.ReadLine();
#endif
            #endregion

            #region B7_8_9
            #if B7_8_9
            Console.Write("Please enter your distance travelled in km:");
            double distance = Convert.ToDouble(Console.ReadLine());
            if (distance <= 2.4)
            {
                Console.WriteLine("If the distance traveled is {0}km then the total fare is:$2.4 ", distance);
            }
            else
            {
                double dis = 2.4 + distance * 0.4;
                Console.WriteLine("If the distance traveled is {0}km then the total fare is: ${1} ", distance, $"{dis:#.###}");
                Console.WriteLine("If the distance traveled is {0}km then the total fare is: ${1} ", distance, $"{Math.Round(dis, 1):0.00}");
                double dis1 = Math.Ceiling(Math.Round(dis, 2) * 10);
                Console.WriteLine("If the distance traveled is {0}km then the total fare is: ${1} ", distance, dis1 / 10);
            }
            Console.ReadLine();
            #endif
            #endregion

            #region B10
            #if B10
            Console.WriteLine("Please input the lengths of its three sides a, b and c.: ");

            string[] temp2 = Console.ReadLine().Split(',');
            double[] temp3 = Array.ConvertAll(temp2, Double.Parse);
            if((temp3[0]+temp3[1])>temp3[2] && (temp3[0] - temp3[1]) < temp3[2] && (temp3[0] + temp3[2]) > temp3[1] && (temp3[0] - temp3[2]) < temp3[1] && (temp3[1] + temp3[2]) > temp3[0] && (temp3[1] - temp3[2]) < temp3[0])
            {
                double s = (temp3[0] + temp3[1] + temp3[2]) / 2;
                double area = Math.Sqrt(s * (s - temp3[0]) * (s - temp3[1]) * (s - temp3[2]));
                Console.WriteLine("the area of a triangle is" + $"{area:#.}");
            }
            else
                Console.WriteLine("Those input 3 side length cannot form a triangle");
            Console.Read();
            #endif
            #endregion
        }
    }
}
