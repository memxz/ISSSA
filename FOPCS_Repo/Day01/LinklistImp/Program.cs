using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinklistImp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LList myList = new LList();
            myList.Add("FOPCS");
            myList.Add("OOPCS");
            myList.Insert(2, "MVC.NET");
            if (myList.Contains("OOPCS"))
                myList.Insert(3, "Design");
            myList.Insert(1, "Data Structures");
            myList.Replace(3, "Java");
            myList.RemoveAt(1);
            myList.Replace(1, "Android");
            for (int i = 0; i < myList.Count(); i++)
                Console.WriteLine(myList.GetNodeAt(i));
            Console.WriteLine(myList.Count() + ";" + myList.Contains("OOPCS"));
            Console.Read();


        }
    }
}
