using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    class Day6QuizQ2
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
    }
}
