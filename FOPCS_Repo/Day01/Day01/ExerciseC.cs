using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class ExerciseC
    {
        static void Main(string[] args)
        {    // C1
            /*Console.Write("Pls Enter your name: ");
            string name = Convert.ToString((Console.ReadLine()).ToLower());
            Console.Write("\nPls Enter your Gender(M/F): ");
            string gender = Convert.ToString(Console.ReadLine()).ToUpper();
            if(gender == "M")
            {
                Console.Write("Good morning, Mr." + name.Substring(0, 1).ToUpper() + name.Substring(1));
                Console.Read();
            }
            else
            {
                Console.Write("Good morning, Mrs." + name.Substring(0,1).ToUpper()+name.Substring(1));
                Console.Read();
            }*/

            // C2
            /*Console.Write("Pls Enter your Name, Gender and Age(Pls seperate it by \',\'): ");
            string[] temp = Console.ReadLine().Split(',');
            string name = Convert.ToString(temp[0].ToLower());
            string gender = Convert.ToString(temp[1].ToUpper());
            int age = int.Parse(temp[2]);
            if (gender == "M")
            {
                if (age > 40)
                {
                    Console.Write("Good morning, Uncle " + name.Substring(0, 1).ToUpper() + name.Substring(1));
                    Console.Read();

                }
                else
                {
                    Console.Write("Good morning, Mr. " + name.Substring(0, 1).ToUpper() + name.Substring(1));
                    Console.Read();
                }
                
            }
            else
            {
                if (age > 40)
                {
                    Console.Write("Good morning, Aunty " + name.Substring(0, 1).ToUpper() + name.Substring(1));
                    Console.Read();
                }
                else
                {
                    Console.Write("Good morning, Mrs. " + name.Substring(0, 1).ToUpper() + name.Substring(1));
                    Console.Read();

                }
                
            }*/

            // C3
            /*Console.WriteLine("Pls enter your Score: ");
            int score = int.Parse(Console.ReadLine());
            if (score < 0)
            {
                Console.WriteLine("**Error**");
                Console.Read();
            }
            else if(score>=0 && score < 40)
            {
                Console.WriteLine("You scored {0} marks which is F grade",score);
                Console.Read();
            }
            else if(score>=40 && score < 60)
            {
                Console.WriteLine("You scored {0} marks which is C grade", score);
                Console.Read();
            }
            else if (score >= 60 && score < 80)
            {
                Console.WriteLine("You scored {0} marks which is B grade", score);
                Console.Read();
            }
            else if (score >= 80 && score <+ 100)
            {
                Console.WriteLine("You scored {0} marks which is A grade", score);
                Console.Read();
            }
            else
            {
                Console.WriteLine("**Error**");
                Console.Read();
            }*/

            // C4
            /*Console.Write("Please enter your distance travelled in km:");
            double temp = Convert.ToDouble(Console.ReadLine());
            double cost;
            double distance = Math.Ceiling(temp * 10) / 10;
            if (distance <= 0.5)
            {
                Console.WriteLine("If the distance traveled is {0}km then the total fare is:$2.4 ", distance);
            }
            else if(distance>0.5 && distance<9)
            {
                cost = 2.4 + (distance-0.5)/0.1 * 0.04;
                Console.WriteLine("If the distance traveled is {0}km then the total fare is: ${1} ", distance, $"{cost:0.00}");
              
            }
            else
            {
                //cost = 2.4 + (distance - 0.5) / 0.1 * 0.04 + (distance - 9) * 0.05;
                cost = 5.8 + (distance - 9)/0.1 * 0.05;
                Console.WriteLine("If the distance traveled is {0}km then the total fare is: ${1} ", distance, $"{cost:0.00}");
                
            }
            Console.ReadLine();
*/
            // C5
            /*Console.WriteLine("Pls input your three-digit integer (100-999): ");
            int num = int.Parse(Console.ReadLine());
            
            int first= num % 10;
            int second = num / 10 % 10; 
            int third= num / 100 % 10;
            int sum = (int)(Math.Pow(first, 3) + Math.Pow(second, 3) + Math.Pow(third, 3));
            if (num == sum)
            {
                Console.WriteLine("True, the number is an Armstrong number");
            }
            else
                Console.WriteLine("False, the number is not an Armstrong number");
            Console.Read();*/



            // D1
            /*while (true)
            {
                Console.WriteLine("Pls enter an integer number: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 88)
                    break;
            }
            
            Console.WriteLine("Lucky you...");
            Console.Read();*/



            // D2
            /*Console.WriteLine("Pls input 2 numbers(seperate by \",\": ");
            string[] start = Console.ReadLine().Split(',');
            int[] num = Array.ConvertAll(start, int.Parse);
            int a = num[0];
            int b = num[1];
            int temp;
            while(a!=b)
            if (a > b)
            {
                temp = a - b;
                a = temp;
            }
            else
            {
                temp = b - a;
                b = temp;
            }
            int hcf = a;
            int lcm = num[0] * num[1] / hcf;
            Console.WriteLine("The HCF is {0} and LCM is {1}",hcf,lcm);
            Console.Read();*/


            // D3a
            /*int n = 0;
            Random rnd = new Random();
            int num = rnd.Next(9);
            Console.WriteLine(num);
            while (true)
            {
                Console.WriteLine("Pls enter the number which you guess: ");
                int guess = int.Parse(Console.ReadLine());
                n++;
                if (num == guess)
                {
                    Console.WriteLine("congratulations, You have taken {0} times attempts to make the guess.",n);
                    break;
                }
            }
            Console.ReadLine();*/


            int n = 0;
            Random rnd = new Random();
            int num = rnd.Next(9);
            Console.WriteLine(num);
            Console.WriteLine("Pls enter the number which you guess: ");
            while (true)
            {
                
                int guess = int.Parse(Console.ReadLine());
                n++;
                if (num == guess)
                {
                    if (n <= 2)
                    {
                        Console.WriteLine("You are a Wizard,congratulations, You have taken {0} times attempts to make the guess.", n);
                        break;
                    }
                    else if (n > 2 && n <= 5)
                    {
                        Console.WriteLine("YYou are lousy!” Every time you make a wrong guess, You have taken {0} times and pls try it again.");

                    }
                    else
                        Console.WriteLine("pls try it again");
                    
                }
            }
            Console.ReadLine();
        }

    }
}
;