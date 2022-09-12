using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Node
    {
        public Node(int key)
        {
            this.key = key;
            this.left = null;
            this.right = null;
        }

        public int key { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
    }

}
