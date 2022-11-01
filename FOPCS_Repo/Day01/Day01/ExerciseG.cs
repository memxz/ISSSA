//#define G1
//#define G2
#define G3
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day01
{
    class ExerciseG
    {
        #region G1
#if G1
        public static void Main(string[] args)
        {

            //initiaize 12 month sales
            int[] sales = { 1000, 1300, 1200, 1100, 2000, 2300, 2200, 1000, 3000, 2000, 3400, 3000 };
            
            Console.WriteLine("Minimum Sales: "+ (Array.IndexOf(sales,sales.Min())+1));
            Console.WriteLine("Maximum Sales: "+(Array.IndexOf(sales, sales.Max())+1));
            Console.WriteLine("total Sales {0} and average sales {1}: " ,sales.Sum(),sales.Average());
            Console.ReadKey();
        }
#endif
        #endregion
        #region G2
#if G2
        public static void quickSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min_idx = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        // remember seen min
                        min_idx = j;
                    }
                }

                if (min_idx != i)
                {
                    // swap the two
                    int tmp = arr[i];
                    arr[i] = arr[min_idx];
                    arr[min_idx] = tmp;

                    foreach(int j in arr)
                    {
                        Console.Write(j);
                    }

                    Console.WriteLine();
                }
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 4, 2, 6, 7, 3, 9, 22 };
            quickSort(arr);

            Console.Read();

        }
#endif
        #endregion

        #region G3
#if G3
        public static void Main(string[] args)
        {
            int[,] student = new int[,]
        {
            {56, 84, 68, 29 },
            {94, 73, 31, 96 },
            {41, 63, 36, 90 },
            {99, 9,  18, 17 },
            {62, 3,  65, 75 },
            {40, 96, 53, 23 },
            {81, 15, 27, 30 },
            {21, 70, 100, 2 },
            {88, 50, 13, 12 },
            {48, 54, 52, 78 },
            {64, 71, 67, 25 },
            {16, 93, 46, 72 }
        };
            //Compute the total marks obtained each student
            int[] total = new int[12];
            int [] total2 = new int[4];
            for(int i=0; i<total.Length; i++)
            {
                for (int j = 0; j < student.GetLength(1); j++)
                {
                    total[i]+= student[i, j];
                }
            }
            foreach(int el in total)
            {
                Console.WriteLine("total mark {0} for student",el);
            }
            
            for(int i=0;i<student.GetLength(1); i++)    
            {
                for(int j=0; j<student.GetLength(0); j++)
                {
                    total2[i]+= student[j, i];
                }

            }
            //Cmpute the class average (and standard deviation*optional) of Marks for each ubject.
            foreach (int el in total2)
            {
                Console.WriteLine("average subject markt: " + el / 12);
            }
            Console.Read();
        }





#endif
        #endregion

    }
}