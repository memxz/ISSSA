using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BST
    {
        private Node root;

        public BST()
        {
            root = null;
        }

        public bool Insert(Node node)
        {
            if (node == null)
            {
                // cannot insert null
                return false;
            }

            if (root == null)
            {
                // tree has no nodes yet, set this one as root
                root = node;
                return true;
            }

            return _Insert(node, root);
        }

        private bool _Insert(Node node, Node curr)
        {
            if (node.key == curr.key)
            {
                return false;   // no duplicate keys allowed
            }

            if (node.key < curr.key)
            {
                if (curr.left == null)
                {
                    // found empty spot for new node
                    curr.left = node;
                    return true;
                }

                // go to left branch
                return _Insert(node, curr.left);
            }
            else
            {
                if (curr.right == null)
                {
                    // found empty spot for new node
                    curr.right = node;
                    return true;
                }

                // go to right branch
                return _Insert(node, curr.right);
            }
        }

        public Node GetRootNode()
        {
            return root;
        }
        public bool findKey(int key)
        {
            Node node = GetRootNode();
            if(node == null)
            {
                return false;
            }
            if(node.key == key)
            {
                return true;
            }
            return _findKey(node, key);
        }
        private bool _findKey(Node node,int key)
        {
            if(node.left!=null)
            {
                if (node.left.key == key)
                {
                    return true;
                }
                _findKey(node.left, key);
            }
            if(node.right!=null)
            {
                if (node.right.key == key)
                {
                    return true;
                }
                _findKey(node.right, key);
            }
            

            return false;
        }
    }
}
