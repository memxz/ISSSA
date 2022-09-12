using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"good","morning","class","have","a","good","class","and","have","fun" };
            Dictionary<string, int> dic = checkOccurence(arr);
            foreach (string e in dic.Keys)
            {
                Console.WriteLine(e + ":" + dic[e]);
            }

            int[] A={ 1, 2, 4};
            int[] B = { 2, 4, 1 };
            Console.WriteLine(compareDict(checkContent(A), checkContent(B)));

            Console.ReadLine();
        }

        
         public static Dictionary<string,int> checkOccurence(string[] st)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach(string e in st)
            {
                int occur;
                if (dict.TryGetValue(e, out occur))
                {
                    int newOccur = occur + 1;
                    dict[e] = newOccur;
                }
                else
                    dict.Add(e, 1);
            }
            return dict;
           
        }
        public static Dictionary<int,int> checkContent(int[] arr)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            foreach(int num in arr)
            {
                if(dict.TryGetValue(num, out int occur))
                {
                    int newOccur = occur + 1;
                    dict[num]=newOccur;
                }
                else
                    dict.Add(num, occur);
            }
            return dict;
        }
        public static bool compareDict(Dictionary<int,int> dict1, Dictionary<int, int> dict2)
        {
            if (dict1.Keys.Count != dict2.Keys.Count)
            { return false; }
            else 
            {
                foreach (int key in dict1.Keys)
                {
                    if (dict2.ContainsKey(key) && dict1[key] == dict2[key])
                    {
                        return true;
                    }
                
                }
                return false;
            }
        }
    }
}
