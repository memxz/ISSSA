using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinCASolution
{
    internal class TwoSum
    {
        public Dictionary<int, int> twoSum(int[] nums,int target)
        {
            var numsDictionary = new Dictionary<int, int>();

            Dictionary<int, int> result = new Dictionary<int, int>();
            int complement = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                complement = target - nums[i];
                int index = 0;
                if (numsDictionary.TryGetValue(complement, out index))
                {
                    result.Add(nums[index], nums[i]);
                    
                }

                if (!numsDictionary.ContainsKey(nums[i]))
                {
                    numsDictionary.Add(nums[i], i);
                }
            }

            return result;
        }
    }
}
