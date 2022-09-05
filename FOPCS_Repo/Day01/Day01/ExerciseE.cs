//#define E1
//#define E2
//#define E3
//#define E4
#define E5
//#define E6
//#define F5
//#define E10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class ExerciseE
    {
        #region E1 recursive
        #if E1
        static int factorial(int n)
        {
            if (n == 1 || n==0)
            {
                return 1;
            }
            else
            return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Pls enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(factorial(num));
            Console.Read();       
        }
        #endif
        #endregion

        #region E1 Increament
        #if E1
        static void Main(string[] args)
        {
            int fact=1;
            Console.WriteLine("Pls enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.Read();
        }
        #endif
        #endregion
        #region E1 Decreament
        #if E1
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Pls enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i>=1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            Console.Read();
        }
        #endif
        #endregion
        #region E2
        #if E2
        static void Main(string[] args)
        {
            Console.WriteLine("NO\tINVERSE\tSQUAREROOT\tSQUARE");
            for (int i = 1; i <= 10; i++)
            {
                string inv = $"{Math.Pow(i, -1):0.0##}";
                string sqrt = $"{Math.Sqrt(i):0.0##}";
                Console.WriteLine($"{i:0.0}" + "\t" + inv + "\t" + sqrt + "\t\t" + $"{i * i:0.0##}");
            }

            Console.Read();
        }
        #endif
        #endregion
        #region E3
        #if E3
        static void Main(string[] args)
        {
            Console.WriteLine("Pls input an integer number: ");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
        #endif
        #endregion

        #region E4
        #if E4
        static void Main(string[] args)
        {
            int number, sum = 0;
            string divisors = "";
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                   Perfect Number                              ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Enter Number To Check :: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    divisors += i.ToString() + "+";
                }
            }
            divisors = divisors.Remove(divisors.Length - 1, 1);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(divisors + " = " + sum);
            if (sum == number)
            {
                Console.WriteLine("Hence , " + number + " Is A Perfect Number");
            }
            else
                Console.WriteLine("Hence , " + number + " Is Not A Perfect Number");

            Console.WriteLine("---------------------------------------------------------------");
            Console.ReadKey();
        }
        #endif
        #endregion
        #region E5
        #if E5
        static void Main(string[] args)
        {
            Console.WriteLine("prime numbers from 5 to 10000 ");
           
            for (int n = 5; n <= 10000; n++)
            {
                int ab = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        ab++;
                    }
                }
                if (ab == 2)
                { 
                    Console.WriteLine("{0} is a Prime Number", n);
                }
                else
                {
                    Console.WriteLine("{0} Not a Prime Number",n);
                }
                
            }
            
            Console.ReadLine();
        }
        #endif
        #endregion

        #region E6
        #if E6
        static void Main(string[] args)
        {
            int number;
            
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("                   Perfect Number                              ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("print out all the perfect numbers from 1 to 1000");
            for(number = 1; number <= 900; number++)
            {
                int sum = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine("---------------------------------------------------------------");
                if (sum == number)
                {
                    Console.WriteLine("Hence , " + number + " Is A Perfect Number");
                }
                else
                    Console.WriteLine("Hence , " + number + " Is Not A Perfect Number");
            }
            

            Console.WriteLine("---------------------------------------------------------------");
            Console.ReadKey();
        }
        #endif
        #endregion

        #region F5
        #if F5
        static void Main(string[] args)
        {
            string[] names = new string[] { "john", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            Dictionary<int, string> student = new Dictionary<int, string>()
            {
                {63,"john" },
                {29,"Venkat" },
                {75,"Mary" },
                {82,"Victor" },
                {55,"Betty" }
            };
            int temp,i,j;
            for (i = 0; i < names.Length-1; i++)
            {
                for (j = 0; j < names.Length - 1; j++)
                {

                    if (marks[j] < marks[j + 1])
                    {
                        temp = marks[j +1];
                        marks[j +1] = marks[j];
                        marks[j] = temp;
                    }

                }
                
            }
            for(int k = 0; k < 5; k++)
            {
                string value = "";
                if (student.TryGetValue(marks[k], out value))
                {
                    Console.WriteLine("For marks = {0}, name = {1}.",marks[k], value);
                }
            }
            Console.WriteLine(names.Length);
            Console.Read();


        }
        #endif
        #endregion

    }
}
