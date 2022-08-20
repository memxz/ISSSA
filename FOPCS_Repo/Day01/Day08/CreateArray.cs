using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class CreateArray
    {
        public int[] myArr =new int[1];
        public void AddElement(int value)
        {
            if (myArr==null)
            {

                myArr[0] =value;
            }
           else if(myArr.Length>0)
            {
                int counter = myArr.Length+1;
                Array.Resize(ref myArr, counter);
                myArr[myArr.Length-1] = value;
            }
        }
        public void RemoveElement(int[] a, int value)
        {

            if (a.Length == 0)
            {

                Console.WriteLine("The Array is empty, you cannot remove anything");
            }
            else
            {
                a = a.Where(val => val != value).ToArray();
            }
        }
        public void RemoveByIndex(int[] a, int num)
        {

            if (a.Length == 0)
            {

                Console.WriteLine("The Array is empty, you cannot remove anything");
            }
            else if (a[num] == Array.IndexOf(a, num))
            {
                a = a.Where(val => val != a[num]).ToArray();
                Console.WriteLine("The integer {0} at {1} is removed", a[num], num);
            
            }
            else
            {
                Console.WriteLine("there is no element found");
            }
        }
        public void getElement(int[] a, int num)
        {
            if (a.Length == 0)
            {

                Console.WriteLine("The Array is empty, you cannot do anything");
            }
            else if (a[num] == Array.IndexOf(a, num))
            {
                Console.WriteLine("The integer is{0} at {1}", a[num], num);
            }
            else
            {
                Console.WriteLine("there is no element found");
            }
        }
        public void PrintElement(int[] a)
        {
            if (a.Length == 0)
            {

                Console.WriteLine("The Array is empty, you cannot do anything");
            }
            else
            {
                foreach (int ele in a) {
                    Console.WriteLine("The integer is: " + ele);
                }
            }
        }

        public void Count(int[] a)
        {
            if (a.Length == 0)
            {

                Console.WriteLine("The Array is empty, you cannot do anything");
            }
            else
            {
                Console.WriteLine("there is {0} elements in this array", a.Length);
            }
        } 
    }
}
    
