//#define E1
//#define E2
//#define E3
//#define E4
//#define E5
//#define E6
//#define F1
//#define F2
//#define F3
//#define F4
//#define F6
#define F5
//#define E10
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            for(number = 1; number <= 1000; number++)
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
            Console.WriteLine("\nsorted on student names alphabetically\n");
            for(int m=0; m < names.Length-1; m++)
            {
               for(int l=0; l < 4; l++)
                {
                    if (names[l].First() > names[l+1].First())
                    {
                        string tp=names[l];
                        names[l] = names[l+1];
                        names[l+1] = tp;
                    }
                }
            }
            for (int k = 0; k < 5; k++)
            {
                    Console.WriteLine("For name = {0}, marks = {1}.", names[k], student.FirstOrDefault(x => x.Value == names[k]).Key);
                
            }
            Console.Read();


        }
#endif
        #endregion

        #region F1
#if F1
        public static void checkVowels(string input)
        {
            Dictionary<char, int> vowels = new Dictionary<char, int>()
            {
                {'a',0 },
                {'e',0 },
                {'i',0 },
                {'o',0 },
                {'u',0 }



            };
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == 'a')
                {
                    vowels['a']++;
                }
                if (input[i] == 'e')
                {
                    vowels['e']++;
                }
                if (input[i] == 'i')
                {
                    vowels['i']++;
                }
                if (input[i] == 'o')
                {
                    vowels['o']++;
                }
                if (input[i] == 'u')
                {
                    vowels['u']++;
                }
            }
            Console.WriteLine("number of a : {0}\nnumber of e : {1}\nnumber of i : {2}\nnumber of o: {3}\nnumber of u : {4}", vowels['a'], vowels['e'], vowels['i'], vowels['o'], vowels['u']);
            Console.Read();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("pls enter phrase");
            string input = Console.ReadLine().ToLower();
            checkVowels(input);
        }

#endif
        #endregion

        #region F2
#if F2
        public static bool isPalindrome(string input)
        {
            int len=input.Length;
            if (len % 2 == 0)
            {
                for (int i= 0; i <= len/2; i++)
                {
                    if (input[i] != input[len - i - 1])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < (len + 1) / 2; i++)
                {
                    if (input[i] != input[len - i - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.Write("pls enter string: ");
            string input = Console.ReadLine();
            Console.WriteLine("{0}", isPalindrome(input)?true:false);
            Console.Read();

        }
#endif
        #endregion

        #region F3
#if F3
        public static bool isPalindrome(string input)
        {
            int len = input.Length;
            if (len % 2 == 0)
            {
                for (int i = 0; i <= len / 2; i++)
                {
                    if (input[i] != input[len - i - 1])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < (len + 1) / 2; i++)
                {
                    if (input[i] != input[len - i - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.Write("pls enter string: ");
            string input = Console.ReadLine().Replace(" ","").ToLower();
            Console.WriteLine("{0}", isPalindrome(input) ? true : false);
            Console.Read();

        }
#endif
        #endregion


        #region F4
#if F4
        public static void Main(string[] args)
        {
            string input = "institute of systems science";
            string[] newInput = input.Split(' ');
            foreach (string arg in newInput)
            {
                Console.Write(arg.ToUpper().FirstOrDefault()+arg.Substring(1)+" ");
            }
            Console.ReadLine();

        }


#endif
        #endregion

        #region F6
        #if F6
        public static bool isValidmatriNo(string input)
        {
            Dictionary<int, string> result = new Dictionary<int, string>() {
                {0,"O" },
                {1,"P" },
                {2,"Q" },
                {3,"R" },
                {4,"S" },
                {5,"Q" }
            };
            //Convert the entire string to uppercase so that we don’t have to worry about case
            string inputUpper=input.ToUpper();
            //Check that the length of the input is exactly 7 characters, otherwise it’s invalid
            if (inputUpper.Length != 7)
            {
                return false;
            }
            //Calculate the checksum based on the rule
            int firstNo = Convert.ToInt32(inputUpper[1]);
            int secNo = Convert.ToInt32(inputUpper[2]);
            int thirdNo = Convert.ToInt32(inputUpper[3]);
            int fourNo = Convert.ToInt32(inputUpper[4]);
            int fifthNo = Convert.ToInt32(inputUpper[5]);
            int rem=(firstNo+ secNo + thirdNo + fourNo + fifthNo)%5;
            //Check whether the last character matches the calculated checksum.
            string re = "";
            string value;
            if (result.TryGetValue(rem, out re))
            {
                value = re;
            }
            else
                return false;


            return true;

        }
        public static void Main(string[] args)
        {
            Console.Write("Enter a matriculation number: ");
            string inpute=Console.ReadLine();
            Console.WriteLine(isValidmatriNo(inpute)?"Valid":"Invalid");
            Console.ReadLine();
        }
        #endif
        #endregion
    }
}