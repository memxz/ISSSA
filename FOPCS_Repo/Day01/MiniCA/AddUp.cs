using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniCA
{
    internal class AddUp
    {
        public Queue<string> addUpToTarget(int[] array, int target)
        {
            Queue<string> queue=new Queue<string>();
            for(int i = 0; i < array.Length-1; i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if (array[i] + array[j]==target)
                    {
                        queue.Enqueue($"{array[i]}"+" & "+$"{array[j]}");
                    }
                }
            }
            return queue;
        }
    }
}
