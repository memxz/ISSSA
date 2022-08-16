using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Day6Quiz
    {
        //these arrays is visible in all the static method, //so you can use them in your method implementation
        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[] { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };
        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }
        //YOUR CODE HERE
        static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            int temp = int.Parse(Console.ReadLine());
            return temp;
        }
        static int GetTaxBracket(int x)
        {
            int index=0;
                for (int i = 0; i < minIncomeArray.Length; i++)
                {
                if (x > 2000 && x >= minIncomeArray[i] && x < minIncomeArray[i + 1])
                {
                    index = Array.IndexOf(minIncomeArray, minIncomeArray[i]);
                    break;
                }
                else if (x > 320000)
                {
                    index = 7;
                    break;
                }
                else
                {
                    index = -1;
                }
                    
                }
            return index;
            
        }
        static double CalculateIncomeTax(int a, int b)
        {
            double total;
            if (b < 0)
            {
                total = 0;
            }
            else
            {
                total = (a - minIncomeArray[b]) * taxRateArray[b] + basePayableAmountArray[b];
            }
            return total;
        }
        static void PrintResult(int m, double n)
        {
            Console.WriteLine("For taxable annual income of ${0}, the tax payable amount is {1}",$"{m:0,0.00}", $"{n:0,0.00}");
            Console.Read();
        }
    
    }
}
