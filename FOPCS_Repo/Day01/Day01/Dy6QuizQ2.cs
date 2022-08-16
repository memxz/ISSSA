using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Dy6QuizQ2
    {
        static void Main(string[] args)
        {
                string upperPlainText = ReturnUpperInputSentence();
                string encryptedText = EncryptSentence(upperPlainText);
                PrintEncryptedSentence(encryptedText);
                string decryptedText = DecrpytSentence(encryptedText);
                PrintDecryptedSentence(decryptedText);
                Console.WriteLine("\nType any key to exit.");
                Console.ReadLine();
        }
        //YOUR CODE HERE
        static string ReturnUpperInputSentence()
        {
            Console.Write("Please enter the sentence: ");
            string temp = Convert.ToString(Console.ReadLine()).ToUpper();
            return temp;
        }
        static string EncryptSentence(string t)
        {
            string output = "";
            char[] arr= t.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                int shifted=0;

                if (Char.IsLetter(arr[i])) 
                {
                    shifted  = arr[i] + 3;
                    if (shifted > 90)
                    {
                        shifted = 65 + shifted - 91;
                    }
                }
                else
                {
                    shifted = arr[i];
                }
                
                output = output + (char)shifted;
            }
            
            return output;
        }
        static string DecrpytSentence(string e)
        {
            string output = "";
            char[] arr = e.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int shifted = 0;

                if (Char.IsLetter(arr[i]))
                {
                    shifted = arr[i] - 3;
                    if (shifted < 65)
                    {
                        shifted = 65 - shifted + 91;
                    }
                }
                else
                {
                    shifted=arr[i];
                }
                
                output = output + (char)shifted;
            }

            return output;
        }
        static void PrintDecryptedSentence(string de)
        {
            Console.WriteLine("The decrypted sentence is : "+de);
        }
        static void PrintEncryptedSentence(string en)
        {
            Console.WriteLine("The encrypted sentence is : "+en);
        }
    }
}
