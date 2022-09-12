using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class VisualTree
    {
        static public void Print(Node root)
        {
            _Print(root, 0, "");
        }

        static public void _Print(Node node, int indent, string side)
        {
            // indent based on depth of tree
            for (int i = 0; i < indent; i++)
            {
                Console.Write("  ");
            }

            // allow us to differentiate whether left or 
            // right branch is empty
            if (node == null)
            {
                Console.WriteLine("--{0}:", side);
                return;
            }

            Console.WriteLine("--{0}:{1}", side, node.key);

            // only show if at least one of the branches contains a key
            if (node.left != null || node.right != null)
            {
                _Print(node.left, 1 + indent, "L");
                _Print(node.right, 1 + indent, "R");
            }
        }

        static public int GetDepth(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = 1 + GetDepth(node.left);
            int right = 1 + GetDepth(node.right);

            // reports the greatest depth found
            return (left > right) ? left : right;
        }
    }
}
