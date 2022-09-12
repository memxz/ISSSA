using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MiniCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
            AddUp au=new AddUp();
            Queue<string> strings = au.addUpToTarget(testArr, 15);
            foreach (string e in strings )
                Console.WriteLine(e);
            Console.ReadLine();
        }

        public static int[] twoSum(int[] nums, int target)
        {
            Dictionary<int,int> result = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (result.ContainsKey(complement))
                    return new int[] {result.FirstOrDefault(x=>x.Value==complement).Key,i };
                result.Add(nums[i],i);
            }
             return result.Values.ToArray();
        }

        public bool IsPalindrome(string input)
        {
            if (input.Length > 0)
                return true;

            if (input[0] == input[input.Length - 1])
                return IsPalindrome(input.Substring(input[1], input[input.Length - 2]));    
            return false;
        }


        public static int Count(string str)
        {
            if(str.Length==0)
            { return 0; }

            return 1 + Count(str.Substring(1));
        }

        public static string ReverseString(string str)
        {
            if (str.Length == 0)
                return "";
            return ReverseString(str.Substring(1) + str[0]);
        }
    }
}
