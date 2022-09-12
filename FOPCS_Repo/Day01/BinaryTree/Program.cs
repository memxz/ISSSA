using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = new int[] { 7, 5, 20, 12, 6, 28, 3, 16, 19, 22, 8, 17, 9, 10, 4 };

            BST bst = new BST();

            // build Binary Search Tree
            for (int i = 0; i < keys.Length; i++)
            {
                bst.Insert(new Node(keys[i]));
            }

            VisualTree.Print(bst.GetRootNode());
            Console.WriteLine(bst.findKey(12));
            Console.ReadKey();
        }
    }
}
