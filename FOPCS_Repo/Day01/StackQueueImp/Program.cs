using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueImp
{
    internal class Program
    {
        public static bool checkBalanceDelimeters(string input) 
        {
            char[] arr = input.ToCharArray();
            Stack<char> mystack = new Stack<char>();
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == '(')
                    mystack.Push('(');
                if (arr[i] == ')')
                    mystack.Pop();
                if (arr[i] == '[')
                    mystack.Push('[');
                if (arr[i] == ']')
                    mystack.Pop();
                if (arr[i] == '{')
                    mystack.Push('{');
                if (arr[i] == '}')
                    mystack.Pop();


            }
            return mystack.Count ==0?true:false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(checkBalanceDelimeters("a {b [c (d + e)/2 - f  ] + 1}"));
            Console.WriteLine(checkBalanceDelimeters("a {b [c (d + e)/2 - f  ] + 1"));
            Console.Read();
        }
    }
}
