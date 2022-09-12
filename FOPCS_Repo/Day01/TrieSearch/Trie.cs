using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrieSearch
{
    internal class Trie
    {
        private bool cascade_rm;
        private Node root;

        public Trie()
        {
            root = new Node();
            root.IsWord = true;  // empty string is a "word"
        }

        public bool Insert(string word)
        {
            Node curr = root;

            foreach (char ch in word)
            {
                if (!curr.CharMap.ContainsKey(ch))
                {
                    curr.CharMap[ch] = new Node();
                }
                curr = curr.CharMap[ch];
            }

            curr.IsWord = true;
            return true;
        }

        public bool Search(string word)
        {
            Node curr = root;

            foreach (char ch in word)
            {
                if (!curr.CharMap.ContainsKey(ch))
                {
                    return false;
                }
                curr = curr.CharMap[ch];
            }

            return curr.IsWord;
        }
    }
}
