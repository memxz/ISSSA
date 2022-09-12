using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "andy", "any", "and", "a", "an", "boy", "boo", "boat" };

            Trie trie = new Trie();

            // build Trie
            foreach (string word in words)
            {
                trie.Insert(word);
            }

            // find words
            string[] targets = { "and", "ang", "boy", "boys" };
            foreach (string word in targets)
            {
                if (trie.Search(word))
                {
                    Console.WriteLine("'{0}' is found.", word);
                }
                else
                {
                    Console.WriteLine("'{0}' is NOT found.", word);
                }
            }
            Console.ReadLine();
        }
    }
}
