using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Day4Quiz
    {
        static string pin = "123456";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            int n = 1;
            while(n<=3){ 
                 Console.Write("Enter your PIN: ");
                 string input = Console.ReadLine();
                if (input.Length > 6 || input.Length < 6)
                {
                    if (n <3)
                    {
                        Console.WriteLine("Incorrect PIN, please try to enter 6 digit pin");
                        n++;
                    }
                    else
                    {
                        break;
                    }
                     
                }
                else if (pin.Substring(0, 1) == input.Substring(0, 1) && pin.Substring(1, 1) == input.Substring(1, 1) && pin.Substring(2, 1) == input.Substring(2, 1) && pin.Substring(3, 1) == input.Substring(3, 1) && pin.Substring(4, 1) == input.Substring(4, 1) && pin.Substring(5, 1) == input.Substring(5, 1))
                {
                     
                    if(n<=3)
                    {
                        Console.WriteLine("PIN accepted, You can access your account now");
                        
                        Console.Read();
                        break;
                        n++;
                    }
                    else
                    {
                        break;
                    }
                        
                }
                else 
                {
                    if (n <3)
                    {
                        Console.WriteLine("Incorrect PIN, please try again");
                        n++;
                    }
                    else
                    {

                        Console.WriteLine("Too many wrong PIN entries.Your account is now locked");
                        Console.Read();
                        break;
                    }
                }
                
            }
        }
    }
}
