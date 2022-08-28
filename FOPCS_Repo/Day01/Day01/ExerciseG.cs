//#define G1
#define G2
//#define G3
//#define G4
//#define G5
//#define G6
//#define G5
//#define G10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class ExerciseG
    {
        static void showSort(int[] arr)
        {
            int len = arr.Length;
            int maxIndex,temp;
            int[,] newArray = new int[(len - 1),len];
            for (int i = 0; i < len - 1; i++)
            {
                maxIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                    temp = arr[i];
                    arr[i] = arr[maxIndex];
                    arr[maxIndex] = temp;
                    newArray[i, j - 1] = arr[maxIndex];


                }
                

            }
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(newArray[i, j]);
                }
            }
            Console.WriteLine();
        }

        static int[] selectionSort(int[] arr)
        {
            int len = arr.Length;
            int maxIndex, temp;
            for (int i = 0; i < len - 1; i++)
            {
                maxIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {    
                        maxIndex = j;                
                    }
                }
                temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;

            }
            return arr;
        }
        static void Main(string[] args)
        {
        #region G1
        #if G1
            Console.Write("Pls enter 12 month Sales Day in suquense(seperate by comma): ");
            string[] input = Console.ReadLine().Split(',');
            int n = 0;
            double[] data = new double[12];
            //double temp;
            double max=data[0];
            double sum=0;
            while (n < 12)
            {
                data[n] = Convert.ToDouble(input[n]);
                n++;

            }
            double min = data[0];
            foreach (double e in data)
            {
                if (min > e)
                {
                    min = e;
                }
                if (max < e)
                {
                    max = e;
                }
                sum = sum + e;
            }
            for (int i = 0; i < input.Length-1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {

                    if (data[i] > data[j])
                    {
                        temp = data[j];
                        data[j] = data[i];
                        data[i] = temp;
                    }
                }
            } 

            Console.WriteLine("Minimum Sales: "+min);
            Console.WriteLine("Maximum Sales: "+max);
            Console.WriteLine("total Sales {0} and average sales {1}: " ,sum,sum/12);
            Console.ReadKey();

        #endif
        #endregion
        #region G2
        #if G2
            Console.Write("Pls enter numbers (seperate by comma): ");
            string[] input = Console.ReadLine().Split(',');
            int[] data = new int[input.Length];
            int n = 0;
            while (n < input.Length)
            {
                data[n] = Convert.ToInt32(input[n]);
                n++;
            }
            showSort(data);
           
            selectionSort(data);
            foreach (int e in data)
            {
                Console.Write(e);
            }

            Console.Read();
        #endif
        #endregion
        }
    }
}
