using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieSearch
{
    internal class Node
    {
        public bool IsWord { get; set; }
        public Dictionary<char, Node> CharMap { get; set; }

        public Node()
        {
            IsWord = false;
            CharMap = new Dictionary<char, Node>();
        }
    }
}
